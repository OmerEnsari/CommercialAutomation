using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationLayer
{
    public partial class Form1 : Form
    {
        DbUrunlerContext context = new DbUrunlerContext();
        public Form1()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await ListTask();
            await ProvinceList();
        }

        // this event handler is triggered when the focused row in the grid view changes
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRow() is TblCompany selectedCompany)
                {
                    txtId.Text = selectedCompany.Id.ToString();
                    txtCompanyName.Text = selectedCompany.Name;
                    txtAuthorizedStatus.Text = selectedCompany.AuthorizedStatus;
                    txtAuthorizedName.Text = selectedCompany.AuthorizedNameSurname;
                    maskTel1.Text = selectedCompany.TelNo1;
                    maskTel2.Text = selectedCompany.TelNo2;
                    maskTel3.Text = selectedCompany.TelNo3;
                    txtMail.Text = selectedCompany.Mail;
                    maskFax.Text = selectedCompany.Fax;
                    cmbProvince.Text = selectedCompany.Province;
                    cmbDistrict.Text = selectedCompany.District;
                    richAddress.Text = selectedCompany.Address;
                    richTaxOffice.Text = selectedCompany.TaxOffice;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProvince = cmbProvince.SelectedItem.ToString();
            cmbDistrict.Properties.Items.Clear();
            try
            {
                var districts = context.TblDistricts
                    .Where(d => d.Province.ProvinceName == selectedProvince)
                    .Select(d => d.DistrictName)
                    .ToList();
                foreach (var district in districts)
                {
                    cmbDistrict.Properties.Items.Add(district);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        #region Button Click Events

        private async void btnadd_Click(object sender, EventArgs e)
        {
            await AddTask();
            await ListTask();
        }

        private async void btnupdate_Click(object sender, EventArgs e)
        {
            await UpdateTask();
            await ListTask();
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            await DeleteTask();
            await ListTask();
        }



        #endregion

        #region Methods

        /// <summary>
        /// Lists the companies from the database and binds them to the grid control.
        /// </summary>
        /// <returns></returns>
        public async Task ListTask()
        {
            try
            {
                var company = await context.TblCompanies.ToListAsync();
                gridControl1.DataSource = company;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        /// <summary>
        /// Adds a new company to the database using the values from the input fields. 
        /// </summary>
        /// <returns></returns>
        public async Task AddTask()
        {
            try
            {
                TblCompany company = new TblCompany();
                company.Name = txtCompanyName.Text;
                company.AuthorizedStatus = txtAuthorizedStatus.Text;
                company.AuthorizedNameSurname = txtAuthorizedName.Text;
                company.TelNo1 = maskTel1.Text;
                company.TelNo2 = maskTel2.Text;
                company.TelNo3 = maskTel3.Text;
                company.Mail = txtMail.Text;
                company.Fax = maskFax.Text;
                company.Province = cmbProvince.Text;
                company.District = cmbDistrict.Text;
                company.Address = richAddress.Text;
                company.TaxOffice = richTaxOffice.Text;
                context.TblCompanies.Add(company);
                await context.SaveChangesAsync();
                MessageBox.Show("Firma Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        /// <summary>
        /// Deletes a company from the database based on the ID provided in the input field.
        /// </summary>
        /// <returns></returns>
        public async Task UpdateTask()
        {
            try
            {
                var company = await context.TblCompanies.FindAsync(Convert.ToInt16(txtId.Text));
                if (company != null)
                {
                    company.Name = txtCompanyName.Text;
                    company.AuthorizedStatus = txtAuthorizedStatus.Text;
                    company.AuthorizedNameSurname = txtAuthorizedName.Text;
                    company.TelNo1 = maskTel1.Text;
                    company.TelNo2 = maskTel2.Text;
                    company.TelNo3 = maskTel3.Text;
                    company.Mail = txtMail.Text;
                    company.Fax = maskFax.Text;
                    company.Province = cmbProvince.Text;
                    company.District = cmbDistrict.Text;
                    company.Address = richAddress.Text;
                    company.TaxOffice = richTaxOffice.Text;

                    await context.SaveChangesAsync();
                    MessageBox.Show("Firma Güncellendi");
                }
                else
                {
                    MessageBox.Show("Firma Bulunamadý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        /// <summary>
        /// Deletes a company from the database based on the ID provided in the input field.
        /// </summary>
        /// <returns></returns>
        public async Task DeleteTask()
        {
            try
            {
                var company = await context.TblCompanies.FindAsync(Convert.ToInt16(txtId.Text));
                if (company != null)
                {
                    context.TblCompanies.Remove(company);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Firma Silindi");
                }
                else
                {
                    MessageBox.Show("Firma Bulunamadý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public async Task ProvinceList()
        {
            try
            {
                var provinces = await context.TblProvinces.ToListAsync();
                foreach (var province in provinces)
                {
                    cmbProvince.Properties.Items.Add(province.ProvinceName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        #endregion
    }
}
