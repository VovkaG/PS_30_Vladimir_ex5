using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MinimalMVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel.Presenter presenterVM;
        private ViewModel.LowerCaseCnvrt lowerCaseCnvrtVM;
        public MainWindow()
        {
            InitializeComponent();
            presenterVM = new ViewModel.Presenter();
            lowerCaseCnvrtVM = new ViewModel.LowerCaseCnvrt();
            DataContext = presenterVM;
        }

        private void btnUpperCase_Click(object sender, RoutedEventArgs e)
        {
            DataContext = presenterVM;
            btnUpperCase.IsEnabled = false;
            btnLowerCase.IsEnabled = true;
        }

        private void btnLowerCase_Click(object sender, RoutedEventArgs e)
        {
            DataContext = lowerCaseCnvrtVM;
            btnLowerCase.IsEnabled = false;
            btnUpperCase.IsEnabled = true;
        }
    }
}
