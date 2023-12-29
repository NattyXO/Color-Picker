using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_picker
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Hide();
                black_form ss = new black_form();
                ss.Show();
            }
            else if (radioButton2.Checked)
            {
                this.Hide();
                Form1 ss = new Form1();
                ss.Show();
            }
        }
    }
}
