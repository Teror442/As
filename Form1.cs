using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private ProductManager productManager;

        public Form1()
        {
            InitializeComponent();
            productManager = new ProductManager();

            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
        }


        private void ClearInputFields()
        {
            txtType.Clear();
            txtCut.Clear();
            txtColor.Clear();
            txtFabric.Clear();
            txtSize.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string type = txtType.Text;
            string cut = txtCut.Text;
            string color = txtColor.Text;
            string fabric = txtFabric.Text;
            string size = txtSize.Text;
            string brand = txtBrand.Text;
            decimal price;

            if (string.IsNullOrWhiteSpace(txtType.Text) ||
                string.IsNullOrWhiteSpace(txtCut.Text) ||
                 string.IsNullOrWhiteSpace(txtColor.Text) ||
                 string.IsNullOrWhiteSpace(txtFabric.Text) ||
                string.IsNullOrWhiteSpace(txtSize.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
             string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a product.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price value.");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Price cannot be less than 0.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Products newProduct = new Products(type, cut, color, fabric, size, brand, price);


            productManager.AddProduct(newProduct);


            decimal finalPrice = newProduct.CalculatePrice();
            lblResult.Text = $"Final Price: {finalPrice}";


            lstProducts.Items.Add($"Type: {type}, Size: {size}, Color: {color}, Price: {finalPrice}");
            ClearInputFields();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            string filePath = "products.txt";
            productManager.SaveToFile(filePath);
            MessageBox.Show("Products saved to file.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            string filePath = "products.txt";
            productManager.LoadFromFile(filePath);


            lstProducts.Items.Clear();
            foreach (var product in productManager.GetAllProducts())
            {
                decimal finalPrice = product.CalculatePrice();
                lstProducts.Items.Add($"Type: {product.Type}, Size: {product.Size}, Color: {product.Color}, Price: {finalPrice}");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string filterType = txtFilterType.Text.ToLower();
            string filterSize = txtFilterSize.Text.ToLower();
            string filterColor = txtFilterColor.Text.ToLower();


            lstProducts.Items.Clear();

            foreach (var product in productManager.GetAllProducts())
            {
                bool matchesType = string.IsNullOrEmpty(filterType) || product.Type.ToLower().Contains(filterType);
                bool matchesSize = string.IsNullOrEmpty(filterSize) || product.Size.ToLower().Contains(filterSize);
                bool matchesColor = string.IsNullOrEmpty(filterColor) || product.Color.ToLower().Contains(filterColor);

                if (matchesType && matchesSize && matchesColor)
                {
                    decimal finalPrice = product.CalculatePrice();
                    lstProducts.Items.Add($"Type: {product.Type}, Size: {product.Size}, Color: {product.Color}, Price: {finalPrice}");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
