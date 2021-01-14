using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IT_Inventory
{
    public partial class UCUsers : UserControl
    {
        clsDBHelper dBHelper = new clsDBHelper();

        System.Windows.Forms.Timer userCountTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer userAdminCountTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer userEnableCountTimer = new System.Windows.Forms.Timer();


        private int initialCounter = 0;
        private int initialCounter2 = 0;
        private int initialCounter3 = 0;

        int enableUsers = 0;
        int adminUsers  = 0;
        public UCUsers()
        {
            InitializeComponent();

            FillUserDataGridView();

            
            StartUserLabelCounter();
            StartAdminUserLabelCounter();
            StarEnableUserLabelCounter(); 


        }

        public void FillUserDataGridView()
        {
            UserDataGridView.DataSource = dBHelper.GetUsers();

            FormatUserDataGridView();

            GetEnableUsers();
            GetAdminsUsers();       
        }

        private void FormatUserDataGridView()
        {
            UserDataGridView.Columns[0].Width = 70;
            UserDataGridView.Columns[1].Width = 140;
            UserDataGridView.Columns[2].Width = 185;
            UserDataGridView.Columns[3].Width = 70;
            UserDataGridView.Columns[4].Width = 90;
        }

        private void GetEnableUsers()
        {
            for(int i = 0; i < UserDataGridView.Rows.Count; i++)
            {
                bool enable = Boolean.Parse(UserDataGridView.Rows[i].Cells[3].Value.ToString());

                if (enable) enableUsers++;
            }
        }

        private void GetAdminsUsers()
        {
            for (int i = 0; i < UserDataGridView.Rows.Count; i++)
            {
                bool isAdmin = Boolean.Parse(UserDataGridView.Rows[i].Cells[4].Value.ToString());

                if (isAdmin) adminUsers++;
            }
        }


        private void StartUserLabelCounter()
        {
            userCountTimer.Tick += new EventHandler(UserCountTimer_Tick);
            userCountTimer.Interval = 500; 
            userCountTimer.Start();
        }

        private void UserCountTimer_Tick(object sender, EventArgs e)
        {
            initialCounter++;

            if (initialCounter == UserDataGridView.Rows.Count)
                userCountTimer.Stop();
            UserCountLabel.Text = initialCounter.ToString();
        }

        private void StartAdminUserLabelCounter()
        {
            userAdminCountTimer.Tick += UserAdminCountTimer_Tick;
            userAdminCountTimer.Interval = 500;
            userAdminCountTimer.Start();
        }

        private void UserAdminCountTimer_Tick(object sender, EventArgs e)
        {
            initialCounter2++;

            if (initialCounter2 == adminUsers)
                userAdminCountTimer.Stop();
            AdminUserLabel.Text = initialCounter2.ToString();
        }

        private void StarEnableUserLabelCounter()
        {
            userEnableCountTimer.Tick += UserEnableCountTimer_Tick;
            userEnableCountTimer.Interval = 500;
            userEnableCountTimer.Start();
        }

        private void UserEnableCountTimer_Tick(object sender, EventArgs e)
        {
            initialCounter3++;

            if (initialCounter3 == enableUsers)
                userEnableCountTimer.Stop();
            EnableUserLabel.Text = initialCounter3.ToString();
        }

       

        private void UserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int userId= Int32.Parse(UserDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string userName = UserDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string mail = UserDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                bool enable = Boolean.Parse(UserDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                bool isAdmin = Boolean.Parse(UserDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());

                FrmUsersUpdate frmUsersUpdate = new FrmUsersUpdate(userId, userName, mail, enable, isAdmin);

                frmUsersUpdate.ShowDialog();
            }
            
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            bool validForm = ValidateAddUserForm(UserTextBox.Text, MailTextBox.Text); 

            if (validForm)
            {
                /*
                bool isAdmnistrator = AdminCheckBox.Checked;

                dBHelper.AddNewUser(UserTextBox.Text, MailTextBox.Text, isAdmnistrator); */

                MessageBox.Show("True bb");
            }
            else
            {
                MessageBox.Show("False bb");
            }

          
        }

        /* PENDIENTE 1/28/2019 */
        private bool ValidateAddUserForm(string userName, string mail)
        {
            // Validaciones:
            // Validar que los campos no esten vacios. 
            // Validar que el correo o el usuario no existan. 
            // Validar la longitud de campos. 

            bool validForm = false;
            
            // Validacion de campos vacios.
            if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(mail))
            {

                foreach(DataGridViewRow row in UserDataGridView.Rows)
                {
                    string dgvUsername = row.Cells[1].Value.ToString();

                    string dgvUsermail = row.Cells[2].Value.ToString();

                    if(userName.Equals(dgvUsername) || mail.Equals(dgvUsermail))
                    {
                        validForm = false;
                        break;
                    }
                    else
                    {
                        validForm = true;
                    }
                }
                
                return validForm;       
            }
            else
            {
                return false;
            }


        }
    }
}
