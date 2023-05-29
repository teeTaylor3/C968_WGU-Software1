namespace C968_Terrence_Taylor
{
    partial class ModifyParts
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
            this.labelIDorName2 = new System.Windows.Forms.Label();
            this.labelMin2 = new System.Windows.Forms.Label();
            this.labelMax2 = new System.Windows.Forms.Label();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.labelInventory2 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelID2 = new System.Windows.Forms.Label();
            this.mptsIDorName = new System.Windows.Forms.TextBox();
            this.mptsMin = new System.Windows.Forms.TextBox();
            this.mptsMax = new System.Windows.Forms.TextBox();
            this.mptsPrice = new System.Windows.Forms.TextBox();
            this.mptsInventory = new System.Windows.Forms.TextBox();
            this.mptsName = new System.Windows.Forms.TextBox();
            this.mptsID = new System.Windows.Forms.TextBox();
            this.Cancel2 = new System.Windows.Forms.Button();
            this.Save2 = new System.Windows.Forms.Button();
            this.rbOutsourced2 = new System.Windows.Forms.RadioButton();
            this.rbInHouse2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelIDorName2
            // 
            this.labelIDorName2.AutoSize = true;
            this.labelIDorName2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDorName2.Location = new System.Drawing.Point(170, 315);
            this.labelIDorName2.Name = "labelIDorName2";
            this.labelIDorName2.Size = new System.Drawing.Size(65, 13);
            this.labelIDorName2.TabIndex = 36;
            this.labelIDorName2.Text = "Machine ID";
            // 
            // labelMin2
            // 
            this.labelMin2.AutoSize = true;
            this.labelMin2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin2.Location = new System.Drawing.Point(370, 275);
            this.labelMin2.Name = "labelMin2";
            this.labelMin2.Size = new System.Drawing.Size(27, 13);
            this.labelMin2.TabIndex = 35;
            this.labelMin2.Text = "Min";
            // 
            // labelMax2
            // 
            this.labelMax2.AutoSize = true;
            this.labelMax2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax2.Location = new System.Drawing.Point(170, 275);
            this.labelMax2.Name = "labelMax2";
            this.labelMax2.Size = new System.Drawing.Size(28, 13);
            this.labelMax2.TabIndex = 34;
            this.labelMax2.Text = "Max";
            // 
            // labelPrice2
            // 
            this.labelPrice2.AutoSize = true;
            this.labelPrice2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice2.Location = new System.Drawing.Point(170, 235);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.Size = new System.Drawing.Size(31, 13);
            this.labelPrice2.TabIndex = 33;
            this.labelPrice2.Text = "Price";
            // 
            // labelInventory2
            // 
            this.labelInventory2.AutoSize = true;
            this.labelInventory2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory2.Location = new System.Drawing.Point(170, 195);
            this.labelInventory2.Name = "labelInventory2";
            this.labelInventory2.Size = new System.Drawing.Size(83, 13);
            this.labelInventory2.TabIndex = 32;
            this.labelInventory2.Text = "Inventory Level";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName2.Location = new System.Drawing.Point(170, 155);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(36, 13);
            this.labelName2.TabIndex = 31;
            this.labelName2.Text = "Name";
            // 
            // labelID2
            // 
            this.labelID2.AutoSize = true;
            this.labelID2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID2.Location = new System.Drawing.Point(170, 115);
            this.labelID2.Name = "labelID2";
            this.labelID2.Size = new System.Drawing.Size(18, 13);
            this.labelID2.TabIndex = 30;
            this.labelID2.Text = "ID";
            // 
            // mptsIDorName
            // 
            this.mptsIDorName.Location = new System.Drawing.Point(257, 312);
            this.mptsIDorName.Name = "mptsIDorName";
            this.mptsIDorName.Size = new System.Drawing.Size(100, 20);
            this.mptsIDorName.TabIndex = 29;
            this.mptsIDorName.TextChanged += new System.EventHandler(this.mptsIDorName_TextChanged);
            // 
            // mptsMin
            // 
            this.mptsMin.Location = new System.Drawing.Point(433, 272);
            this.mptsMin.Name = "mptsMin";
            this.mptsMin.Size = new System.Drawing.Size(100, 20);
            this.mptsMin.TabIndex = 28;
            this.mptsMin.TextChanged += new System.EventHandler(this.mptsMin_TextChanged);
            // 
            // mptsMax
            // 
            this.mptsMax.Location = new System.Drawing.Point(257, 272);
            this.mptsMax.Name = "mptsMax";
            this.mptsMax.Size = new System.Drawing.Size(100, 20);
            this.mptsMax.TabIndex = 27;
            this.mptsMax.TextChanged += new System.EventHandler(this.mptsMax_TextChanged);
            // 
            // mptsPrice
            // 
            this.mptsPrice.Location = new System.Drawing.Point(257, 232);
            this.mptsPrice.Name = "mptsPrice";
            this.mptsPrice.Size = new System.Drawing.Size(100, 20);
            this.mptsPrice.TabIndex = 26;
            this.mptsPrice.TextChanged += new System.EventHandler(this.mptsPrice_TextChanged);
            // 
            // mptsInventory
            // 
            this.mptsInventory.Location = new System.Drawing.Point(257, 192);
            this.mptsInventory.Name = "mptsInventory";
            this.mptsInventory.Size = new System.Drawing.Size(100, 20);
            this.mptsInventory.TabIndex = 25;
            this.mptsInventory.TextChanged += new System.EventHandler(this.mptsInventory_TextChanged);
            // 
            // mptsName
            // 
            this.mptsName.Location = new System.Drawing.Point(257, 152);
            this.mptsName.Name = "mptsName";
            this.mptsName.Size = new System.Drawing.Size(100, 20);
            this.mptsName.TabIndex = 24;
            this.mptsName.TextChanged += new System.EventHandler(this.mptsName_TextChanged);
            // 
            // mptsID
            // 
            this.mptsID.Location = new System.Drawing.Point(257, 112);
            this.mptsID.Name = "mptsID";
            this.mptsID.ReadOnly = true;
            this.mptsID.Size = new System.Drawing.Size(100, 20);
            this.mptsID.TabIndex = 23;
            this.mptsID.TextChanged += new System.EventHandler(this.mptsID_TextChanged);
            // 
            // Cancel2
            // 
            this.Cancel2.Location = new System.Drawing.Point(575, 372);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(75, 23);
            this.Cancel2.TabIndex = 22;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = true;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // Save2
            // 
            this.Save2.Location = new System.Drawing.Point(475, 372);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(75, 23);
            this.Save2.TabIndex = 21;
            this.Save2.Text = "Save";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Click += new System.EventHandler(this.Save2_Click);
            // 
            // rbOutsourced2
            // 
            this.rbOutsourced2.AutoSize = true;
            this.rbOutsourced2.Location = new System.Drawing.Point(470, 64);
            this.rbOutsourced2.Name = "rbOutsourced2";
            this.rbOutsourced2.Size = new System.Drawing.Size(80, 17);
            this.rbOutsourced2.TabIndex = 20;
            this.rbOutsourced2.TabStop = true;
            this.rbOutsourced2.Text = "Outsourced";
            this.rbOutsourced2.UseVisualStyleBackColor = true;
            this.rbOutsourced2.CheckedChanged += new System.EventHandler(this.Outsourced2_CheckedChanged);
            // 
            // rbInHouse2
            // 
            this.rbInHouse2.AutoSize = true;
            this.rbInHouse2.Location = new System.Drawing.Point(215, 64);
            this.rbInHouse2.Name = "rbInHouse2";
            this.rbInHouse2.Size = new System.Drawing.Size(68, 17);
            this.rbInHouse2.TabIndex = 19;
            this.rbInHouse2.TabStop = true;
            this.rbInHouse2.Text = "In-House";
            this.rbInHouse2.UseVisualStyleBackColor = true;
            this.rbInHouse2.CheckedChanged += new System.EventHandler(this.InHouse2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Inventory Management System";
            // 
            // ModifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 441);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelIDorName2);
            this.Controls.Add(this.labelMin2);
            this.Controls.Add(this.labelMax2);
            this.Controls.Add(this.labelPrice2);
            this.Controls.Add(this.labelInventory2);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelID2);
            this.Controls.Add(this.mptsIDorName);
            this.Controls.Add(this.mptsMin);
            this.Controls.Add(this.mptsMax);
            this.Controls.Add(this.mptsPrice);
            this.Controls.Add(this.mptsInventory);
            this.Controls.Add(this.mptsName);
            this.Controls.Add(this.mptsID);
            this.Controls.Add(this.Cancel2);
            this.Controls.Add(this.Save2);
            this.Controls.Add(this.rbOutsourced2);
            this.Controls.Add(this.rbInHouse2);
            this.Name = "ModifyParts";
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDorName2;
        private System.Windows.Forms.Label labelMin2;
        private System.Windows.Forms.Label labelMax2;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.Label labelInventory2;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelID2;
        private System.Windows.Forms.TextBox mptsIDorName;
        private System.Windows.Forms.TextBox mptsMin;
        private System.Windows.Forms.TextBox mptsMax;
        private System.Windows.Forms.TextBox mptsPrice;
        private System.Windows.Forms.TextBox mptsInventory;
        private System.Windows.Forms.TextBox mptsName;
        private System.Windows.Forms.TextBox mptsID;
        private System.Windows.Forms.Button Cancel2;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.RadioButton rbOutsourced2;
        private System.Windows.Forms.RadioButton rbInHouse2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipName;
    }
}