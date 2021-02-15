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
        private readonly IDialogProvider _dialogProvider;
        private ILibraryBL _bl;
        public MainWindowViewModel(ILibraryBL bl, IDialogProvider dialogProvider)
        { 
            _bl = bl;
            _dialogProvider = dialogProvider;
             AddBook = new RelayCommand(OnAddBook, CanAddBook);
        }

        private bool CanAddBook(object arg)
        {
            return true;
        }

        private void OnAddBook(object obj)
        {
            var vm = new AddBookWindowViewModel(_bl);
            _dialogProvider.ShowAddBookDialog(vm);
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
