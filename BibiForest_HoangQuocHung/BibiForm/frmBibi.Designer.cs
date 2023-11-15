namespace BibiForm
{
    partial class frmBibi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBibiID = new TextBox();
            txtPassword = new TextBox();
            txtBibiName = new TextBox();
            txtFood = new TextBox();
            txtCountry = new TextBox();
            txtForest = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtOwnerID = new TextBox();
            txtOwnerName = new TextBox();
            dgvBibi = new DataGridView();
            btnCreate = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBibi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Bibi ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 147);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Bibi Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 195);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Food";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 238);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 284);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = "Forest";
            // 
            // txtBibiID
            // 
            txtBibiID.Location = new Point(144, 49);
            txtBibiID.Name = "txtBibiID";
            txtBibiID.ReadOnly = true;
            txtBibiID.Size = new Size(178, 27);
            txtBibiID.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(144, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(178, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtBibiName
            // 
            txtBibiName.Location = new Point(144, 144);
            txtBibiName.Name = "txtBibiName";
            txtBibiName.ReadOnly = true;
            txtBibiName.Size = new Size(178, 27);
            txtBibiName.TabIndex = 8;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(144, 198);
            txtFood.Name = "txtFood";
            txtFood.ReadOnly = true;
            txtFood.Size = new Size(178, 27);
            txtFood.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(144, 238);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(178, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtForest
            // 
            txtForest.Location = new Point(144, 284);
            txtForest.Name = "txtForest";
            txtForest.ReadOnly = true;
            txtForest.Size = new Size(178, 27);
            txtForest.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 49);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 12;
            label7.Text = "Owner ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 101);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 13;
            label8.Text = "Owner Name";
            // 
            // txtOwnerID
            // 
            txtOwnerID.Location = new Point(482, 49);
            txtOwnerID.Name = "txtOwnerID";
            txtOwnerID.ReadOnly = true;
            txtOwnerID.Size = new Size(228, 27);
            txtOwnerID.TabIndex = 14;
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(482, 100);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.ReadOnly = true;
            txtOwnerName.Size = new Size(226, 27);
            txtOwnerName.TabIndex = 16;
            // 
            // dgvBibi
            // 
            dgvBibi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBibi.Location = new Point(15, 317);
            dgvBibi.Name = "dgvBibi";
            dgvBibi.RowHeadersWidth = 51;
            dgvBibi.RowTemplate.Height = 29;
            dgvBibi.Size = new Size(773, 121);
            dgvBibi.TabIndex = 17;
            dgvBibi.CellDoubleClick += dgvBibi_CellDoubleClick;
            dgvBibi.CellEndEdit += dgvBibi_CellEndEdit;
            dgvBibi.SelectionChanged += dgvBibi_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(349, 258);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(463, 258);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(576, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 40);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(694, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmBibi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnCreate);
            Controls.Add(dgvBibi);
            Controls.Add(txtOwnerName);
            Controls.Add(txtOwnerID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtForest);
            Controls.Add(txtCountry);
            Controls.Add(txtFood);
            Controls.Add(txtBibiName);
            Controls.Add(txtPassword);
            Controls.Add(txtBibiID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBibi";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBibi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBibiID;
        private TextBox txtPassword;
        private TextBox txtBibiName;
        private TextBox txtFood;
        private TextBox txtCountry;
        private TextBox txtForest;
        private Label label7;
        private Label label8;
        private TextBox txtOwnerID;
        private TextBox txtOwnerName;
        private DataGridView dgvBibi;
        private Button btnCreate;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnUpdate;
    }
}