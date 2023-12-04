namespace SportStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMuki_Click(object sender, EventArgs e)
        {
            if (buttonMuki.Width == 494)
            {
                buttonMuki.Size = new Size(40, 30);
                buttonMuki.Text = "<-";
                panelMuki.Scale(1000, 500);
                // panelMuki.Size = new Size(1000, 500);
                panelMuki.BringToFront();
            }
            else
            {
                buttonMuki.Size = new Size(494, 244);
                panelMuki.Size = new Size(500, 250);
                buttonMuki.Text = "Mukibude";
            }
        }

        private void buttonSauna_Click(object sender, EventArgs e)
        {

        }
    }
}