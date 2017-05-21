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
using System.IO;
using CSharp6.XmlHandl;
using System.Xml.Serialization;
namespace CSharp6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _planeList = new BindingList<Plane>();
            PassengerPlane pl = new PassengerPlane { Number = 1,  Mark = "Boing", Creator = null, AirlineName = "united", SeatsCount = 250, ReleaseYear = 2010 };
            PassengerPlane pl1 = new PassengerPlane { Number = 3, Mark = "aBoing", Creator = null, AirlineName = "united", SeatsCount = 250, ReleaseYear = 2010 };
            PassengerPlane pl2 = new PassengerPlane { Number = 4, Mark = "abBoing", Creator = null, AirlineName = "united", SeatsCount = 250, ReleaseYear = 2010 };
            listAirPlane.DataSource = _planeList;
            _planeList.Add(pl);
            _planeList.Add(pl1);
            _planeList.Add(pl2);
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
        private BindingList<Plane> _planeList { set; get; }
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultDes = XmlSerializeWrapper.Deserialize<Plane[]>("save.xml");
            foreach (var i in resultDes)
            {
                _planeList.Add(i);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializeWrapper.Serialize(_planeList, "save.xml");
        }
    }
}
