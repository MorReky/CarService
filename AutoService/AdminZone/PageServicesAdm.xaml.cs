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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoService.AdminZone
{
    /// <summary>
    /// Логика взаимодействия для PageServicesAdm.xaml
    /// </summary>
    public partial class PageServicesAdm : Page
    {
        int countService = 0;//счётчик для отображения
        List<int> ServiceId = new List<int>();//Массив с id сервисов

        public PageServicesAdm()
        {
            InitializeComponent();

            LoadPageNext();
        }

        public void LoadPageNext()
        {
            //расковырять и перенести в отдельный класс
            //а не проще ли тут создать новый экземпляр класса и работать с ним? И нужно ли будет производить очистку памяти после lтакой "работы"?
            var Services = ConnectDB.DbObj.Service.ToList();
            ServiceId = (from IdService in Services select IdService.ID).ToList(); //Получаем массив ID для перечисления элементов
            for (int i = 0; i < 4; i++)
            {
                var service = Services.FirstOrDefault(x => x.ID == ServiceId[countService]);//Это получение информации о записи
                ServiceControlHelper.Id = service.ID;
                ServiceControlHelper.NameService = service.Title;
                ServiceControlHelper.Duration = service.Duration;
                ServiceControlHelper.Digit = service.Digit;
                ServiceControlHelper.Price = service.Value;
                ServiceControlHelper.Discount = (float)service.Discount;
                ServiceControlHelper.MainPage = service.MainImagePath;
                countService++;
                //Возможно, на 101 интерации получим ошибку. Подозреваю, решение проблемы заключено в коде ниже
                //if (i<3)
                //{
                //    countService++;
                //}
                switch (i)
                {
                    case 0:
                        {
                            LoadingServices(StckpDiscount1, TxtNameService1, TxtDurationService1, TxtPriceService1, TxtDiscount1, TxtStartPriceBlock1, Image1);
                            break;
                        }
                    case 1:
                        {
                            LoadingServices(StckpDiscount2, TxtNameService2, TxtDurationService2, TxtPriceService2, TxtDiscount2, TxtStartPriceBlock2, Image2);
                            break;
                        }
                    case 2:
                        {
                            LoadingServices(StckpDiscount3, TxtNameService3, TxtDurationService3, TxtPriceService3, TxtDiscount3, TxtStartPriceBlock3, Image3);
                            break;
                        }
                    case 3:
                        {
                            LoadingServices(StckpDiscount4, TxtNameService4, TxtDurationService4, TxtPriceService4, TxtDiscount4, TxtStartPriceBlock4, Image4);
                            break;
                        }
                }

            }
        }

        public void LoadPageBack()
        {
            //а не проще ли тут создать новый экземпляр класса и работать с ним? И нужно ли будет производить очистку памяти после lтакой "работы"?
            //Можно ли убрать куда-то вот ЭТО формированрие объекта для рационального распределения ресурсов?
            var Services = ConnectDB.DbObj.Service.ToList();
            ServiceId = (from IdService in Services select IdService.ID).ToList(); //Получаем массив ID для перечисления элементов
            for (int i = 3; i >= 0; i--)
            {
                countService--;
                var service = Services.FirstOrDefault(x => x.ID == ServiceId[countService]);//Это получение информации о записи
                ServiceControlHelper.Id = service.ID;
                ServiceControlHelper.NameService = service.Title;
                ServiceControlHelper.Duration = service.Duration;
                ServiceControlHelper.Digit = service.Digit;
                ServiceControlHelper.Price = service.Value;
                ServiceControlHelper.Discount = (float)service.Discount;
                ServiceControlHelper.MainPage = service.MainImagePath;
                ServiceControlHelper.Description = service.Description;
                switch (i)
                {
                    case 0:
                        {
                            LoadingServices(StckpDiscount1, TxtNameService1, TxtDurationService1, TxtPriceService1, TxtDiscount1, TxtStartPriceBlock1, Image1);
                            break;
                        }
                    case 1:
                        {
                            LoadingServices(StckpDiscount2, TxtNameService2, TxtDurationService2, TxtPriceService2, TxtDiscount2, TxtStartPriceBlock2, Image2);
                            break;
                        }
                    case 2:
                        {
                            LoadingServices(StckpDiscount3, TxtNameService3, TxtDurationService3, TxtPriceService3, TxtDiscount3, TxtStartPriceBlock3, Image3);
                            break;
                        }
                    case 3:
                        {
                            LoadingServices(StckpDiscount4, TxtNameService4, TxtDurationService4, TxtPriceService4, TxtDiscount4, TxtStartPriceBlock4, Image4);
                            break;
                        }
                }
            }
        }
        public void LoadingServices(StackPanel Container, TextBlock NameService, TextBlock DuratationService, TextBlock PriceService, TextBlock DiscountService, TextBlock StartPriceService, Image ImageMain)
        {
            if (ServiceControlHelper.MainPage != null)
            {
                string filename = "../Resorces/" + ServiceControlHelper.MainPage.Trim();
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(filename, UriKind.Relative);
                image.EndInit();
                ImageMain.Source = image;
            }
            NameService.Text = ServiceControlHelper.NameService;
            DuratationService.Text = ServiceControlHelper.Duration.ToString() + " " + ServiceControlHelper.Digit;
            if (ServiceControlHelper.Discount == 0)
            {
                Container.Visibility = Visibility.Hidden;
                StartPriceService.Text = null;
                PriceService.Text = ServiceControlHelper.Price.ToString();
            }
            else
            {
                Container.Visibility = Visibility.Visible;
                DiscountService.Text = Convert.ToString(ServiceControlHelper.Discount * 100);
                StartPriceService.Text = ServiceControlHelper.Price.ToString();
                PriceService.Text = Convert.ToString(ServiceControlHelper.Price - ServiceControlHelper.Price * ServiceControlHelper.Discount);
            }

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            LoadPageBack();

            if (countService <= 0)
                BtnBack.IsEnabled = false;
            else
                BtnBack.IsEnabled = true;
            if (countService >= ServiceId.Count)
                BtnNext.IsEnabled = false;
            else
                BtnNext.IsEnabled = true;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            LoadPageNext();

            if (countService <= 0)
                BtnBack.IsEnabled = false;
            else
                BtnBack.IsEnabled = true;
            if (countService >= ServiceId.Count)
                BtnNext.IsEnabled = false;
            else
                BtnNext.IsEnabled = true;
        }

        private void BtnBackFrm_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frameObj.GoBack();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }


        private void BtnEditInf1_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frameObj.Navigate(new PageEditInformationService(TxtNameService1.Text));
        }

        private void BtnEditInf2_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frameObj.Navigate(new PageEditInformationService(TxtNameService2.Text));
        }

        private void BtnEditInf3_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frameObj.Navigate(new PageEditInformationService(TxtNameService3.Text));
        }

        private void BtnEditInf4_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frameObj.Navigate(new PageEditInformationService(TxtNameService4.Text));
        }
    }
}
