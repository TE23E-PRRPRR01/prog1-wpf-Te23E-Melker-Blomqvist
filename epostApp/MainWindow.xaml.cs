﻿using System.Net;
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

namespace epostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private ClickSkicka(object sender, RoutedEventArgs e)
    {
        // Läs av epost
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text

        // mail
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = NetworkCredential("toure", "pass")

        if (epost != "" && meddelande != "")
        {
            lblStatus.Content = "Ok";
        }
        else
        {
            lblStatus.Content = "fel";
        }
    }

}