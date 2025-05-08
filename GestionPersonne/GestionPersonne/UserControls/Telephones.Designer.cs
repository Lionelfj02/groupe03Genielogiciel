
namespace GestionPersonne.UserControls
{
    partial class Telephones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSup = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListePersonnes = new System.Windows.Forms.ComboBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tablePhone = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.init = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhone)).BeginInit();
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
            this.btSup.Location = new System.Drawing.Point(1018, 241);
            this.btSup.Margin = new System.Windows.Forms.Padding(4);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(348, 55);
            this.btSup.TabIndex = 53;
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
            this.btAdd.Location = new System.Drawing.Point(1018, 100);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(348, 55);
            this.btAdd.TabIndex = 51;
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
            this.btMod.Location = new System.Drawing.Point(1019, 170);
            this.btMod.Margin = new System.Windows.Forms.Padding(4);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(348, 55);
            this.btMod.TabIndex = 52;
            this.btMod.Text = "Modifier";
            this.btMod.UseVisualStyleBackColor = false;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Personnes";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(555, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 54);
            this.label1.TabIndex = 41;
            this.label1.Text = "Telephones";
            // 
            // ListePersonnes
            // 
            this.ListePersonnes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListePersonnes.FormattingEnabled = true;
            this.ListePersonnes.Location = new System.Drawing.Point(9, 113);
            this.ListePersonnes.Margin = new System.Windows.Forms.Padding(4);
            this.ListePersonnes.Name = "ListePersonnes";
            this.ListePersonnes.Size = new System.Drawing.Size(441, 42);
            this.ListePersonnes.TabIndex = 49;
            this.ListePersonnes.SelectedIndexChanged += new System.EventHandler(this.ListePersonnes_SelectedIndexChanged);
            // 
            // txtInitial
            // 
            this.txtInitial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitial.Location = new System.Drawing.Point(9, 267);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(4);
            this.txtInitial.MaxLength = 4;
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.ReadOnly = true;
            this.txtInitial.Size = new System.Drawing.Size(97, 42);
            this.txtInitial.TabIndex = 54;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(116, 267);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.MaxLength = 9;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(333, 42);
            this.txtNum.TabIndex = 55;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // comboCountry
            // 
            this.comboCountry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(9, 203);
            this.comboCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(441, 42);
            this.comboCountry.TabIndex = 57;
            this.comboCountry.SelectedIndexChanged += new System.EventHandler(this.comboCountry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 32);
            this.label3.TabIndex = 56;
            this.label3.Text = "Selectionner un pays";
            // 
            // tablePhone
            // 
            this.tablePhone.AllowUserToAddRows = false;
            this.tablePhone.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tablePhone.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePhone.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePhone.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePhone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.id,
            this.personId,
            this.nam,
            this.init,
            this.Pnum});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePhone.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePhone.EnableHeadersVisualStyles = false;
            this.tablePhone.GridColor = System.Drawing.Color.Black;
            this.tablePhone.Location = new System.Drawing.Point(9, 331);
            this.tablePhone.Margin = new System.Windows.Forms.Padding(4);
            this.tablePhone.MultiSelect = false;
            this.tablePhone.Name = "tablePhone";
            this.tablePhone.ReadOnly = true;
            this.tablePhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablePhone.RowHeadersVisible = false;
            this.tablePhone.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.tablePhone.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablePhone.RowTemplate.Height = 30;
            this.tablePhone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePhone.Size = new System.Drawing.Size(1357, 452);
            this.tablePhone.TabIndex = 58;
            this.tablePhone.Click += new System.EventHandler(this.tablePhone_Click);
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
            this.nam.HeaderText = "Name";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // init
            // 
            this.init.HeaderText = "Initial";
            this.init.MinimumWidth = 6;
            this.init.Name = "init";
            this.init.ReadOnly = true;
            // 
            // Pnum
            // 
            this.Pnum.HeaderText = "Phone Number";
            this.Pnum.MinimumWidth = 6;
            this.Pnum.Name = "Pnum";
            this.Pnum.ReadOnly = true;
            // 
            // Telephones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePhone);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.ListePersonnes);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Telephones";
            this.Size = new System.Drawing.Size(1371, 786);
            this.Load += new System.EventHandler(this.Telephones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSup;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListePersonnes;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView tablePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn personId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn init;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pnum;
    }
}
