
namespace GestionPersonne.UserControls
{
    partial class Adresses
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
            this.btSup = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAddress = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.av = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListePersonnes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVi = new System.Windows.Forms.TextBox();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddress)).BeginInit();
            this.SuspendLayout();
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
            this.btSup.Location = new System.Drawing.Point(1019, 191);
            this.btSup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(348, 55);
            this.btSup.TabIndex = 78;
            this.btSup.Text = "Supprimer";
            this.btSup.UseVisualStyleBackColor = false;
            this.btSup.Click += new System.EventHandler(this.btSup_Click);
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
            this.btAdd.Location = new System.Drawing.Point(1019, 43);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(348, 55);
            this.btAdd.TabIndex = 76;
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
            this.btMod.Location = new System.Drawing.Point(1019, 117);
            this.btMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(348, 55);
            this.btMod.TabIndex = 77;
            this.btMod.Text = "Modifier";
            this.btMod.UseVisualStyleBackColor = false;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(555, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 54);
            this.label1.TabIndex = 75;
            this.label1.Text = "Adresses";
            // 
            // tableAddress
            // 
            this.tableAddress.AllowUserToAddRows = false;
            this.tableAddress.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tableAddress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAddress.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableAddress.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tableAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.id,
            this.personId,
            this.nam,
            this.av,
            this.Q,
            this.com,
            this.city,
            this.country});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableAddress.DefaultCellStyle = dataGridViewCellStyle7;
            this.tableAddress.EnableHeadersVisualStyles = false;
            this.tableAddress.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tableAddress.Location = new System.Drawing.Point(9, 332);
            this.tableAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableAddress.MultiSelect = false;
            this.tableAddress.Name = "tableAddress";
            this.tableAddress.ReadOnly = true;
            this.tableAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableAddress.RowHeadersVisible = false;
            this.tableAddress.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.tableAddress.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tableAddress.RowTemplate.Height = 30;
            this.tableAddress.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableAddress.Size = new System.Drawing.Size(1357, 450);
            this.tableAddress.TabIndex = 83;
            this.tableAddress.Click += new System.EventHandler(this.tableAddress_Click);
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
            // personId
            // 
            this.personId.HeaderText = "IdP";
            this.personId.MinimumWidth = 6;
            this.personId.Name = "personId";
            this.personId.ReadOnly = true;
            this.personId.Visible = false;
            // 
            // nam
            // 
            this.nam.FillWeight = 150F;
            this.nam.HeaderText = "Nom";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // av
            // 
            this.av.FillWeight = 60F;
            this.av.HeaderText = "Avenue";
            this.av.MinimumWidth = 6;
            this.av.Name = "av";
            this.av.ReadOnly = true;
            // 
            // Q
            // 
            this.Q.FillWeight = 60F;
            this.Q.HeaderText = "Quartier";
            this.Q.MinimumWidth = 6;
            this.Q.Name = "Q";
            this.Q.ReadOnly = true;
            // 
            // com
            // 
            this.com.FillWeight = 60F;
            this.com.HeaderText = "Commune";
            this.com.MinimumWidth = 6;
            this.com.Name = "com";
            this.com.ReadOnly = true;
            // 
            // city
            // 
            this.city.FillWeight = 60F;
            this.city.HeaderText = "Ville";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // country
            // 
            this.country.FillWeight = 150F;
            this.country.HeaderText = "Pays";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // ListePersonnes
            // 
            this.ListePersonnes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListePersonnes.FormattingEnabled = true;
            this.ListePersonnes.Items.AddRange(new object[] {
            "Sql Server",
            "MySql"});
            this.ListePersonnes.Location = new System.Drawing.Point(9, 103);
            this.ListePersonnes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListePersonnes.Name = "ListePersonnes";
            this.ListePersonnes.Size = new System.Drawing.Size(441, 42);
            this.ListePersonnes.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 84;
            this.label2.Text = "Personnes";
            // 
            // txtAv
            // 
            this.txtAv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtAv.Location = new System.Drawing.Point(9, 183);
            this.txtAv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAv.Name = "txtAv";
            this.txtAv.Size = new System.Drawing.Size(441, 42);
            this.txtAv.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 87;
            this.label3.Text = "Avenue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 89;
            this.label4.Text = "Quartier";
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtQ.Location = new System.Drawing.Point(9, 270);
            this.txtQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(441, 42);
            this.txtQ.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 91;
            this.label5.Text = "Commune";
            // 
            // txtCom
            // 
            this.txtCom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtCom.Location = new System.Drawing.Point(477, 103);
            this.txtCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(441, 42);
            this.txtCom.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 32);
            this.label6.TabIndex = 93;
            this.label6.Text = "Ville";
            // 
            // txtVi
            // 
            this.txtVi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtVi.Location = new System.Drawing.Point(477, 183);
            this.txtVi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVi.Name = "txtVi";
            this.txtVi.Size = new System.Drawing.Size(441, 42);
            this.txtVi.TabIndex = 92;
            // 
            // comboCountry
            // 
            this.comboCountry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Items.AddRange(new object[] {
            "Sql Server",
            "MySql"});
            this.comboCountry.Location = new System.Drawing.Point(477, 270);
            this.comboCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(441, 42);
            this.comboCountry.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 32);
            this.label7.TabIndex = 94;
            this.label7.Text = "Pays";
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btPrint.FlatAppearance.BorderSize = 2;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Location = new System.Drawing.Point(1019, 262);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(348, 55);
            this.btPrint.TabIndex = 96;
            this.btPrint.Text = "Imprimer";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::GestionPersonne.Properties.Resources.icons8_update_50px_1;
            this.button1.Location = new System.Drawing.Point(943, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 55);
            this.button1.TabIndex = 97;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAv);
            this.Controls.Add(this.ListePersonnes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableAddress);
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Adresses";
            this.Size = new System.Drawing.Size(1371, 786);
            this.Load += new System.EventHandler(this.Adresses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSup;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tableAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn personId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn av;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q;
        private System.Windows.Forms.DataGridViewTextBoxColumn com;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.ComboBox ListePersonnes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVi;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button button1;
    }
}
