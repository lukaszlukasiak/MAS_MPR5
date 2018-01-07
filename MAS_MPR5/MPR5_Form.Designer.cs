namespace MAS_MPR5
{
    partial class MPR5_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsbExplorePersons = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabConApplication = new System.Windows.Forms.TabControl();
            this.tabExplore = new System.Windows.Forms.TabPage();
            this.tabPersons = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnRemoveSelectedPerson = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.lsbPersonsList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPets = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteSelectedPet = new System.Windows.Forms.Button();
            this.btnAddNewPet = new System.Windows.Forms.Button();
            this.lsbPetsList = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxPetType = new System.Windows.Forms.TextBox();
            this.tbxBreedSpecies = new System.Windows.Forms.TextBox();
            this.tbxPetAge = new System.Windows.Forms.TextBox();
            this.tbxOwner = new System.Windows.Forms.TextBox();
            this.tbxPetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabConApplication.SuspendLayout();
            this.tabExplore.SuspendLayout();
            this.tabPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 583);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsbExplorePersons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(985, 583);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 0;
            // 
            // lsbExplorePersons
            // 
            this.lsbExplorePersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbExplorePersons.FormattingEnabled = true;
            this.lsbExplorePersons.Location = new System.Drawing.Point(0, 0);
            this.lsbExplorePersons.Name = "lsbExplorePersons";
            this.lsbExplorePersons.Size = new System.Drawing.Size(330, 583);
            this.lsbExplorePersons.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.MaximumSize = new System.Drawing.Size(1, 55555);
            this.label3.MinimumSize = new System.Drawing.Size(1, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 583);
            this.label3.TabIndex = 2;
            // 
            // tabConApplication
            // 
            this.tabConApplication.Controls.Add(this.tabExplore);
            this.tabConApplication.Controls.Add(this.tabPersons);
            this.tabConApplication.Controls.Add(this.tabPets);
            this.tabConApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConApplication.Location = new System.Drawing.Point(0, 0);
            this.tabConApplication.Name = "tabConApplication";
            this.tabConApplication.SelectedIndex = 0;
            this.tabConApplication.Size = new System.Drawing.Size(999, 615);
            this.tabConApplication.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabConApplication.TabIndex = 1;
            // 
            // tabExplore
            // 
            this.tabExplore.Controls.Add(this.panel1);
            this.tabExplore.Location = new System.Drawing.Point(4, 22);
            this.tabExplore.Name = "tabExplore";
            this.tabExplore.Padding = new System.Windows.Forms.Padding(3);
            this.tabExplore.Size = new System.Drawing.Size(991, 589);
            this.tabExplore.TabIndex = 0;
            this.tabExplore.Text = "Przeglądaj";
            this.tabExplore.UseVisualStyleBackColor = true;
            // 
            // tabPersons
            // 
            this.tabPersons.Controls.Add(this.splitContainer3);
            this.tabPersons.Location = new System.Drawing.Point(4, 22);
            this.tabPersons.Name = "tabPersons";
            this.tabPersons.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersons.Size = new System.Drawing.Size(991, 589);
            this.tabPersons.TabIndex = 1;
            this.tabPersons.Text = "Osoby";
            this.tabPersons.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnRemoveSelectedPerson);
            this.splitContainer3.Panel1.Controls.Add(this.btnAddNewPerson);
            this.splitContainer3.Panel1.Controls.Add(this.lsbPersonsList);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.tbxName);
            this.splitContainer3.Panel2.Controls.Add(this.tbxSurname);
            this.splitContainer3.Panel2.Controls.Add(this.tbxAge);
            this.splitContainer3.Panel2.Controls.Add(this.tbxCity);
            this.splitContainer3.Panel2.Controls.Add(this.tbxUserName);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.SizeChanged += new System.EventHandler(this.splitContainer3_Panel2_SizeChanged);
            this.splitContainer3.Size = new System.Drawing.Size(985, 583);
            this.splitContainer3.SplitterDistance = 330;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.SizeChanged += new System.EventHandler(this.splitContainer3_SizeChanged);
            // 
            // btnRemoveSelectedPerson
            // 
            this.btnRemoveSelectedPerson.Location = new System.Drawing.Point(20, 43);
            this.btnRemoveSelectedPerson.Name = "btnRemoveSelectedPerson";
            this.btnRemoveSelectedPerson.Size = new System.Drawing.Size(295, 23);
            this.btnRemoveSelectedPerson.TabIndex = 2;
            this.btnRemoveSelectedPerson.Text = "Usuń Zaznaczoną Osobę";
            this.btnRemoveSelectedPerson.UseVisualStyleBackColor = true;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(20, 14);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(295, 23);
            this.btnAddNewPerson.TabIndex = 1;
            this.btnAddNewPerson.Text = "Dodaj Nową Osobę";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            // 
            // lsbPersonsList
            // 
            this.lsbPersonsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbPersonsList.FormattingEnabled = true;
            this.lsbPersonsList.Location = new System.Drawing.Point(0, 72);
            this.lsbPersonsList.Name = "lsbPersonsList";
            this.lsbPersonsList.Size = new System.Drawing.Size(330, 511);
            this.lsbPersonsList.TabIndex = 0;
            this.lsbPersonsList.SelectedIndexChanged += new System.EventHandler(this.lsbPersonsList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Miasto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Wiek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nazwisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwa Użytkownika";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(25, 102);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(597, 20);
            this.tbxName.TabIndex = 5;
            this.tbxName.Validated += new System.EventHandler(this.tbxName_Validated);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(25, 152);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(597, 20);
            this.tbxSurname.TabIndex = 4;
            this.tbxSurname.Validated += new System.EventHandler(this.tbxSurname_Validated);
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(25, 210);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(597, 20);
            this.tbxAge.TabIndex = 3;
            this.tbxAge.TextChanged += new System.EventHandler(this.tbxAge_TextChanged);
            this.tbxAge.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAge_Validating);
            this.tbxAge.Validated += new System.EventHandler(this.tbxAge_Validated);
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(25, 314);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(597, 20);
            this.tbxCity.TabIndex = 2;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(25, 31);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(597, 20);
            this.tbxUserName.TabIndex = 1;
            this.tbxUserName.Validated += new System.EventHandler(this.tbxUserName_Validated);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(1, 55555);
            this.label1.MinimumSize = new System.Drawing.Size(1, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 583);
            this.label1.TabIndex = 0;
            // 
            // tabPets
            // 
            this.tabPets.Controls.Add(this.splitContainer2);
            this.tabPets.Location = new System.Drawing.Point(4, 22);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(991, 589);
            this.tabPets.TabIndex = 2;
            this.tabPets.Text = "Zwierzęta";
            this.tabPets.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnDeleteSelectedPet);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddNewPet);
            this.splitContainer2.Panel1.Controls.Add(this.lsbPetsList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.tbxPetType);
            this.splitContainer2.Panel2.Controls.Add(this.tbxBreedSpecies);
            this.splitContainer2.Panel2.Controls.Add(this.tbxPetAge);
            this.splitContainer2.Panel2.Controls.Add(this.tbxOwner);
            this.splitContainer2.Panel2.Controls.Add(this.tbxPetName);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.SizeChanged += new System.EventHandler(this.splitContainer2_Panel2_SizeChanged);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(985, 583);
            this.splitContainer2.SplitterDistance = 330;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnDeleteSelectedPet
            // 
            this.btnDeleteSelectedPet.Location = new System.Drawing.Point(20, 43);
            this.btnDeleteSelectedPet.Name = "btnDeleteSelectedPet";
            this.btnDeleteSelectedPet.Size = new System.Drawing.Size(295, 23);
            this.btnDeleteSelectedPet.TabIndex = 4;
            this.btnDeleteSelectedPet.Text = "Usuń Zaznaczone Zwierze";
            this.btnDeleteSelectedPet.UseVisualStyleBackColor = true;
            // 
            // btnAddNewPet
            // 
            this.btnAddNewPet.Location = new System.Drawing.Point(20, 14);
            this.btnAddNewPet.Name = "btnAddNewPet";
            this.btnAddNewPet.Size = new System.Drawing.Size(295, 23);
            this.btnAddNewPet.TabIndex = 3;
            this.btnAddNewPet.Text = "Dodaj Nowe Zwierzę";
            this.btnAddNewPet.UseVisualStyleBackColor = true;
            // 
            // lsbPetsList
            // 
            this.lsbPetsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbPetsList.FormattingEnabled = true;
            this.lsbPetsList.Location = new System.Drawing.Point(0, 72);
            this.lsbPetsList.Name = "lsbPetsList";
            this.lsbPetsList.Size = new System.Drawing.Size(330, 511);
            this.lsbPetsList.TabIndex = 0;
            this.lsbPetsList.SelectedIndexChanged += new System.EventHandler(this.lsbPetsList_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Właściciel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Wiek";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Rasa/podgatunek";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Typ zwierzęcia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nazwa";
            // 
            // tbxPetType
            // 
            this.tbxPetType.Location = new System.Drawing.Point(30, 95);
            this.tbxPetType.Name = "tbxPetType";
            this.tbxPetType.Size = new System.Drawing.Size(597, 20);
            this.tbxPetType.TabIndex = 6;
            // 
            // tbxBreedSpecies
            // 
            this.tbxBreedSpecies.Location = new System.Drawing.Point(30, 158);
            this.tbxBreedSpecies.Name = "tbxBreedSpecies";
            this.tbxBreedSpecies.Size = new System.Drawing.Size(597, 20);
            this.tbxBreedSpecies.TabIndex = 5;
            // 
            // tbxPetAge
            // 
            this.tbxPetAge.Location = new System.Drawing.Point(30, 211);
            this.tbxPetAge.Name = "tbxPetAge";
            this.tbxPetAge.Size = new System.Drawing.Size(597, 20);
            this.tbxPetAge.TabIndex = 4;
            // 
            // tbxOwner
            // 
            this.tbxOwner.Location = new System.Drawing.Point(30, 266);
            this.tbxOwner.Name = "tbxOwner";
            this.tbxOwner.ReadOnly = true;
            this.tbxOwner.Size = new System.Drawing.Size(597, 20);
            this.tbxOwner.TabIndex = 3;
            // 
            // tbxPetName
            // 
            this.tbxPetName.Location = new System.Drawing.Point(30, 39);
            this.tbxPetName.Name = "tbxPetName";
            this.tbxPetName.Size = new System.Drawing.Size(597, 20);
            this.tbxPetName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.MaximumSize = new System.Drawing.Size(1, 55555);
            this.label2.MinimumSize = new System.Drawing.Size(1, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 583);
            this.label2.TabIndex = 1;
            // 
            // MPR5_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 615);
            this.Controls.Add(this.tabConApplication);
            this.Name = "MPR5_Form";
            this.Text = "MPR5";
            this.Load += new System.EventHandler(this.MPR5_Form_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabConApplication.ResumeLayout(false);
            this.tabExplore.ResumeLayout(false);
            this.tabPersons.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPets.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabConApplication;
        private System.Windows.Forms.TabPage tabExplore;
        private System.Windows.Forms.TabPage tabPersons;
        private System.Windows.Forms.TabPage tabPets;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnRemoveSelectedPerson;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.ListBox lsbPersonsList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnDeleteSelectedPet;
        private System.Windows.Forms.Button btnAddNewPet;
        private System.Windows.Forms.ListBox lsbPetsList;
        private System.Windows.Forms.ListBox lsbExplorePersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPetType;
        private System.Windows.Forms.TextBox tbxBreedSpecies;
        private System.Windows.Forms.TextBox tbxPetAge;
        private System.Windows.Forms.TextBox tbxOwner;
        private System.Windows.Forms.TextBox tbxPetName;
    }
}

