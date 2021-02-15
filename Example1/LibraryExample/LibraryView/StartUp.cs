using Autofac;
using CommonEntities;
using LibraryViewModel.ViewModels;
using System;
using System.Windows;
using LibraryBusinessLayer;
using LibraryDataLayer;
using LibraryViewModel;

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
            // Запуск приложения и отображение главного окна
            app.Run(_container.Resolve<MainWindow>());
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<LibraryData>().As<ILibraryData>();
            builder.RegisterType<LibraryBL>().As<ILibraryBL>();
            builder.RegisterType<MainWindowViewModel>().As<ILibraryMainWindowViewModel>();
            builder.RegisterType<MainWindow>().AsSelf().SingleInstance();
            builder.RegisterType<WpfDialogProvider>().As<IDialogProvider>();
        }
    }
}
