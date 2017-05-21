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
            this.passengerPlaneRadioButton = new System.Windows.Forms.RadioButton();
            this.militaryPlaneRadioButton = new System.Windows.Forms.RadioButton();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.markLabel = new System.Windows.Forms.Label();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.releaseYeaLabelr = new System.Windows.Forms.Label();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.airLineNameLabel = new System.Windows.Forms.Label();
            this.airlineNameTextBox = new System.Windows.Forms.TextBox();
            this.seatsCountLabel = new System.Windows.Forms.Label();
            this.trackBarSeatsCount = new System.Windows.Forms.TrackBar();
            this.seatsCountTextBox = new System.Windows.Forms.TextBox();
            this.passengerPanel = new System.Windows.Forms.Panel();
            this.allowCreatorCheckBox = new System.Windows.Forms.CheckBox();
            this.militaryPanel = new System.Windows.Forms.Panel();
            this.crewMembersListBox = new System.Windows.Forms.ListBox();
            this.crewMembersLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.crewMembersTextBox = new System.Windows.Forms.TextBox();
            this.trackBarCapacity = new System.Windows.Forms.TrackBar();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.creatorCountryTextBox = new System.Windows.Forms.TextBox();
            this.creatorNameTextBox = new System.Windows.Forms.TextBox();
            this.creatorFoundationYearTextBox = new System.Windows.Forms.TextBox();
            this.creatorYearLabel = new System.Windows.Forms.Label();
            this.creatorCountryLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.creatorNameLabel = new System.Windows.Forms.Label();
            this.creatorPanel = new System.Windows.Forms.Panel();
            this.planeTypeListBox = new System.Windows.Forms.ListBox();
            this.planeTypesLabel = new System.Windows.Forms.Label();
            this.planeTypesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeatsCount)).BeginInit();
            this.passengerPanel.SuspendLayout();
            this.militaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCapacity)).BeginInit();
            this.creatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passengerPlaneRadioButton
            // 
            this.passengerPlaneRadioButton.AutoSize = true;
            this.passengerPlaneRadioButton.Location = new System.Drawing.Point(12, 12);
            this.passengerPlaneRadioButton.Name = "passengerPlaneRadioButton";
            this.passengerPlaneRadioButton.Size = new System.Drawing.Size(75, 17);
            this.passengerPlaneRadioButton.TabIndex = 0;
            this.passengerPlaneRadioButton.TabStop = true;
            this.passengerPlaneRadioButton.Text = "Passenger";
            this.passengerPlaneRadioButton.UseVisualStyleBackColor = true;
            this.passengerPlaneRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonPassengerPlane_CheckedChanged);
            // 
            // militaryPlaneRadioButton
            // 
            this.militaryPlaneRadioButton.AutoSize = true;
            this.militaryPlaneRadioButton.Location = new System.Drawing.Point(93, 12);
            this.militaryPlaneRadioButton.Name = "militaryPlaneRadioButton";
            this.militaryPlaneRadioButton.Size = new System.Drawing.Size(57, 17);
            this.militaryPlaneRadioButton.TabIndex = 1;
            this.militaryPlaneRadioButton.TabStop = true;
            this.militaryPlaneRadioButton.Text = "Military";
            this.militaryPlaneRadioButton.UseVisualStyleBackColor = true;
            this.militaryPlaneRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonMilitaryPlane_CheckedChanged);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(15, 45);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(64, 17);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Number";
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
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel.Location = new System.Drawing.Point(15, 72);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(43, 17);
            this.markLabel.TabIndex = 5;
            this.markLabel.Text = "Mark";
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(127, 69);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(200, 20);
            this.markTextBox.TabIndex = 6;
            // 
            // releaseYeaLabelr
            // 
            this.releaseYeaLabelr.AutoSize = true;
            this.releaseYeaLabelr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseYeaLabelr.Location = new System.Drawing.Point(15, 99);
            this.releaseYeaLabelr.Name = "releaseYeaLabelr";
            this.releaseYeaLabelr.Size = new System.Drawing.Size(101, 17);
            this.releaseYeaLabelr.TabIndex = 10;
            this.releaseYeaLabelr.Text = "ReleaseYear";
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Location = new System.Drawing.Point(127, 98);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(200, 20);
            this.releaseYearTextBox.TabIndex = 17;
            this.releaseYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // airLineNameLabel
            // 
            this.airLineNameLabel.AutoSize = true;
            this.airLineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airLineNameLabel.Location = new System.Drawing.Point(15, 9);
            this.airLineNameLabel.Name = "airLineNameLabel";
            this.airLineNameLabel.Size = new System.Drawing.Size(105, 17);
            this.airLineNameLabel.TabIndex = 18;
            this.airLineNameLabel.Text = "AirLine Name";
            // 
            // airlineNameTextBox
            // 
            this.airlineNameTextBox.Location = new System.Drawing.Point(127, 9);
            this.airlineNameTextBox.Name = "airlineNameTextBox";
            this.airlineNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.airlineNameTextBox.TabIndex = 19;
            // 
            // seatsCountLabel
            // 
            this.seatsCountLabel.AutoSize = true;
            this.seatsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatsCountLabel.Location = new System.Drawing.Point(18, 39);
            this.seatsCountLabel.Name = "seatsCountLabel";
            this.seatsCountLabel.Size = new System.Drawing.Size(91, 17);
            this.seatsCountLabel.TabIndex = 20;
            this.seatsCountLabel.Text = "SeatsCount";
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
            // seatsCountTextBox
            // 
            this.seatsCountTextBox.Location = new System.Drawing.Point(127, 39);
            this.seatsCountTextBox.Name = "seatsCountTextBox";
            this.seatsCountTextBox.Size = new System.Drawing.Size(200, 20);
            this.seatsCountTextBox.TabIndex = 23;
            this.seatsCountTextBox.Text = "0";
            this.seatsCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // passengerPanel
            // 
            this.passengerPanel.Controls.Add(this.airLineNameLabel);
            this.passengerPanel.Controls.Add(this.seatsCountTextBox);
            this.passengerPanel.Controls.Add(this.airlineNameTextBox);
            this.passengerPanel.Controls.Add(this.trackBarSeatsCount);
            this.passengerPanel.Controls.Add(this.seatsCountLabel);
            this.passengerPanel.Location = new System.Drawing.Point(0, 124);
            this.passengerPanel.Name = "passengerPanel";
            this.passengerPanel.Size = new System.Drawing.Size(348, 130);
            this.passengerPanel.TabIndex = 24;
            this.passengerPanel.Visible = false;
            // 
            // allowCreatorCheckBox
            // 
            this.allowCreatorCheckBox.AutoSize = true;
            this.allowCreatorCheckBox.Location = new System.Drawing.Point(265, 13);
            this.allowCreatorCheckBox.Name = "allowCreatorCheckBox";
            this.allowCreatorCheckBox.Size = new System.Drawing.Size(88, 17);
            this.allowCreatorCheckBox.TabIndex = 27;
            this.allowCreatorCheckBox.Text = "Allow Creator";
            this.allowCreatorCheckBox.UseVisualStyleBackColor = true;
            this.allowCreatorCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxAllowCreator_CheckedChanged);
            // 
            // militaryPanel
            // 
            this.militaryPanel.Controls.Add(this.crewMembersListBox);
            this.militaryPanel.Controls.Add(this.crewMembersLabel);
            this.militaryPanel.Controls.Add(this.capacityTextBox);
            this.militaryPanel.Controls.Add(this.crewMembersTextBox);
            this.militaryPanel.Controls.Add(this.trackBarCapacity);
            this.militaryPanel.Controls.Add(this.capacityLabel);
            this.militaryPanel.Location = new System.Drawing.Point(0, 124);
            this.militaryPanel.Name = "militaryPanel";
            this.militaryPanel.Size = new System.Drawing.Size(353, 174);
            this.militaryPanel.TabIndex = 28;
            this.militaryPanel.Visible = false;
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
            // crewMembersLabel
            // 
            this.crewMembersLabel.AutoSize = true;
            this.crewMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crewMembersLabel.Location = new System.Drawing.Point(8, 9);
            this.crewMembersLabel.Name = "crewMembersLabel";
            this.crewMembersLabel.Size = new System.Drawing.Size(113, 17);
            this.crewMembersLabel.TabIndex = 18;
            this.crewMembersLabel.Text = "Crew members";
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
            this.crewMembersTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addToList_KeyDown);
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
            // creatorCountryTextBox
            // 
            this.creatorCountryTextBox.Location = new System.Drawing.Point(131, 59);
            this.creatorCountryTextBox.Name = "creatorCountryTextBox";
            this.creatorCountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.creatorCountryTextBox.TabIndex = 15;
            // 
            // creatorNameTextBox
            // 
            this.creatorNameTextBox.Location = new System.Drawing.Point(131, 33);
            this.creatorNameTextBox.Name = "creatorNameTextBox";
            this.creatorNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.creatorNameTextBox.TabIndex = 14;
            // 
            // creatorFoundationYearTextBox
            // 
            this.creatorFoundationYearTextBox.Location = new System.Drawing.Point(131, 87);
            this.creatorFoundationYearTextBox.Name = "creatorFoundationYearTextBox";
            this.creatorFoundationYearTextBox.Size = new System.Drawing.Size(200, 20);
            this.creatorFoundationYearTextBox.TabIndex = 16;
            this.creatorFoundationYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyDigitsPress);
            // 
            // creatorYearLabel
            // 
            this.creatorYearLabel.AutoSize = true;
            this.creatorYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatorYearLabel.Location = new System.Drawing.Point(1, 87);
            this.creatorYearLabel.Name = "creatorYearLabel";
            this.creatorYearLabel.Size = new System.Drawing.Size(123, 17);
            this.creatorYearLabel.TabIndex = 13;
            this.creatorYearLabel.Text = "FoundationYear";
            // 
            // creatorCountryLabel
            // 
            this.creatorCountryLabel.AutoSize = true;
            this.creatorCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatorCountryLabel.Location = new System.Drawing.Point(1, 60);
            this.creatorCountryLabel.Name = "creatorCountryLabel";
            this.creatorCountryLabel.Size = new System.Drawing.Size(64, 17);
            this.creatorCountryLabel.TabIndex = 12;
            this.creatorCountryLabel.Text = "Country";
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatorLabel.Location = new System.Drawing.Point(5, 0);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(62, 17);
            this.creatorLabel.TabIndex = 7;
            this.creatorLabel.Text = "Creator";
            // 
            // creatorNameLabel
            // 
            this.creatorNameLabel.AutoSize = true;
            this.creatorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatorNameLabel.Location = new System.Drawing.Point(1, 34);
            this.creatorNameLabel.Name = "creatorNameLabel";
            this.creatorNameLabel.Size = new System.Drawing.Size(49, 17);
            this.creatorNameLabel.TabIndex = 11;
            this.creatorNameLabel.Text = "Name";
            // 
            // creatorPanel
            // 
            this.creatorPanel.Controls.Add(this.planeTypeListBox);
            this.creatorPanel.Controls.Add(this.planeTypesLabel);
            this.creatorPanel.Controls.Add(this.planeTypesTextBox);
            this.creatorPanel.Controls.Add(this.creatorNameLabel);
            this.creatorPanel.Controls.Add(this.creatorLabel);
            this.creatorPanel.Controls.Add(this.creatorCountryLabel);
            this.creatorPanel.Controls.Add(this.creatorYearLabel);
            this.creatorPanel.Controls.Add(this.creatorFoundationYearTextBox);
            this.creatorPanel.Controls.Add(this.creatorNameTextBox);
            this.creatorPanel.Controls.Add(this.creatorCountryTextBox);
            this.creatorPanel.Location = new System.Drawing.Point(359, 13);
            this.creatorPanel.Name = "creatorPanel";
            this.creatorPanel.Size = new System.Drawing.Size(348, 253);
            this.creatorPanel.TabIndex = 26;
            this.creatorPanel.Visible = false;
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
            this.planeTypesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addToList_KeyDown);
            // 
            // CreatePlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 339);
            this.Controls.Add(this.allowCreatorCheckBox);
            this.Controls.Add(this.creatorPanel);
            this.Controls.Add(this.passengerPanel);
            this.Controls.Add(this.releaseYearTextBox);
            this.Controls.Add(this.releaseYeaLabelr);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.militaryPlaneRadioButton);
            this.Controls.Add(this.passengerPlaneRadioButton);
            this.Controls.Add(this.militaryPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CreatePlaneForm";
            this.Text = "CreatePlane";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeatsCount)).EndInit();
            this.passengerPanel.ResumeLayout(false);
            this.passengerPanel.PerformLayout();
            this.militaryPanel.ResumeLayout(false);
            this.militaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCapacity)).EndInit();
            this.creatorPanel.ResumeLayout(false);
            this.creatorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton passengerPlaneRadioButton;
        private System.Windows.Forms.RadioButton militaryPlaneRadioButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.Label releaseYeaLabelr;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.Label airLineNameLabel;
        private System.Windows.Forms.TextBox airlineNameTextBox;
        private System.Windows.Forms.Label seatsCountLabel;
        private System.Windows.Forms.TrackBar trackBarSeatsCount;
        private System.Windows.Forms.TextBox seatsCountTextBox;
        private System.Windows.Forms.Panel passengerPanel;
        private System.Windows.Forms.CheckBox allowCreatorCheckBox;
        private System.Windows.Forms.Panel militaryPanel;
        private System.Windows.Forms.Label crewMembersLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox crewMembersTextBox;
        private System.Windows.Forms.TrackBar trackBarCapacity;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.ListBox crewMembersListBox;
        private System.Windows.Forms.TextBox creatorCountryTextBox;
        private System.Windows.Forms.TextBox creatorNameTextBox;
        private System.Windows.Forms.TextBox creatorFoundationYearTextBox;
        private System.Windows.Forms.Label creatorYearLabel;
        private System.Windows.Forms.Label creatorCountryLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label creatorNameLabel;
        private System.Windows.Forms.Panel creatorPanel;
        private System.Windows.Forms.ListBox planeTypeListBox;
        private System.Windows.Forms.Label planeTypesLabel;
        private System.Windows.Forms.TextBox planeTypesTextBox;
    }
}