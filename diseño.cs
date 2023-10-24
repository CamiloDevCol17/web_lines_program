using System;
using System.Drawing;
using System.Windows.Forms;

namespace DibujarLineasApp
{
    public partial class Form1 : Form
    {
        public const int Ancho = 20;
        public const int Alto = 20;
        Graphics grafico;

        public Form1()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            try
            {
                double xInicio, yInicio, xFinal, yFinal;

                if (double.TryParse(txtxinicial.Text, out xInicio) && double.TryParse(txtyinicial.Text, out yInicio) &&
                    double.TryParse(txtxfinal.Text, out xFinal) && double.TryParse(txtyfinal.Text, out yFinal))
                {
                    // Crear objeto clsLinea con los puntos iniciales y finales
                    clsLinea linea = new clsLinea(xInicio, yInicio, xFinal, yFinal);

                    // Dibujar la l�nea
                    using (Graphics g = CreateGraphics())
                    {
                        Pen pen = new Pen(Color.Black, 2);
                        g.DrawLine(pen, linea.ObtenerXInicio(), linea.ObtenerYInicio(), linea.ObtenerXFinal(), linea.ObtenerYFinal());
                    }

                    // Actualizar el contador de l�neas
                    txtcontador.Text = Convert.ToString(clsLinea.ObtenerCuenta());
                }
                else
                {
                    MessageBox.Show("Ingrese valores num�ricos v�lidos para los puntos iniciales y finales.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
