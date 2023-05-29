namespace C968_Terrence_Taylor
{
    partial class MainScreen
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
            this.DGVPart = new System.Windows.Forms.DataGridView();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.SearchParts = new System.Windows.Forms.TextBox();
            this.SearchProducts = new System.Windows.Forms.TextBox();
            this.Parts1 = new System.Windows.Forms.Label();
            this.Products1 = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.Label();
            this.Add1 = new System.Windows.Forms.Button();
            this.Modify1 = new System.Windows.Forms.Button();
            this.Delete1 = new System.Windows.Forms.Button();
            this.Delete2 = new System.Windows.Forms.Button();
            this.Modify2 = new System.Windows.Forms.Button();
            this.Add2 = new System.Windows.Forms.Button();
            this.Exit1 = new System.Windows.Forms.Button();
            this.Search1 = new System.Windows.Forms.Button();
            this.Search2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPart
            // 
            this.DGVPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPart.Location = new System.Drawing.Point(12, 145);
            this.DGVPart.Name = "DGVPart";
            this.DGVPart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVPart.Size = new System.Drawing.Size(600, 215);
            this.DGVPart.TabIndex = 0;
            this.DGVPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPart_CellClick);
            // 
            // DGVProduct
            // 
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Location = new System.Drawing.Point(672, 145);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.Size = new System.Drawing.Size(600, 215);
            this.DGVProduct.TabIndex = 1;
            this.DGVProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProduct_CellClick);
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(447, 120);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(165, 20);
            this.SearchParts.TabIndex = 2;
            this.SearchParts.DoubleClick += new System.EventHandler(this.Search1_Click);
            // 
            // SearchProducts
            // 
            this.SearchProducts.Location = new System.Drawing.Point(1107, 120);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(165, 20);
            this.SearchProducts.TabIndex = 3;
            this.SearchProducts.TextChanged += new System.EventHandler(this.Search2_Click);
            this.SearchProducts.DoubleClick += new System.EventHandler(this.Search2_Click);
            // 
            // Parts1
            // 
            this.Parts1.AutoSize = true;
            this.Parts1.Location = new System.Drawing.Point(9, 125);
            this.Parts1.Name = "Parts1";
            this.Parts1.Size = new System.Drawing.Size(31, 13);
            this.Parts1.TabIndex = 4;
            this.Parts1.Text = "Parts";
            // 
            // Products1
            // 
            this.Products1.AutoSize = true;
            this.Products1.Location = new System.Drawing.Point(669, 123);
            this.Products1.Name = "Products1";
            this.Products1.Size = new System.Drawing.Size(49, 13);
            this.Products1.TabIndex = 5;
            this.Products1.Text = "Products";
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.Location = new System.Drawing.Point(12, 9);
            this.Main.Name = "Main";
            this.Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Main.Size = new System.Drawing.Size(268, 24);
            this.Main.TabIndex = 6;
            this.Main.Text = "Inventory Management System";
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(420, 365);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(60, 25);
            this.Add1.TabIndex = 7;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // Modify1
            // 
            this.Modify1.Location = new System.Drawing.Point(486, 365);
            this.Modify1.Name = "Modify1";
            this.Modify1.Size = new System.Drawing.Size(60, 25);
            this.Modify1.TabIndex = 8;
            this.Modify1.Text = "Modify";
            this.Modify1.UseVisualStyleBackColor = true;
            this.Modify1.Click += new System.EventHandler(this.Modify1_Click);
            // 
            // Delete1
            // 
            this.Delete1.Location = new System.Drawing.Point(552, 365);
            this.Delete1.Name = "Delete1";
            this.Delete1.Size = new System.Drawing.Size(60, 25);
            this.Delete1.TabIndex = 9;
            this.Delete1.Text = "Delete";
            this.Delete1.UseVisualStyleBackColor = true;
            this.Delete1.Click += new System.EventHandler(this.Delete1_Click);
            // 
            // Delete2
            // 
            this.Delete2.Location = new System.Drawing.Point(1212, 365);
            this.Delete2.Name = "Delete2";
            this.Delete2.Size = new System.Drawing.Size(60, 25);
            this.Delete2.TabIndex = 12;
            this.Delete2.Text = "Delete";
            this.Delete2.UseVisualStyleBackColor = true;
            this.Delete2.Click += new System.EventHandler(this.Delete2_Click);
            // 
            // Modify2
            // 
            this.Modify2.Location = new System.Drawing.Point(1146, 365);
            this.Modify2.Name = "Modify2";
            this.Modify2.Size = new System.Drawing.Size(60, 25);
            this.Modify2.TabIndex = 11;
            this.Modify2.Text = "Modify";
            this.Modify2.UseVisualStyleBackColor = true;
            this.Modify2.Click += new System.EventHandler(this.Modify2_Click);
            // 
            // Add2
            // 
            this.Add2.Location = new System.Drawing.Point(1080, 365);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(60, 25);
            this.Add2.TabIndex = 10;
            this.Add2.Text = "Add";
            this.Add2.UseVisualStyleBackColor = true;
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // Exit1
            // 
            this.Exit1.Location = new System.Drawing.Point(1212, 422);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(60, 25);
            this.Exit1.TabIndex = 13;
            this.Exit1.Text = "Exit";
            this.Exit1.UseVisualStyleBackColor = true;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // Search1
            // 
            this.Search1.Location = new System.Drawing.Point(368, 118);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(75, 23);
            this.Search1.TabIndex = 14;
            this.Search1.Text = "Search";
            this.Search1.UseVisualStyleBackColor = true;
            this.Search1.Click += new System.EventHandler(this.Search1_Click);
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(1027, 120);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(75, 23);
            this.Search2.TabIndex = 15;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.Search2_Click);
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.Search1);
            this.Controls.Add(this.Exit1);
            this.Controls.Add(this.Delete2);
            this.Controls.Add(this.Modify2);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.Delete1);
            this.Controls.Add(this.Modify1);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Products1);
            this.Controls.Add(this.Parts1);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.DGVProduct);
            this.Controls.Add(this.DGVPart);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView Parts;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.DataGridView DGVPart;
        private System.Windows.Forms.TextBox SearchParts;
        private System.Windows.Forms.TextBox SearchProducts;
        private System.Windows.Forms.Label Parts1;
        private System.Windows.Forms.Label Products1;
        private System.Windows.Forms.Label Main;
        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.Button Modify1;
        private System.Windows.Forms.Button Delete1;
        private System.Windows.Forms.Button Delete2;
        private System.Windows.Forms.Button Modify2;
        private System.Windows.Forms.Button Add2;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button Search1;
        private System.Windows.Forms.Button Search2;
        public System.Windows.Forms.DataGridView DGVProduct;
    }
}

