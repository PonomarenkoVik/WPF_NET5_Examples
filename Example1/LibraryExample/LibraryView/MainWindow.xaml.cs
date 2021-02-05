using CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ILibraryView
    {
        private ILibraryViewModel _viewModel;
        public MainWindow(ILibraryViewModel vm)
        {
            DataContext = _viewModel = vm;
            InitializeComponent();
        }

        public IDialogProvider<object> CreateAddBookDialogProvider(object dataContext) => new AddBookWindow(dataContext);
    }
}
