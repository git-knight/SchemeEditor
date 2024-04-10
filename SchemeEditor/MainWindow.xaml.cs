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

namespace SchemeEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<OpBlockType> logTypes = new List<OpBlockType>
        {
            new OpBlockType("AND", new[]{ "A", "B", "C" }, new[]{ "A", "B" })
        };

        List<string> ExistingTypesList => logTypes.Select(x => x.Name).ToList();

        public MainWindow()
        {
            InitializeComponent();

            listItems.ItemsSource = ExistingTypesList;
        }

        private void listItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listItems.SelectedItem != null)
            {
                var rng = new Random();

            }
        }
    }
}