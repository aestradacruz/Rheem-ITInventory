using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Inventory
{
    public partial class FrmMainInitialCategory : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        public FrmMainInitialCategory()
        {
            InitializeComponent();
        }

        

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cboCategories.SelectedIndex > -1)
            {
                ShowMainForm(cboCategories.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona una categoría.", "IT Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(-1);
            this.Hide();
            frmMain.Show();
        }

        private void ShowMainForm(int selectedIndex)
        {
            FrmMain frmMain = new FrmMain(selectedIndex);
            this.Hide();
            frmMain.Show();
        }
    }
}
