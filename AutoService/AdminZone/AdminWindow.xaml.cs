using AutoService.DataFilesApp;
using AutoServiceProject.DataFilesApp;
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
using System.Windows.Shapes;

namespace AutoService.AdminZone
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();

            ConnectDB.DbObj = new AutoServiceEntities();

            FrameApp.frameObj = FrmMain;
            FrmMain.Navigate(new PageAdminMenu());
        }
    }
 
}
