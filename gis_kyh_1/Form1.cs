using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gis_kyh_1
{
    public partial class mainForm : Form
    {
        Bitmap mainPicture;

        private int choice;
        private Color color = Color.Red;
        private int size = 5;
        private int interval = 5;

        kPoint point;
        kPolyline line;

        public mainForm()
        {
            InitializeComponent();
            mainPicture = new Bitmap(this.mainMap.Width, this.mainMap.Height);
            cmbAddItems();
        }

        private void cmbAddItems()
        {
            // Initialize comboBox
            cmbColorPoint.Items.Add(Color.Brown);
            cmbColorPoint.Items.Add(Color.Blue);
            cmbColorPoint.Items.Add(Color.Green);
            cmbColorPoint.Items.Add(Color.Red);
            cmbColorPoint.Items.Add(Color.Yellow);
            cmbColorPoint.SelectedItem = cmbColorPoint.Items[3];

            cmbColorLine.Items.Add(Color.Brown);
            cmbColorLine.Items.Add(Color.Blue);
            cmbColorLine.Items.Add(Color.Green);
            cmbColorLine.Items.Add(Color.Red);
            cmbColorLine.Items.Add(Color.Yellow);
            cmbColorLine.SelectedItem = cmbColorPoint.Items[3];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mainPicture = new Bitmap(this.mainMap.Width, this.mainMap.Height);
            mainMap.Image = mainPicture;
            line = new gis_kyh_1.kPolyline(mainPicture, color);
        }

        private void mainMap_MouseClick(object sender, MouseEventArgs e)
        {
            kPoint point = new kPoint(e, mainPicture, color);

            int page = tabControl.SelectedIndex;
            if (page == 0)
            {
                size = Convert.ToInt32(this.tbxSizePoint.Text);
                color = (Color)this.cmbColorPoint.SelectedItem;
                point = new kPoint(e, mainPicture, color);
            }
            else if (page == 1)
            {
                size = Convert.ToInt32(this.tbxSizeLine.Text);
                color = (Color)this.cmbColorLine.SelectedItem;
                interval = Convert.ToInt32(this.tbxInterval.Text);
                line.color = color;
            }
            else if (page == 2)
            {
                size = Convert.ToInt32(this.tbxSizePoint.Text);
                color = (Color)this.cmbColorPoint.SelectedItem;
            }

            switch (choice)
            {
                case 1: point.DrawCircleSymbol(e, size); break;
                case 2: point.DrawTriangleSymbol(e, size); break;
                case 3: point.DrawPentagramSymbol(e, size); break;
                case 4: point.DrawFanSymbol(e, size); break;
                case 5: point.DrawFilledCircleSymbol(e, size); break;
                case 6: point.DrawFilledTriangleSymbol(e, size); break;
                case 7: point.DrawFilledPentagramSymbol(e, size); break;

                case 11: line.DrawGeneralLineSymbol(e, interval, size); break;
                case 12: line.DrawDoubleLineSymbol(e, interval); break;
            }
            mainMap.Image = mainPicture;
        }

        #region Choice of button
        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void btnPentagram_Click(object sender, EventArgs e)
        {
            choice = 3;
        }

        private void btnFan_Click(object sender, EventArgs e)
        {
            choice = 4;
        }

        private void btnSolidCircle_Click(object sender, EventArgs e)
        {
            choice = 5;
        }

        private void btnSolidTriangle_Click(object sender, EventArgs e)
        {
            choice = 6;
        }

        private void btnSolidPentagram_Click(object sender, EventArgs e)
        {
            choice = 7;
        }

        private void btnGeneralLine_Click(object sender, EventArgs e)
        {
            choice = 11; line = new gis_kyh_1.kPolyline(mainPicture, color);
        }

        private void btnTwoLine_Click(object sender, EventArgs e)
        {
            choice = 12; line = new gis_kyh_1.kPolyline(mainPicture, color);
        }

        #endregion
    }
}
