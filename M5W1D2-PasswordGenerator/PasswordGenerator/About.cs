using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            txtAbout.Text = "Copyright (c) 2017 TechElevator, LLC" + System.Environment.NewLine +
                "Version " + Application.ProductVersion + System.Environment.NewLine +
                "All Rights Reserved." + System.Environment.NewLine +
                "John Fulton" + System.Environment.NewLine +
                "john@TechElevator.com";
            btnOk.Focus();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAbout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
