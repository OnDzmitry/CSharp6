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
    public partial class EditForm : Form
    {
        public EditForm(Plane plane)
        {
            InitializeComponent();
            SetTemplate(plane);
            _editPlane = plane;
            
        }
        private void allowCreatorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allowCreatorCheckBox.Checked == true)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
        private void seatsCountTrackBar_Scroll(object sender, EventArgs e)
        {
            textBoxSeatsCount.Text = Convert.ToString((sender as TrackBar).Value);
        }
        private void capacityTrackBar_Scroll(object sender, EventArgs e)
        {
            capacityTextBox.Text = Convert.ToString((sender as TrackBar).Value);
        }
        private void onlyDigitsPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        public void SetTemplate(Plane plane)
        {
            numberTextBox.Text = plane.Number.ToString();
            markTextBox.Text = plane.Mark;
            releaseYearTextBox.Text = plane.ReleaseYear.ToString();
            if (plane is PassengerPlane)
            {
                PassengerPlane passPlane = plane as PassengerPlane;
                panelPassenger.Visible = true;
                textBoxAirlineName.Text = passPlane.AirlineName;
                textBoxSeatsCount.Text = passPlane.SeatsCount.ToString();
            }
            if (plane is MilitaryPlane)
            {
                MilitaryPlane millPlane = plane as MilitaryPlane;
                capacityPanel.Visible = true;
                _crewMembers = new BindingList<string>(millPlane.CrewMembers);
                crewMembersListBox.DataSource = _crewMembers;
                capacityTextBox.Text = millPlane.Capacity.ToString() ;
            }
            if (plane.Creator!=null)
            {
                panel1.Visible = true;
                allowCreatorCheckBox.Checked = true;
                creatorNameTextBox.Text = plane.Creator.Name;
                creatorCountryTextBox.Text = plane.Creator.Country;
                creatorFoundationYearTextBox.Text = plane.Creator.FoundationYear.ToString();
                _planesTypes = new BindingList<string>(plane.Creator.AirPlanesTypes);
                planeTypeListBox.DataSource =_planesTypes;
            }
        }
        public void Edit()
        {
            try
            {
                AirPlaneCreator creator = null;
                if (allowCreatorCheckBox.Checked)
                {
                    creator = new AirPlaneCreator
                    {
                        Name = creatorNameTextBox.Text,
                        Country = creatorCountryTextBox.Text,
                        FoundationYear = Convert.ToInt32(creatorFoundationYearTextBox.Text),
                        AirPlanesTypes = _planesTypes.ToList()
                    };
                }
                _editPlane.Number = Convert.ToInt32(numberTextBox.Text);
                _editPlane.Mark = markTextBox.Text;
                _editPlane.Creator = creator;
                _editPlane.ReleaseYear = Convert.ToInt32(releaseYearTextBox.Text);
                if (_editPlane is PassengerPlane)
                {
                    (_editPlane as PassengerPlane).AirlineName = textBoxAirlineName.Text; 
                    (_editPlane as PassengerPlane).SeatsCount = Convert.ToInt32(textBoxSeatsCount.Text);
                }
                if (_editPlane is MilitaryPlane)
                {
                    (_editPlane as MilitaryPlane).Capacity = Convert.ToInt32( capacityTextBox.Text);
                }
            }
            catch (Exception)
            {

            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            Edit();
            (this.Owner as MainForm).RefreshList() ;
            this.Close();
        }

        private void crewMembersTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if ((sender as TextBox).Name =="crewMembersTextBox")
                {
                    _crewMembers.Add(crewMembersTextBox.Text);
                    crewMembersTextBox.Clear();
                }
                if ((sender as TextBox).Name== "planeTypesTextBox")
                {
                    if (_planesTypes==null)
                    {
                        _planesTypes = new BindingList<string>();
                        planeTypeListBox.DataSource = _planesTypes;
                    }
                    _planesTypes.Add(planeTypesTextBox.Text);
                    planeTypesTextBox.Clear();
                }
            }
        }
        private Plane _editPlane;
        private BindingList<string> _crewMembers;
        private BindingList<string> _planesTypes;
    }
}
