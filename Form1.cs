namespace FormasGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if(txtLadoQuadrado.Text == "")
            {
                MessageBox.Show("Favor digitar o valor do lado do quadrodo!");
            }
            else
            {
                double lado = Convert.ToDouble(txtLadoQuadrado.Text);

                Quadrado quadrado = new Quadrado(lado);

                double area = quadrado.CalcularArea();
                double perimetro = quadrado.CalcularPerimetro();

                lblAreaQuadrado.Text = $"Área: {area}";
                lblPerimetroQuadrado.Text = $"Perímetro: {perimetro}";

                quadrado.Mostrar(pictureBoxQuadrado);

            }
            
        }
    }
}