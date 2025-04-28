using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace WiredBrainCoffee.CustomersApp.View
{
  public partial class CustomersView : UserControl
  {
        private CustomerViewModel _viewModel;

        public CustomersView()
        {
            InitializeComponent();
            _viewModel = new CustomerViewModel();
            DataContext = _viewModel; 
        }

    private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
    {
      //var column = (int)customerListGrid.GetValue(Grid.ColumnProperty);

      //var newColumn = column == 0 ? 2 : 0;
      //customerListGrid.SetValue(Grid.ColumnProperty, newColumn);

      var column = Grid.GetColumn(customerListGrid);

      var newColumn = column == 0 ? 2 : 0;
      Grid.SetColumn(customerListGrid, newColumn);
    }

        private void CheckBox_Checked()
        {

        }
    }
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private string? firstname;
        private string? lastname;
        private bool isDeveloper;

        public string? Firstname { get => firstname; set { firstname = value; RaisePropertyChanged(); } }
        public string? Lastname { get => lastname; set { lastname = value; RaisePropertyChanged(); } }

        public bool IsDeveloper { get => isDeveloper; set { isDeveloper = value; RaisePropertyChanged(); } }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void RaisePropertyChanged([CallerMemberName]string? Propertyname = null)
        {
            PropertyChanged?.Invoke(this , new PropertyChangedEventArgs(nameof(Propertyname)
        }
    }
}
