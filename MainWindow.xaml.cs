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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;


namespace ilyass gouria
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
            list.Items.Add("Name:" + name.Text);
            list.Items.Add("Age:" + age.Text);
            list.Items.Add("Email:" + email.Text);
            list.Items.Add("height:" + height.Value);
            list.Items.Add("weight:" + weight.Value);

        }

        private void age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }
    }
