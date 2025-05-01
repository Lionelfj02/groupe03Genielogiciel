
namespace GestionPersonne.UserControls
{
    partial class Personnes
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePerson = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btSup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(555, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnes";
            // 
            // tablePerson
            // 
            this.tablePerson.AllowUserToAddRows = false;
            this.tablePerson.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tablePerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tablePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePerson.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablePerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.id,
            this.fName,
            this.LName,
            this.nam,
            this.sex});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePerson.DefaultCellStyle = dataGridViewCellStyle7;
            this.tablePerson.EnableHeadersVisualStyles = false;
            this.tablePerson.GridColor = System.Drawing.Color.Black;
            this.tablePerson.Location = new System.Drawing.Point(4, 345);
            this.tablePerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablePerson.MultiSelect = false;
            this.tablePerson.Name = "tablePerson";
            this.tablePerson.ReadOnly = true;
            this.tablePerson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablePerson.RowHeadersVisible = false;
            this.tablePerson.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.tablePerson.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tablePerson.RowTemplate.Height = 30;
            this.tablePerson.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePerson.Size = new System.Drawing.Size(1363, 441);
            this.tablePerson.TabIndex = 29;
            this.tablePerson.Click += new System.EventHandler(this.tablePerson_Click);
            // 
            // num
            // 
            this.num.FillWeight = 25F;
            this.num.HeaderText = "#";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // fName
            // 
            this.fName.HeaderText = "Nom";
            this.fName.MinimumWidth = 6;
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "Post-Nom";
            this.LName.MinimumWidth = 6;
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // nam
            // 
            this.nam.HeaderText = "Prenom";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Sexe";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(9, 116);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(441, 42);
            this.txtname.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Post-Nom";
            // 
            // txtpost
            // 
            this.txtpost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpost.Location = new System.Drawing.Point(500, 116);
            this.txtpost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(441, 42);
            this.txtpost.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prenom";
            // 
            // txtpre
            // 
            this.txtpre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpre.Location = new System.Drawing.Point(9, 225);
            this.txtpre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(441, 42);
            this.txtpre.TabIndex = 34;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.FormattingEnabled = true;
            this.txtSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.txtSex.Location = new System.Drawing.Point(500, 226);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(441, 42);
            this.txtSex.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "Sexe";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAdd.FlatAppearance.BorderSize = 2;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(1019, 64);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(348, 55);
            this.btAdd.TabIndex = 38;
            this.btAdd.Text = "Ajouter";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btMod
            // 
            this.btMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btMod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btMod.FlatAppearance.BorderSize = 2;
            this.btMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod.ForeColor = System.Drawing.Color.White;
            this.btMod.Location = new System.Drawing.Point(1019, 138);
            this.btMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(348, 55);
            this.btMod.TabIndex = 39;
            this.btMod.Text = "Modifier";
            this.btMod.UseVisualStyleBackColor = false;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // btSup
            // 
            this.btSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btSup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSup.FlatAppearance.BorderSize = 2;
            this.btSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSup.ForeColor = System.Drawing.Color.White;
            this.btSup.Location = new System.Drawing.Point(1019, 212);
            this.btSup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(348, 55);
            this.btSup.TabIndex = 40;
            this.btSup.Text = "Supprimer";
            this.btSup.UseVisualStyleBackColor = false;
            this.btSup.Click += new System.EventHandler(this.btSup_Click);
            // 
            // Personnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.tablePerson);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Personnes";
            this.Size = new System.Drawing.Size(1371, 786);
            this.Load += new System.EventHandler(this.Personnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tablePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.ComboBox txtSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btSup;
    }
}
