using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncProgramming
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(WebClient webClient = new WebClient())
            {
                var json = webClient.DownloadString("https://cat-fact.herokuapp.com/facts");
                dynamic timeZones = JsonConvert.DeserializeObject<RootObject>(json);
        
                #region bad code to get names optimize late
                List<All> all = new List<All>(timeZones.all);
                List<User> user = new List<User>();
                List<Name> name = new List<Name>();
                foreach (var item in all)
                {
                    user.Add(item.user);
                }
               
                foreach (var u in user)
                {
                    if(u != null)
                    name.Add(u.name);
                }
                lstbox.ItemsSource = name;
                lstbox.DisplayMemberPath = "first";
                lstbox.SelectedValuePath = "last";
                #endregion
            }
        }   
    }
}
