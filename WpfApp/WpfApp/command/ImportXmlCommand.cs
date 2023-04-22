using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Xml;
using WpfApp.entity;
using WpfApp.Services;

namespace WpfApp.command
{
    internal class ImportXmlCommand : Command
    {
        private DatabaseQuery database;

        public ImportXmlCommand(DatabaseQuery database)
        {
            this.database = database;
        }
        
        public override void Execute(object parameter)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Документ (*.xml) | *.xml"};
            
            if(ofd.ShowDialog() ?? false)
            {
                ParseDocument(ofd.FileName);
            }
        }

        private void ParseDocument(String documnetName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(documnetName);

            XmlNode node = xmlDocument.DocumentElement.SelectSingleNode("/Cards");

            int updated = 0;
            int inserted = 0;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                CARD card = new CARD();

                foreach (XmlAttribute xmlAttribute in childNode.Attributes)
                {
                    PropertyInfo property = card.GetType().GetProperty(xmlAttribute.Name);
                    Type propertyType = property.PropertyType;
                    object value = xmlAttribute.Value;

                    if (propertyType == typeof(int?))
                        value = String.IsNullOrEmpty(xmlAttribute.Value) ? (int?)null : Int32.Parse(xmlAttribute.Value);

                    if (propertyType == typeof(Int64))
                        value = String.IsNullOrEmpty(xmlAttribute.Value) ? 0 : Int64.Parse(xmlAttribute.Value);

                    if (propertyType == typeof(DateTime?))
                        value = String.IsNullOrEmpty(xmlAttribute.Value) ? (DateTime?)null : DateTime.Parse(xmlAttribute.Value);

                    if (propertyType == typeof(Nullable<decimal>))
                        value = String.IsNullOrEmpty(xmlAttribute.Value) ? (decimal?)null : decimal.Parse(xmlAttribute.Value, CultureInfo.InvariantCulture);

                    if (propertyType == typeof(System.Guid))
                        value = Guid.Parse(xmlAttribute.Value);

                    if (propertyType == typeof(Int32))
                        value = String.IsNullOrEmpty(xmlAttribute.Value) ? 0 : Int32.Parse(xmlAttribute.Value);

                    property.SetValue(card, value);
                }

                if (database.isConstains(card))
                {
                    database.UpdateRecord(card);
                    updated++;
                }
                else
                {
                    database.InsertIntoTable(card);
                    inserted++;
                }
            }

            StringBuilder messageStr = new StringBuilder();
            messageStr.Append(updated > 0 ? $"Обновлено {updated} записей." : "");
            messageStr.Append(inserted > 0 ? $"Добавлено {inserted} записей." : "");

            MessageBox.Show(messageStr.ToString(), "Импорт из XML", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
