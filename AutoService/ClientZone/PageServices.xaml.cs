using AutoService.DataFilesApp;
using AutoServiceProject.DataFilesApp;
using System;
using System.Collections;
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

namespace AutoServiceProject.ClientZone
{
    /// <summary>
    /// Логика взаимодействия для PageServices.xaml
    /// </summary>
    public partial class PageServices : Page
    {
        int countService = 0;//счётчик для отображения


        public PageServices()
        {
            InitializeComponent();


            LoadingServices();
        }

        public void LoadingServices()
        {

            var Services = ConnectDB.DbObj.Service.ToList();
            List<int> ServiceId = new List<int>();
            ServiceId = (from IdService in Services select IdService.ID).ToList(); //Получаем массив ID для перечисления элементов
            var service = Services.FirstOrDefault(x => x.ID == ServiceId[countService]);
            ServiceControlHelper.Id = service.ID;
            ServiceControlHelper.NameService = service.Title;
            ServiceControlHelper.Duration = service.Duration;
            ServiceControlHelper.Digit = service.Digit;
            ServiceControlHelper.Price = service.Value;
            ServiceControlHelper.Discount = service.Discount;
            ServiceControlHelper.MainPage = service.MainImagePath;   //а не проще ли тут создать новый экземпляр класса и работать с ним? И нужно ли будет производить очистку памяти после такой "работы"?
            TxtNameService1.Text = ServiceControlHelper.NameService;
            TxtPriceService1.Text = ServiceControlHelper.Price.ToString();
            TxtDurationService1.Text = ServiceControlHelper.Duration.ToString() + " " + ServiceControlHelper.Digit;

        }
        

        private void BtnMoreInf_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
