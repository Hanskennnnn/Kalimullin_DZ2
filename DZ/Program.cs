﻿using System;
namespace ALMAZ
{
    struct UserData
    {
        public string Name;
        public string Surname;
        public string City;
        public DateTime DateTime;
        public long PinCode;
        public UserData(string name, string surname, string city, DateTime dateTime, long pinCode)
        {

            Name = name;
            Surname = surname;
            City = city;
            DateTime = dateTime;
            PinCode = pinCode;
        }
        public void PrintUserData()
        {
            int age = DateTime.Today.Year - DateTime.Year;

            if (DateTime > DateTime.Today.AddYears(-age))
                age--;
            Console.WriteLine($"Имя: {Name} {Surname}\n" +
                $"Город: {City}\n" +
                $"Возраст: {age}\n" +
                $"Пин-Код: {PinCode}");
        }
    }
    /// 
    /// Информация о студенте
    /// 
    struct StudentInformation
    {
        /// 
        /// Имя студента
        ///
        public string Name;
        ///
        /// Фамилия студента
        /// 
        public string Surname;
        ///
        /// ID Студента
        /// 
        public long ID;
        /// 
        /// Дата рождения студента
        /// 
        public DateTime DateTime;
        ///
        /// Кол-во выпитого напитка в мл
        /// 
        public int VolumeOfConsumedDrink;
        ///
        /// Информация о выпитом напитке
        /// 
        public AlcoholInformation AlcoholInfo;
        /// 
        /// Категория алкоголизма
        /// 
        public AlcoholismCategory Category;

        public enum AlcoholismCategory
        {
            Алкоголик,
            ЛюбительВыпить,
            ПьетПоПраздникам,
            НеПьёт,
        }

        public StudentInformation(string name, string surname, long id, DateTime dateTime, int volumeOfConsumedDrink, AlcoholismCategory category, AlcoholInformation alcoholInfo)
        {

            Name = name;
            Surname = surname;
            ID = id;
            DateTime = dateTime;
            VolumeOfConsumedDrink = volumeOfConsumedDrink;
            Category = category;
            AlcoholInfo = alcoholInfo;
        }
        public void PrintStudentInfo()
        {
            int age = DateTime.Today.Year - DateTime.Year;

            if (DateTime > DateTime.Today.AddYears(-age))
                age--;
            Console.WriteLine($"Имя:{Name} {Surname}\n" +
                $"ID: {ID}\n" +
                $"Возраст: {age}\n" +
                $"Кол-во выпитого напитка: {VolumeOfConsumedDrink}\n" +
                $"Категория алкоголизма: {Category}\n" +
                $"Вид Алкоголя: {AlcoholInfo}");
        }
    }

    //Информация о напитке
    struct AlcoholInformation
    {
        ///
        /// Название напитка
        /// 
        public string Name;
        /// <summary>
        /// Процент алкоголя
        /// </summary>
        public int AlcoholPercentage;

        public AlcoholInformation(string name, int alcoholPercentage)
        {
            Name = name;
            AlcoholPercentage = alcoholPercentage;
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {

            //Задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine($"byte – {byte.MaxValue} – {byte.MinValue}");
            Console.WriteLine($"sbyte – {sbyte.MaxValue} – {sbyte.MinValue}");
            Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
            Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
            Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
            Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
            Console.WriteLine($"uint – {uint.MaxValue} – {uint.MinValue}");
            Console.WriteLine($"ulong – {ulong.MaxValue} – {ulong.MinValue}");
            Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
            Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
            Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");




            //Задание 2

            Console.WriteLine("\n\nЗадание 2");
            Console.WriteLine("Введите свое Имя, Фамилию, Город, Дату рождения и Пин-Код в данном порядке каждую на отдельной строке.");
            Console.WriteLine("Пример правильного ввода:\nИван\n" +
                "Иванов\n" +
                "Казань\n" +
                "2006.08.02\n" +
                "1234");

            UserData userData = new UserData();
            userData.Name = Console.ReadLine();
            userData.Surname = Console.ReadLine();
            userData.City = Console.ReadLine();
            //userData.DateTime = DateTime.Parse(Console.ReadLine());
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateTime))
                userData.DateTime = dateTime;
            else
                Console.WriteLine("Ошибка ввода.");

            if (long.TryParse(Console.ReadLine(), out long pinCode))
                userData.PinCode = pinCode;
            else
                Console.WriteLine("Ошибка ввода.");


            userData.PrintUserData();

