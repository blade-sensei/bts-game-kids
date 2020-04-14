namespace jeux
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.img2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbreponse = new System.Windows.Forms.TextBox();
            this.btvalider = new System.Windows.Forms.Button();
            this.btsuivant = new System.Windows.Forms.Button();
            this.bt_accueuil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // img2
            // 
            this.img2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img2.ImageStream")));
            this.img2.TransparentColor = System.Drawing.Color.Transparent;
            this.img2.Images.SetKeyName(0, "Capture d’écran 2015-02-13 à 10.14.32.png");
            this.img2.Images.SetKeyName(1, "Capture d’écran 2015-02-13 à 10.14.41.png");
            this.img2.Images.SetKeyName(2, "Capture d’écran 2015-02-13 à 10.14.55.png");
            this.img2.Images.SetKeyName(3, "Capture d’écran 2015-02-13 à 10.15.01.png");
            this.img2.Images.SetKeyName(4, "Capture d’écran 2015-02-13 à 10.15.09.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(274, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(206, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "label1";
            // 
            // tbreponse
            // 
            this.tbreponse.Location = new System.Drawing.Point(274, 142);
            this.tbreponse.Name = "tbreponse";
            this.tbreponse.Size = new System.Drawing.Size(100, 20);
            this.tbreponse.TabIndex = 46;
            // 
            // btvalider
            // 
            this.btvalider.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btvalider.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvalider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btvalider.Location = new System.Drawing.Point(287, 185);
            this.btvalider.Name = "btvalider";
            this.btvalider.Size = new System.Drawing.Size(87, 32);
            this.btvalider.TabIndex = 47;
            this.btvalider.Text = "Valider";
            this.btvalider.UseVisualStyleBackColor = false;
            this.btvalider.Click += new System.EventHandler(this.btvalider_Click);
            // 
            // btsuivant
            // 
            this.btsuivant.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btsuivant.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsuivant.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btsuivant.Location = new System.Drawing.Point(287, 240);
            this.btsuivant.Name = "btsuivant";
            this.btsuivant.Size = new System.Drawing.Size(87, 39);
            this.btsuivant.TabIndex = 48;
            this.btsuivant.Text = "Suivant";
            this.btsuivant.UseVisualStyleBackColor = false;
            this.btsuivant.Visible = false;
            this.btsuivant.Click += new System.EventHandler(this.btsuivant_Click);
            // 
            // bt_accueuil
            // 
            this.bt_accueuil.Location = new System.Drawing.Point(12, 321);
            this.bt_accueuil.Name = "bt_accueuil";
            this.bt_accueuil.Size = new System.Drawing.Size(110, 27);
            this.bt_accueuil.TabIndex = 49;
            this.bt_accueuil.Text = "Retour à l\'accueuil";
            this.bt_accueuil.UseVisualStyleBackColor = true;
            this.bt_accueuil.Click += new System.EventHandler(this.bt_accueuil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 360);
            this.Controls.Add(this.bt_accueuil);
            this.Controls.Add(this.btsuivant);
            this.Controls.Add(this.btvalider);
            this.Controls.Add(this.tbreponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList img2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbreponse;
        private System.Windows.Forms.Button btvalider;
        private System.Windows.Forms.Button btsuivant;
        private System.Windows.Forms.Button bt_accueuil;
    }
}