using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeometricas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            if (LadoTrianguloTxt.Text == "" || AlturaTrianguloTxt.Text == "")
            {
                MessageBox.Show("Preencha o Lado e a Altura do triangulo!");
            }
            else
            {
                double ladoTriangulo = Convert.ToDouble(LadoTrianguloTxt.Text);
                double alturaTriangulo = Convert.ToDouble(AlturaTrianguloTxt.Text);

                Triangulo triangulo = new Triangulo(ladoTriangulo, alturaTriangulo);

                double areaTriangulo = triangulo.CalcularArea();
                double perimetroTriangulo = triangulo.CalcularPerimetro();

                AreaTrianguloTxt.Text = areaTriangulo.ToString();
                PerimetroTrianguloTxt.Text = perimetroTriangulo.ToString();

                triangulo.Mostrar(pictureBoxTriangulo);
            }
            
        }
    }
}
