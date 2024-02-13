namespace FormasGeometricas
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public abstract class Forma
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public virtual void Mostrar(PictureBox pictureBox) { }
    }

    public class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

        public override void Mostrar(PictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawRectangle(Pens.Black, 10, 10, 80, 80);
            }
            pictureBox.Image = bmp;
        }
    }

    public class Triangulo : Forma
    {
        private double LadoTriangulo;
        private double AlturaTriangulo;

        public Triangulo(double ladoTriangulo, double alturaTriangulo)
        {
            this.LadoTriangulo = ladoTriangulo;
            this.AlturaTriangulo = alturaTriangulo;
        }

        public override double CalcularArea()
        {
            return (LadoTriangulo * AlturaTriangulo) / 2;
        }

        public override double CalcularPerimetro()
        {
            return LadoTriangulo * 3;
        }

        public override void Mostrar(PictureBox pictureBox)
        {
            
            // Criando os pontos que formam o triângulo
            Point ponto1 = new Point(50, 50);
            Point ponto2 = new Point(50, 200);
            Point ponto3 = new Point(100, 100);

            // Criando um array de pontos com os vértices do triângulo
            Point[] pontosTriangulo = { ponto1, ponto2, ponto3 };

            
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);

            // Desenhando o triângulo com a cor vermelha
            g.FillPolygon(Brushes.Red, pontosTriangulo);
            pictureBox.Image = bmp;

        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipal());
        }
    }
}