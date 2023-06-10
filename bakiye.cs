using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class bakiye : Form
    {
        public bakiye()
        {
            InitializeComponent();
        }

        private void bakiye_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = Form1.musteriBakiye.ToString() + " $ ";
        }
    }
}
