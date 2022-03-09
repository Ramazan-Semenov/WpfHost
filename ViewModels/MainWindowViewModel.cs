using System;
using System.Collections.Generic;

using WpfApplicationHost.Models;
using WpfApplicationHost.Views;

namespace WpfApplicationHost.ViewModels
{
    /// <summary>
    /// <see cref="MainWindow"/> view model.
    /// </summary>
    public class MainWindowViewModel
    {
        /// <summary>
        /// Example application tabs.
        /// </summary>
        public IEnumerable<TabModel> TabModels { get; private set; } = new[]
        {
            new TabModel("1",@"C:\Users\lenovo\source\repos\TaskDataGrid\TaskDataGrid\bin\Debug\TaskDataGrid.exe"),
            new TabModel("2",@"C:\Users\lenovo\source\repos\Modern_Design\Modern_Design\bin\Debug\Modern_Design.exe")
            //new TabModel("Write", $@"{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\write.exe"),
            //new TabModel("Regedit", $@"{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\regedit.exe"),
        };
    }
}