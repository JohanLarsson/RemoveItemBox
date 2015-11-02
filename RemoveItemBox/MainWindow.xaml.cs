using System.Windows;

namespace RemoveItemBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var viewModel = new ViewModel();
            viewModel.AddCommand.Execute(null);
            viewModel.AddCommand.Execute(null);
            DataContext = viewModel;
        }
    }
}
