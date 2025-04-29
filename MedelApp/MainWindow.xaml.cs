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

namespace MedelApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    int summa = 0;
    int antalKlick = 0;

    private void KlickAddera(object sender, RoutedEventArgs e)
    {
        // Räkna antal klick
        antalKlick++;

        string talet = txbTal1.Text;

        // Gör till int
        int.TryParse(talet, out int tal);

        // Lägg till summan
        summa = summa + tal;

        // Skriv ut summa
        txbResultat.Text = $"{summa}";
    }
}