            //Задание 3
            Console.WriteLine("\n\nЗадание 3");
            Console.Write("Введите строку: ");

            char[] chars = Console.ReadLine().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
                else if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
            }
            Console.WriteLine(new string(chars));







            //Задание 4
            Console.WriteLine("\n\nЗадание 4");

            Console.Write("Введите строку: ");
            string mainString = Console.ReadLine();


            Console.Write("Введите подстроку: ");
            string subString = Console.ReadLine();


            int counter = 0;
            int index = mainString.IndexOf(subString, StringComparison.OrdinalIgnoreCase);

            while (index != -1)
            {
                counter++;
                index = mainString.IndexOf(subString, index + subString.Length, StringComparison.OrdinalIgnoreCase);
            }


            Console.WriteLine($"Количество вхождений подстроки '{subString}' в строку '{mainString}': {counter}");





            //Задание 5
            Console.WriteLine("\n\nЗадание 5");
            Console.WriteLine("Введите цену бутылки: ");

            if (int.TryParse(Console.ReadLine(), out int normalPrice))
            {

            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
            Console.WriteLine("Введите скидку в Duty Free: ");

            if (float.TryParse(Console.ReadLine(), out float salePercentage))
            {

            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
            Console.WriteLine("Введите стоимость отпуска: ");

            if (int.TryParse(Console.ReadLine(), out int holidayPrice))
            {

            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }


            float salePrice = normalPrice * (salePercentage / 100);
            float number = holidayPrice / salePrice;
            Console.WriteLine(number);

            Console.WriteLine($"Вывод: {Math.Floor(number)}");




            //Задание 6
            Console.WriteLine("\n\nЗадание 6");

            AlcoholInformation beer = new AlcoholInformation("Beer", 5);
            AlcoholInformation wine = new AlcoholInformation("Wine", 12);
            AlcoholInformation vodka = new AlcoholInformation("Vodka", 40);
            StudentInformation[] students = new StudentInformation[5];
            students[0] = new StudentInformation("Иван", "Иванов", 1, new DateTime(2000, 1, 15), 2000, StudentInformation.AlcoholismCategory.Алкоголик, vodka);
            students[1] = new StudentInformation("Петр", "Петров", 2, new DateTime(1999, 5, 20), 1500, StudentInformation.AlcoholismCategory.ЛюбительВыпить, beer);
            students[2] = new StudentInformation("Сергей", "Сергеев", 3, new DateTime(2001, 3, 10), 1000, StudentInformation.AlcoholismCategory.ПьетПоПраздникам, wine);
            students[3] = new StudentInformation("Алексей", "Алексеев", 4, new DateTime(2002, 7, 7), 0, StudentInformation.AlcoholismCategory.НеПьёт, beer);
            students[4] = new StudentInformation("Михаил", "Михайлов", 5, new DateTime(2001, 11, 25), 2500, StudentInformation.AlcoholismCategory.Алкоголик, vodka);



            int globalVolumeOfConsumedDrinks = 0;
            double globalAlcoholVolume = 0;

            for (int i = 0; i < students.Length; i++)
            {
                globalAlcoholVolume += students[i].VolumeOfConsumedDrink * (students[i].AlcoholInfo.AlcoholPercentage / 100.0);
                globalVolumeOfConsumedDrinks += students[i].VolumeOfConsumedDrink;

            }
            double globalAlcoholPercentage = (globalAlcoholVolume / globalVolumeOfConsumedDrinks) * 100;

            foreach (var student in students)
            {
                double alcoholVolume = student.VolumeOfConsumedDrink * (student.AlcoholInfo.AlcoholPercentage / 100.0);
                double percentageOfTotalDrink = (student.VolumeOfConsumedDrink / (double)globalVolumeOfConsumedDrinks) * 100;
                double percentageOfTotalAlcohol = (alcoholVolume / globalAlcoholVolume) * 100;

                Console.WriteLine($"{student.Name} {student.Surname}:");
                Console.WriteLine($"  Процент от общего объема напитков: {percentageOfTotalDrink:F2}%");
                Console.WriteLine($"  Процент от общего объема алкоголя: {percentageOfTotalAlcohol:F2}%\n");
            }

            Console.WriteLine($"Общий объем напитков: {globalVolumeOfConsumedDrinks} мл");
            Console.WriteLine($"Объем чистого алкоголя: {globalAlcoholVolume:F2} мл");
            Console.WriteLine($"Глобальный процент алкоголя относительно общего объема: {globalAlcoholPercentage:F2}%");




        }













    }
}
