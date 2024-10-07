using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfContolsTextApp
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (sender is TextBox textBox)
            //{ 
            //    txtTablo.Text = textBox.Text;
            //}
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            if(txtEditor.SelectionLength > 0)
                txtTablo.Text = txtEditor.SelectedText;
            else
            {
                txtEditor.SelectionStart = 2;
                txtEditor.SelectionLength = 5;
                txtTablo.Text = txtEditor.SelectedText;
            }
        }
    }
}