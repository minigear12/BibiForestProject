using AutoMapper.Execution;
using BibiBusiness.DTO;
using BibiBusiness.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibiForm
{
    public partial class frmBibiDetails : Form
    {

        private IOwnerRepository OwnerRepository = new OwnerRepository();
        private IBibiRepository BibiRepository = new BibiRepository();
        public IBibiRepository bibiRepository { get; set; }
        public Bibi bibiInfo { get; set; }
        public Owner OwnerInfo { get; set; }
        public frmBibiDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBibiID.Text) ||
               string.IsNullOrEmpty(txtPassword.Text) ||
               string.IsNullOrEmpty(txtBibiName.Text) ||
               string.IsNullOrEmpty(txtFood.Text) ||
               string.IsNullOrEmpty(txtCountry.Text) ||
               string.IsNullOrEmpty(txtForest.Text)
               || string.IsNullOrEmpty(cbOwnerName.Text))
            {
                MessageBox.Show("Fill all bibi fields !!!");
                return;

            }


            var ownerStr = cbOwnerName.SelectedItem.ToString();

            var arrOwner = ownerStr.Split("-");
            var OwnerID = arrOwner[0];
            var OwnerName = arrOwner[1];

            Owner owner = new Owner();
            owner.OwnerId = OwnerID;
            owner.OwnerName = OwnerName;

            var bibi = new Bibi();
            bibi.BibiId = int.Parse(txtBibiID.Text);
            bibi.BibiName = txtBibiName.Text;
            bibi.Password = txtPassword.Text;
            bibi.OwnerId = OwnerID;
            bibi.Food = txtFood.Text;
            bibi.Country = txtCountry.Text;
            bibi.Forest = txtForest.Text;
            BibiRepository.create(bibi);
            MessageBox.Show("New Bibi made !!! <3");

        }

        private void newBibi_Load(object sender, EventArgs e)
        {



            var owner = OwnerRepository.GetAll();

            owner.ForEach(member =>
            {
                cbOwnerName.Items.Add(member.OwnerId + "-" + member.OwnerName);
            });





        }

        
    }
}
