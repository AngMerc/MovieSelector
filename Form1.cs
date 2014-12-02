using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSelector
{
    public partial class movieForm : Form
    {
        public movieForm()
        {
            InitializeComponent();
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            lblAll.Visible = true;
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            lblAll.Visible = false;
        }

        private void lblMovie_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selMovie = listBoxMovies.SelectedItem.ToString();

            if (selMovie == "Dumb and Dumber To")
            {
                lblAll.Visible = false;
                lblMovie.Visible = true;
                lblMovie.Text = "Start Times for Dumb and Dumber To are:\n  8:00  |  10:40  |  1:20";
                this.BackColor = System.Drawing.Color.White;
            }
            else if (selMovie == "Big Hero 6")
            {
                lblAll.Visible = false;
                lblMovie.Visible = true;
                lblMovie.Text = "Start Times for Big Hero 6 are:\n  10:45  |  12:30  |  1:25  |  3:10  |  4:04";
                this.BackColor = System.Drawing.Color.Wheat;
            }
            else if (selMovie == "Interstellar")
            {
                lblAll.Visible = false;
                lblMovie.Visible = true;
                lblMovie.Text = "Start Times for Interstellar are:\n  11:30  |  1:30  |  3:15  |  5:10  |  6:00";
                this.BackColor = System.Drawing.Color.MintCream;
            }
            else
            {
                lblAll.Visible = false;
                lblMovie.Visible = true;
                lblMovie.Text = "Start Times for Gone Girl are:\n  11:20  |  1:50  |  4:25  |  7:10  |  9:45";
                this.BackColor = System.Drawing.Color.MistyRose;
            }

        }
    }
}
