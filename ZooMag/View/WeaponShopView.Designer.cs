
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
            this.weaponsDBDataSet = new ZooMag.WeaponsDBDataSet();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weaponTableAdapter = new ZooMag.WeaponsDBDataSetTableAdapters.WeaponTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weaponBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWeapons
            // 
            this.dgvWeapons.AutoGenerateColumns = false;
            this.dgvWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn});
            this.dgvWeapons.DataSource = this.weaponBindingSource1;
            this.dgvWeapons.Location = new System.Drawing.Point(12, 12);
            this.dgvWeapons.Name = "dgvWeapons";
            this.dgvWeapons.Size = new System.Drawing.Size(244, 205);
            this.dgvWeapons.TabIndex = 0;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.HeaderText = "Attack";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            // 
            // weaponBindingSource1
            // 
            this.weaponBindingSource1.DataSource = typeof(ZooMag.Model.Weapon);
            // 
            // WeaponShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooMag.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvWeapons);
            this.Name = "WeaponShopView";
            this.Text = "WeaponShopView";
            this.Load += new System.EventHandler(this.WeaponShopView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWeapons;
        private WeaponsDBDataSet weaponsDBDataSet;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private WeaponsDBDataSetTableAdapters.WeaponTableAdapter weaponTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource weaponBindingSource1;
    }
}