namespace C968_Terrence_Taylor
{
    partial class AddParts
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
            this.rbInHouse1 = new System.Windows.Forms.RadioButton();
            this.rbOutsourced1 = new System.Windows.Forms.RadioButton();
            this.Save1 = new System.Windows.Forms.Button();
            this.Cancel1 = new System.Windows.Forms.Button();
            this.aptsID = new System.Windows.Forms.TextBox();
            this.aptsName = new System.Windows.Forms.TextBox();
            this.aptsInventory = new System.Windows.Forms.TextBox();
            this.aptsPrice = new System.Windows.Forms.TextBox();
            this.aptsMax = new System.Windows.Forms.TextBox();
            this.aptsMin = new System.Windows.Forms.TextBox();
            this.aptsIDorName = new System.Windows.Forms.TextBox();
            this.labelID1 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelInventory1 = new System.Windows.Forms.Label();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.labelMax1 = new System.Windows.Forms.Label();
            this.Min1 = new System.Windows.Forms.Label();
            this.labelIDorName1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // rbInHouse1
            // 
            this.rbInHouse1.AutoSize = true;
            this.rbInHouse1.Location = new System.Drawing.Point(215, 64);
            this.rbInHouse1.Name = "rbInHouse1";
            this.rbInHouse1.Size = new System.Drawing.Size(68, 17);
            this.rbInHouse1.TabIndex = 0;
            this.rbInHouse1.TabStop = true;
            this.rbInHouse1.Text = "In-House";
            this.rbInHouse1.UseVisualStyleBackColor = true;
            this.rbInHouse1.CheckedChanged += new System.EventHandler(this.InHouse1_CheckedChanged);
            // 
            // rbOutsourced1
            // 
            this.rbOutsourced1.AutoSize = true;
            this.rbOutsourced1.Location = new System.Drawing.Point(470, 64);
            this.rbOutsourced1.Name = "rbOutsourced1";
            this.rbOutsourced1.Size = new System.Drawing.Size(80, 17);
            this.rbOutsourced1.TabIndex = 1;
            this.rbOutsourced1.TabStop = true;
            this.rbOutsourced1.Text = "Outsourced";
            this.rbOutsourced1.UseVisualStyleBackColor = true;
            this.rbOutsourced1.CheckedChanged += new System.EventHandler(this.Ousourced1_CheckedChanged);
            // 
            // Save1
            // 
            this.Save1.Location = new System.Drawing.Point(475, 372);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(75, 23);
            this.Save1.TabIndex = 3;
            this.Save1.Text = "Save";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // Cancel1
            // 
            this.Cancel1.Location = new System.Drawing.Point(575, 372);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(75, 23);
            this.Cancel1.TabIndex = 4;
            this.Cancel1.Text = "Cancel";
            this.Cancel1.UseVisualStyleBackColor = true;
            this.Cancel1.Click += new System.EventHandler(this.Cancel1_Click);
            // 
            // aptsID
            // 
            this.aptsID.Location = new System.Drawing.Point(257, 112);
            this.aptsID.Name = "aptsID";
            this.aptsID.ReadOnly = true;
            this.aptsID.Size = new System.Drawing.Size(100, 20);
            this.aptsID.TabIndex = 5;
            this.aptsID.TextChanged += new System.EventHandler(this.aptsID_TextChanged);
            // 
            // aptsName
            // 
            this.aptsName.Location = new System.Drawing.Point(257, 152);
            this.aptsName.Name = "aptsName";
            this.aptsName.Size = new System.Drawing.Size(100, 20);
            this.aptsName.TabIndex = 6;
            this.aptsName.TextChanged += new System.EventHandler(this.aptsName_TextChanged);
            // 
            // aptsInventory
            // 
            this.aptsInventory.Location = new System.Drawing.Point(257, 192);
            this.aptsInventory.Name = "aptsInventory";
            this.aptsInventory.Size = new System.Drawing.Size(100, 20);
            this.aptsInventory.TabIndex = 7;
            this.aptsInventory.TextChanged += new System.EventHandler(this.aptsInventory_TextChanged);
            // 
            // aptsPrice
            // 
            this.aptsPrice.Location = new System.Drawing.Point(257, 232);
            this.aptsPrice.Name = "aptsPrice";
            this.aptsPrice.Size = new System.Drawing.Size(100, 20);
            this.aptsPrice.TabIndex = 8;
            this.aptsPrice.TextChanged += new System.EventHandler(this.aptsPrice_TextChanged);
            // 
            // aptsMax
            // 
            this.aptsMax.Location = new System.Drawing.Point(257, 272);
            this.aptsMax.Name = "aptsMax";
            this.aptsMax.Size = new System.Drawing.Size(100, 20);
            this.aptsMax.TabIndex = 9;
            this.aptsMax.TextChanged += new System.EventHandler(this.aptsMax_TextChanged);
            // 
            // aptsMin
            // 
            this.aptsMin.Location = new System.Drawing.Point(457, 272);
            this.aptsMin.Name = "aptsMin";
            this.aptsMin.Size = new System.Drawing.Size(100, 20);
            this.aptsMin.TabIndex = 10;
            this.aptsMin.TextChanged += new System.EventHandler(this.aptsMin_TextChanged);
            // 
            // aptsIDorName
            // 
            this.aptsIDorName.Location = new System.Drawing.Point(257, 312);
            this.aptsIDorName.Name = "aptsIDorName";
            this.aptsIDorName.Size = new System.Drawing.Size(100, 20);
            this.aptsIDorName.TabIndex = 11;
            this.aptsIDorName.TextChanged += new System.EventHandler(this.aptsIDorName_TextChanged);
            // 
            // labelID1
            // 
            this.labelID1.AutoSize = true;
            this.labelID1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID1.Location = new System.Drawing.Point(170, 115);
            this.labelID1.Name = "labelID1";
            this.labelID1.Size = new System.Drawing.Size(18, 13);
            this.labelID1.TabIndex = 12;
            this.labelID1.Text = "ID";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName1.Location = new System.Drawing.Point(170, 155);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(36, 13);
            this.labelName1.TabIndex = 13;
            this.labelName1.Text = "Name";
            // 
            // labelInventory1
            // 
            this.labelInventory1.AutoSize = true;
            this.labelInventory1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory1.Location = new System.Drawing.Point(170, 195);
            this.labelInventory1.Name = "labelInventory1";
            this.labelInventory1.Size = new System.Drawing.Size(83, 13);
            this.labelInventory1.TabIndex = 14;
            this.labelInventory1.Text = "Inventory Level";
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice1.Location = new System.Drawing.Point(170, 235);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(31, 13);
            this.labelPrice1.TabIndex = 15;
            this.labelPrice1.Text = "Price";
            // 
            // labelMax1
            // 
            this.labelMax1.AutoSize = true;
            this.labelMax1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax1.Location = new System.Drawing.Point(170, 275);
            this.labelMax1.Name = "labelMax1";
            this.labelMax1.Size = new System.Drawing.Size(28, 13);
            this.labelMax1.TabIndex = 16;
            this.labelMax1.Text = "Max";
            // 
            // Min1
            // 
            this.Min1.AutoSize = true;
            this.Min1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min1.Location = new System.Drawing.Point(370, 275);
            this.Min1.Name = "Min1";
            this.Min1.Size = new System.Drawing.Size(27, 13);
            this.Min1.TabIndex = 17;
            this.Min1.Text = "Min";
            // 
            // labelIDorName1
            // 
            this.labelIDorName1.AutoSize = true;
            this.labelIDorName1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDorName1.Location = new System.Drawing.Point(170, 315);
            this.labelIDorName1.Name = "labelIDorName1";
            this.labelIDorName1.Size = new System.Drawing.Size(65, 13);
            this.labelIDorName1.TabIndex = 18;
            this.labelIDorName1.Text = "Machine ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Inventory Management System";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderApp.ContainerControl = this;
            // 
            // AddParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 441);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelIDorName1);
            this.Controls.Add(this.Min1);
            this.Controls.Add(this.labelMax1);
            this.Controls.Add(this.labelPrice1);
            this.Controls.Add(this.labelInventory1);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.labelID1);
            this.Controls.Add(this.aptsIDorName);
            this.Controls.Add(this.aptsMin);
            this.Controls.Add(this.aptsMax);
            this.Controls.Add(this.aptsPrice);
            this.Controls.Add(this.aptsInventory);
            this.Controls.Add(this.aptsName);
            this.Controls.Add(this.aptsID);
            this.Controls.Add(this.Cancel1);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.rbOutsourced1);
            this.Controls.Add(this.rbInHouse1);
            this.Name = "AddParts";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.Part_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInHouse1;
        private System.Windows.Forms.RadioButton rbOutsourced1;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Button Cancel1;
        private System.Windows.Forms.TextBox aptsID;
        private System.Windows.Forms.TextBox aptsName;
        private System.Windows.Forms.TextBox aptsInventory;
        private System.Windows.Forms.TextBox aptsPrice;
        private System.Windows.Forms.TextBox aptsMax;
        private System.Windows.Forms.TextBox aptsMin;
        private System.Windows.Forms.TextBox aptsIDorName;
        private System.Windows.Forms.Label labelID1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelInventory1;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Label labelMax1;
        private System.Windows.Forms.Label Min1;
        private System.Windows.Forms.Label labelIDorName1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}