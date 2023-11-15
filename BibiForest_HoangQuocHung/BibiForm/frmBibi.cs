using BibiBusiness.Models;
using AutoMapper;
using BibiBusiness.DTO;
using BibiBusiness.Mapper;
using DataAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;
using AutoMapper.Execution;

namespace BibiForm
{
    public partial class frmBibi : Form
    {
        IBibiRepository bibiRepository = new BibiRepository();
        IOwnerRepository ownerRepository = new OwnerRepository();
        public Bibi bibi { get; set; }
        public Owner owner { get; set; }

        BindingSource bibiSource;


        public frmBibi()
        {
            InitializeComponent();
        }




        private void loadBibi(List<Bibi> bibi)
        {
            bibiSource = new BindingSource();
            if (bibi != null && bibi.Count == 0)
            {
                dgvBibi.DataSource = null;
                return;
            }

            bibi = bibi == null ? bibiRepository.findAll() : bibi;
            var config = new MapperConfiguration(cfg =>
            {
                BibiConfig.createMap(cfg);
            });

            var mapperAirCon = config.CreateMapper();

            var bibiDTOs = bibi.Select(
                bibi => mapperAirCon
                .Map<Bibi, BibiDTO>(bibi)
                );




            bibiSource.DataSource = bibiDTOs;

            txtBibiID.DataBindings.Clear();
            txtBibiName.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtFood.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtForest.DataBindings.Clear();
            //txtOwnerID.DataBindings.Clear();
            //txtOwnerName.DataBindings.Clear();




            txtBibiID.DataBindings.Add("Text", bibiSource, "BibiID");
            txtPassword.DataBindings.Add("Text", bibiSource, "Password");
            txtBibiName.DataBindings.Add("Text", bibiSource, "BibiName");
            txtFood.DataBindings.Add("Text", bibiSource, "Food");
            txtCountry.DataBindings.Add("Text", bibiSource, "Country");
            txtForest.DataBindings.Add("Text", bibiSource, "Forest");
            //txtOwnerID.DataBindings.Add("Text", bibiSource, "OwnerID");
            //txtOwnerName.DataBindings.Add("Text", bibiSource, "OwnerName");

            dgvBibi.DataSource = null;
            dgvBibi.DataSource = bibiSource;
            dgvBibi.Update();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmBibiDetails frmBibiDetails = new frmBibiDetails
            {
                bibiRepository = this.bibiRepository,


            };

            if (frmBibiDetails.ShowDialog() == DialogResult.OK)
            {
                loadBibi(null);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadBibi(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bibiRepository.delete(int.Parse(txtBibiID.Text));
            loadBibi(null);
        }

        private void dgvBibi_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txtBibiName.Text);
            Bibi bibi = bibiRepository.findById(int.Parse(txtBibiID.Text));
            var Owner = bibiRepository.findOwnerByBibi(bibi.OwnerId);

            txtOwnerID.Text = Owner.OwnerId;
            txtOwnerName.Text = Owner.OwnerName;
        }

        private void dgvBibi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBibiID.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtBibiName.ReadOnly = false;
            txtFood.ReadOnly = false;
            txtCountry.ReadOnly = false;
            txtForest.ReadOnly = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            using (BibiForestContext BibiForestContext = new BibiForestContext())
            {
                Bibi bibi = new Bibi();
                 if (bibi.BibiId == 0)
                {
                    BibiForestContext.Bibis.Add(bibi);
                }
                else
                {
                    bibiRepository.update(bibi);
                    loadBibi(null);
                }
                txtBibiID.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtBibiName.ReadOnly = true;
                txtFood.ReadOnly = true;
                txtCountry.ReadOnly = true;
                txtForest.ReadOnly = true;
            }
        }

        private void dgvBibi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}