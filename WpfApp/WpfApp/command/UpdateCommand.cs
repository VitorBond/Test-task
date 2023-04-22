using WpfApp.entity;
using WpfApp.Services;
using WpfApp.viewmodel;

namespace WpfApp.command
{
    internal class UpdateCommand : Command
    {
        private BaseViewModel model;
        private DatabaseQuery database;

        public UpdateCommand(BaseViewModel model, DatabaseQuery database)
        {
            this.model = model;
            this.database = database;
        }

        public override void Execute(object parameter)
        {
            model.CARDs = database.GetCARDs();
        }
    }
}
