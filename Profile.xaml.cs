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
using System.Windows.Shapes;

namespace DeMolµ
{
    /// <summary>
    /// Interaction logic for NietMol.xaml
    /// </summary>
    public partial class NietMol : Window
    {

        public NietMol(string naam, bool isMol, string leeftijd, string beroep, string locatie, string jaar)
        {
            InitializeComponent();

            TxtNaam.Text = naam; // Set the text content first
            TxtLeeftijd.Text = leeftijd;
            TxtBeroep.Text = beroep;
            TxtJaar.Text = jaar;
            TxtLocatie.Text = locatie;

            if (isMol)
            {
                TxtNaam.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0371d"));
                TxtBeroep.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0371d"));
                TxtJaar.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0371d"));
                TxtLeeftijd.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0371d"));
                TxtLocatie.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0371d"));
                TxtMol.Text = "Jij bent de Mol!";
                TxtMol.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0371d"));
                ChangeImageSource();
            }
            else
            {
                TxtNaam.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#61f1f1"));
                TxtBeroep.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#61f1f1"));
                TxtJaar.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#61f1f1"));
                TxtLeeftijd.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#61f1f1"));
                TxtLocatie.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#61f1f1"));
                TxtMol.Text = "Jij bent de Mol Niet!";
                TxtMol.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#61f1f1"));

            }
        }


        private void ChangeImageSource()
        {
            // Create a relative URI for the image you want to display
            Uri newImageUri = new Uri("DeMolRed.jpg", UriKind.Relative);

            // Create a BitmapImage and set the UriSource to the new URI
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = newImageUri;
            bitmapImage.EndInit();

            // Set the source of your Image control to the new BitmapImage
            Picca.Source = bitmapImage;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
