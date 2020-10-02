using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.DataFilesApp
{
    /// <summary>
    /// Класс обработки данных об услуге
    /// </summary>
    class ServiceControlHelper
    {
        public static int Id { get; set; }

        public static string NameService { get; set; }

        public static int Duration { get; set; }

        public static string Digit { get; set; }

        public static int Price { get; set; }

        public static float Discount { get; set; }

        public static string MainPage { get; set; }

        public static string Description { get; set; }
    }
}
