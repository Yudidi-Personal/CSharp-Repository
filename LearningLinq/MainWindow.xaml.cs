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

namespace LearningLinq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable<Person> list = new List<Person>()
        {
        new Person(){ Name="Olive",Sex="女",Age=22},
        new Person(){ Name="Moyao",Sex="男",Age=23},
        new Person(){ Name="Momo",Sex="女",Age=22},
        new Person(){ Name="Only",Sex="女",Age=20},
        new Person(){ Name="Love",Sex="女",Age=21},
        new Person(){ Name="For",Sex="女",Age=22},
        new Person(){ Name="Remote",Sex="男",Age=23},
        new Person(){ Name="Snow",Sex="女",Age=23}
        };

        public MainWindow()
        {
            InitializeComponent();
            lvmPerson.ItemsSource = list;
        }

        private void btnGirlsClick(object sender, RoutedEventArgs e)
        {
            var women = from i in list
                        where i.Sex == "女"
                        select i;
            lvmPerson.ItemsSource = women;
        }
    }
}
