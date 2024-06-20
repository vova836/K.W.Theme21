using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public enum CarType
    {
        Economy,
        Comfort
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Список водителей такси
            List<TaxiInfo> taxiDrivers = new List<TaxiInfo>
        {
            new TaxiInfo("Максим", "Батрудинов", "Б323ВД", CarType.Comfort),
            new TaxiInfo("Владимир", "Иваненко", "В423БФ", CarType.Comfort),
            new TaxiInfo("Иван", "Иванов", "А453ДИ", CarType.Comfort),
            new TaxiInfo("Петр", "Петров", "В234СД", CarType.Comfort),
            new TaxiInfo("Сергей", "Сидоров", "Р587ОЕ", CarType.Comfort),
            new TaxiInfo("Владимир", "Козлов", "Ф655МЛ", CarType.Comfort),
            new TaxiInfo("Александр", "Баранов", "М323РО", CarType.Comfort),
            new TaxiInfo("Марк", "Сидарнов", "В543ЩУ", CarType.Comfort),
            new TaxiInfo("Никита", "Полканский", "В907МТ", CarType.Comfort),
            new TaxiInfo("Владислав", "Петухин", "Ц234МС", CarType.Comfort),
            new TaxiInfo("Сергей", "Синицин", "Е317ОС", CarType.Comfort),
            new TaxiInfo("Иван", "Иавнков", "Б5678У", CarType.Economy),
            new TaxiInfo("Сергей", "Алашевский", "Е5432ГУ", CarType.Economy),
            new TaxiInfo("Илья", "Андропав", "Е367НА", CarType.Economy),
            new TaxiInfo("Александр", "Медведев", "Е567ОМ", CarType.Economy),
            new TaxiInfo("Алексей", "Сергеев", "В453ЗУ", CarType.Economy),
            new TaxiInfo("Федр", "Воронин", "К457УК", CarType.Economy),
            new TaxiInfo("Арсений", "Варонский", "В224МИ", CarType.Economy),
            new TaxiInfo("Владимир", "Якольский", "Ф433АВ", CarType.Economy),
            new TaxiInfo("Сергей", "Пироченко", "Ф545ПУ", CarType.Economy),
            new TaxiInfo("Максим", "Иванов", "А123ВФ", CarType.Economy),
            new TaxiInfo("Евгений", "Растов", "А544ЩТ", CarType.Economy),
        };

            // Список таксопарков в Тирасполе
            List<TaxiParks> taxiParks = new List<TaxiParks>
        {
            new TaxiParks("Тираспольский таксопарк №1", "ул. Ленина, 15"),
            new TaxiParks("Такси Тирасполь", "ул. Карла Маркса, 22"),
            new TaxiParks("Таксопарк Приднестровья", "ул. Октябрьская, 7"),
            new TaxiParks("Такси-1", "ул. Ленина, 21"),
            new TaxiParks("Таксопарк Тирасполь", "ул. Кирова, 13"),
            new TaxiParks("Столица Такси", "ул. Софийская, 42"),
            new TaxiParks("Тирас Такси", "ул. Малышева, 23")
        };

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Меню такси:");
                Console.WriteLine("1. Информация о водителях такси.");
                Console.WriteLine("2. Информация о таксопарков.");
                Console.WriteLine("3. История появления такси.");
                Console.WriteLine("4. Вызов диспетчера.");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                switch (key.KeyChar)
                {
                    case '1':
                        // Код для информации о водителях такси
                        foreach (var info in taxiDrivers)
                        {
                            Console.WriteLine(info);
                        }
                        break;
                    case '2':
                        // Код для информации о таксопарков
                        foreach (var taxiPark in taxiParks)
                        {
                            Console.WriteLine($"Название: {taxiPark.Name}, Местоположение: {taxiPark.Location}");
                        }
                        break;
                    case '3':
                        // Код для истории появления такси
                        // Код для истории появления такси
                        string history = @"История появления такси:

1. Древний Рим:
   В Древнем Риме существовали колесницы, которые можно было арендовать. Они выполняли функцию такси для состоятельных граждан.

2. 17 век:
   В 1605 году в Лондоне появились первые 'Hackney Carriages' — наемные экипажи. В Париже в 1637 году началась организация первых таксомоторных экипажей.

3. 19 век:
   В 1891 году немецкий инженер Вильгельм Брюн разработал таксометр, устройство для измерения стоимости проезда.

4. Начало 20 века:
   В 1907 году в Лондоне появились первые моторизованные такси. В том же году в Нью-Йорке начали работать такси с таксометрами.

5. Современность:
   Сегодня такси стало неотъемлемой частью городской транспортной системы. С развитием технологий появились мобильные приложения для вызова такси, такие как Uber и Яндекс.Такси.";

                        Console.WriteLine(history);
                        break;
                    case '4':
                        // Код для вызова диспетчера
                        Console.WriteLine("Вызов диспетчера:");
                        TaxiDispatcher dispatcher = new TaxiDispatcher();
                        dispatcher.ProcessTaxiOrder();
                        TaxiDriver driver = new TaxiDriver();
                        driver.ProcessDriveTaxi();
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
}
