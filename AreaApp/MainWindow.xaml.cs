﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AreaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        // int bredd = int.Parse(txbBredd.Text);
        // int höjd = int.Parse(txbHöjd.Text);

        if (!int.TryParse(txbBredd.Text, out int bredd))
        {
            txbResultat.Text = "fel ange heltal";
        }

        if (!int.TryParse(txbHöjd.Text, out int höjd))


        int area = bredd * höjd;

        txbResultat.Text = area.ToString();
    }

    private void KlickRensa(object sender, RoutedEventArgs)
    {
        txbBredd.Clear();
        txbHöjd.Clear();
        txbResultat.Clear();
    }

}