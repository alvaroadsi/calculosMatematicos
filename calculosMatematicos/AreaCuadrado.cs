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

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int lado;
            int area;
            lado = int.Parse(textBox1.Text);
            area = lado * lado;
            Resultado.Text = $"El área del cuadrado es: {area.ToString()}";
        }
    }
}
