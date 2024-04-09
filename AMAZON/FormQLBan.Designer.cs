
namespace AMAZON
{
    partial class FormQLBan
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
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.numericBan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.TapControl = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTableStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpTable.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBan)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.TapControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel19);
            this.tpTable.Controls.Add(this.panel15);
            this.tpTable.Controls.Add(this.panel18);
            this.tpTable.Location = new System.Drawing.Point(4, 29);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(991, 523);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.dtgvTable);
            this.panel19.Location = new System.Drawing.Point(7, 80);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(520, 437);
            this.panel19.TabIndex = 6;
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(3, 6);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 62;
            this.dtgvTable.RowTemplate.Height = 28;
            this.dtgvTable.Size = new System.Drawing.Size(514, 428);
            this.dtgvTable.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel1);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Location = new System.Drawing.Point(533, 83);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(453, 435);
            this.panel15.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.numericBan);
            this.panel16.Controls.Add(this.label5);
            this.panel16.Location = new System.Drawing.Point(3, 82);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(447, 73);
            this.panel16.TabIndex = 3;
            // 
            // numericBan
            // 
            this.numericBan.Location = new System.Drawing.Point(133, 24);
            this.numericBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericBan.Name = "numericBan";
            this.numericBan.Size = new System.Drawing.Size(311, 26);
            this.numericBan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số bàn:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txbTableName);
            this.panel17.Controls.Add(this.label6);
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(447, 73);
            this.panel17.TabIndex = 2;
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new System.Drawing.Point(133, 24);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(311, 26);
            this.txbTableName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã bàn: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnEditTable);
            this.panel18.Controls.Add(this.btnDeleteTable);
            this.panel18.Controls.Add(this.btnAddTable);
            this.panel18.Location = new System.Drawing.Point(7, 7);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(520, 70);
            this.panel18.TabIndex = 4;
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(362, 3);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(155, 64);
            this.btnEditTable.TabIndex = 2;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(185, 3);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(148, 64);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(3, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(162, 64);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 29);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(991, 523);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Món";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(532, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 435);
            this.panel5.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.nmFoodPrice);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(6, 99);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(447, 73);
            this.panel8.TabIndex = 3;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(133, 24);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            55000,
            0,
            0,
            0});
            this.nmFoodPrice.Minimum = new decimal(new int[] {
            29000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(311, 26);
            this.nmFoodPrice.TabIndex = 4;
            this.nmFoodPrice.Value = new decimal(new int[] {
            29000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá tiền:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodName);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(6, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(447, 73);
            this.panel7.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(133, 24);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(311, 26);
            this.txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEditFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 70);
            this.panel4.TabIndex = 1;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(353, 3);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(164, 64);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(144, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(149, 64);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(12, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(104, 64);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(6, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 435);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(3, 3);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 62;
            this.dtgvFood.RowTemplate.Height = 28;
            this.dtgvFood.Size = new System.Drawing.Size(514, 429);
            this.dtgvFood.TabIndex = 0;
            // 
            // TapControl
            // 
            this.TapControl.Controls.Add(this.tpFood);
            this.TapControl.Controls.Add(this.tpTable);
            this.TapControl.Location = new System.Drawing.Point(12, 12);
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(999, 556);
            this.TapControl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTableStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 73);
            this.panel1.TabIndex = 4;
            // 
            // txbTableStatus
            // 
            this.txbTableStatus.Location = new System.Drawing.Point(133, 24);
            this.txbTableStatus.Name = "txbTableStatus";
            this.txbTableStatus.Size = new System.Drawing.Size(311, 26);
            this.txbTableStatus.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình Trạng: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormQLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 580);
            this.Controls.Add(this.TapControl);
            this.Name = "FormQLBan";
            this.Text = "Admin";
            this.tpTable.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBan)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.TapControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.NumericUpDown numericBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabControl TapControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTableStatus;
        private System.Windows.Forms.Label label7;
    }
}