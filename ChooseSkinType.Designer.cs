namespace BeautyTrack
{
    partial class ChooseSkinType
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
            this.buttonSkinType = new System.Windows.Forms.Button();
            this.comboBoxSkinType = new System.Windows.Forms.ComboBox();
            this.labelChooseSkinType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSkinType
            // 
            this.buttonSkinType.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonSkinType.Location = new System.Drawing.Point(1038, 445);
            this.buttonSkinType.Name = "buttonSkinType";
            this.buttonSkinType.Size = new System.Drawing.Size(61, 24);
            this.buttonSkinType.TabIndex = 1;
            this.buttonSkinType.Text = "Next";
            this.buttonSkinType.UseVisualStyleBackColor = false;
            this.buttonSkinType.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSkinType
            // 
            this.comboBoxSkinType.FormattingEnabled = true;
            this.comboBoxSkinType.Items.AddRange(new object[] {
            "Normal Skin",
            "Dry Skin",
            "Oily Skin",
            "Sensitive Skin",
            "Combination Skin"});
            this.comboBoxSkinType.Location = new System.Drawing.Point(853, 445);
            this.comboBoxSkinType.Name = "comboBoxSkinType";
            this.comboBoxSkinType.Size = new System.Drawing.Size(163, 24);
            this.comboBoxSkinType.TabIndex = 2;
            // 
            // labelChooseSkinType
            // 
            this.labelChooseSkinType.AutoSize = true;
            this.labelChooseSkinType.BackColor = System.Drawing.Color.White;
            this.labelChooseSkinType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelChooseSkinType.ForeColor = System.Drawing.Color.Black;
            this.labelChooseSkinType.Location = new System.Drawing.Point(690, 448);
            this.labelChooseSkinType.Name = "labelChooseSkinType";
            this.labelChooseSkinType.Size = new System.Drawing.Size(141, 18);
            this.labelChooseSkinType.TabIndex = 3;
            this.labelChooseSkinType.Text = "Choose your skin type";
            this.labelChooseSkinType.Click += new System.EventHandler(this.labelChooseSkinType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BeautyTrack.Properties.Resources._4__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1534, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChooseSkinType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 700);
            this.Controls.Add(this.labelChooseSkinType);
            this.Controls.Add(this.comboBoxSkinType);
            this.Controls.Add(this.buttonSkinType);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChooseSkinType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseSkinType";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSkinType;
        private System.Windows.Forms.ComboBox comboBoxSkinType;
        private System.Windows.Forms.Label labelChooseSkinType;
    }
}