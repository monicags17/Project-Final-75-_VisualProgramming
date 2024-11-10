namespace BeautyTrack
{
    partial class InputProdukAdmin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxNamaProduk = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxKandunganManfaat = new System.Windows.Forms.TextBox();
            this.comboBoxJenisKulit = new System.Windows.Forms.ComboBox();
            this.comboBoxJenisSkincare = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelChoosePhoto = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautyTrack.Properties.Resources.input_nama_produk;
            this.pictureBox1.Location = new System.Drawing.Point(43, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxNamaProduk
            // 
            this.textBoxNamaProduk.Location = new System.Drawing.Point(356, 152);
            this.textBoxNamaProduk.Name = "textBoxNamaProduk";
            this.textBoxNamaProduk.Size = new System.Drawing.Size(276, 22);
            this.textBoxNamaProduk.TabIndex = 1;
            this.textBoxNamaProduk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(356, 214);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(276, 22);
            this.textBoxHarga.TabIndex = 2;
            // 
            // textBoxKandunganManfaat
            // 
            this.textBoxKandunganManfaat.Location = new System.Drawing.Point(356, 396);
            this.textBoxKandunganManfaat.Name = "textBoxKandunganManfaat";
            this.textBoxKandunganManfaat.Size = new System.Drawing.Size(276, 22);
            this.textBoxKandunganManfaat.TabIndex = 5;
            this.textBoxKandunganManfaat.TextChanged += new System.EventHandler(this.textBoxKandunganManfaat_TextChanged);
            // 
            // comboBoxJenisKulit
            // 
            this.comboBoxJenisKulit.FormattingEnabled = true;
            this.comboBoxJenisKulit.Items.AddRange(new object[] {
            "Normal Skin",
            "Oily Skin",
            "Dry Skin",
            "Combination Skin",
            "Sensitive Skin"});
            this.comboBoxJenisKulit.Location = new System.Drawing.Point(356, 275);
            this.comboBoxJenisKulit.Name = "comboBoxJenisKulit";
            this.comboBoxJenisKulit.Size = new System.Drawing.Size(201, 24);
            this.comboBoxJenisKulit.TabIndex = 6;
            // 
            // comboBoxJenisSkincare
            // 
            this.comboBoxJenisSkincare.FormattingEnabled = true;
            this.comboBoxJenisSkincare.Items.AddRange(new object[] {
            "Face Wash",
            "Moisturizer",
            "Sunscreen",
            "Serum",
            "Face Mask"});
            this.comboBoxJenisSkincare.Location = new System.Drawing.Point(356, 334);
            this.comboBoxJenisSkincare.Name = "comboBoxJenisSkincare";
            this.comboBoxJenisSkincare.Size = new System.Drawing.Size(201, 24);
            this.comboBoxJenisSkincare.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(43, 499);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(166, 499);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(286, 499);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(404, 499);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(534, 499);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 12;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(825, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 313);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelChoosePhoto
            // 
            this.labelChoosePhoto.AutoSize = true;
            this.labelChoosePhoto.Location = new System.Drawing.Point(899, 248);
            this.labelChoosePhoto.Name = "labelChoosePhoto";
            this.labelChoosePhoto.Size = new System.Drawing.Size(92, 16);
            this.labelChoosePhoto.TabIndex = 14;
            this.labelChoosePhoto.Text = "Choose Photo";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(660, 499);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 574);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 322);
            this.dataGridView1.TabIndex = 16;
            // 
            // InputProdukAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeautyTrack.Properties.Resources.ext;
            this.ClientSize = new System.Drawing.Size(1117, 914);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelChoosePhoto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxJenisSkincare);
            this.Controls.Add(this.comboBoxJenisKulit);
            this.Controls.Add(this.textBoxKandunganManfaat);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaProduk);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InputProdukAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.InputProdukAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxNamaProduk;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxKandunganManfaat;
        private System.Windows.Forms.ComboBox comboBoxJenisKulit;
        private System.Windows.Forms.ComboBox comboBoxJenisSkincare;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelChoosePhoto;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}