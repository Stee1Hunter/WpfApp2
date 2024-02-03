using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        Button[] buttons;
        
        public void prosto_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int knopka = random.Next(1, 9);
            
            buttons = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
            
            (sender as Button).Content = "x";
            (sender as Button).IsEnabled = false;
            
            
            if (buttons.Any(but => but.IsEnabled == true))
            {
                while (buttons[knopka].IsEnabled == false)
                    knopka = random.Next(1, 9);
                buttons[knopka].Content = "0";
                buttons[knopka].IsEnabled = false;
                
            }
            pobeda();
            
        }
        
        public void pobeda()
        {
            bool b = false;
            if (buttons[0].Content == buttons[1].Content && buttons[0].Content == buttons[2].Content && buttons[0].Content == "x" ||
                buttons[3].Content == buttons[4].Content && buttons[3].Content == buttons[5].Content && buttons[3].Content == "x" ||
                buttons[6].Content == buttons[7].Content && buttons[6].Content == buttons[8].Content && buttons[6].Content == "x" ||
                buttons[0].Content == buttons[3].Content && buttons[0].Content == buttons[6].Content && buttons[0].Content == "x" ||
                buttons[1].Content == buttons[4].Content && buttons[1].Content == buttons[7].Content && buttons[1].Content == "x" ||
                buttons[2].Content == buttons[5].Content && buttons[2].Content == buttons[8].Content && buttons[2].Content == "x" ||
                buttons[0].Content == buttons[4].Content && buttons[0].Content == buttons[8].Content && buttons[0].Content == "x" ||
                buttons[2].Content == buttons[4].Content && buttons[2].Content == buttons[6].Content && buttons[2].Content == "x")
            {
                MessageBox.Show("победа крестов");
                b = true;
            }
            if (buttons[0].Content == buttons[1].Content && buttons[0].Content == buttons[2].Content && buttons[0].Content == "0" ||
                buttons[3].Content == buttons[4].Content && buttons[3].Content == buttons[5].Content && buttons[3].Content == "0" ||
                buttons[6].Content == buttons[7].Content && buttons[6].Content == buttons[8].Content && buttons[6].Content == "0" ||
                buttons[0].Content == buttons[3].Content && buttons[0].Content == buttons[6].Content && buttons[0].Content == "0" ||
                buttons[1].Content == buttons[4].Content && buttons[1].Content == buttons[7].Content && buttons[1].Content == "0" ||
                buttons[2].Content == buttons[5].Content && buttons[2].Content == buttons[8].Content && buttons[2].Content == "0" ||
                buttons[0].Content == buttons[4].Content && buttons[0].Content == buttons[8].Content && buttons[0].Content == "0" ||
                buttons[2].Content == buttons[4].Content && buttons[2].Content == buttons[6].Content && buttons[2].Content == "0")
            {
                MessageBox.Show("победа нулей");
                b = true;
            }
            if (buttons[0].Content == buttons[1].Content && buttons[0].Content != buttons[2].Content && buttons[0].Content == "0" && b == false ||
                buttons[3].Content == buttons[4].Content && buttons[3].Content != buttons[5].Content && buttons[3].Content == "0" && b == false ||
                buttons[6].Content == buttons[7].Content && buttons[6].Content != buttons[8].Content && buttons[6].Content == "0" && b == false ||
                buttons[0].Content == buttons[3].Content && buttons[0].Content != buttons[6].Content && buttons[0].Content == "0" && b == false ||
                buttons[1].Content == buttons[4].Content && buttons[1].Content != buttons[7].Content && buttons[1].Content == "0" && b == false ||
                buttons[2].Content == buttons[5].Content && buttons[2].Content != buttons[8].Content && buttons[2].Content == "0" && b == false ||
                buttons[0].Content == buttons[4].Content && buttons[0].Content != buttons[8].Content && buttons[0].Content == "0" && b == false ||
                buttons[2].Content == buttons[4].Content && buttons[2].Content != buttons[6].Content && buttons[2].Content == "0" && b == false)
            {
                MessageBox.Show("ничья");
            }






        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
