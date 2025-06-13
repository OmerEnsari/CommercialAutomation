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
    public partial class FrmFirmalar : Form
    {
        private SqlBaglanti connect = new SqlBaglanti();
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            CompanyList();
            ProvinceList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CompanyAdd();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CompanyUpdate();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CompanyDel();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    txtId.Text = dr["Id"].ToString();
                    txtCompanyName.Text = dr["Name"].ToString();
                    txtAuthorizedStatus.Text = dr["AuthorizedStatus"].ToString();
                    txtAuthorizedName.Text = dr["AuthorizedNameSurname"].ToString();
                    txtTel1.Text = dr["TelNo1"].ToString();
                    txtTel2.Text = dr["TelNo2"].ToString();
                    txtTel3.Text = dr["TelNo3"].ToString();
                    txtMail.Text = dr["Mail"].ToString();
                    txtFax.Text = dr["Fax"].ToString();
                    cmbProvince.Text = dr["Province"].ToString();
                    cmbDistrict.Text = dr["District"].ToString();
                    txtAdress.Text = dr["Address"].ToString();
                    txtTaxOffice.Text = dr["TaxOffice"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred while selecting the company: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select DistrictName From Tbl_District where ProvinceId=@p1",
                    connect.baglanti());
                komut.Parameters.AddWithValue("@p1",
                    cmbProvince.SelectedIndex + 1); // Assuming ProvinceId starts from 1
                SqlDataReader dr = komut.ExecuteReader();
                cmbDistrict.Properties.Items.Clear(); // Clear previous items
                while (dr.Read())
                {
                    cmbDistrict.Properties.Items.Add(dr[0]);
                }

                connect.baglanti().Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred while loading districts: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        /// <summary>
        /// Retrieves the list of companies from the database and binds it to the grid control.
        /// </summary>
        void CompanyList()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Company", connect.baglanti());
                da.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while adding the company: " + e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        /// <summary>
        /// Adds a new company to the database with the provided details from the text boxes and combo boxes.
        /// </summary>
        void CompanyAdd()
        {
            try
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_Company (Name, AuthorizedStatus, AuthorizedNameSurname, TelNo1, TelNo2, TelNo3, Mail, Fax, Province, District, Address, TaxOffice)" +
                                                    " values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12)", connect.baglanti());
                command.Parameters.AddWithValue("@p1", txtCompanyName.Text);
                command.Parameters.AddWithValue("@p2", txtAuthorizedStatus.Text);
                command.Parameters.AddWithValue("@p3", txtAuthorizedName.Text);
                command.Parameters.AddWithValue("@p4", txtTel1.Text);
                command.Parameters.AddWithValue("@p5", txtTel2.Text);
                command.Parameters.AddWithValue("@p6", txtTel3.Text);
                command.Parameters.AddWithValue("@p7", txtMail.Text);
                command.Parameters.AddWithValue("@p8", txtFax.Text);
                command.Parameters.AddWithValue("@p9", cmbProvince.Text);
                command.Parameters.AddWithValue("@p10", cmbDistrict.Text);
                command.Parameters.AddWithValue("@p11", txtAdress.Text);
                command.Parameters.AddWithValue("@p12", txtTaxOffice.Text);
                command.ExecuteNonQuery();
                connect.baglanti().Close();
                MessageBox.Show("Company added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CompanyList();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while adding the company: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        /// <summary>
        /// Deletes the company based on the provided ID from the text box.
        /// </summary>
        void CompanyDel()
        {
            try
            {
                int id = int.Parse(txtId.Text);
                SqlCommand command = new SqlCommand("Delete From Tbl_Company Where Id=@p1", connect.baglanti());
                command.Parameters.AddWithValue("@p1", id);
                command.ExecuteNonQuery();
                connect.baglanti().Close();
                MessageBox.Show("Company deleted successfully.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CompanyList();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while adding the company: " + e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Updates the company information based on the provided ID.
        /// </summary>
        void CompanyUpdate()
        {
            try
            {
                int id = int.Parse(txtId.Text);
                SqlCommand command = new SqlCommand(
                    "Update Tbl_Company Set Name=@p1, AuthorizedStatus=@p2, AuthorizedNameSurname=@p3, TelNo1=@p4, TelNo2=@p5, TelNo3=@p6, Mail=@p7, Fax=@p8, Province=@p9, District=@p10, Address=@p11, TaxOffice=@p12 Where Id=@p13",
                    connect.baglanti());
                command.Parameters.AddWithValue("@p1", txtCompanyName.Text);
                command.Parameters.AddWithValue("@p2", txtAuthorizedStatus.Text);
                command.Parameters.AddWithValue("@p3", txtAuthorizedName.Text);
                command.Parameters.AddWithValue("@p4", txtTel1.Text);
                command.Parameters.AddWithValue("@p5", txtTel2.Text);
                command.Parameters.AddWithValue("@p6", txtTel3.Text);
                command.Parameters.AddWithValue("@p7", txtMail.Text);
                command.Parameters.AddWithValue("@p8", txtFax.Text);
                command.Parameters.AddWithValue("@p9", cmbProvince.Text);
                command.Parameters.AddWithValue("@p10", cmbDistrict.Text);
                command.Parameters.AddWithValue("@p11", txtAdress.Text);
                command.Parameters.AddWithValue("@p12", txtTaxOffice.Text);
                command.Parameters.AddWithValue("@p13", id);
                command.ExecuteNonQuery();
                connect.baglanti().Close();
                MessageBox.Show("Company updated successfully.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                CompanyList();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while updating the company: " + e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the list of provinces from the database and populates the province combo box.
        /// </summary>
        void ProvinceList()
        {
            SqlCommand komut = new SqlCommand("Select ProvinceName From Tbl_Province", connect.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbProvince.Properties.Items.Add(dr[0]);
            }
            connect.baglanti().Close();
        }

    }
}
