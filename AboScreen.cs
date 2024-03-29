﻿using System;
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
        private Form1 f1;
        Membership tempMembership;
        public AboScreen(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;

            tempMembership = f1.ActiveUser.UserMembership;
            if (tempMembership.MukiAbo == true)
            {
                checkBoxMuki.Checked = true;
            }
            if (tempMembership.CardioAbo == true)
            {
                checkBoxCardio.Checked = true;
            }
            if (tempMembership.WasserAbo == true)
            {
                checkBoxWasser.Checked = true;
            }
            if (tempMembership.WellnessAbo == true)
            {
                checkBoxWellness.Checked = true;
            }
        }

        int gesamtpreis = 0;

        private void checkedAll()
        {
            if (checkBoxMuki.Checked && checkBoxCardio.Checked && checkBoxWellness.Checked && checkBoxWasser.Checked)
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

        private void checkBoxWellness_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWellness.Checked)
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
            checkBoxWellness.Checked = true;
            checkBoxWasser.Checked = true;

            gesamtPreis.Text = "30";
        }

        private void buttonBuchen_Click(object sender, EventArgs e)
        {
            Membership membership = new Membership(checkBoxMuki.Checked, checkBoxCardio.Checked, checkBoxWasser.Checked, checkBoxWellness.Checked, int.Parse(gesamtPreis.Text));
            f1.ActiveUser.UserMembership = membership;
            MessageBox.Show("Deine Buchung war erfolgreich");
        }

        private void buttonShowAbo_Click(object sender, EventArgs e)
        {
            f1.ActiveUser.DisplayMembershipInfo();
        }

        private void buttonSecret_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sie haben noch zeit umzukehren!", "Unnormal Spannendes Geheimnis", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

            if (result == DialogResult.Ignore)
            {
                PremiumUser user1 = new PremiumUser(f1.ActiveUser);

                f1.UsersList.Remove(f1.ActiveUser);
                f1.UsersList.Add(user1);

                f1.ActiveUser = user1;
            }
        }
    }
}
