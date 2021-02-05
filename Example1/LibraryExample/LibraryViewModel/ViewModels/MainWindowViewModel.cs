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
    public class MainWindowViewModel : ViewModelBase, ILibraryViewModel, IDisposable
    {
        private ILibraryView _view;
        private ILibraryBL _bl;
        public MainWindowViewModel(ILibraryView view, ILibraryBL bl)
        {
            _view = view; 
            _bl = bl;
             AddBook = new RelayCommand(OnAddBook, CanAddBook);
        }

        private bool CanAddBook(object arg)
        {
            throw new NotImplementedException();
        }

        private void OnAddBook(object obj)
        {
            var vm = new AddBookWindowViewModel(_bl);
            _view.CreateAddBookDialogProvider(vm).ShowDialog(null);
        }

       
        public ICommand AddBook { get; }


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
