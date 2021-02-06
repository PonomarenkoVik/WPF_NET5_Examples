using CommonEntities;
using CommonEntities.ModelViewInterfaces;
using LibraryViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryViewModel.ViewModels
{
    public class AddBookWindowViewModel : ViewModelBase, ILibraryAddBookWindowModelView
    {
        private ILibraryBL _bl;
        public AddBookWindowViewModel(ILibraryBL bl)
        {
            _bl = bl;
            Add = new RelayCommand(AddBook, CanAddBook);
        }

        #region Properties
        private string _bookName;
        public string BookName
        {
            get { return _bookName; }
            set 
            { 
                _bookName = value;
                OnPropertyChanged();
            }
        }

        private string _bookId;
        public string BookId
        {
            get { return _bookId; }
            set
            {
                _bookId = value;
                OnPropertyChanged();
            }
        }

        private string _icbn;
        public string ICBN
        {
            get { return _icbn; }
            set
            {
                _icbn = value;
                OnPropertyChanged();
            }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged();
            }
        }

        private string _publisher;
        public string Publisher
        {
            get { return _publisher; }
            set
            {
                _publisher = value;
                OnPropertyChanged();
            }
        }

        private string _edition;
        public string Edition
        {
            get { return _edition; }
            set
            {
                _edition = value;
                OnPropertyChanged();
            }
        }

        private string _bookShelf;
        public string BookShelf
        {
            get { return _bookShelf; }
            set
            {
                _bookShelf = value;
                OnPropertyChanged();
            }
        }

        private string _row;
        public string Row
        {
            get { return _row; }
            set
            {
                _row = value;
                OnPropertyChanged();
            }
        }

        private string _column;
        public string Column
        {
            get { return _column; }
            set
            {
                _column = value;
                OnPropertyChanged();
            }
        }

        private string _addButtonTooltip;
        public string AddButtonTooltip
        {
            get { return _addButtonTooltip; }
            set
            {
                _addButtonTooltip = value;
                OnPropertyChanged();
            }
        }
        #endregion Properties

        #region ICommand
        public ICommand Add { get; set; }

        private bool CanAddBook(object arg)
        {
            if (string.IsNullOrEmpty(BookName) ||
                string.IsNullOrEmpty(BookId) ||
                string.IsNullOrEmpty(ICBN) ||
                string.IsNullOrEmpty(Author) ||
                string.IsNullOrEmpty(Publisher) ||
                string.IsNullOrEmpty(Edition) ||
                string.IsNullOrEmpty(Row) ||
                string.IsNullOrEmpty(Column))
            {
                AddButtonTooltip = "Fill all required field";
                return false;
            }

            if (!CheckFieldLength(BookName, "Book name", 5, 20, out string mess))
            {
                AddButtonTooltip = mess;
                return false;
            }

            if (BookName.Length < 5 || BookName.Length > 20)
            {
                AddButtonTooltip = "Book name length must be between 5 - 20 symbols";
                return false;
            }

            int bookId;
            if (!int.TryParse(BookId, out bookId) || bookId < 0 || bookId > 999999)
            {
                AddButtonTooltip = "Book id is not valid";
                return false;
            }

            if (!CheckBookId(bookId))
            {
                AddButtonTooltip = "Book id isn't exist";
                return false;
            }

            if (!int.TryParse(ICBN, out var icbn) || icbn < 0 || bookId > 19999)
            {
                AddButtonTooltip = "ICBM number is not valid";
                return false;
            }

            if (!CheckFieldLength(Author, "Author", 5, 20, out mess))
            {
                AddButtonTooltip = mess;
                return false;
            }

            if (!CheckFieldLength(Publisher, "Publisher", 5, 20, out mess))
            {
                AddButtonTooltip = mess;
                return false;
            }

            if (!CheckFieldLength(Edition, "Edition", 5, 20, out mess))
            {
                AddButtonTooltip = mess;
                return false;
            }

            if (!int.TryParse(BookShelf, out var bookShelf) || bookShelf < 0 || bookShelf > 20)
            {
                AddButtonTooltip = "Book shelf is not valid";
                return false;
            }

            if (!int.TryParse(Row, out var row) || row < 1 || row > 40)
            {
                AddButtonTooltip = "Book row is not valid";
                return false;
            }

            if (!int.TryParse(Column, out var column) || column < 1 || column > 25)
            {
                AddButtonTooltip = "Book column is not valid";
                return false;
            }

            AddButtonTooltip = "Click to add book";
            return true;
        }

        private bool CheckFieldLength(string val, string fieldName, int fromLength, int toLength, out string mess)
        {
            if (val.Length >= fromLength && val.Length <= toLength)
            {
                mess = null;
                return true;
            }
            mess = $"{fieldName} length must be between {fromLength} - {toLength} symbols";
            return true;
        }

        private bool CheckBookId(int bookId)
        {
            return true;
        }

        private void AddBook(object obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
