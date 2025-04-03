namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtType = new TextBox();
            txtPrice = new TextBox();
            txtBrand = new TextBox();
            txtColor = new TextBox();
            txtSize = new TextBox();
            txtFabric = new TextBox();
            txtCut = new TextBox();
            btnAddProduct = new Button();
            btnClear = new Button();
            lblResult = new Label();
            lstProducts = new ListBox();
            btnSave = new Button();
            btnLoad = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFilterColor = new TextBox();
            txtFilterType = new TextBox();
            txtFilterSize = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnFilter = new Button();
            SuspendLayout();
            // 
            // txtType
            // 
            txtType.Location = new Point(171, 67);
            txtType.Margin = new Padding(3, 4, 3, 4);
            txtType.Name = "txtType";
            txtType.Size = new Size(249, 27);
            txtType.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(171, 533);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(249, 27);
            txtPrice.TabIndex = 1;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(171, 476);
            txtBrand.Margin = new Padding(3, 4, 3, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(249, 27);
            txtBrand.TabIndex = 2;
            txtBrand.TextChanged += txtBrand_TextChanged;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(171, 258);
            txtColor.Margin = new Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(249, 27);
            txtColor.TabIndex = 3;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(171, 403);
            txtSize.Margin = new Padding(3, 4, 3, 4);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(249, 27);
            txtSize.TabIndex = 4;
            // 
            // txtFabric
            // 
            txtFabric.Location = new Point(171, 340);
            txtFabric.Margin = new Padding(3, 4, 3, 4);
            txtFabric.Name = "txtFabric";
            txtFabric.Size = new Size(249, 27);
            txtFabric.TabIndex = 5;
            // 
            // txtCut
            // 
            txtCut.Location = new Point(171, 157);
            txtCut.Margin = new Padding(3, 4, 3, 4);
            txtCut.Name = "txtCut";
            txtCut.Size = new Size(249, 27);
            txtCut.TabIndex = 6;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(641, 102);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(200, 51);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(641, 265);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 48);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(584, 483);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(76, 20);
            lblResult.TabIndex = 9;
            lblResult.Text = "Final Price";
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(584, 533);
            lstProducts.Margin = new Padding(3, 4, 3, 4);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(406, 164);
            lstProducts.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(641, 174);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 57);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(641, 347);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(200, 58);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 77);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 13;
            label1.Text = "Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 265);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 14;
            label2.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 168);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 15;
            label3.Text = "Cut:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 347);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 16;
            label4.Text = "Fabric:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 410);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 17;
            label5.Text = "Size:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 533);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 18;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 483);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 19;
            label7.Text = "Brand:";
            // 
            // txtFilterColor
            // 
            txtFilterColor.Location = new Point(1083, 67);
            txtFilterColor.Margin = new Padding(3, 4, 3, 4);
            txtFilterColor.Name = "txtFilterColor";
            txtFilterColor.Size = new Size(127, 27);
            txtFilterColor.TabIndex = 20;
            // 
            // txtFilterType
            // 
            txtFilterType.Location = new Point(1083, 126);
            txtFilterType.Margin = new Padding(3, 4, 3, 4);
            txtFilterType.Name = "txtFilterType";
            txtFilterType.Size = new Size(127, 27);
            txtFilterType.TabIndex = 21;
            // 
            // txtFilterSize
            // 
            txtFilterSize.Location = new Point(1083, 189);
            txtFilterSize.Margin = new Padding(3, 4, 3, 4);
            txtFilterSize.Name = "txtFilterSize";
            txtFilterSize.Size = new Size(127, 27);
            txtFilterSize.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(971, 133);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 23;
            label8.Text = "Type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(971, 196);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 24;
            label9.Text = "Size:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(971, 77);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 25;
            label10.Text = "Color:";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(1274, 29);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(144, 49);
            btnFilter.TabIndex = 26;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 904);
            Controls.Add(btnFilter);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtFilterSize);
            Controls.Add(txtFilterType);
            Controls.Add(txtFilterColor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lstProducts);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(btnAddProduct);
            Controls.Add(txtCut);
            Controls.Add(txtFabric);
            Controls.Add(txtSize);
            Controls.Add(txtColor);
            Controls.Add(txtBrand);
            Controls.Add(txtPrice);
            Controls.Add(txtType);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtType;
        private TextBox txtPrice;
        private TextBox txtBrand;
        private TextBox txtColor;
        private TextBox txtSize;
        private TextBox txtFabric;
        private TextBox txtCut;
        private Button btnAddProduct;
        private Button btnClear;
        private Label lblResult;
        private ListBox lstProducts;
        private Button btnSave;
        private Button btnLoad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFilterColor;
        private TextBox txtFilterType;
        private TextBox txtFilterSize;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnFilter;
    }
}
