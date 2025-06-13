using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommercialAutomation
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        private SqlBaglanti connect = new SqlBaglanti();



        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            productList();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            productAdd();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            productUpdate();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            productDel();
        }

        /// <summary>
        /// Lists the products from the database and binds them to the grid control.
        /// </summary>
        void productList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Product", connect.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        /// <summary>
        /// Adds a new product to the database.
        /// </summary>
        void productAdd()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Product (Name, Brand, Model, Year, Quantity, CostPrice, SalePrice, Detail) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtBrand.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", txtYaer.Text);
            komut.Parameters.AddWithValue("@p5", numStock.Text);
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtCost.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtPrice.Text));
            komut.Parameters.AddWithValue("@p8", txtDetail.Text);
            komut.ExecuteNonQuery();
            connect.baglanti().Close();
            MessageBox.Show("Product added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            productList(); // Refresh the product list after adding a new product
        }
        /// <summary>
        /// Updates the product information in the database.
        /// </summary>
        void productUpdate()
        {
            int ýd = int.Parse(txtId.Text);
            SqlCommand komut = new SqlCommand("Update Tbl_Product Set Name=@p1, Brand=@p2, Model=@p3, Year=@p4, Quantity=@p5, CostPrice=@p6, SalePrice=@p7, Detail=@p8 Where Id=@p9", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtBrand.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", txtYaer.Text);
            komut.Parameters.AddWithValue("@p5", numStock.Text);
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtCost.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtPrice.Text));
            komut.Parameters.AddWithValue("@p8", txtDetail.Text);
            komut.Parameters.AddWithValue("@p9", ýd);
            komut.ExecuteNonQuery();
            connect.baglanti().Close();
            MessageBox.Show("Product updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            productList(); // Refresh the product list after updating
        }
        /// <summary>
        /// Deletes a product from the database based on the provided ID.
        /// </summary>
        void productDel()
        {
            int ýd = int.Parse(txtId.Text);
            SqlCommand komut = new SqlCommand("Delete From Tbl_Product Where Id=@p1", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", ýd);
            komut.ExecuteNonQuery();
            connect.baglanti().Close();
            MessageBox.Show("Product deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            productList(); // Refresh the product list after deletion
        }
        /// <summary>
        /// Handles the event when the focused row in the grid view changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null) {
                txtId.Text = dr["Id"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtBrand.Text = dr["Brand"].ToString();
                txtModel.Text = dr["Model"].ToString();
                txtYaer.Text = dr["Year"].ToString();
                numStock.Text = dr["Quantity"].ToString();
                txtCost.Text = dr["CostPrice"].ToString();
                txtPrice.Text = dr["SalePrice"].ToString();
                txtDetail.Text = dr["Detail"].ToString();
            }
        }
    }
}
