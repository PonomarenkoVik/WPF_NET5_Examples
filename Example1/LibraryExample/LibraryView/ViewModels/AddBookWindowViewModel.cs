using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryView.ViewModels
{
    class AddBookWindowViewModel : DependencyObject
    {
        public static DependencyProperty WindowTitleProperty;
        public string WindowTitle
        {
            get => (string)GetValue(WindowTitleProperty);
            set => SetValue(WindowTitleProperty, value);
        }

        static AddBookWindowViewModel()
        {
            WindowTitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(AddBookWindowViewModel));
        }
    }
}
