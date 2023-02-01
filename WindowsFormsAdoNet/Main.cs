// github.com/8bits-1byte
// PRODUCT MANAGER Base Project.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdoNet
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        ProductDAL prodDAL = new ProductDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            label_valueTotal.Text = prodDAL.getItemCount().ToString();
            dgw_prodList.DataSource = prodDAL.GetProducts();
            label_valueId.Text = prodDAL.getIdValue();
        }

        private void btn_prodAdd_Click(object sender, EventArgs e)
        {
            if (txtBox_prodName.Text.Length == 0 || txtBox_prodPrice.Text.Length == 0 || txtBox_prodStock.Text.Length == 0)
            {
                MessageBox.Show("Please fill up the sections.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                prodDAL.AddItem(
                    new Product
                    {
                        product_name = txtBox_prodName.Text,
                        product_price = Convert.ToDecimal(txtBox_prodPrice.Text),
                        product_stock = Convert.ToInt32(txtBox_prodStock.Text)
                    }
                    );
                label_valueId.Text = prodDAL.getIdValue();
                dgw_prodList.DataSource = prodDAL.GetProducts();
                label_valueTotal.Text = prodDAL.getItemCount().ToString();
                //resetting the textbox.
                txtBox_prodName.Text = "";
                txtBox_prodPrice.Text = "";
                txtBox_prodStock.Text = "";
                MessageBox.Show("Item Added!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
     
        private void dgw_prodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                    DataGridViewRow row = this.dgw_prodList.Rows[e.RowIndex];
                    label_modValueId.Text = row.Cells["product_id"].Value.ToString();
                    txtBox_modName.Text = row.Cells["product_name"].Value.ToString();
                    txtBox_modPrice.Text = row.Cells["product_price"].Value.ToString();
                    txtBox_modStock.Text = row.Cells["product_stock"].Value.ToString();
            
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_modName.Text) || string.IsNullOrWhiteSpace(txtBox_modPrice.Text) || string.IsNullOrWhiteSpace(txtBox_modStock.Text))
            {
                MessageBox.Show("Values has to be filled up!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // int product_id, string product_name, decimal product_price, int product_stock
                int product_id = Convert.ToInt32(label_modValueId.Text);
                string product_name = txtBox_modName.Text;
                decimal product_price = Convert.ToDecimal(txtBox_modPrice.Text);
                int product_stock = Convert.ToInt32(txtBox_modStock.Text);
                prodDAL.UpdateItem(product_id, product_name, product_price, product_stock);
                label_valueId.Text = prodDAL.getIdValue();
                label_valueTotal.Text = prodDAL.getItemCount().ToString();
                dgw_prodList.DataSource = prodDAL.GetProducts();
                MessageBox.Show("Item Modified!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgw_prodList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgw_prodList.Rows[e.RowIndex];
                // get the clicked product_id 
                int selectedProductId = Convert.ToInt32(row.Cells["product_id"].Value);


                // checking up If the user wants to delete the data.
                var result = MessageBox.Show("Delete the cell?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    label_valueId.Text = prodDAL.getIdValue();
                    prodDAL.DeleteItem(selectedProductId);
                    label_valueTotal.Text = prodDAL.getItemCount().ToString();
                    dgw_prodList.DataSource = prodDAL.GetProducts();
                    label_modValueId.Text = "";
                    txtBox_modName.Text = "";
                    txtBox_modPrice.Text = "";
                    txtBox_modStock.Text = "";
                    MessageBox.Show("Cell is deleted from database!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
