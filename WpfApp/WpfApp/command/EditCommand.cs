using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.entity;
using WpfApp.view;
using WpfApp.viewmodel;

namespace WpfApp.command
{
    internal class EditCommand : Command
    {
        private BaseViewModel model;

        public EditCommand(BaseViewModel model) { this.model = model; }

        public override void Execute(object parameter)
        {
            if (model.Selecteditem == null)
            {
                MessageBox.Show("Не выбрана запись для редактирования!");
                return;
            }
            editwindow window = new editwindow();
            window.EditedCard = model.Selecteditem;
            window.Show();
        }
    }
}
