using CommonEntities;
using LibraryViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryViewModel.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, ILibraryMainWindowViewModel, IDisposable
    {
        private ILibraryMainWindowView _view;
        private ILibraryBL _bl;
        public MainWindowViewModel(ILibraryBL bl)
        { 
            _bl = bl;
             AddBook = new RelayCommand(OnAddBook, CanAddBook);
        }

        public void SetView(ILibraryMainWindowView view) => _view = view;


        private bool CanAddBook(object arg)
        {
            return true;
        }

        private void OnAddBook(object obj)
        {
            var vm = new AddBookWindowViewModel(_bl);
            _view.CreateAddBookDialogProvider(vm).ShowDialog(null);
        }

       
        public ICommand AddBook { get; set; }


        bool _disposed = false;
        bool _isDisposing = false;
        public void Dispose()
        {
            _isDisposing = true;
            _bl.Dispose();
            _disposed = true;
            throw new NotImplementedException();
        }
    }
}
