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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _planeList = new BindingList<Plane>();
            PassengerPlane pl = new PassengerPlane { Number = 1, Mark = "Boing", Creator = null, AirlineName = "united", SeatsCount = 250, ReleaseYear = 2010 };
            PassengerPlane pl1 = new PassengerPlane { Number = 1, Mark = "Boing", Creator = null, AirlineName = "united", SeatsCount = 250, ReleaseYear = 2010 };
            listAirPlane.DataSource = _planeList;
            _planeList.Add(pl);
            _planeList.Add(pl1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatePlaneForm newPlane = new CreatePlaneForm(_planeList);
            newPlane.Show();
        }
        public void RefreshList()
        {
            _planeList.ResetBindings();
        }
        private BindingList<Plane> _planeList;
        private int _index = -1;
        private void listAirPlane_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listAirPlane.IndexFromPoint(e.X, e.Y);
                if (index != -1)
                {
                    listAirPlane.SetSelected(index, true);
                    _index = index;
                    contextMenuStrip1.Show(e.X+this.Location.X+23, e.Y+this.Location.Y+58);
                }
            }
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAirPlaneForm newView = new ViewAirPlaneForm(_planeList[_index]);
            newView.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm newEdit = new EditForm(_planeList[_index]);
            newEdit.Owner = this;
            newEdit.ShowDialog();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _planeList.RemoveAt(_index);
        }
    }
}
