namespace IT_Inventory
{
    partial class FrmUsersUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersUpdate));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserNamePictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MailPictureBox = new System.Windows.Forms.PictureBox();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            this.UserTypePictureBox = new System.Windows.Forms.PictureBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserTypePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlTitleBar.Controls.Add(this.panel2);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(350, 23);
            this.pnlTitleBar.TabIndex = 11;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 23);
            this.panel2.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(23, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Información del usuario";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Enabled = false;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(10, 75);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(330, 25);
            this.UsernameTextBox.TabIndex = 25;
            this.UsernameTextBox.Text = "abel.estrada";
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.UsernameTextBox, "Modificar nombre de usuario");
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre de usuario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MailTextBox
            // 
            this.MailTextBox.BackColor = System.Drawing.Color.White;
            this.MailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailTextBox.Enabled = false;
            this.MailTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailTextBox.Location = new System.Drawing.Point(10, 150);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(330, 25);
            this.MailTextBox.TabIndex = 27;
            this.MailTextBox.Text = "abel.estrada@rheem.com";
            this.MailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Correo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserNamePictureBox
            // 
            this.UserNamePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserNamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserNamePictureBox.Image")));
            this.UserNamePictureBox.Location = new System.Drawing.Point(230, 55);
            this.UserNamePictureBox.Name = "UserNamePictureBox";
            this.UserNamePictureBox.Size = new System.Drawing.Size(15, 15);
            this.UserNamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserNamePictureBox.TabIndex = 30;
            this.UserNamePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.UserNamePictureBox, "Modificar nombre de usuario");
            this.UserNamePictureBox.Click += new System.EventHandler(this.UserNamePictureBox_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // MailPictureBox
            // 
            this.MailPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MailPictureBox.Image")));
            this.MailPictureBox.Location = new System.Drawing.Point(230, 130);
            this.MailPictureBox.Name = "MailPictureBox";
            this.MailPictureBox.Size = new System.Drawing.Size(15, 15);
            this.MailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MailPictureBox.TabIndex = 32;
            this.MailPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.MailPictureBox, "Modificar nombre de usuario");
            this.MailPictureBox.Click += new System.EventHandler(this.MailPictureBox_Click);
            // 
            // StatusPictureBox
            // 
            this.StatusPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StatusPictureBox.Image")));
            this.StatusPictureBox.Location = new System.Drawing.Point(10, 210);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(15, 15);
            this.StatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StatusPictureBox.TabIndex = 33;
            this.StatusPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.StatusPictureBox, "Modificar nombre de usuario");
            this.StatusPictureBox.Click += new System.EventHandler(this.StatusPictureBox_Click);
            // 
            // UserTypePictureBox
            // 
            this.UserTypePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserTypePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserTypePictureBox.Image")));
            this.UserTypePictureBox.Location = new System.Drawing.Point(325, 210);
            this.UserTypePictureBox.Name = "UserTypePictureBox";
            this.UserTypePictureBox.Size = new System.Drawing.Size(15, 15);
            this.UserTypePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserTypePictureBox.TabIndex = 34;
            this.UserTypePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.UserTypePictureBox, "Modificar nombre de usuario");
            this.UserTypePictureBox.Click += new System.EventHandler(this.UserTypePictureBox_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(10, 320);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(330, 26);
            this.UpdateButton.TabIndex = 31;
            this.UpdateButton.Text = "MODIFICAR";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Deshabilitado",
            "Habilitado"});
            this.StatusComboBox.Location = new System.Drawing.Point(10, 230);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(150, 33);
            this.StatusComboBox.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(10, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estatus del usuario";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeComboBox.FormattingEnabled = true;
            this.UserTypeComboBox.Items.AddRange(new object[] {
            "Normal",
            "Administrador"});
            this.UserTypeComboBox.Location = new System.Drawing.Point(190, 230);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(150, 33);
            this.UserTypeComboBox.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(190, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tipo de usuario";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmUsersUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 370);
            this.Controls.Add(this.UserTypeComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UserTypePictureBox);
            this.Controls.Add(this.StatusPictureBox);
            this.Controls.Add(this.MailPictureBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UserNamePictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsersUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsersUpdate";
            this.pnlTitleBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserTypePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox UserNamePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.PictureBox MailPictureBox;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.PictureBox UserTypePictureBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
        private System.Windows.Forms.Label label9;
    }
}