using System.Globalization;
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

namespace MelkerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickJämför(object sender, RoutedEventArgs e)
    {
        // Läs in talen
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // till int
        double.TryParse(tal1, out double siffra1);
        double.TryParse(tal2, out double siffra2);

        if(siffra1 > siffra2)
        {
            txbResultat.Text = $"{tal1} är större än {tal2}";
        }
        else if(siffra1 < siffra2)
        {
            txbResultat.Text = $"{tal2} är större än {tal1}";
        }
        else
        {
           txbResultat.Text = "Talen är lika stora";
        }

    }
}