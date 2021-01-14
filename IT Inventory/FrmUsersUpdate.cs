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
    public partial class FrmUsersUpdate : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        int userId = 0;


        public FrmUsersUpdate(int userId, string userName, string mail, bool enable, bool isAdministrator)
        {
            this.userId = userId;

            InitializeComponent();

            SetupInterface(userName, mail, enable, isAdministrator);
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
            this.Close();
        }




        #endregion

        private void SetupInterface(string userName, string mail, bool enable, bool isAdministrator)
        {
            UsernameTextBox.Text = userName;
            MailTextBox.Text = mail;

            if (enable)
                StatusComboBox.SelectedIndex = 1;
            else
                StatusComboBox.SelectedIndex = 0;

            if (isAdministrator)
                UserTypeComboBox.SelectedIndex = 1;
            else
                UserTypeComboBox.SelectedIndex = 0;


            StatusComboBox.Enabled = false;
            UserTypeComboBox.Enabled = false;
        }

        private void UserNamePictureBox_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Enabled = true;
            UsernameTextBox.Focus();
        }

        private void MailPictureBox_Click(object sender, EventArgs e)
        {
            MailTextBox.Enabled = true;
            MailTextBox.Focus();
        }

        private void StatusPictureBox_Click(object sender, EventArgs e)
        {
            StatusComboBox.Enabled = true;
        }

        private void UserTypePictureBox_Click(object sender, EventArgs e)
        {
            UserTypeComboBox.Enabled = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            clsDBHelper dBHelper = new clsDBHelper();

            bool enableUser;

            if (StatusComboBox.SelectedIndex == 0)
                enableUser = false;
            else
                enableUser = true;

            bool administratorUser;

            if (UserTypeComboBox.SelectedIndex == 0)
                administratorUser = false;
            else
                administratorUser = true;


            dBHelper.UpdateUserInformation(userId, UsernameTextBox.Text, MailTextBox.Text, enableUser, administratorUser);
        }
    }
}
