namespace BibiForm
{
    partial class frmBibiDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            label7 = new Label();
            cbOwnerName = new ComboBox();
            txtPassword = new TextBox();
            txtBibiName = new TextBox();
            txtFood = new TextBox();
            txtCountry = new TextBox();
            txtForest = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 76);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Bibi ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 177);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Bibi Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 125);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 232);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Food";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 288);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 345);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = "Forest";
            // 
            // txtBibiID
            // 
            txtBibiID.Location = new Point(133, 76);
            txtBibiID.Name = "txtBibiID";
            txtBibiID.Size = new Size(278, 27);
            txtBibiID.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 24);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 7;
            label7.Text = "Owner Name";
            // 
            // cbOwnerName
            // 
            cbOwnerName.FormattingEnabled = true;
            cbOwnerName.Location = new Point(135, 21);
            cbOwnerName.Name = "cbOwnerName";
            cbOwnerName.Size = new Size(276, 28);
            cbOwnerName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(135, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(276, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtBibiName
            // 
            txtBibiName.Location = new Point(135, 177);
            txtBibiName.Name = "txtBibiName";
            txtBibiName.Size = new Size(276, 27);
            txtBibiName.TabIndex = 10;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(133, 234);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(278, 27);
            txtFood.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(133, 285);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(278, 27);
            txtCountry.TabIndex = 12;
            // 
            // txtForest
            // 
            txtForest.Location = new Point(133, 342);
            txtForest.Name = "txtForest";
            txtForest.Size = new Size(278, 27);
            txtForest.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(160, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "&Make new Bibi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmBibiDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(btnSave);
            Controls.Add(txtForest);
            Controls.Add(txtCountry);
            Controls.Add(txtFood);
            Controls.Add(txtBibiName);
            Controls.Add(txtPassword);
            Controls.Add(cbOwnerName);
            Controls.Add(label7);
            Controls.Add(txtBibiID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBibiDetails";
            Text = "frmBibiDetails";
            Load += newBibi_Load;
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
        private Label label7;
        private ComboBox cbOwnerName;
        private TextBox txtPassword;
        private TextBox txtBibiName;
        private TextBox txtFood;
        private TextBox txtCountry;
        private TextBox txtForest;
        private Button btnSave;
    }
}