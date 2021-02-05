using Autofac;
using CommonEntities;
using LibraryViewModel.ViewModels;
using System;
using System.Windows;

namespace LibraryView
{
    public class Startup
    {
        [STAThread()]
        static void Main()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);

            // Создание приложения
            Application app = new Application();
            // Создание главного окна.
            MainWindow win = new MainWindow(null);
            // Запуск приложения и отображение главного окна,
            app.Run(win);
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindow>().As<ILibraryView>();
            builder.RegisterType<MainWindowViewModel>().As<ILibraryViewModel>();
            builder.RegisterType<MainWindowViewModel>().As<ILibraryViewModel>();
        }
    }
}
