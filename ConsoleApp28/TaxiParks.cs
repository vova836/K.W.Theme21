using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    /// <summary>
    /// Класс для хранения информации о таксопарке
    /// </summary>
    class TaxiParks
    {
        public string Name { get; set; }
        public string Location { get; set; }


        /// <summary>
        /// Конструктор для инициализации данных таксопарка
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        public TaxiParks(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
