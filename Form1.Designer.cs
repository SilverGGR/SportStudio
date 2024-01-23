namespace SportStudio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkHome = new Label();
            linkAbo = new Label();
            linkAnmeldung = new Label();
            panelMuki = new Panel();
            buttonMuki = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            buttonSauna = new Button();
            panelSauna = new Panel();
            buttonCardio = new Button();
            panelCardio = new Panel();
            buttonWasser = new Button();
            panelWasser = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMuki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSauna.SuspendLayout();
            panelCardio.SuspendLayout();
            panelWasser.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(217, 46, 24);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1065, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 46, 24);
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(368, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 42);
            label1.TabIndex = 1;
            label1.Text = "Sport und so";
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.BackColor = Color.FromArgb(217, 46, 24);
            linkHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkHome.Location = new Point(793, 28);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(68, 25);
            linkHome.TabIndex = 2;
            linkHome.Text = "Home";
            // 
            // linkAbo
            // 
            linkAbo.AutoSize = true;
            linkAbo.BackColor = Color.FromArgb(217, 46, 24);
            linkAbo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkAbo.Location = new Point(867, 28);
            linkAbo.Name = "linkAbo";
            linkAbo.Size = new Size(51, 25);
            linkAbo.TabIndex = 3;
            linkAbo.Text = "Abo";
            linkAbo.Click += linkAbo_Click;
            // 
            // linkAnmeldung
            // 
            linkAnmeldung.AutoSize = true;
            linkAnmeldung.BackColor = Color.FromArgb(217, 46, 24);
            linkAnmeldung.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkAnmeldung.Location = new Point(924, 28);
            linkAnmeldung.Name = "linkAnmeldung";
            linkAnmeldung.Size = new Size(121, 25);
            linkAnmeldung.TabIndex = 4;
            linkAnmeldung.Text = "Anmeldung";
            // 
            // panelMuki
            // 
            panelMuki.BackColor = Color.FromArgb(255, 192, 192);
            panelMuki.Controls.Add(buttonMuki);
            panelMuki.Controls.Add(pictureBox2);
            panelMuki.Controls.Add(label4);
            panelMuki.Controls.Add(label3);
            panelMuki.Location = new Point(26, 93);
            panelMuki.Name = "panelMuki";
            panelMuki.Size = new Size(500, 250);
            panelMuki.TabIndex = 6;
            // 
            // buttonMuki
            // 
            buttonMuki.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMuki.Image = (Image)resources.GetObject("buttonMuki.Image");
            buttonMuki.Location = new Point(3, 3);
            buttonMuki.Name = "buttonMuki";
            buttonMuki.Size = new Size(494, 244);
            buttonMuki.TabIndex = 7;
            buttonMuki.Text = "Mukibude";
            buttonMuki.UseVisualStyleBackColor = true;
            buttonMuki.Click += buttonMuki_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(276, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 244);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 4.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 40);
            label4.Name = "label4";
            label4.Size = new Size(268, 242);
            label4.TabIndex = 9;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 14);
            label3.Name = "label3";
            label3.Size = new Size(127, 29);
            label3.TabIndex = 8;
            label3.Text = "Mukibude";
            // 
            // buttonSauna
            // 
            buttonSauna.BackColor = Color.Transparent;
            buttonSauna.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSauna.Image = (Image)resources.GetObject("buttonSauna.Image");
            buttonSauna.Location = new Point(3, 3);
            buttonSauna.Name = "buttonSauna";
            buttonSauna.Size = new Size(494, 244);
            buttonSauna.TabIndex = 7;
            buttonSauna.Text = "Sauna";
            buttonSauna.UseVisualStyleBackColor = false;
            buttonSauna.Click += buttonSauna_Click;
            // 
            // panelSauna
            // 
            panelSauna.BackColor = Color.FromArgb(255, 192, 192);
            panelSauna.Controls.Add(buttonSauna);
            panelSauna.Location = new Point(543, 93);
            panelSauna.Name = "panelSauna";
            panelSauna.Size = new Size(500, 250);
            panelSauna.TabIndex = 8;
            // 
            // buttonCardio
            // 
            buttonCardio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCardio.Image = (Image)resources.GetObject("buttonCardio.Image");
            buttonCardio.Location = new Point(3, 3);
            buttonCardio.Name = "buttonCardio";
            buttonCardio.Size = new Size(494, 244);
            buttonCardio.TabIndex = 7;
            buttonCardio.Text = "Cardio";
            buttonCardio.UseVisualStyleBackColor = true;
            buttonCardio.Click += buttonCardio_Click;
            // 
            // panelCardio
            // 
            panelCardio.BackColor = SystemColors.ActiveCaption;
            panelCardio.Controls.Add(buttonCardio);
            panelCardio.Location = new Point(26, 352);
            panelCardio.Name = "panelCardio";
            panelCardio.Size = new Size(500, 250);
            panelCardio.TabIndex = 8;
            // 
            // buttonWasser
            // 
            buttonWasser.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWasser.Image = (Image)resources.GetObject("buttonWasser.Image");
            buttonWasser.Location = new Point(3, 3);
            buttonWasser.Name = "buttonWasser";
            buttonWasser.Size = new Size(494, 244);
            buttonWasser.TabIndex = 7;
            buttonWasser.Text = "Wasser";
            buttonWasser.UseVisualStyleBackColor = true;
            buttonWasser.Click += buttonWasser_Click;
            // 
            // panelWasser
            // 
            panelWasser.BackColor = SystemColors.ActiveBorder;
            panelWasser.Controls.Add(buttonWasser);
            panelWasser.Location = new Point(543, 352);
            panelWasser.Name = "panelWasser";
            panelWasser.Size = new Size(500, 250);
            panelWasser.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 633);
            Controls.Add(panelWasser);
            Controls.Add(panelCardio);
            Controls.Add(panelSauna);
            Controls.Add(panelMuki);
            Controls.Add(linkAbo);
            Controls.Add(label1);
            Controls.Add(linkHome);
            Controls.Add(linkAnmeldung);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMuki.ResumeLayout(false);
            panelMuki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelSauna.ResumeLayout(false);
            panelCardio.ResumeLayout(false);
            panelWasser.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label linkHome;
        private Label linkAbo;
        private Label linkAnmeldung;
        private Panel panelMuki;
        private Button buttonMuki;
        private Button buttonSauna;
        private Panel panelSauna;
        private Button buttonCardio;
        private Panel panelCardio;
        private Button buttonWasser;
        private Panel panelWasser;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
    }
}