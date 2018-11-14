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
    public partial class Form1 : Form
    {
        AreaCuadrado AreaCua;
        AreaCirculo AreaCir;
        public static int SegAreaCir=0;
        public static int SegAreaCua=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void areaDelCirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegAreaCir==0)
            {
                AreaCir = new AreaCirculo();
                AreaCir.MdiParent = this;
                AreaCir.Show();
                SegAreaCir = 1;
            }


        }

        private void areaDelCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SegAreaCua==0)
            {
                AreaCua = new AreaCuadrado();
                AreaCua.MdiParent = this;
                AreaCua.Show();
                SegAreaCua = 1;
            }
        }
    }
}
