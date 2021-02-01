using System;
using System.Windows;

namespace LibraryView
{
    public class Startup
    {
        [STAThread()]
        static void Main()
        {
            // Создание приложения
            Application app = new Application();
            // Создание главного окна.
            MainWindow win = new MainWindow();
            // Запуск приложения и отображение главного окна,
            app.Run(win);
        }
    }
}
