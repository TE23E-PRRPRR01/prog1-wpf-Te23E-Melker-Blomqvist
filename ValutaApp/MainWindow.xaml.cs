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

namespace ValutaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void USD(object sender, RoutedEventArgs e)
    {
        string belopp = txbBelopp.Text;

        // Gör till int
        double.TryParse(belopp, out double beloppTal);

        // Räkna ut
        double beloppUSD = beloppTal / 9.64;

        // Resultat
        txbResultat.Text = $"${beloppUSD}";
    }

    private void EUR(object sender, RoutedEventArgs e)
    {
        string belopp = txbBelopp.Text;

        // Gör till int
        double.TryParse(belopp, out double beloppTal);

        // Räkna ut
        double beloppEUR = beloppTal / 10.98;

        // Resultat
        txbResultat.Text = $"${beloppEUR}";
    }

    private void GBP(object sender, RoutedEventArgs e)
    {
        string belopp = txbBelopp.Text;

        // Gör till int
        double.TryParse(belopp, out double beloppTal);

        // Räkna ut
        double beloppGBP = beloppTal / 12.9;

        // Resultat
        txbResultat.Text = $"${beloppGBP}";
    }
}