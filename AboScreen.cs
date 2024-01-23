using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportStudio
{
    public partial class AboScreen : Form
    {
        public AboScreen()
        {
            InitializeComponent();
        }

        int gesamtpreis = 0;

        private void checkedAll()
        {
            if (checkBoxMuki.Checked && checkBoxCardio.Checked && checkBoxSauna.Checked && checkBoxWasser.Checked)
            {
                gesamtPreis.Text = "30";
            }
        }

        private void checkBoxMuki_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMuki.Checked)
            {
                gesamtpreis += 10;
            }
            else
            {
                gesamtpreis -= 10;
            }
            gesamtPreis.Text = gesamtpreis.ToString();
            checkedAll();
        }

        private void checkBoxSauna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSauna.Checked)
            {
                gesamtpreis += 5;
            }
            else
            {
                gesamtpreis -= 5;
            }
            gesamtPreis.Text = gesamtpreis.ToString();
            checkedAll();
        }

        private void checkBoxCardio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCardio.Checked)
            {
                gesamtpreis += 8;
            }
            else
            {
                gesamtpreis -= 8;
            }
            gesamtPreis.Text = gesamtpreis.ToString();
            checkedAll();
        }

        private void checkBoxWasser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWasser.Checked)
            {
                gesamtpreis += 12;
            }
            else
            {
                gesamtpreis -= 12;
            }
            gesamtPreis.Text = gesamtpreis.ToString();
            checkedAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBoxMuki.Checked = true;
            checkBoxCardio.Checked = true;
            checkBoxSauna.Checked = true;
            checkBoxWasser.Checked = true;

            gesamtPreis.Text = "30";
        }
    }
}
