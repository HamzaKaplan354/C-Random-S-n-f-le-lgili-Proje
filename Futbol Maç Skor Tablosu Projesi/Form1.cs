using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0; 
        int tspuan = 0;
        Random hsp = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int gs, fb, bjk, ts;
            gs = hsp.Next(0, 7);
            label13.Text = gs.ToString();
            fb = hsp.Next(0, 7);
            label14.Text = fb.ToString();
            bjk = hsp.Next(0, 7);
            label15.Text = bjk.ToString();
            ts = hsp.Next(0, 7);
            label16.Text = ts.ToString();
            if (Convert.ToInt32(label13.Text)>Convert.ToInt32(label14.Text))
            {
                gspuan = gspuan + 3;
                label5.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label13.Text))
            {
                fbpuan = fbpuan + 3;
                label6.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label14.Text))
            {
                gspuan = gspuan + 1;
                label5.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label14.Text) == Convert.ToInt32(label13.Text))
            {
                fbpuan = fbpuan + 1;
                label6.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label16.Text))
            {
                bjkpuan = bjkpuan + 3;
                label7.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label15.Text))
            {
                tspuan = tspuan + 3;
                label8.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label16.Text))
            {
                bjkpuan = bjkpuan + 1;
                label7.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label16.Text) == Convert.ToInt32(label15.Text))
            {
                tspuan = tspuan + 1;
                label8.Text = tspuan.ToString();
            }
            if (label5.Text=="50")
            {
                MessageBox.Show("2022-2023 SPOR TOTO SÜPERLİG ŞAMPİYONU Galatasaray ");
            }
            if (label6.Text=="50")
            {
                MessageBox.Show("2022-2023 SPOR TOTO SÜPERLİG ŞAMPİYONU Fenerbahçe ");
            }
            if (label7.Text=="50")
            {
                MessageBox.Show("2022-2023 SPOR TOTO SÜPERLİG ŞAMPİYONU Beşiktaş ");
            }
            if (label8.Text=="50")
            {
                MessageBox.Show("2022-2023 SPOR TOTO SÜPERLİG ŞAMPİYONU TrabzonSpor ");
            }
        }
    }
}
