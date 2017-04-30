namespace CSharp6
{
    partial class EditForm
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
            this.capacityPanel = new System.Windows.Forms.Panel();
            this.crewMembersListBox = new System.Windows.Forms.ListBox();
            this.crewMembersLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.crewMembersTextBox = new System.Windows.Forms.TextBox();
            this.capacitytrackBar = new System.Windows.Forms.TrackBar();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.allowCreatorCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.planeTypeListBox = new System.Windows.Forms.ListBox();
            this.creatorPlaneTypesLabel = new System.Windows.Forms.Label();
            this.planeTypesTextBox = new System.Windows.Forms.TextBox();
            this.creatorNameLabel = new System.Windows.Forms.Label();
            this.labelCreator = new System.Windows.Forms.Label();
            this.creatorCountryLabel = new System.Windows.Forms.Label();
            this.creatorYearLabel = new System.Windows.Forms.Label();
            this.creatorFoundationYearTextBox = new System.Windows.Forms.TextBox();
            this.creatorNameTextBox = new System.Windows.Forms.TextBox();
            this.creatorCountryTextBox = new System.Windows.Forms.TextBox();
            this.panelPassenger = new System.Windows.Forms.Panel();
            this.airLineNameLabel = new System.Windows.Forms.Label();
            this.textBoxSeatsCount = new System.Windows.Forms.TextBox();
            this.textBoxAirlineName = new System.Windows.Forms.TextBox();
            this.seatsCountTrackBar = new System.Windows.Forms.TrackBar();
            this.seatsCountLabel = new System.Windows.Forms.Label();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.releaseYearLabel = new System.Windows.Forms.Label();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.markLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.capacityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacitytrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPassenger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsCountTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // capacityPanel
            // 
            this.capacityPanel.Controls.Add(this.crewMembersListBox);
            this.capacityPanel.Controls.Add(this.crewMembersLabel);
            this.capacityPanel.Controls.Add(this.capacityTextBox);
            this.capacityPanel.Controls.Add(this.crewMembersTextBox);
            this.capacityPanel.Controls.Add(this.capacitytrackBar);
            this.capacityPanel.Controls.Add(this.capacityLabel);
            this.capacityPanel.Location = new System.Drawing.Point(-4, 124);
            this.capacityPanel.Name = "capacityPanel";
            this.capacityPanel.Size = new System.Drawing.Size(353, 174);
            this.capacityPanel.TabIndex = 40;
            this.capacityPanel.Visible = false;
            // 
            // crewMembersListBox
            // 
            this.crewMembersListBox.FormattingEnabled = true;
            this.crewMembersListBox.Location = new System.Drawing.Point(1040, -78);
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
            // 
            // crewMembersTextBox
            // 
            this.crewMembersTextBox.Location = new System.Drawing.Point(126, 9);
            this.crewMembersTextBox.Multiline = true;
            this.crewMembersTextBox.Name = "crewMembersTextBox";
            this.crewMembersTextBox.Size = new System.Drawing.Size(200, 20);
            this.crewMembersTextBox.TabIndex = 19;
            this.crewMembersTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.crewMembersTextBox_KeyDown);
            // 
            // capacitytrackBar
            // 
            this.capacitytrackBar.Location = new System.Drawing.Point(126, 119);
            this.capacitytrackBar.Maximum = 900;
            this.capacitytrackBar.Name = "capacitytrackBar";
            this.capacitytrackBar.Size = new System.Drawing.Size(200, 45);
            this.capacitytrackBar.TabIndex = 22;
            this.capacitytrackBar.Scroll += new System.EventHandler(this.capacityTrackBar_Scroll);
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
            // allowCreatorCheckBox
            // 
            this.allowCreatorCheckBox.AutoSize = true;
            this.allowCreatorCheckBox.Location = new System.Drawing.Point(270, 12);
            this.allowCreatorCheckBox.Name = "allowCreatorCheckBox";
            this.allowCreatorCheckBox.Size = new System.Drawing.Size(88, 17);
            this.allowCreatorCheckBox.TabIndex = 39;
            this.allowCreatorCheckBox.Text = "Allow Creator";
            this.allowCreatorCheckBox.UseVisualStyleBackColor = true;
            this.allowCreatorCheckBox.CheckedChanged += new System.EventHandler(this.allowCreatorCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.planeTypeListBox);
            this.panel1.Controls.Add(this.creatorPlaneTypesLabel);
            this.panel1.Controls.Add(this.planeTypesTextBox);
            this.panel1.Controls.Add(this.creatorNameLabel);
            this.panel1.Controls.Add(this.labelCreator);
            this.panel1.Controls.Add(this.creatorCountryLabel);
            this.panel1.Controls.Add(this.creatorYearLabel);
            this.panel1.Controls.Add(this.creatorFoundationYearTextBox);
            this.panel1.Controls.Add(this.creatorNameTextBox);
            this.panel1.Controls.Add(this.creatorCountryTextBox);
            this.panel1.Location = new System.Drawing.Point(364, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 253);
            this.panel1.TabIndex = 38;
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
            // creatorPlaneTypesLabel
            // 
            this.creatorPlaneTypesLabel.AutoSize = true;
            this.creatorPlaneTypesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatorPlaneTypesLabel.Location = new System.Drawing.Point(13, 118);
            this.creatorPlaneTypesLabel.Name = "creatorPlaneTypesLabel";
            this.creatorPlaneTypesLabel.Size = new System.Drawing.Size(98, 17);
            this.creatorPlaneTypesLabel.TabIndex = 25;
            this.creatorPlaneTypesLabel.Text = "Plane Types";
            // 
            // planeTypesTextBox
            // 
            this.planeTypesTextBox.Location = new System.Drawing.Point(131, 118);
            this.planeTypesTextBox.Multiline = true;
            this.planeTypesTextBox.Name = "planeTypesTextBox";
            this.planeTypesTextBox.Size = new System.Drawing.Size(200, 20);
            this.planeTypesTextBox.TabIndex = 26;
            this.planeTypesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.crewMembersTextBox_KeyDown);
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
            // creatorFoundationYearTextBox
            // 
            this.creatorFoundationYearTextBox.Location = new System.Drawing.Point(131, 87);
            this.creatorFoundationYearTextBox.Name = "creatorFoundationYearTextBox";
            this.creatorFoundationYearTextBox.Size = new System.Drawing.Size(200, 20);
            this.creatorFoundationYearTextBox.TabIndex = 16;
            // 
            // creatorNameTextBox
            // 
            this.creatorNameTextBox.Location = new System.Drawing.Point(131, 33);
            this.creatorNameTextBox.Name = "creatorNameTextBox";
            this.creatorNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.creatorNameTextBox.TabIndex = 14;
            // 
            // creatorCountryTextBox
            // 
            this.creatorCountryTextBox.Location = new System.Drawing.Point(131, 59);
            this.creatorCountryTextBox.Name = "creatorCountryTextBox";
            this.creatorCountryTextBox.Size = new System.Drawing.Size(200, 20);
            this.creatorCountryTextBox.TabIndex = 15;
            // 
            // panelPassenger
            // 
            this.panelPassenger.Controls.Add(this.airLineNameLabel);
            this.panelPassenger.Controls.Add(this.textBoxSeatsCount);
            this.panelPassenger.Controls.Add(this.textBoxAirlineName);
            this.panelPassenger.Controls.Add(this.seatsCountTrackBar);
            this.panelPassenger.Controls.Add(this.seatsCountLabel);
            this.panelPassenger.Location = new System.Drawing.Point(-4, 124);
            this.panelPassenger.Name = "panelPassenger";
            this.panelPassenger.Size = new System.Drawing.Size(348, 130);
            this.panelPassenger.TabIndex = 37;
            this.panelPassenger.Visible = false;
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
            // textBoxSeatsCount
            // 
            this.textBoxSeatsCount.Location = new System.Drawing.Point(127, 39);
            this.textBoxSeatsCount.Name = "textBoxSeatsCount";
            this.textBoxSeatsCount.Size = new System.Drawing.Size(200, 20);
            this.textBoxSeatsCount.TabIndex = 23;
            this.textBoxSeatsCount.Text = "0";
            // 
            // textBoxAirlineName
            // 
            this.textBoxAirlineName.Location = new System.Drawing.Point(127, 9);
            this.textBoxAirlineName.Name = "textBoxAirlineName";
            this.textBoxAirlineName.Size = new System.Drawing.Size(200, 20);
            this.textBoxAirlineName.TabIndex = 19;
            // 
            // seatsCountTrackBar
            // 
            this.seatsCountTrackBar.Location = new System.Drawing.Point(127, 65);
            this.seatsCountTrackBar.Maximum = 900;
            this.seatsCountTrackBar.Name = "seatsCountTrackBar";
            this.seatsCountTrackBar.Size = new System.Drawing.Size(200, 45);
            this.seatsCountTrackBar.TabIndex = 22;
            this.seatsCountTrackBar.Scroll += new System.EventHandler(this.seatsCountTrackBar_Scroll);
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
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Location = new System.Drawing.Point(123, 98);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(200, 20);
            this.releaseYearTextBox.TabIndex = 36;
            // 
            // releaseYearLabel
            // 
            this.releaseYearLabel.AutoSize = true;
            this.releaseYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseYearLabel.Location = new System.Drawing.Point(11, 99);
            this.releaseYearLabel.Name = "releaseYearLabel";
            this.releaseYearLabel.Size = new System.Drawing.Size(101, 17);
            this.releaseYearLabel.TabIndex = 35;
            this.releaseYearLabel.Text = "ReleaseYear";
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(123, 69);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(200, 20);
            this.markTextBox.TabIndex = 34;
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel.Location = new System.Drawing.Point(11, 72);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(43, 17);
            this.markLabel.TabIndex = 33;
            this.markLabel.Text = "Mark";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(123, 44);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.numberTextBox.TabIndex = 32;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(11, 45);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(64, 17);
            this.numberLabel.TabIndex = 31;
            this.numberLabel.Text = "Number";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(296, 321);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 23);
            this.editButton.TabIndex = 41;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 356);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.allowCreatorCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPassenger);
            this.Controls.Add(this.releaseYearTextBox);
            this.Controls.Add(this.releaseYearLabel);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.capacityPanel);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.capacityPanel.ResumeLayout(false);
            this.capacityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacitytrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPassenger.ResumeLayout(false);
            this.panelPassenger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsCountTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel capacityPanel;
        private System.Windows.Forms.ListBox crewMembersListBox;
        private System.Windows.Forms.Label crewMembersLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox crewMembersTextBox;
        private System.Windows.Forms.TrackBar capacitytrackBar;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.CheckBox allowCreatorCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox planeTypeListBox;
        private System.Windows.Forms.Label creatorPlaneTypesLabel;
        private System.Windows.Forms.TextBox planeTypesTextBox;
        private System.Windows.Forms.Label creatorNameLabel;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label creatorCountryLabel;
        private System.Windows.Forms.Label creatorYearLabel;
        private System.Windows.Forms.TextBox creatorFoundationYearTextBox;
        private System.Windows.Forms.TextBox creatorNameTextBox;
        private System.Windows.Forms.TextBox creatorCountryTextBox;
        private System.Windows.Forms.Panel panelPassenger;
        private System.Windows.Forms.Label airLineNameLabel;
        private System.Windows.Forms.TextBox textBoxSeatsCount;
        private System.Windows.Forms.TextBox textBoxAirlineName;
        private System.Windows.Forms.TrackBar seatsCountTrackBar;
        private System.Windows.Forms.Label seatsCountLabel;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.Label releaseYearLabel;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button editButton;
    }
}