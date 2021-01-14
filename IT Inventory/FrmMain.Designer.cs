namespace IT_Inventory
{
    partial class FrmMain
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnObjectType = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.pnlFlag3 = new System.Windows.Forms.Panel();
            this.pnlFlag8 = new System.Windows.Forms.Panel();
            this.pnlFlag4 = new System.Windows.Forms.Panel();
            this.pnlFlag7 = new System.Windows.Forms.Panel();
            this.pnlFlag5 = new System.Windows.Forms.Panel();
            this.pnlFlag6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlFlag2 = new System.Windows.Forms.Panel();
            this.pnlFlag1 = new System.Windows.Forms.Panel();
            this.btnMoves = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlTitleBar.Controls.Add(this.panel1);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1200, 23);
            this.pnlTitleBar.TabIndex = 9;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1154, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 23);
            this.panel1.TabIndex = 10;
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.pnlFlag2);
            this.pnlMenu.Controls.Add(this.pnlFlag1);
            this.pnlMenu.Controls.Add(this.btnMoves);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnInventory);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(150, 627);
            this.pnlMenu.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnObjectType);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnStatus);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnProject);
            this.panel2.Controls.Add(this.btnDepartment);
            this.panel2.Controls.Add(this.btnLocation);
            this.panel2.Controls.Add(this.pnlFlag3);
            this.panel2.Controls.Add(this.pnlFlag8);
            this.panel2.Controls.Add(this.pnlFlag4);
            this.panel2.Controls.Add(this.pnlFlag7);
            this.panel2.Controls.Add(this.pnlFlag5);
            this.panel2.Controls.Add(this.pnlFlag6);
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 378);
            this.panel2.TabIndex = 23;
            // 
            // btnObjectType
            // 
            this.btnObjectType.BackColor = System.Drawing.Color.Transparent;
            this.btnObjectType.FlatAppearance.BorderSize = 0;
            this.btnObjectType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnObjectType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnObjectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjectType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObjectType.ForeColor = System.Drawing.Color.White;
            this.btnObjectType.Location = new System.Drawing.Point(6, 265);
            this.btnObjectType.Name = "btnObjectType";
            this.btnObjectType.Size = new System.Drawing.Size(144, 40);
            this.btnObjectType.TabIndex = 29;
            this.btnObjectType.Text = "TIPO DE OBJETO";
            this.btnObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObjectType.UseVisualStyleBackColor = false;
            this.btnObjectType.Click += new System.EventHandler(this.btnObjectType_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(6, 220);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(144, 40);
            this.btnUsers.TabIndex = 28;
            this.btnUsers.Text = "USUARIOS";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(6, 175);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(144, 40);
            this.btnStatus.TabIndex = 27;
            this.btnStatus.Text = "ESTATUS";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "CATÁLOGOS";
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.Color.Transparent;
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.ForeColor = System.Drawing.Color.White;
            this.btnProject.Location = new System.Drawing.Point(6, 130);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(144, 40);
            this.btnProject.TabIndex = 25;
            this.btnProject.Text = "PROYECTO";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.UseVisualStyleBackColor = false;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDepartment.Location = new System.Drawing.Point(6, 85);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(144, 40);
            this.btnDepartment.TabIndex = 24;
            this.btnDepartment.Text = "DEPARTAMENTO";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.Transparent;
            this.btnLocation.FlatAppearance.BorderSize = 0;
            this.btnLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.ForeColor = System.Drawing.Color.White;
            this.btnLocation.Location = new System.Drawing.Point(6, 40);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(144, 40);
            this.btnLocation.TabIndex = 23;
            this.btnLocation.Text = "UBICACIÓN";
            this.btnLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // pnlFlag3
            // 
            this.pnlFlag3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFlag3.Location = new System.Drawing.Point(0, 40);
            this.pnlFlag3.Name = "pnlFlag3";
            this.pnlFlag3.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag3.TabIndex = 19;
            // 
            // pnlFlag8
            // 
            this.pnlFlag8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFlag8.Location = new System.Drawing.Point(0, 265);
            this.pnlFlag8.Name = "pnlFlag8";
            this.pnlFlag8.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag8.TabIndex = 22;
            // 
            // pnlFlag4
            // 
            this.pnlFlag4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFlag4.Location = new System.Drawing.Point(0, 85);
            this.pnlFlag4.Name = "pnlFlag4";
            this.pnlFlag4.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag4.TabIndex = 21;
            // 
            // pnlFlag7
            // 
            this.pnlFlag7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFlag7.Location = new System.Drawing.Point(0, 220);
            this.pnlFlag7.Name = "pnlFlag7";
            this.pnlFlag7.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag7.TabIndex = 20;
            // 
            // pnlFlag5
            // 
            this.pnlFlag5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFlag5.Location = new System.Drawing.Point(0, 130);
            this.pnlFlag5.Name = "pnlFlag5";
            this.pnlFlag5.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag5.TabIndex = 19;
            // 
            // pnlFlag6
            // 
            this.pnlFlag6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFlag6.Location = new System.Drawing.Point(0, 175);
            this.pnlFlag6.Name = "pnlFlag6";
            this.pnlFlag6.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag6.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(0, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 19;
            // 
            // pnlFlag2
            // 
            this.pnlFlag2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFlag2.Location = new System.Drawing.Point(0, 85);
            this.pnlFlag2.Name = "pnlFlag2";
            this.pnlFlag2.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag2.TabIndex = 18;
            // 
            // pnlFlag1
            // 
            this.pnlFlag1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.pnlFlag1.Location = new System.Drawing.Point(0, 40);
            this.pnlFlag1.Name = "pnlFlag1";
            this.pnlFlag1.Size = new System.Drawing.Size(6, 40);
            this.pnlFlag1.TabIndex = 17;
            // 
            // btnMoves
            // 
            this.btnMoves.BackColor = System.Drawing.Color.Transparent;
            this.btnMoves.FlatAppearance.BorderSize = 0;
            this.btnMoves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnMoves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoves.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoves.ForeColor = System.Drawing.Color.White;
            this.btnMoves.Location = new System.Drawing.Point(6, 85);
            this.btnMoves.Name = "btnMoves";
            this.btnMoves.Size = new System.Drawing.Size(144, 40);
            this.btnMoves.TabIndex = 16;
            this.btnMoves.Text = "MOVIMIENTOS";
            this.btnMoves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoves.UseVisualStyleBackColor = false;
            this.btnMoves.Click += new System.EventHandler(this.btnMoves_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "MENÚ";
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(6, 40);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(144, 40);
            this.btnInventory.TabIndex = 11;
            this.btnInventory.Text = "INVENTARIO";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContent.Location = new System.Drawing.Point(156, 29);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1032, 612);
            this.pnlContent.TabIndex = 11;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.pnlTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnMoves;
        private System.Windows.Forms.Panel pnlFlag1;
        private System.Windows.Forms.Panel pnlFlag2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnObjectType;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Panel pnlFlag3;
        private System.Windows.Forms.Panel pnlFlag8;
        private System.Windows.Forms.Panel pnlFlag4;
        private System.Windows.Forms.Panel pnlFlag7;
        private System.Windows.Forms.Panel pnlFlag5;
        private System.Windows.Forms.Panel pnlFlag6;
    }
}