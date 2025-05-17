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
        for (int i= 0; i < names.Count; i ++)
        {
            StdNames.Items.Add(new ListViewItem { Content = names[i] } );
        }
    }
    public string TextBoxInput { get ; set; }
    public List<string> names = new List<string>() { "Haid Mousavi", "Asghar" };

    private void AddName(object sender, RoutedEventArgs e)
    {
        names.Add(Inputname.Text);
        StdNames.Items.Add(new ListViewItem { Content = Inputname.Text });
        Inputname.Clear();
    }

    private void DeleteName(object sender, RoutedEventArgs e)
    {
        int selecteditem = StdNames.SelectedIndex;
        StdNames.Items.Remove(StdNames.SelectedItem);
        names.RemoveAt(selecteditem);
    }

    private void ChangeName(object sender, RoutedEventArgs e)
    {
        int selecteditem = StdNames.SelectedIndex;
        StdNames.Items.Clear();
        names[selecteditem] = Inputname.Text;
        for(int i=0; i < names.Count; i++)
            StdNames.Items.Add(new ListViewItem { Content = names[i] });
    }
}