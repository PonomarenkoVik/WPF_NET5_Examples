using Autofac;
using CommonEntities;
using LibraryViewModel.ViewModels;
using System;
using System.Windows;
using LibraryBusinessLayer;
using LibraryDataLayer;

namespace LibraryView
{
    public class Startup
    {
        private static IContainer _container;

        [STAThread()]
        static void Main()
        {
            var builder = new ContainerBuilder();
            RegisterTypes(builder);

            // Создание приложения
            Application app = new Application();
            // Создание главного окна.
            _container = builder.Build();
            ILibraryViewModel viewModel = _container.Resolve<ILibraryViewModel>();

            var mainWindow = new MainWindow(viewModel);
            viewModel.SetView(mainWindow);
            // Запуск приложения и отображение главного окна,
            app.Run(mainWindow);
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<LibraryData>().As<ILibraryData>();
            builder.RegisterType<LibraryBL>().As<ILibraryBL>();
            builder.RegisterType<MainWindowViewModel>().As<ILibraryViewModel>();
            builder.RegisterType<MainWindow>().As<ILibraryView>();

        }
    }
}
