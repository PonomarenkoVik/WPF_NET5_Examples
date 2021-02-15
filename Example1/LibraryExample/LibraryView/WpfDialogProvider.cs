using LibraryView;
using CommonEntities;
using CommonEntities.ModelViewInterfaces;
using LibraryViewModel;

namespace LibraryView
{
    public class WpfDialogProvider : IDialogProvider
    {
        public Result<bool, string> ShowAddBookDialog(ILibraryAddBookWindowModelView viewModel)
        {
            var view = new AddBookWindow()
            {
                DataContext = viewModel
            };
            var res = view.ShowDialog();
            return new Result<bool, string>(res ?? false, viewModel.ErrorMessage);
        }
    }
}