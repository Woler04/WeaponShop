
namespace ZooMag.View
{
    partial class WeaponShopView
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
            this.dgvWeapons = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.weaponsDBDataSet = new ZooMag.WeaponsDBDataSet();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weaponTableAdapter = new ZooMag.WeaponsDBDataSetTableAdapters.WeaponTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weaponBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWeapons
            // 
            this.dgvWeapons.AllowUserToAddRows = false;
            this.dgvWeapons.AllowUserToDeleteRows = false;
            this.dgvWeapons.AutoGenerateColumns = false;
            this.dgvWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn});
            this.dgvWeapons.DataSource = this.weaponBindingSource1;
            this.dgvWeapons.Location = new System.Drawing.Point(12, 12);
            this.dgvWeapons.Name = "dgvWeapons";
            this.dgvWeapons.ReadOnly = true;
            this.dgvWeapons.Size = new System.Drawing.Size(244, 205);
            this.dgvWeapons.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(551, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(143, 80);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(387, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(387, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(158, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblAttack
            // 
            this.lblAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblAttack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAttack.Location = new System.Drawing.Point(387, 51);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(158, 13);
            this.lblAttack.TabIndex = 5;
            this.lblAttack.Text = "Attack";
            // 
            // txtAttack
            // 
            this.txtAttack.Location = new System.Drawing.Point(387, 67);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(158, 20);
            this.txtAttack.TabIndex = 4;
            // 
            // weaponsDBDataSet
            // 
            this.weaponsDBDataSet.DataSetName = "WeaponsDBDataSet";
            this.weaponsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataMember = "Weapon";
            this.weaponBindingSource.DataSource = this.weaponsDBDataSet;
            // 
            // weaponTableAdapter
            // 
            this.weaponTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(551, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 80);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.HeaderText = "Attack";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            this.attackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weaponBindingSource1
            // 
            this.weaponBindingSource1.DataSource = typeof(ZooMag.Model.Weapon);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 80);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // WeaponShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooMag.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.txtAttack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvWeapons);
            this.Name = "WeaponShopView";
            this.Text = "WeaponShopView";
            this.Load += new System.EventHandler(this.WeaponShopView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWeapons;
        private WeaponsDBDataSet weaponsDBDataSet;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private WeaponsDBDataSetTableAdapters.WeaponTableAdapter weaponTableAdapter;
        private System.Windows.Forms.BindingSource weaponBindingSource1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.TextBox txtAttack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
    }
}