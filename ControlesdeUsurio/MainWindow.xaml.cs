using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlesdeUsurio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
            switch (CbFigura.SelectedIndex)
            {
                case 0: // Circulo
                    grdParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;


                case 1: //Triangulo
                    grdParametrosFigura.Children.Add(new ParametrosTriangulo());
                    break;

                case 2: //Rectangulo
                    grdParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;

                case 3: //Pentagono
                    grdParametrosFigura.Children.Add(new ParametrosPentagono());
                    break;

                case 4: //Cuadrado
                    grdParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;

                case 5: //Trapecio
                    grdParametrosFigura.Children.Add(new ParametrosTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;

            switch (CbFigura.SelectedIndex)
            {
                case 0: // Circulo
                    double radio =
                        double.Parse(
                    ((ParametrosCirculo)
                        (grdParametrosFigura.Children[0])).
                        txtRadio.Text);
                    area = Math.PI * radio * radio;
                    break;

                case 1: // Triangulo
                    double basetriangulo =
                        double.Parse(
                    ((ParametrosTriangulo)
                        (grdParametrosFigura.Children[0])).
                        txtbasetriangulo.Text);
                    double altura =
                        double.Parse(
                    ((ParametrosTriangulo)
                        (grdParametrosFigura.Children[0])).
                        txtalturatriangulo.Text);
                    area = (basetriangulo * altura) / 2;
                    break;

                case 2: // Rectangulo
                    double baserectangulo =
                        double.Parse(
                    ((ParametrosRectangulo)
                        (grdParametrosFigura.Children[0])).
                        txtbaserectangulo.Text);
                    double alturarectangulo =
                        double.Parse(
                    ((ParametrosRectangulo)
                        (grdParametrosFigura.Children[0])).
                        txtalturarectangulo.Text);
                    area = baserectangulo * alturarectangulo;
                    break;

                case 3: // Cuadrado
                    double lado =
                        double.Parse(
                    ((ParametrosCuadrado)
                        (grdParametrosFigura.Children[0])).
                        txtladocuadrado.Text);
                    area = lado * lado;
                    break;

                case 4: // Pentagono
                    double perimetro =
                        double.Parse(
                    ((ParametrosPentagono)
                        (grdParametrosFigura.Children[0])).
                        txtperimetro.Text);
                    double apotema =
                        double.Parse(
                    ((ParametrosPentagono)
                        (grdParametrosFigura.Children[0])).
                        txtapotema.Text);
                    area = (perimetro * apotema) / 2;
                    break;

                case 5: // Trapecio
                    double basemayor =
                        double.Parse(
                    ((ParametrosTrapecio)
                        (grdParametrosFigura.Children[0])).
                        txtbasemayor.Text);
                    double basemenor =
                        double.Parse(
                    ((ParametrosTrapecio)
                        (grdParametrosFigura.Children[0])).
                        txtbasemenor.Text);
                    double alturatrapecio =
                        double.Parse(
                    ((ParametrosTrapecio)
                        (grdParametrosFigura.Children[0])).
                        txtalturatrapecio.Text);
                    area = ((basemayor + basemenor) * alturatrapecio) / 2;

                    break;
                default:
                    break;
            }

            lblresultado.Text = area.ToString();
        }
    }
}


