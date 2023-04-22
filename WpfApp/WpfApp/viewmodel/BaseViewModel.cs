using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Input;
using WpfApp.command;
using WpfApp.entity;
using WpfApp.Services;

namespace WpfApp.viewmodel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<CARD> _CARDs;
        private DatabaseQuery database;
        private CARD selecteditem;

        public ICommand ImportXml { get; }
        public ICommand Update { get; }
        public ICommand Edit { get; }

        public ObservableCollection<CARD> CARDs 
        { 
            get { return _CARDs; } 
            set 
            { 
                _CARDs = value; 
                OnPropertyChanged("CARDs");
            }
        }

        public CARD Selecteditem
        {
            get { return selecteditem; }
            set
            {
                selecteditem = value;
                OnPropertyChanged("Selecteditem");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel() 
        { 
            database = new DatabaseQuery();

            CARDs = database.GetCARDs();

            ImportXml = new ImportXmlCommand(database);
            Update = new UpdateCommand(this, database);
            Edit = new EditCommand(this);
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            { 
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
