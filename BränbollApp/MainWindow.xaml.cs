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

namespace BränbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int poänginne = 0;
    int poängute = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {

        poänginne += 5;
        txbinne.Text = $"{poänginne}";

        txbHistori.Text += $"\nLag inne +5. totalt: {poänginne}"
    }

     private void KlickBränning(object sender, RoutedEventArgs e)
    {

        poängute += 2;
        txbute.Text = $"{poängute}";
    }
    
     private void KlickLyra(object sender, RoutedEventArgs e)
    {

        poängute += 3;
        txbute.Text = $"{poängute}";
    }
     private void KlickVarv(object sender, RoutedEventArgs e)
    {

        poänginne += 1;
        txbinne.Text = $"{poänginne}";
    }
}