using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_de_orentacion_de_objetos
{
    public partial class Form1 : Form
    {
        int resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var num1 = 7;
            var num2 = 5;
            int resultado = suma(num1, num2);
        }

        private int suma(int num1, int num2)
        {
            int toalsuma = num1 + num2;
            return toalsuma;
            throw new NotImplementedException();
        }
    }
}
