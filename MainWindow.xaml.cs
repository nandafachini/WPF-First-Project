using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRUDProject
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowVM();
            InitializeComponent();
            saveButton.IsEnabled = true;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            removeButton.IsEnabled = false;
            addButton.IsEnabled = false;
            cadButton.IsEnabled = false;
            updateButton.IsEnabled = false;
            visualizeButton.IsEnabled = false;
            nicknameButton.IsEnabled = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
