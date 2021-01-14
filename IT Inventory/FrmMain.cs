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
    public partial class FrmMain : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        int categorySelected;

        int flagIndex = 0;

        UCInventory ucInventory = new UCInventory();
        UCTransactions ucTransactions = new UCTransactions();
        UCLocations ucLocations = new UCLocations();
        UCDepartments ucDepartments = new UCDepartments();
        UCProjects ucProjects = new UCProjects();
        UCStatus ucStatus = new UCStatus();
        UCUsers ucUsers = new UCUsers();
        UCObjectTypes ucObjectTypes = new UCObjectTypes();


        public FrmMain(int categorySelected)
        {
            InitializeComponent();

            this.categorySelected = categorySelected;

            AddUserControl(ucUsers);
        }

        #region TITLE BAR EVENTS

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




        #endregion

        private void btnInventory_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            AddUserControl(ucInventory);

            flagIndex = 1;
            PaintFlag();
        }

        private void btnMoves_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            AddUserControl(ucTransactions);
            
            flagIndex = 2;
            PaintFlag();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            AddUserControl(ucLocations);

            flagIndex = 3;
            PaintFlag();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            AddUserControl(ucDepartments);

            flagIndex = 4;
            PaintFlag();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            AddUserControl(ucProjects);

            flagIndex = 5;
            PaintFlag();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            AddUserControl(ucStatus);

            flagIndex = 6;
            PaintFlag();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            ucUsers = new UCUsers();

            AddUserControl(ucUsers);

            flagIndex = 7;
            PaintFlag();
        }

        private void btnObjectType_Click(object sender, EventArgs e)
        {
            RemoveUsersControls();

            AddUserControl(ucObjectTypes);

            flagIndex = 8;

            PaintFlag();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(userControl);
        } 

        private void RemoveUsersControls()
        {

            if (pnlContent.Controls.Contains(ucInventory)) pnlContent.Controls.Remove(ucInventory);
            if (pnlContent.Controls.Contains(ucTransactions)) pnlContent.Controls.Remove(ucTransactions);
            if (pnlContent.Controls.Contains(ucLocations)) pnlContent.Controls.Remove(ucLocations);
            if (pnlContent.Controls.Contains(ucDepartments)) pnlContent.Controls.Remove(ucDepartments);
            if (pnlContent.Controls.Contains(ucProjects)) pnlContent.Controls.Remove(ucProjects);
            if (pnlContent.Controls.Contains(ucStatus)) pnlContent.Controls.Remove(ucStatus);
            if (pnlContent.Controls.Contains(ucUsers)) pnlContent.Controls.Remove(ucUsers);
            if (pnlContent.Controls.Contains(ucObjectTypes)) pnlContent.Controls.Remove(ucObjectTypes);

        }

        private void RemoveFlagColor()
        {
            pnlFlag1.BackColor = Colors.BLACK_60;
            pnlFlag2.BackColor = Colors.BLACK_60;
            pnlFlag3.BackColor = Colors.BLACK_60;
            pnlFlag4.BackColor = Colors.BLACK_60;
            pnlFlag5.BackColor = Colors.BLACK_60;
            pnlFlag6.BackColor = Colors.BLACK_60;
            pnlFlag7.BackColor = Colors.BLACK_60;
            pnlFlag8.BackColor = Colors.BLACK_60;
        }

        private void PaintFlag()
        {
            RemoveFlagColor();

            switch (flagIndex)
            {
                case 1:
                    pnlFlag1.BackColor = Colors.ACCENT_COLOR;
                    break;

                case 2:
                    pnlFlag2.BackColor = Colors.ACCENT_COLOR;
                    break;

                case 3:
                    pnlFlag3.BackColor = Colors.ACCENT_COLOR;
                    break;

                case 4:
                    pnlFlag4.BackColor = Colors.ACCENT_COLOR;
                    break;

                case 5:
                    pnlFlag5.BackColor = Colors.ACCENT_COLOR;
                    break;

                case 6:
                    pnlFlag6.BackColor = Colors.ACCENT_COLOR;
                    break;

                case 7:
                    pnlFlag7.BackColor = Colors.ACCENT_COLOR;
                    break;

                case 8:
                    pnlFlag8.BackColor = Colors.ACCENT_COLOR;
                    break;
            }
        }
    }
}
