using AutoService.AdminZone;
using AutoService.DataFilesApp;
using AutoServiceProject.ClientZone;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoServiceProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int CountClick = 0;

        public MainWindow()
        {
            InitializeComponent();

            ConnectDB.DbObj = new AutoServiceEntities();

            FrameApp.frameObj = FrmMain;
            FrmMain.Navigate(new PageServices());

            
            
        }

        /// <summary>
        /// Логика проверки условия открытия админского окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Нужна переработка данного события
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString()=="D0"|| e.Key.ToString() =="NumPad0")
            {
                CountClick++;
                if (CountClick==4)
                {
                    CountClick = 0;
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                }
            }
            else
            {
                CountClick = 0;
            }
        }
    }
}
