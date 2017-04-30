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
        
        public CreatePlaneForm(BindingList<Plane> planes)
        {
            InitializeComponent();
            _crewMembers = new BindingList<string>();
            _planesTypes = new BindingList<string>();
            crewMembersListBox.DataSource = _crewMembers;
            planeTypeListBox.DataSource = _planesTypes;
            _planesList = planes;
        }
        private void _planesList_ListChanged(object sender, ListChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            seatsCountTextBox.Text = Convert.ToString( (sender as TrackBar).Value);
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
            if ( allowCreatorCheckBox.Checked == true )
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
        private void onlyDigitsPress (object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void trackBarCapacity_Scroll(object sender, EventArgs e)
        {
            capacityTextBox.Text = Convert.ToString((sender as TrackBar).Value);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AirPlaneCreator creator = null;
            if (allowCreatorCheckBox.Checked)
            {
                creator = new AirPlaneCreator
                {
                    Name = creatorNameTextBox.Text,
                    Country = creatorCountryTextBox.Text,
                    AirPlanesTypes = _planesTypes.ToList(),
                    FoundationYear = Convert.ToInt32(creatorFoundationYearTextBox.Text)
                };
            }
            if (passengerPlaneRadioButton.Checked)
            {
                PassengerPlane newPasPlane = new PassengerPlane
                {
                    Number = Convert.ToInt32(numberTextBox.Text),
                    Mark = markTextBox.Text,
                    AirlineName = airlineNameTextBox.Text,
                    Creator = creator,
                    ReleaseYear = Convert.ToInt32(releaseYearTextBox.Text),
                    SeatsCount = Convert.ToInt32(seatsCountTextBox.Text)
                };
                _planesList.Add(newPasPlane);
            }
            if (militaryPlaneRadioButton.Checked)
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

        private void addToList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as TextBox).Name == "crewMembersTextBox")
                {
                    _crewMembers.Add(crewMembersTextBox.Text);
                    crewMembersTextBox.Clear();
                }
                if ((sender as TextBox).Name== "planeTypesTextBox")
                {
                    _planesTypes.Add(planeTypesTextBox.Text);
                    planeTypesTextBox.Clear();
                }
            }
        }
        private BindingList<Plane> _planesList;
        private BindingList<String> _crewMembers;
        private BindingList<String> _planesTypes;
    }
}
