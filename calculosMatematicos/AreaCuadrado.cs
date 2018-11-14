using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculosMatematicos
{
    public partial class AreaCuadrado : Form
    {
        public AreaCuadrado()
        {
            InitializeComponent();
        }

        private void AreaCuadrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.SegAreaCua = 1;
        }
    }
}
