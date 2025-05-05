using System.Diagnostics;
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

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void onButtonClick(object sender, RoutedEventArgs e)
    {
        //Debug.Write("Hi! Clicked") it will show in terminal while debuging
        //MessageBox.Show("You Clicked!");
        HiSection.Text = "Hi! Hadi";
        //HiSection.Text += "Hi Hadi!";
        SecondButton.Content = "salam Hadi";
        Items.Children.Add(new Button { Content = "Good Morning" });
    }
}