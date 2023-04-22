using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using WpfApp.entity;

namespace WpfApp.Services
{
    public class DatabaseQuery
    {
        private databaseEntities database;

        public DatabaseQuery() => database = new databaseEntities();

        public bool isConstains(CARD field) => (from c in database.CARDs select c.CARDCODE).ToList().Contains(field.CARDCODE);

        public ObservableCollection<CARD> GetCARDs()
        {
            var query = from card in database.CARDs select card;
            return new ObservableCollection<CARD>(query);
        }

        public void UpdateRecord(CARD field)
        {
            var card = database.CARDs.SingleOrDefault(_card => _card.CARDCODE.Equals(field.CARDCODE));
            database.Entry(card).CurrentValues.SetValues(field);
            database.SaveChanges();
        }

        public void InsertIntoTable(CARD Field)
        {
            database.CARDs.Add(Field);
            database.SaveChanges();
        }

        public bool IsNeedToBeUpdated(CARD filed)
        {
            var query = (from c in database.CARDs
                        where c.CARDCODE == filed.CARDCODE &&
                              c.STARTDATE == filed.STARTDATE &&
                              c.FINISHDATE == filed.FINISHDATE &&
                              c.LASTNAME == filed.LASTNAME &&
                              c.FIRSTNAME == filed.FIRSTNAME &&
                              c.SURNAME == filed.SURNAME &&
                              c.FULLNAME == filed.FULLNAME &&
                              c.GENDERID == filed.GENDERID &&
                              c.BIRTHDAY == filed.BIRTHDAY &&
                              c.PHONEHOME == filed.PHONEHOME &&
                              c.PHONEMOBIL == filed.PHONEMOBIL &&
                              c.EMAIL == filed.EMAIL &&
                              c.CITY == filed.CITY &&
                              c.STREET == filed.STREET &&
                              c.HOUSE == filed.HOUSE &&
                              c.APARTMENT == filed.APARTMENT &&
                              c.ALTADDRESS == filed.ALTADDRESS &&
                              c.CARDTYPE == filed.CARDTYPE &&
                              c.OWNERGUID == filed.OWNERGUID &&
                              c.CARDPER == filed.CARDPER &&
                              c.TURNOVER == filed.TURNOVER
                         select c).ToList();

            return query.Count > 0 ? false : true;
        }
    }
}
