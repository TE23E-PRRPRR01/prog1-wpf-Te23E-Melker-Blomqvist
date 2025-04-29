using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kalkapp;

/// <summary>
/// doubleeraction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickPlus(object sender, RoutedEventArgs e)
    {
        // läs av text input
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // omvandla till double
        double.TryParse(tal1, out double tal1Double);
        double.TryParse(tal2, out double tal2Double);

        // uträkning
        double resultat = tal1Double + tal2Double;

        // resultat
        txbResult.Text = $"{resultat}";
    }

        private void KlickMinus(object sender, RoutedEventArgs e)
    {
        // läs av text input
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // omvandla till double
        double.TryParse(tal1, out double tal1Double);
        double.TryParse(tal2, out double tal2Double);

        // uträkning
        double resultat = tal1Double - tal2Double;

        // resultat
        txbResult.Text = $"{resultat}";
    }

        private void KlickMultiplicera(object sender, RoutedEventArgs e)
    {
        // läs av text input
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // omvandla till double
        double.TryParse(tal1, out double tal1Double);
        double.TryParse(tal2, out double tal2Double);

        // uträkning
        double resultat = tal1Double * tal2Double;

        // resultat
        txbResult.Text = $"{resultat}";
    }

        private void KlickDela(object sender, RoutedEventArgs e)
    {
        // läs av text input
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // omvandla till double
        double.TryParse(tal1, out double tal1Double);
        double.TryParse(tal2, out double tal2Double);

        // uträkning
        double resultat = tal1Double / tal2Double;

        // resultat
        txbResult.Text = $"{resultat}";
    }
}