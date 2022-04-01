using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStack_GUI
{
    public partial class Volumes : Form
    {
        public Volumes()
        {
            InitializeComponent();
        }

        private void Volumes_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
        }
    }
}
