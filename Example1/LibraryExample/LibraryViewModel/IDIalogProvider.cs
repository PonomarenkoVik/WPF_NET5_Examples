using CommonEntities;
using CommonEntities.ModelViewInterfaces;

namespace LibraryViewModel
{
    public interface IDialogProvider
    {
        Result<bool, string> ShowAddBookDialog(ILibraryAddBookWindowModelView viewModel);
    }
}