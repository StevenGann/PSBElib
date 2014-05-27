using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSBElib;

namespace PSBEtester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (PSBE.Diagnostic())
            {
                toolStripStatusLabel1.Text = "Status:[Diagnostic Passed]";
            }
            else
            {
                toolStripStatusLabel1.Text = "Status:[Diagnostic FAILED!]";
            }
        }

        private void buttonRunDiag_Click(object sender, EventArgs e)
        {
            textBoxDiagResult.Text = Convert.ToString(PSBE.Diagnostic());
        }
    }
}
