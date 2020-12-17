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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /* Este tipo de codigo es escrito en C# 
             * 
            Grid miGrid = new Grid();
            this.Content = miGrid;
            Button miBoton = new Button();
            miBoton.Width = 200;
            miBoton.Height = 50;
            miBoton.Background = Brushes.Pink;

            WrapPanel miwrap = new WrapPanel();

            TextBlock miText1 = new TextBlock();
            miText1.Text = "click";
            miwrap.Children.Add(miText1);

            TextBlock miText2 = new TextBlock();
            miText2.Text = "Enter";
            miText2.FontStyle = FontStyles.Italic;
            miwrap.Children.Add(miText2);

            TextBlock miText3 = new TextBlock();
            miText3.Text = "Aceptar";
            miwrap.Children.Add(miText3);

            miBoton.Content = miwrap;
            miGrid.Children.Add(miBoton);

            */


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        //metodo creado automaticamente cuando se crea el evento button_click en el button desde el MainWindow.xaml
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le has dado al botón");
        }
        */



    }
}
