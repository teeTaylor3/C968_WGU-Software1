namespace C968_Terrence_Taylor
{
    partial class AddProduct
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apdMin = new System.Windows.Forms.TextBox();
            this.apdMax = new System.Windows.Forms.TextBox();
            this.apdPrice = new System.Windows.Forms.TextBox();
            this.apdInventory = new System.Windows.Forms.TextBox();
            this.apdName = new System.Windows.Forms.TextBox();
            this.apdID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchAllParts = new System.Windows.Forms.TextBox();
            this.Search3 = new System.Windows.Forms.Button();
            this.DGVAssociatedParts1 = new System.Windows.Forms.DataGridView();
            this.DGVAllParts1 = new System.Windows.Forms.DataGridView();
            this.Cancel3 = new System.Windows.Forms.Button();
            this.Save3 = new System.Windows.Forms.Button();
            this.Delete3 = new System.Windows.Forms.Button();
            this.Add3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllParts1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Inventory Management System";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Inventory Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // apdMin
            // 
            this.apdMin.Location = new System.Drawing.Point(244, 335);
            this.apdMin.Name = "apdMin";
            this.apdMin.Size = new System.Drawing.Size(50, 20);
            this.apdMin.TabIndex = 28;
            this.apdMin.TextChanged += new System.EventHandler(this.apdMin_TextChanged);
            // 
            // apdMax
            // 
            this.apdMax.Location = new System.Drawing.Point(101, 335);
            this.apdMax.Name = "apdMax";
            this.apdMax.Size = new System.Drawing.Size(50, 20);
            this.apdMax.TabIndex = 27;
            this.apdMax.TextChanged += new System.EventHandler(this.apdMax_TextChanged);
            // 
            // apdPrice
            // 
            this.apdPrice.Location = new System.Drawing.Point(129, 280);
            this.apdPrice.Name = "apdPrice";
            this.apdPrice.Size = new System.Drawing.Size(100, 20);
            this.apdPrice.TabIndex = 26;
            this.apdPrice.TextChanged += new System.EventHandler(this.apdPrice_TextChanged);
            // 
            // apdInventory
            // 
            this.apdInventory.Location = new System.Drawing.Point(129, 222);
            this.apdInventory.Name = "apdInventory";
            this.apdInventory.Size = new System.Drawing.Size(100, 20);
            this.apdInventory.TabIndex = 25;
            this.apdInventory.TextChanged += new System.EventHandler(this.apdInventory_TextChanged);
            // 
            // apdName
            // 
            this.apdName.Location = new System.Drawing.Point(129, 160);
            this.apdName.Name = "apdName";
            this.apdName.Size = new System.Drawing.Size(100, 20);
            this.apdName.TabIndex = 24;
            this.apdName.TextChanged += new System.EventHandler(this.apdName_TextChanged);
            // 
            // apdID
            // 
            this.apdID.Location = new System.Drawing.Point(129, 109);
            this.apdID.Name = "apdID";
            this.apdID.ReadOnly = true;
            this.apdID.Size = new System.Drawing.Size(100, 20);
            this.apdID.TabIndex = 23;
            this.apdID.TextChanged += new System.EventHandler(this.apdID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Parts Associated with the Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "All Parts";
            // 
            // SearchAllParts
            // 
            this.SearchAllParts.Location = new System.Drawing.Point(540, 62);
            this.SearchAllParts.Name = "SearchAllParts";
            this.SearchAllParts.Size = new System.Drawing.Size(200, 20);
            this.SearchAllParts.TabIndex = 43;
            // 
            // Search3
            // 
            this.Search3.Location = new System.Drawing.Point(745, 60);
            this.Search3.Name = "Search3";
            this.Search3.Size = new System.Drawing.Size(75, 23);
            this.Search3.TabIndex = 42;
            this.Search3.Text = "Search";
            this.Search3.UseVisualStyleBackColor = true;
            this.Search3.Click += new System.EventHandler(this.Search3_Click);
            // 
            // DGVAssociatedParts1
            // 
            this.DGVAssociatedParts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAssociatedParts1.Location = new System.Drawing.Point(455, 285);
            this.DGVAssociatedParts1.Name = "DGVAssociatedParts1";
            this.DGVAssociatedParts1.Size = new System.Drawing.Size(366, 150);
            this.DGVAssociatedParts1.TabIndex = 41;
            this.DGVAssociatedParts1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAssociatedParts1_CellClick);
            // 
            // DGVAllParts1
            // 
            this.DGVAllParts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAllParts1.Location = new System.Drawing.Point(455, 105);
            this.DGVAllParts1.Name = "DGVAllParts1";
            this.DGVAllParts1.Size = new System.Drawing.Size(366, 150);
            this.DGVAllParts1.TabIndex = 40;
            this.DGVAllParts1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAllParts1_CellClick);
            // 
            // Cancel3
            // 
            this.Cancel3.Location = new System.Drawing.Point(745, 525);
            this.Cancel3.Name = "Cancel3";
            this.Cancel3.Size = new System.Drawing.Size(75, 23);
            this.Cancel3.TabIndex = 39;
            this.Cancel3.Text = "Cancel";
            this.Cancel3.UseVisualStyleBackColor = true;
            this.Cancel3.Click += new System.EventHandler(this.Cancel3_Click);
            // 
            // Save3
            // 
            this.Save3.Location = new System.Drawing.Point(635, 525);
            this.Save3.Name = "Save3";
            this.Save3.Size = new System.Drawing.Size(75, 23);
            this.Save3.TabIndex = 38;
            this.Save3.Text = "Save";
            this.Save3.UseVisualStyleBackColor = true;
            this.Save3.Click += new System.EventHandler(this.Save3_Click);
            // 
            // Delete3
            // 
            this.Delete3.Location = new System.Drawing.Point(745, 445);
            this.Delete3.Name = "Delete3";
            this.Delete3.Size = new System.Drawing.Size(75, 23);
            this.Delete3.TabIndex = 37;
            this.Delete3.Text = "Delete";
            this.Delete3.UseVisualStyleBackColor = true;
            this.Delete3.Click += new System.EventHandler(this.Delete3_Click);
            // 
            // Add3
            // 
            this.Add3.Location = new System.Drawing.Point(745, 260);
            this.Add3.Name = "Add3";
            this.Add3.Size = new System.Drawing.Size(75, 23);
            this.Add3.TabIndex = 36;
            this.Add3.Text = "Add";
            this.Add3.UseVisualStyleBackColor = true;
            this.Add3.Click += new System.EventHandler(this.Add3_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 606);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchAllParts);
            this.Controls.Add(this.Search3);
            this.Controls.Add(this.DGVAssociatedParts1);
            this.Controls.Add(this.DGVAllParts1);
            this.Controls.Add(this.Cancel3);
            this.Controls.Add(this.Save3);
            this.Controls.Add(this.Delete3);
            this.Controls.Add(this.Add3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apdMin);
            this.Controls.Add(this.apdMax);
            this.Controls.Add(this.apdPrice);
            this.Controls.Add(this.apdInventory);
            this.Controls.Add(this.apdName);
            this.Controls.Add(this.apdID);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllParts1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apdMin;
        private System.Windows.Forms.TextBox apdMax;
        private System.Windows.Forms.TextBox apdPrice;
        private System.Windows.Forms.TextBox apdInventory;
        private System.Windows.Forms.TextBox apdName;
        private System.Windows.Forms.TextBox apdID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SearchAllParts;
        private System.Windows.Forms.Button Search3;
        private System.Windows.Forms.DataGridView DGVAssociatedParts1;
        private System.Windows.Forms.DataGridView DGVAllParts1;
        private System.Windows.Forms.Button Cancel3;
        private System.Windows.Forms.Button Save3;
        private System.Windows.Forms.Button Delete3;
        private System.Windows.Forms.Button Add3;
    }
}