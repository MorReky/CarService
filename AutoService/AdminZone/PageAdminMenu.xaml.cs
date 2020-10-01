using AutoServiceProject.ProgramProcedures;
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

namespace AutoService.AdminZone
{
    /// <summary>
    /// Логика взаимодействия для PageAdminMenu.xaml
    /// </summary>
    public partial class PageAdminMenu : Page
    {

        public PageAdminMenu()
        {
            InitializeComponent();   
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frameObj.Navigate(new PageServicesAdm());
        }

        private void BtnClientRecord_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnComingRecord_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
