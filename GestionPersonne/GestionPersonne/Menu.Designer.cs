
namespace GestionPersonne
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDecon = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btPhone = new System.Windows.Forms.Button();
            this.btPerson = new System.Windows.Forms.Button();
            this.ControlerUser = new System.Windows.Forms.Panel();
            this.btRestore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 71);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1503, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btRestore);
            this.panel2.Controls.Add(this.btDecon);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btPhone);
            this.panel2.Controls.Add(this.btPerson);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 787);
            this.panel2.TabIndex = 13;
            // 
            // btDecon
            // 
            this.btDecon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDecon.FlatAppearance.BorderSize = 0;
            this.btDecon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecon.ForeColor = System.Drawing.Color.Red;
            this.btDecon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDecon.Location = new System.Drawing.Point(4, 709);
            this.btDecon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDecon.Name = "btDecon";
            this.btDecon.Size = new System.Drawing.Size(271, 64);
            this.btDecon.TabIndex = 14;
            this.btDecon.Text = "Deconnexion";
            this.btDecon.UseVisualStyleBackColor = true;
            this.btDecon.Click += new System.EventHandler(this.btDecon_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(7, 407);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(269, 64);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Adresses";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btPhone
            // 
            this.btPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btPhone.FlatAppearance.BorderSize = 0;
            this.btPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhone.ForeColor = System.Drawing.Color.White;
            this.btPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPhone.Location = new System.Drawing.Point(5, 319);
            this.btPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPhone.Name = "btPhone";
            this.btPhone.Size = new System.Drawing.Size(271, 64);
            this.btPhone.TabIndex = 11;
            this.btPhone.Text = "Telephones";
            this.btPhone.UseVisualStyleBackColor = true;
            this.btPhone.Click += new System.EventHandler(this.btPhone_Click);
            // 
            // btPerson
            // 
            this.btPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btPerson.FlatAppearance.BorderSize = 0;
            this.btPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerson.ForeColor = System.Drawing.Color.White;
            this.btPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPerson.Location = new System.Drawing.Point(5, 230);
            this.btPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPerson.Name = "btPerson";
            this.btPerson.Size = new System.Drawing.Size(271, 64);
            this.btPerson.TabIndex = 10;
            this.btPerson.Text = "Personnes";
            this.btPerson.UseVisualStyleBackColor = true;
            this.btPerson.Click += new System.EventHandler(this.btPerson_Click);
            // 
            // ControlerUser
            // 
            this.ControlerUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlerUser.Location = new System.Drawing.Point(276, 71);
            this.ControlerUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlerUser.Name = "ControlerUser";
            this.ControlerUser.Size = new System.Drawing.Size(1371, 787);
            this.ControlerUser.TabIndex = 14;
            this.ControlerUser.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlerUser_Paint);
            // 
            // btRestore
            // 
            this.btRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestore.FlatAppearance.BorderSize = 0;
            this.btRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestore.ForeColor = System.Drawing.Color.White;
            this.btRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRestore.Location = new System.Drawing.Point(4, 637);
            this.btRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(269, 64);
            this.btRestore.TabIndex = 15;
            this.btRestore.Text = "Restorer Config";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GestionPersonne.Properties.Resources.Logo_Standard_Color_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(41, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Black;
            this.btExit.Image = global::GestionPersonne.Properties.Resources.icons8_Close_40px;
            this.btExit.Location = new System.Drawing.Point(1575, 4);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(68, 64);
            this.btExit.TabIndex = 5;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 858);
            this.Controls.Add(this.ControlerUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDecon;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btPhone;
        private System.Windows.Forms.Button btPerson;
        private System.Windows.Forms.Panel ControlerUser;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}