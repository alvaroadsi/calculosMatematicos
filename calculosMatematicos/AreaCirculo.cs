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
    public partial class AreaCirculo : Form
    {
        public AreaCirculo()
        {
            InitializeComponent();
        }

        private void AreaCirculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.SegAreaCir = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float radio;
            double area;
            radio = float.Parse(textBox1.Text);

            area = Math.PI * Math.Pow(radio, 2);

            LabelArea.Text = "El área del circulo es "+ area.ToString();
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
