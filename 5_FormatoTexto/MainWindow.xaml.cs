
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

namespace _5_FormatoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoEditableTextBlock.FontWeight = FontWeights.Bold;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoEditableTextBlock.FontStyle = FontStyles.Italic;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoEditableTextBlock.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoEditableTextBlock.Foreground = new SolidColorBrush(Colors.Red);
        }


        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoEditableTextBlock.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void TextoIntroducirTexBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoEditableTextBlock.Text = textoIntroducirTexBox.Text;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoEditableTextBlock.FontStyle = FontStyles.Normal;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoEditableTextBlock.FontWeight = FontWeights.Normal;
        }
    }
}
