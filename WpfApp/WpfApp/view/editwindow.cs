using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfApp.entity;
using WpfApp.Services;

namespace WpfApp.view
{
    public partial class editwindow : Form
    {
        public CARD EditedCard { get;  set; }

        public editwindow()
        {
            InitializeComponent();
        }

        private void editwindow_Load(object sender, EventArgs e)
        {
            Cardcore.Text = EditedCard.CARDCODE.ToString();
            Latname.Text = EditedCard.LASTNAME;
            Firstname.Text = EditedCard.FIRSTNAME;
            Surname.Text = EditedCard.SURNAME;
            Fullname.Text = EditedCard.FULLNAME;
            GenderID.Text = EditedCard.GENDERID.ToString();
            Phonehome.Text = EditedCard.PHONEHOME;
            Phonemobil.Text = EditedCard.PHONEMOBIL;
            Email.Text = EditedCard.EMAIL;
            City.Text = EditedCard.CITY;
            Street.Text = EditedCard.STREET;
            House.Text = EditedCard.HOUSE.ToString();
            Apartment.Text = EditedCard.APARTMENT.ToString();
            altaddress.Text = EditedCard.ALTADDRESS;
            Cardtype.Text = EditedCard.CARDTYPE;
            GUID.Text = EditedCard.OWNERGUID.ToString("D");
            Cardper.Text = EditedCard.CARDPER.ToString();
            Turnover.Text = EditedCard.TURNOVER.ToString();

            if(EditedCard.STARTDATE != null)
            {
                Startdate.Value = (DateTime)EditedCard.STARTDATE;
            }

            if (EditedCard.FINISHDATE != null)
            {
                Finishdate.Value = (DateTime)EditedCard.FINISHDATE;
            }

            if (EditedCard.BIRTHDAY != null)
            {
                Birthday.Value = (DateTime)EditedCard.BIRTHDAY;
            }
        }

        private void Startdate_ValueChanged(object sender, EventArgs e)
        {
            Startdate.CustomFormat = "dd.MM.yyyy";
        }

        private void Finishdate_ValueChanged(object sender, EventArgs e)
        {
            Finishdate.CustomFormat = "dd.MM.yyyy";
        }

        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
            Birthday.CustomFormat = "dd.MM.yyyy";
        }

        private void SaveVutton_Click(object sender, EventArgs e)
        {
            EditedCard.CARDCODE = Convert.ToInt64(Cardcore.Text);
            EditedCard.LASTNAME = Latname.Text;
            EditedCard.FIRSTNAME = Firstname.Text;
            EditedCard.SURNAME = Surname.Text;
            EditedCard.FULLNAME = Fullname.Text;
            EditedCard.GENDERID = Convert.ToInt32(GenderID.Text);
            EditedCard.PHONEHOME = Phonehome.Text;
            EditedCard.PHONEMOBIL = Phonemobil.Text;
            EditedCard.EMAIL = Email.Text;
            EditedCard.CITY = City.Text;
            EditedCard.STREET = Street.Text;
            EditedCard.HOUSE = Convert.ToInt32(House.Text);
            EditedCard.APARTMENT = Convert.ToInt32(Apartment.Text);
            EditedCard.ALTADDRESS = altaddress.Text;
            EditedCard.CARDTYPE = Cardtype.Text;
            EditedCard.OWNERGUID = Guid.Parse(GUID.Text);
            EditedCard.CARDPER = Convert.ToInt32(Cardper.Text);
            EditedCard.TURNOVER = Convert.ToDecimal(Turnover.Text);

            if (Startdate.CustomFormat == "dd.MM.yyyy")
            {
                EditedCard.STARTDATE = (DateTime?) Startdate.Value;
            }

            if (Finishdate.CustomFormat == "dd.MM.yyyy")
            {
                EditedCard.FINISHDATE = (DateTime?)Finishdate.Value;
            }

            if (Birthday.CustomFormat == "dd.MM.yyyy")
            {
                EditedCard.BIRTHDAY = (DateTime?)Birthday.Value;
            }

            DatabaseQuery database = new DatabaseQuery();
            database.UpdateRecord(EditedCard);
        }
    }
}
