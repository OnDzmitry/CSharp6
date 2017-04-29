namespace CSharp6
{
    partial class CreatePlaneForm
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
            this.radioButtonPassengerPlane = new System.Windows.Forms.RadioButton();
            this.radioButtonMilitaryPlane = new System.Windows.Forms.RadioButton();
            this.labelNumber = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelMark = new System.Windows.Forms.Label();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.labelAirLineName = new System.Windows.Forms.Label();
            this.textBoxAirlineName = new System.Windows.Forms.TextBox();
            this.labelSeatsCount = new System.Windows.Forms.Label();
            this.trackBarSeatsCount = new System.Windows.Forms.TrackBar();
            this.textBoxSeatsCount = new System.Windows.Forms.TextBox();
            this.panelPassenger = new System.Windows.Forms.Panel();
            this.checkBoxAllowCreator = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crewMembersListBox = new System.Windows.Forms.ListBox();
            this.labelCrewMembers = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.crewMembersTextBox = new System.Windows.Forms.TextBox();
            this.trackBarCapacity = new System.Windows.Forms.TrackBar();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.textBoxCreatorCountry = new System.Windows.Forms.TextBox();
            this.textBoxCreatorName = new System.Windows.Forms.TextBox();
            this.textBoxCreatorFoundationYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCreator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.planeTypeListBox = new System.Windows.Forms.ListBox();
            this.planeTypesLabel = new System.Windows.Forms.Label();
            this.planeTypesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeatsCount)).BeginInit();
            this.panelPassenger.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCapacity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonPassengerPlane
            // 
            this.radioButtonPassengerPlane.AutoSize = true;
            this.radioButtonPassengerPlane.Location = new System.Drawing.Point(12, 12);
            this.radioButtonPassengerPlane.Name = "radioButtonPassengerPlane";
            this.radioButtonPassengerPlane.Size = new System.Drawing.Size(75, 17);
            this.radioButtonPassengerPlane.TabIndex = 0;
            this.radioButtonPassengerPlane.TabStop = true;
            this.radioButtonPassengerPlane.Text = "Passenger";
            this.radioButtonPassengerPlane.UseVisualStyleBackColor = true;
            this.radioButtonPassengerPlane.CheckedChanged += new System.EventHandler(this.radioButtonPassengerPlane_CheckedChanged);
            // 
            // radioButtonMilitaryPlane
            // 
            this.radioButtonMilitaryPlane.AutoSize = true;
            this.radioButtonMilitaryPlane.Location = new System.Drawing.Point(93, 12);
            this.radioButtonMilitaryPlane.Name = "radioButtonMilitaryPlane";
            this.radioButtonMilitaryPlane.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMilitaryPlane.TabIndex = 1;
            this.radioButtonMilitaryPlane.TabStop = true;
            this.radioButtonMilitaryPlane.Text = "Military";
            this.radioButtonMilitaryPlane.UseVisualStyleBackColor = true;
            this.radioButtonMilitaryPlane.CheckedChanged += new System.EventHandler(this.radioButtonMilitaryPlane_CheckedChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(15, 45);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(64, 17);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Number";
            this.labelNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(127, 44);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.numberTextBox.TabIndex = 3;
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(205, 304);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(276, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMark.Location = new System.Drawing.Point(15, 72);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(43, 17);
            this.labelMark.TabIndex = 5;
            this.labelMark.Text = "Mark";
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(127, 69);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(200, 20);
            this.markTextBox.TabIndex = 6;
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReleaseYear.Location = new System.Drawing.Point(15, 99);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(101, 17);
            this.labelReleaseYear.TabIndex = 10;
            this.labelReleaseYear.Text = "ReleaseYear";
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Location = new System.Drawing.Point(127, 98);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(200, 20);
            this.releaseYearTextBox.TabIndex = 17;
            this.releaseYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // labelAirLineName
            // 
            this.labelAirLineName.AutoSize = true;
            this.labelAirLineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAirLineName.Location = new System.Drawing.Point(15, 9);
            this.labelAirLineName.Name = "labelAirLineName";
            this.labelAirLineName.Size = new System.Drawing.Size(105, 17);
            this.labelAirLineName.TabIndex = 18;
            this.labelAirLineName.Text = "AirLine Name";
            // 
            // textBoxAirlineName
            // 
            this.textBoxAirlineName.Location = new System.Drawing.Point(127, 9);
            this.textBoxAirlineName.Name = "textBoxAirlineName";
            this.textBoxAirlineName.Size = new System.Drawing.Size(200, 20);
            this.textBoxAirlineName.TabIndex = 19;
            // 
            // labelSeatsCount
            // 
            this.labelSeatsCount.AutoSize = true;
            this.labelSeatsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeatsCount.Location = new System.Drawing.Point(18, 39);
            this.labelSeatsCount.Name = "labelSeatsCount";
            this.labelSeatsCount.Size = new System.Drawing.Size(91, 17);
            this.labelSeatsCount.TabIndex = 20;
            this.labelSeatsCount.Text = "SeatsCount";
            // 
            // trackBarSeatsCount
            // 
            this.trackBarSeatsCount.Location = new System.Drawing.Point(127, 65);
            this.trackBarSeatsCount.Maximum = 900;
            this.trackBarSeatsCount.Name = "trackBarSeatsCount";
            this.trackBarSeatsCount.Size = new System.Drawing.Size(200, 45);
            this.trackBarSeatsCount.TabIndex = 22;
            this.trackBarSeatsCount.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBoxSeatsCount
            // 
            this.textBoxSeatsCount.Location = new System.Drawing.Point(127, 39);
            this.textBoxSeatsCount.Name = "textBoxSeatsCount";
            this.textBoxSeatsCount.Size = new System.Drawing.Size(200, 20);
            this.textBoxSeatsCount.TabIndex = 23;
            this.textBoxSeatsCount.Text = "0";
            this.textBoxSeatsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // panelPassenger
            // 
            this.panelPassenger.Controls.Add(this.labelAirLineName);
            this.panelPassenger.Controls.Add(this.textBoxSeatsCount);
            this.panelPassenger.Controls.Add(this.textBoxAirlineName);
            this.panelPassenger.Controls.Add(this.trackBarSeatsCount);
            this.panelPassenger.Controls.Add(this.labelSeatsCount);
            this.panelPassenger.Location = new System.Drawing.Point(0, 124);
            this.panelPassenger.Name = "panelPassenger";
            this.panelPassenger.Size = new System.Drawing.Size(348, 130);
            this.panelPassenger.TabIndex = 24;
            this.panelPassenger.Visible = false;
            // 
            // checkBoxAllowCreator
            // 
            this.checkBoxAllowCreator.AutoSize = true;
            this.checkBoxAllowCreator.Location = new System.Drawing.Point(265, 13);
            this.checkBoxAllowCreator.Name = "checkBoxAllowCreator";
            this.checkBoxAllowCreator.Size = new System.Drawing.Size(88, 17);
            this.checkBoxAllowCreator.TabIndex = 27;
            this.checkBoxAllowCreator.Text = "Allow Creator";
            this.checkBoxAllowCreator.UseVisualStyleBackColor = true;
            this.checkBoxAllowCreator.CheckedChanged += new System.EventHandler(this.checkBoxAllowCreator_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crewMembersListBox);
            this.panel2.Controls.Add(this.labelCrewMembers);
            this.panel2.Controls.Add(this.capacityTextBox);
            this.panel2.Controls.Add(this.crewMembersTextBox);
            this.panel2.Controls.Add(this.trackBarCapacity);
            this.panel2.Controls.Add(this.capacityLabel);
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 174);
            this.panel2.TabIndex = 28;
            this.panel2.Visible = false;
            // 
            // crewMembersListBox
            // 
            this.crewMembersListBox.FormattingEnabled = true;
            this.crewMembersListBox.Location = new System.Drawing.Point(126, 35);
            this.crewMembersListBox.Name = "crewMembersListBox";
            this.crewMembersListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.crewMembersListBox.Size = new System.Drawing.Size(200, 56);
            this.crewMembersListBox.TabIndex = 24;
            // 
            // labelCrewMembers
            // 
            this.labelCrewMembers.AutoSize = true;
            this.labelCrewMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCrewMembers.Location = new System.Drawing.Point(8, 9);
            this.labelCrewMembers.Name = "labelCrewMembers";
            this.labelCrewMembers.Size = new System.Drawing.Size(113, 17);
            this.labelCrewMembers.TabIndex = 18;
            this.labelCrewMembers.Text = "Crew members";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(126, 93);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(200, 20);
            this.capacityTextBox.TabIndex = 23;
            this.capacityTextBox.Text = "0";
            this.capacityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // crewMembersTextBox
            // 
            this.crewMembersTextBox.Location = new System.Drawing.Point(126, 9);
            this.crewMembersTextBox.Multiline = true;
            this.crewMembersTextBox.Name = "crewMembersTextBox";
            this.crewMembersTextBox.Size = new System.Drawing.Size(200, 20);
            this.crewMembersTextBox.TabIndex = 19;
            this.crewMembersTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCrewMembers_KeyDown);
            // 
            // trackBarCapacity
            // 
            this.trackBarCapacity.Location = new System.Drawing.Point(126, 119);
            this.trackBarCapacity.Maximum = 900;
            this.trackBarCapacity.Name = "trackBarCapacity";
            this.trackBarCapacity.Size = new System.Drawing.Size(200, 45);
            this.trackBarCapacity.TabIndex = 22;
            this.trackBarCapacity.Scroll += new System.EventHandler(this.trackBarCapacity_Scroll);
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacityLabel.Location = new System.Drawing.Point(18, 93);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(70, 17);
            this.capacityLabel.TabIndex = 20;
            this.capacityLabel.Text = "Capacity";
            // 
            // textBoxCreatorCountry
            // 
            this.textBoxCreatorCountry.Location = new System.Drawing.Point(131, 59);
            this.textBoxCreatorCountry.Name = "textBoxCreatorCountry";
            this.textBoxCreatorCountry.Size = new System.Drawing.Size(200, 20);
            this.textBoxCreatorCountry.TabIndex = 15;
            // 
            // textBoxCreatorName
            // 
            this.textBoxCreatorName.Location = new System.Drawing.Point(131, 33);
            this.textBoxCreatorName.Name = "textBoxCreatorName";
            this.textBoxCreatorName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCreatorName.TabIndex = 14;
            // 
            // textBoxCreatorFoundationYear
            // 
            this.textBoxCreatorFoundationYear.Location = new System.Drawing.Point(131, 87);
            this.textBoxCreatorFoundationYear.Name = "textBoxCreatorFoundationYear";
            this.textBoxCreatorFoundationYear.Size = new System.Drawing.Size(200, 20);
            this.textBoxCreatorFoundationYear.TabIndex = 16;
            this.textBoxCreatorFoundationYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "FoundationYear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Country";
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreator.Location = new System.Drawing.Point(5, 0);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(62, 17);
            this.labelCreator.TabIndex = 7;
            this.labelCreator.Text = "Creator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.planeTypeListBox);
            this.panel1.Controls.Add(this.planeTypesLabel);
            this.panel1.Controls.Add(this.planeTypesTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelCreator);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxCreatorFoundationYear);
            this.panel1.Controls.Add(this.textBoxCreatorName);
            this.panel1.Controls.Add(this.textBoxCreatorCountry);
            this.panel1.Location = new System.Drawing.Point(359, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 253);
            this.panel1.TabIndex = 26;
            this.panel1.Visible = false;
            // 
            // planeTypeListBox
            // 
            this.planeTypeListBox.FormattingEnabled = true;
            this.planeTypeListBox.Location = new System.Drawing.Point(131, 144);
            this.planeTypeListBox.Name = "planeTypeListBox";
            this.planeTypeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.planeTypeListBox.Size = new System.Drawing.Size(200, 56);
            this.planeTypeListBox.TabIndex = 27;
            // 
            // planeTypesLabel
            // 
            this.planeTypesLabel.AutoSize = true;
            this.planeTypesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planeTypesLabel.Location = new System.Drawing.Point(13, 118);
            this.planeTypesLabel.Name = "planeTypesLabel";
            this.planeTypesLabel.Size = new System.Drawing.Size(98, 17);
            this.planeTypesLabel.TabIndex = 25;
            this.planeTypesLabel.Text = "Plane Types";
            // 
            // planeTypesTextBox
            // 
            this.planeTypesTextBox.Location = new System.Drawing.Point(131, 118);
            this.planeTypesTextBox.Multiline = true;
            this.planeTypesTextBox.Name = "planeTypesTextBox";
            this.planeTypesTextBox.Size = new System.Drawing.Size(200, 20);
            this.planeTypesTextBox.TabIndex = 26;
            this.planeTypesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.planeTypesTextBox_KeyDown);
            // 
            // CreatePlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 339);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBoxAllowCreator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPassenger);
            this.Controls.Add(this.releaseYearTextBox);
            this.Controls.Add(this.labelReleaseYear);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.radioButtonMilitaryPlane);
            this.Controls.Add(this.radioButtonPassengerPlane);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CreatePlaneForm";
            this.Text = "CreatePlane";
            this.Load += new System.EventHandler(this.CreatePlaneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeatsCount)).EndInit();
            this.panelPassenger.ResumeLayout(false);
            this.panelPassenger.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCapacity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPassengerPlane;
        private System.Windows.Forms.RadioButton radioButtonMilitaryPlane;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.Label labelReleaseYear;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.Label labelAirLineName;
        private System.Windows.Forms.TextBox textBoxAirlineName;
        private System.Windows.Forms.Label labelSeatsCount;
        private System.Windows.Forms.TrackBar trackBarSeatsCount;
        private System.Windows.Forms.TextBox textBoxSeatsCount;
        private System.Windows.Forms.Panel panelPassenger;
        private System.Windows.Forms.CheckBox checkBoxAllowCreator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCrewMembers;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox crewMembersTextBox;
        private System.Windows.Forms.TrackBar trackBarCapacity;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.ListBox crewMembersListBox;
        private System.Windows.Forms.TextBox textBoxCreatorCountry;
        private System.Windows.Forms.TextBox textBoxCreatorName;
        private System.Windows.Forms.TextBox textBoxCreatorFoundationYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox planeTypeListBox;
        private System.Windows.Forms.Label planeTypesLabel;
        private System.Windows.Forms.TextBox planeTypesTextBox;
    }
}