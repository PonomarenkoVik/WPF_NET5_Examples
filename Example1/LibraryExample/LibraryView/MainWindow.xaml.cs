using CommonEntities;
using CommonEntities.ModelViewInterfaces;
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
    public partial class MainWindow : Window, ILibraryMainWindowView
    {
        private ILibraryMainWindowViewModel _viewModel;
        public MainWindow(ILibraryMainWindowViewModel vm)
        {
            DataContext = _viewModel = vm;
            InitializeComponent();
        }

        public IDialogProvider<object> CreateAddBookDialogProvider(ILibraryAddBookWindowModelView dataContext)
        {
           return new AddBookWindow(dataContext) 
           { 
               Owner = this,
               WindowStartupLocation = WindowStartupLocation.CenterOwner

           };
        }
    }
}
