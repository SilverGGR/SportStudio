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
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
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
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(932, 46);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 46, 24);
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 7);
            label1.Name = "label1";
            label1.Size = new Size(198, 36);
            label1.TabIndex = 1;
            label1.Text = "Sport und so";
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.BackColor = Color.FromArgb(217, 46, 24);
            linkHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkHome.Location = new Point(694, 21);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(56, 20);
            linkHome.TabIndex = 2;
            linkHome.Text = "Home";
            // 
            // linkAbo
            // 
            linkAbo.AutoSize = true;
            linkAbo.BackColor = Color.FromArgb(217, 46, 24);
            linkAbo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkAbo.Location = new Point(759, 21);
            linkAbo.Name = "linkAbo";
            linkAbo.Size = new Size(41, 20);
            linkAbo.TabIndex = 3;
            linkAbo.Text = "Abo";
            linkAbo.Click += linkAbo_Click;
            // 
            // linkAnmeldung
            // 
            linkAnmeldung.AutoSize = true;
            linkAnmeldung.BackColor = Color.FromArgb(217, 46, 24);
            linkAnmeldung.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkAnmeldung.Location = new Point(808, 21);
            linkAnmeldung.Name = "linkAnmeldung";
            linkAnmeldung.Size = new Size(99, 20);
            linkAnmeldung.TabIndex = 4;
            linkAnmeldung.Text = "Anmeldung";
            // 
            // panelMuki
            // 
            panelMuki.Controls.Add(buttonMuki);
            panelMuki.Controls.Add(label4);
            panelMuki.Controls.Add(label3);
            panelMuki.Controls.Add(pictureBox2);
            panelMuki.Location = new Point(23, 70);
            panelMuki.Margin = new Padding(3, 2, 3, 2);
            panelMuki.Name = "panelMuki";
            panelMuki.Size = new Size(438, 188);
            panelMuki.TabIndex = 6;
            // 
            // buttonMuki
            // 
            buttonMuki.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonMuki.BackgroundImage = Properties.Resources.mukiBild1;
            buttonMuki.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMuki.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMuki.Location = new Point(3, 3);
            buttonMuki.Margin = new Padding(3, 2, 3, 2);
            buttonMuki.Name = "buttonMuki";
            buttonMuki.Size = new Size(432, 183);
            buttonMuki.TabIndex = 7;
            buttonMuki.Text = "Mukibude";
            buttonMuki.UseVisualStyleBackColor = true;
            buttonMuki.Click += buttonMuki_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 4.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 30);
            label4.Name = "label4";
            label4.Size = new Size(200, 176);
            label4.TabIndex = 9;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 10);
            label3.Name = "label3";
            label3.Size = new Size(102, 24);
            label3.TabIndex = 8;
            label3.Text = "Mukibude";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(432, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // buttonSauna
            // 
            buttonSauna.BackColor = Color.Transparent;
            buttonSauna.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSauna.Image = (Image)resources.GetObject("buttonSauna.Image");
            buttonSauna.Location = new Point(3, 2);
            buttonSauna.Margin = new Padding(3, 2, 3, 2);
            buttonSauna.Name = "buttonSauna";
            buttonSauna.Size = new Size(432, 183);
            buttonSauna.TabIndex = 7;
            buttonSauna.Text = "Sauna";
            buttonSauna.UseVisualStyleBackColor = false;
            buttonSauna.Click += buttonSauna_Click;
            // 
            // panelSauna
            // 
            panelSauna.BackColor = Color.FromArgb(255, 192, 192);
            panelSauna.Controls.Add(buttonSauna);
            panelSauna.Location = new Point(475, 70);
            panelSauna.Margin = new Padding(3, 2, 3, 2);
            panelSauna.Name = "panelSauna";
            panelSauna.Size = new Size(438, 188);
            panelSauna.TabIndex = 8;
            // 
            // buttonCardio
            // 
            buttonCardio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCardio.Image = (Image)resources.GetObject("buttonCardio.Image");
            buttonCardio.Location = new Point(3, 2);
            buttonCardio.Margin = new Padding(3, 2, 3, 2);
            buttonCardio.Name = "buttonCardio";
            buttonCardio.Size = new Size(432, 183);
            buttonCardio.TabIndex = 7;
            buttonCardio.Text = "Cardio";
            buttonCardio.UseVisualStyleBackColor = true;
            buttonCardio.Click += buttonCardio_Click;
            // 
            // panelCardio
            // 
            panelCardio.BackColor = SystemColors.ActiveCaption;
            panelCardio.Controls.Add(buttonCardio);
            panelCardio.Location = new Point(23, 264);
            panelCardio.Margin = new Padding(3, 2, 3, 2);
            panelCardio.Name = "panelCardio";
            panelCardio.Size = new Size(438, 188);
            panelCardio.TabIndex = 8;
            // 
            // buttonWasser
            // 
            buttonWasser.BackgroundImage = Properties.Resources.wasserBild;
            buttonWasser.BackgroundImageLayout = ImageLayout.Zoom;
            buttonWasser.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWasser.Location = new Point(3, 2);
            buttonWasser.Margin = new Padding(3, 2, 3, 2);
            buttonWasser.Name = "buttonWasser";
            buttonWasser.Size = new Size(432, 183);
            buttonWasser.TabIndex = 7;
            buttonWasser.Text = "Wasser";
            buttonWasser.UseVisualStyleBackColor = true;
            buttonWasser.Click += buttonWasser_Click;
            // 
            // panelWasser
            // 
            panelWasser.BackColor = SystemColors.ActiveBorder;
            panelWasser.Controls.Add(buttonWasser);
            panelWasser.Location = new Point(475, 264);
            panelWasser.Margin = new Padding(3, 2, 3, 2);
            panelWasser.Name = "panelWasser";
            panelWasser.Size = new Size(438, 188);
            panelWasser.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 475);
            Controls.Add(panelWasser);
            Controls.Add(panelCardio);
            Controls.Add(panelSauna);
            Controls.Add(panelMuki);
            Controls.Add(linkAbo);
            Controls.Add(label1);
            Controls.Add(linkHome);
            Controls.Add(linkAnmeldung);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
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