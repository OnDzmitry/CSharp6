using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp6.Models;
namespace CSharp6
{
    
    public partial class CreatePlaneForm : Form
    {
        public CreatePlaneForm(Plane plane)
        {
            InitializeComponent();
        }
        public CreatePlaneForm(BindingList<Plane> planes)
        {
            InitializeComponent();
            _mode += AddPlane;
            _crewMembers = new BindingList<string>();
            _planesTypes = new BindingList<string>();
            crewMembersListBox.DataSource = _crewMembers;
            planeTypeListBox.DataSource = _planesTypes;
            _planesList = planes;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreatePlaneForm_Load(object sender, EventArgs e)
        {

        }
       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxSeatsCount.Text = Convert.ToString( (sender as TrackBar).Value);
        }
       
       
        private void radioButtonPassengerPlane_CheckedChanged(object sender, EventArgs e)
        {
            panelPassenger.Visible = true;
            panel2.Visible = false;
        }

        private void radioButtonMilitaryPlane_CheckedChanged(object sender, EventArgs e)
        {
            panelPassenger.Visible = false;
            panel2.Visible = true;
        }

        private void checkBoxAllowCreator_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxAllowCreator.Checked == true )
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
        private BindingList<Plane> _planesList;
        private BindingList<String> _crewMembers;
        private BindingList<String> _planesTypes;
        private delegate void Mode();
        private event Mode _mode;
        private void onlyDigitsPress (object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void trackBarCapacity_Scroll(object sender, EventArgs e)
        {
            capacityTextBox.Text = Convert.ToString((sender as TrackBar).Value);
        }

        private void textBoxCrewMembers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _crewMembers.Add(crewMembersTextBox.Text);
                crewMembersTextBox.Clear();
            }
        }

        private void planeTypesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _planesTypes.Add(planeTypesTextBox.Text);
                planeTypesTextBox.Clear();
            }

        }
        private void AddPlane()
        {
            AirPlaneCreator creator = null;
            if (checkBoxAllowCreator.Checked)
            {
                creator = new AirPlaneCreator
                {
                    Name = textBoxCreatorName.Text,
                    Country = textBoxCreatorCountry.Text,
                    AirPlanesTypes = _planesTypes.ToList(),
                    FoundationYear = Convert.ToInt32(textBoxCreatorFoundationYear.Text)
                };
            }
            if (radioButtonPassengerPlane.Checked)
            {
                PassengerPlane newPasPlane = new PassengerPlane
                {
                    Number = Convert.ToInt32(numberTextBox.Text),
                    Mark = markTextBox.Text,
                    AirlineName = textBoxAirlineName.Text,
                    Creator = creator,
                    ReleaseYear = Convert.ToInt32(releaseYearTextBox.Text),
                    SeatsCount = Convert.ToInt32(textBoxSeatsCount.Text)
                };
                _planesList.Add(newPasPlane);
            }
            if (radioButtonMilitaryPlane.Checked)
            {
                MilitaryPlane newMilPlane = new MilitaryPlane
                {
                    Number = Convert.ToInt32(numberTextBox.Text),
                    Mark = markTextBox.Text,
                    Creator = creator,
                    ReleaseYear = Convert.ToInt32(releaseYearTextBox.Text),
                    Capacity = Convert.ToInt32(capacityTextBox.Text),
                    CrewMembers = _crewMembers.ToList()
                };
                _planesList.Add(newMilPlane);
            }
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            _mode();
        }
    }
}
