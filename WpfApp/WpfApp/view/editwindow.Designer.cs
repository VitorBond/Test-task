using WpfApp.entity;

namespace WpfApp.view
{
    partial class editwindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Phonemobil = new System.Windows.Forms.TextBox();
            this.Cardper = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Phonehome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.GenderID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Latname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cardtype = new System.Windows.Forms.TextBox();
            this.Finishdate = new System.Windows.Forms.DateTimePicker();
            this.Startdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Turnover = new System.Windows.Forms.TextBox();
            this.Cardcore = new System.Windows.Forms.TextBox();
            this.GUID = new System.Windows.Forms.TextBox();
            this.Fullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.House = new System.Windows.Forms.TextBox();
            this.Apartment = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.altaddress = new System.Windows.Forms.TextBox();
            this.SaveVutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Email, 3);
            this.Email.Location = new System.Drawing.Point(517, 134);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(248, 20);
            this.Email.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(435, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 26);
            this.label16.TabIndex = 39;
            this.label16.Text = "EMAIL";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phonemobil
            // 
            this.Phonemobil.Location = new System.Drawing.Point(310, 134);
            this.Phonemobil.Name = "Phonemobil";
            this.Phonemobil.Size = new System.Drawing.Size(119, 20);
            this.Phonemobil.TabIndex = 38;
            // 
            // Cardper
            // 
            this.Cardper.Location = new System.Drawing.Point(517, 29);
            this.Cardper.Name = "Cardper";
            this.Cardper.Size = new System.Drawing.Size(99, 20);
            this.Cardper.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(224, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 26);
            this.label15.TabIndex = 37;
            this.label15.Text = "PHONEMOBIL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phonehome
            // 
            this.Phonehome.Location = new System.Drawing.Point(95, 134);
            this.Phonehome.Name = "Phonehome";
            this.Phonehome.Size = new System.Drawing.Size(122, 20);
            this.Phonehome.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 26);
            this.label14.TabIndex = 35;
            this.label14.Text = "PHONEHOME";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Birthday
            // 
            this.Birthday.CustomFormat = " ";
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birthday.Location = new System.Drawing.Point(95, 109);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(122, 20);
            this.Birthday.TabIndex = 34;
            this.Birthday.ValueChanged += new System.EventHandler(this.Birthday_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "BIRTHDAY";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenderID
            // 
            this.GenderID.Location = new System.Drawing.Point(702, 83);
            this.GenderID.Name = "GenderID";
            this.GenderID.Size = new System.Drawing.Size(63, 20);
            this.GenderID.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(622, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 26);
            this.label12.TabIndex = 31;
            this.label12.Text = "GENDERID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(517, 83);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(99, 20);
            this.Surname.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(435, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 26);
            this.label11.TabIndex = 29;
            this.label11.Text = "SURNAME";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(310, 83);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(119, 20);
            this.Firstname.TabIndex = 28;
            // 
            // Latname
            // 
            this.Latname.Location = new System.Drawing.Point(95, 83);
            this.Latname.Name = "Latname";
            this.Latname.Size = new System.Drawing.Size(122, 20);
            this.Latname.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "FIRSTNAME";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 26);
            this.label9.TabIndex = 25;
            this.label9.Text = "LASTNAME";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "OWNERGUID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "FULLNAME";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "CARDPER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "CARDTYPE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cardtype
            // 
            this.Cardtype.Location = new System.Drawing.Point(310, 29);
            this.Cardtype.Name = "Cardtype";
            this.Cardtype.Size = new System.Drawing.Size(119, 20);
            this.Cardtype.TabIndex = 9;
            // 
            // Finishdate
            // 
            this.Finishdate.CustomFormat = " ";
            this.Finishdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Finishdate.Location = new System.Drawing.Point(310, 56);
            this.Finishdate.Name = "Finishdate";
            this.Finishdate.Size = new System.Drawing.Size(119, 20);
            this.Finishdate.TabIndex = 24;
            this.Finishdate.ValueChanged += new System.EventHandler(this.Finishdate_ValueChanged);
            // 
            // Startdate
            // 
            this.Startdate.CustomFormat = " ";
            this.Startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Startdate.Location = new System.Drawing.Point(95, 56);
            this.Startdate.Name = "Startdate";
            this.Startdate.Size = new System.Drawing.Size(122, 20);
            this.Startdate.TabIndex = 23;
            this.Startdate.ValueChanged += new System.EventHandler(this.Startdate_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 27);
            this.label8.TabIndex = 21;
            this.label8.Text = "FINISHDATE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Turnover
            // 
            this.Turnover.Location = new System.Drawing.Point(702, 29);
            this.Turnover.Name = "Turnover";
            this.Turnover.Size = new System.Drawing.Size(63, 20);
            this.Turnover.TabIndex = 11;
            // 
            // Cardcore
            // 
            this.Cardcore.Location = new System.Drawing.Point(95, 29);
            this.Cardcore.Name = "Cardcore";
            this.Cardcore.Size = new System.Drawing.Size(122, 20);
            this.Cardcore.TabIndex = 8;
            // 
            // GUID
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GUID, 3);
            this.GUID.Location = new System.Drawing.Point(517, 3);
            this.GUID.Name = "GUID";
            this.GUID.Size = new System.Drawing.Size(248, 20);
            this.GUID.TabIndex = 7;
            // 
            // Fullname
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Fullname, 3);
            this.Fullname.Location = new System.Drawing.Point(95, 3);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(333, 20);
            this.Fullname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "TURNOVER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARDCODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "STARTDATE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.83673F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.16327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.Fullname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GUID, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cardcore, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Turnover, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Startdate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Finishdate, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cardtype, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Latname, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Firstname, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Surname, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.GenderID, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Birthday, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Phonehome, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Cardper, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Phonemobil, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.Email, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label19, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label20, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.City, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Street, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.House, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.Apartment, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.altaddress, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.SaveVutton, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 26);
            this.label17.TabIndex = 41;
            this.label17.Text = "CITY";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 26);
            this.label18.TabIndex = 42;
            this.label18.Text = "STREET";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(435, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 26);
            this.label19.TabIndex = 43;
            this.label19.Text = "HOUSE";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(622, 157);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 26);
            this.label20.TabIndex = 44;
            this.label20.Text = "APARTMENT";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(95, 160);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(122, 20);
            this.City.TabIndex = 45;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(310, 160);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(119, 20);
            this.Street.TabIndex = 46;
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(517, 160);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(99, 20);
            this.House.TabIndex = 47;
            // 
            // Apartment
            // 
            this.Apartment.Location = new System.Drawing.Point(702, 160);
            this.Apartment.Name = "Apartment";
            this.Apartment.Size = new System.Drawing.Size(63, 20);
            this.Apartment.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 183);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 27);
            this.label21.TabIndex = 49;
            this.label21.Text = "ALTADDRESS";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altaddress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.altaddress, 7);
            this.altaddress.Location = new System.Drawing.Point(95, 186);
            this.altaddress.Name = "altaddress";
            this.altaddress.Size = new System.Drawing.Size(676, 20);
            this.altaddress.TabIndex = 50;
            // 
            // SaveVutton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SaveVutton, 2);
            this.SaveVutton.Location = new System.Drawing.Point(3, 242);
            this.SaveVutton.Name = "SaveVutton";
            this.SaveVutton.Size = new System.Drawing.Size(142, 23);
            this.SaveVutton.TabIndex = 51;
            this.SaveVutton.Text = "Записать и закрыть";
            this.SaveVutton.UseVisualStyleBackColor = true;
            this.SaveVutton.Click += new System.EventHandler(this.SaveVutton_Click);
            // 
            // editwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "editwindow";
            this.Text = "editwindow";
            this.Load += new System.EventHandler(this.editwindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fullname;
        private System.Windows.Forms.TextBox GUID;
        private System.Windows.Forms.TextBox Cardcore;
        private System.Windows.Forms.TextBox Turnover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Startdate;
        private System.Windows.Forms.DateTimePicker Finishdate;
        private System.Windows.Forms.TextBox Cardtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Latname;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GenderID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Phonehome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Cardper;
        private System.Windows.Forms.TextBox Phonemobil;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox House;
        private System.Windows.Forms.TextBox Apartment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox altaddress;
        private System.Windows.Forms.Button SaveVutton;

        
    }
}