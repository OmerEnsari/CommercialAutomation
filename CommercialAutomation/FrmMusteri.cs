using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmMusteri : Form
    {
        private SqlBaglanti connect = new SqlBaglanti();
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            customerList();
            provinceList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            customerAdd();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DistrictName From Tbl_District where ProvinceId=@p1", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbProvince.SelectedIndex + 1); // Assuming ProvinceId starts from 1
            SqlDataReader dr = komut.ExecuteReader();
            cmbDistrict.Properties.Items.Clear(); // Clear previous items
            while (dr.Read())
            {
                cmbDistrict.Properties.Items.Add(dr[0]);
            }
            connect.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtSurname.Text = dr["Surname"].ToString();
                txtTel1.Text = dr["TelNo"].ToString();
                txtTel2.Text = dr["TelNo2"].ToString();
                txtTcNo.Text = dr["TCNo"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                cmbProvince.Text = dr["Province"].ToString();
                cmbDistrict.Text = dr["District"].ToString();
                txtAdress.Text = dr["Address"].ToString();
                txtTaxOffice.Text = dr["TaxOffice"].ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            customerDel();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            customerUpdate();
        }


        /// <summary>
        /// Adds a new customer to the database.
        /// </summary>
        void customerList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Customer", connect.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        /// <summary>
        /// Adds a new customer to the database with the details provided in the form fields.
        /// </summary>
        void customerAdd()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Customer (Name, Surname, TelNo, TelNo2, TCNo, Mail, Province, District, Address, TaxOffice) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", txtTel1.Text);
            komut.Parameters.AddWithValue("@p4", txtTel2.Text);
            komut.Parameters.AddWithValue("@p5", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbProvince.Text);
            komut.Parameters.AddWithValue("@p8", cmbDistrict.Text);
            komut.Parameters.AddWithValue("@p9", txtAdress.Text);
            komut.Parameters.AddWithValue("@p10", txtTaxOffice.Text);
            komut.ExecuteNonQuery();
            connect.baglanti().Close();
            MessageBox.Show("Customer added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            customerList(); // Refresh the customer list after adding a new customer
        }

        /// <summary>
        /// Lists the provinces from the database and populates the province combo box.
        /// </summary>
        void provinceList()
        {
            SqlCommand komut = new SqlCommand("Select ProvinceName From Tbl_Province", connect.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbProvince.Properties.Items.Add(dr[0]);
            }
            connect.baglanti().Close();
        }

        /// <summary>
        /// Updates the selected customer's details in the database.
        /// </summary>
        void customerDel()
        {
            int id = int.Parse(txtId.Text);
            SqlCommand komut = new SqlCommand("Delete From Tbl_Customer where Id=@p1", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            connect.baglanti().Close();
            MessageBox.Show("Customer deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            customerList(); // Refresh the customer list after deletion
        }

        /// <summary>
        /// Updates the selected customer's details in the database with the values provided in the form fields.
        /// </summary>
        void customerUpdate()
        {
            int id = int.Parse(txtId.Text);
            SqlCommand komut = new SqlCommand("Update Tbl_Customer set Name=@p1, Surname=@p2, TelNo=@p3, TelNo2=@p4, TCNo=@p5, Mail=@p6, Province=@p7, District=@p8, Address=@p9, TaxOffice=@p10 where Id=@p11", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", txtTel1.Text);
            komut.Parameters.AddWithValue("@p4", txtTel2.Text);
            komut.Parameters.AddWithValue("@p5", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbProvince.Text);
            komut.Parameters.AddWithValue("@p8", cmbDistrict.Text);
            komut.Parameters.AddWithValue("@p9", txtAdress.Text);
            komut.Parameters.AddWithValue("@p10", txtTaxOffice.Text);
            komut.Parameters.AddWithValue("@p11", id);
            komut.ExecuteNonQuery();
            connect.baglanti().Close();
            MessageBox.Show("Customer updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            customerList(); // Refresh the customer list after updating
        }
    }
}
