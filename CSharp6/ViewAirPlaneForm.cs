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
    public partial class ViewAirPlaneForm : Form
    {
        
        public ViewAirPlaneForm()
        {
            InitializeComponent();
        }
        public ViewAirPlaneForm(Plane plane)
        {
            InitializeComponent();
            AddToTemlatePlane(plane);
        }
        private void AddToTemlatePlane (Plane plane)
        {
            numberLabel.Text = plane.Number.ToString();
            markLabel.Text = plane.Mark;
            releaseYearLabel.Text = plane.ReleaseYear.ToString();
            if (plane is PassengerPlane)
            {
                PassengerPlane passPlane = plane as PassengerPlane;
                labelType.Text = "Passenger Plane";
                planeAirLinelabel.Text = passPlane.AirlineName;
                planeSeatsCountlabel.Text = passPlane.SeatsCount.ToString();
                panelPassenger.Visible = true;
            }
            if (plane is MilitaryPlane)
            {
                MilitaryPlane millPlane = plane as MilitaryPlane;
                labelType.Text = "Military Plane";
                crewMembersListBox.DataSource = new BindingList<string>(millPlane.CrewMembers);
                capacityPlaneLabel.Text = millPlane.Capacity.ToString();
                panelMilitary.Visible = true;
            }
            if (plane.Creator != null)
            {
                creatorNameLabel.Text = plane.Creator.Name;
                creatorYearLabel.Text = plane.Creator.FoundationYear.ToString();
                creatorCountryLabel.Text = plane.Creator.Country;
                planeTypeListBox.DataSource = plane.Creator.AirPlanesTypes;
                panelCreator.Visible = true;
            }
        }
      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
