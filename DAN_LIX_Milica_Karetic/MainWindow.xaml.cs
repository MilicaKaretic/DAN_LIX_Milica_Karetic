using DAN_LIX_Milica_Karetic.ViewModels;
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

namespace DAN_LIX_Milica_Karetic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Main window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new GameViewModel(this);
        }

        /// <summary>
        /// Gets the button that was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slide_Clicked(object sender, RoutedEventArgs e)
        {
            var game = DataContext as GameViewModel;
            var button = sender as Button;
            game.ClickedSlide(button.DataContext);
        }

        /// <summary>
        /// Play again button, it restarts the game when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgain_C(object sender, RoutedEventArgs e)
        {
            var game = DataContext as GameViewModel;
            game.Restart();
        }
    }
}
