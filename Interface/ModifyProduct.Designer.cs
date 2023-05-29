namespace C968_Terrence_Taylor
{
    partial class ModifyProduct
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
            this.Cancel4 = new System.Windows.Forms.Button();
            this.Save4 = new System.Windows.Forms.Button();
            this.Delete4 = new System.Windows.Forms.Button();
            this.Add4 = new System.Windows.Forms.Button();
            this.mpdID = new System.Windows.Forms.TextBox();
            this.mpdName = new System.Windows.Forms.TextBox();
            this.mpdInventory = new System.Windows.Forms.TextBox();
            this.mpdPrice = new System.Windows.Forms.TextBox();
            this.mpdMax = new System.Windows.Forms.TextBox();
            this.mpdMin = new System.Windows.Forms.TextBox();
            this.DGVAllParts2 = new System.Windows.Forms.DataGridView();
            this.DGVAssociatedParts2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Search4 = new System.Windows.Forms.Button();
            this.SearchAllParts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllParts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel4
            // 
            this.Cancel4.Location = new System.Drawing.Point(745, 525);
            this.Cancel4.Name = "Cancel4";
            this.Cancel4.Size = new System.Drawing.Size(75, 23);
            this.Cancel4.TabIndex = 7;
            this.Cancel4.Text = "Cancel";
            this.Cancel4.UseVisualStyleBackColor = true;
            this.Cancel4.Click += new System.EventHandler(this.Cancel4_Click);
            // 
            // Save4
            // 
            this.Save4.Location = new System.Drawing.Point(635, 525);
            this.Save4.Name = "Save4";
            this.Save4.Size = new System.Drawing.Size(75, 23);
            this.Save4.TabIndex = 6;
            this.Save4.Text = "Save";
            this.Save4.UseVisualStyleBackColor = true;
            this.Save4.Click += new System.EventHandler(this.Save4_Click);
            // 
            // Delete4
            // 
            this.Delete4.Location = new System.Drawing.Point(745, 445);
            this.Delete4.Name = "Delete4";
            this.Delete4.Size = new System.Drawing.Size(75, 23);
            this.Delete4.TabIndex = 5;
            this.Delete4.Text = "Delete";
            this.Delete4.UseVisualStyleBackColor = true;
            this.Delete4.Click += new System.EventHandler(this.Delete4_Click);
            // 
            // Add4
            // 
            this.Add4.Location = new System.Drawing.Point(745, 260);
            this.Add4.Name = "Add4";
            this.Add4.Size = new System.Drawing.Size(75, 23);
            this.Add4.TabIndex = 4;
            this.Add4.Text = "Add";
            this.Add4.UseVisualStyleBackColor = true;
            this.Add4.Click += new System.EventHandler(this.Add4_Click);
            // 
            // mpdID
            // 
            this.mpdID.Location = new System.Drawing.Point(129, 109);
            this.mpdID.Name = "mpdID";
            this.mpdID.ReadOnly = true;
            this.mpdID.Size = new System.Drawing.Size(100, 20);
            this.mpdID.TabIndex = 8;
            this.mpdID.TextChanged += new System.EventHandler(this.mpdID_TextChanged);
            // 
            // mpdName
            // 
            this.mpdName.Location = new System.Drawing.Point(129, 160);
            this.mpdName.Name = "mpdName";
            this.mpdName.Size = new System.Drawing.Size(100, 20);
            this.mpdName.TabIndex = 9;
            this.mpdName.TextChanged += new System.EventHandler(this.mpdName_TextChanged);
            // 
            // mpdInventory
            // 
            this.mpdInventory.Location = new System.Drawing.Point(129, 222);
            this.mpdInventory.Name = "mpdInventory";
            this.mpdInventory.Size = new System.Drawing.Size(100, 20);
            this.mpdInventory.TabIndex = 10;
            this.mpdInventory.TextChanged += new System.EventHandler(this.mpdInventory_TextChanged);
            // 
            // mpdPrice
            // 
            this.mpdPrice.Location = new System.Drawing.Point(129, 280);
            this.mpdPrice.Name = "mpdPrice";
            this.mpdPrice.Size = new System.Drawing.Size(100, 20);
            this.mpdPrice.TabIndex = 11;
            this.mpdPrice.TextChanged += new System.EventHandler(this.mpdPrice_TextChanged);
            // 
            // mpdMax
            // 
            this.mpdMax.Location = new System.Drawing.Point(101, 335);
            this.mpdMax.Name = "mpdMax";
            this.mpdMax.Size = new System.Drawing.Size(50, 20);
            this.mpdMax.TabIndex = 12;
            this.mpdMax.TextChanged += new System.EventHandler(this.mpdMax_TextChanged);
            // 
            // mpdMin
            // 
            this.mpdMin.Location = new System.Drawing.Point(244, 335);
            this.mpdMin.Name = "mpdMin";
            this.mpdMin.Size = new System.Drawing.Size(50, 20);
            this.mpdMin.TabIndex = 13;
            this.mpdMin.TextChanged += new System.EventHandler(this.mpdMin_TextChanged);
            // 
            // DGVAllParts2
            // 
            this.DGVAllParts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAllParts2.Location = new System.Drawing.Point(455, 105);
            this.DGVAllParts2.Name = "DGVAllParts2";
            this.DGVAllParts2.Size = new System.Drawing.Size(366, 150);
            this.DGVAllParts2.TabIndex = 14;
            this.DGVAllParts2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAllParts2_CellClick);
            // 
            // DGVAssociatedParts2
            // 
            this.DGVAssociatedParts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAssociatedParts2.Location = new System.Drawing.Point(455, 285);
            this.DGVAssociatedParts2.Name = "DGVAssociatedParts2";
            this.DGVAssociatedParts2.Size = new System.Drawing.Size(366, 150);
            this.DGVAssociatedParts2.TabIndex = 15;
            this.DGVAssociatedParts2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAssociatedParts2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Inventory Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Inventory Management System";
            // 
            // Search4
            // 
            this.Search4.Location = new System.Drawing.Point(745, 60);
            this.Search4.Name = "Search4";
            this.Search4.Size = new System.Drawing.Size(75, 23);
            this.Search4.TabIndex = 23;
            this.Search4.Text = "Search";
            this.Search4.UseVisualStyleBackColor = true;
            this.Search4.Click += new System.EventHandler(this.Search4_Click);
            // 
            // SearchAllParts
            // 
            this.SearchAllParts.Location = new System.Drawing.Point(540, 62);
            this.SearchAllParts.Name = "SearchAllParts";
            this.SearchAllParts.Size = new System.Drawing.Size(200, 20);
            this.SearchAllParts.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "All Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Parts Associated with the Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 606);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchAllParts);
            this.Controls.Add(this.Search4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVAssociatedParts2);
            this.Controls.Add(this.DGVAllParts2);
            this.Controls.Add(this.mpdMin);
            this.Controls.Add(this.mpdMax);
            this.Controls.Add(this.mpdPrice);
            this.Controls.Add(this.mpdInventory);
            this.Controls.Add(this.mpdName);
            this.Controls.Add(this.mpdID);
            this.Controls.Add(this.Cancel4);
            this.Controls.Add(this.Save4);
            this.Controls.Add(this.Delete4);
            this.Controls.Add(this.Add4);
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllParts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAssociatedParts2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel4;
        private System.Windows.Forms.Button Save4;
        private System.Windows.Forms.Button Delete4;
        private System.Windows.Forms.Button Add4;
        private System.Windows.Forms.TextBox mpdID;
        private System.Windows.Forms.TextBox mpdName;
        private System.Windows.Forms.TextBox mpdInventory;
        private System.Windows.Forms.TextBox mpdPrice;
        private System.Windows.Forms.TextBox mpdMax;
        private System.Windows.Forms.TextBox mpdMin;
        private System.Windows.Forms.DataGridView DGVAllParts2;
        private System.Windows.Forms.DataGridView DGVAssociatedParts2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Search4;
        private System.Windows.Forms.TextBox SearchAllParts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}