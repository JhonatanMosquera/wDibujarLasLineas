using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wDibujarLasLineas
{
    public partial class Form1 : Form
    {
        Graphics lineal;
        
        public Form1()
        {
            InitializeComponent();
            lineal = CreateGraphics();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double xInicial = double.Parse(txtXInicial.Text);
                double xFinal = double.Parse(txtXFinal.Text);
                double yInicial = double.Parse(txtYInicial.Text);
                double yFinal = double.Parse(txtYFinal.Text);

                ClsLineas modificar = new ClsLineas(xInicial,xFinal,xInicial,xInicial  );
                Pen pen = new Pen(Color.Azure);
                pen.Width = 10;
                lineal.DrawLine(pen, modificar.getXInicial(), modificar.getXFinal(), modificar.getYFinal(), modificar.getYFinal());
                txtNumeroVeces.Text = Convert.ToString(ClsLineas.getContador());







            }
            catch 
            {

                MessageBox.Show("Error ingresa numeros por favor");
                
            }







        }
    }
}
