using System;
namespace ALMAZ
{

    struct AccountInformation
    {
        public string Number;
        public string Type;
        public decimal Balance;
        public AccountInformation(string number, string type, decimal balance)
        {
            Number = number;
            Type = type;
            Balance = balance;
        }
        public void PrintInformation()
        {
            Console.WriteLine($"Номер счета: {Number}");
            Console.WriteLine($"Тип счета: {Type}");
            Console.WriteLine($"Баланс: {Balance}");
        }

    }
    public enum AccountType
    {
        Current,
        Savings
    }

    public enum University
    {
        КГУ,
        КАИ,
        КХТИ

    }
    struct EmployeeInformation
    {
        public string Name;
        public string Surname;
        public University Univer;

        public EmployeeInformation(string name, string surname, University univer)
        {
            Name = name;
            Surname = surname;
            Univer = univer;
        }
        public void PrintInformation()
        {
            Console.WriteLine($"Имя работника: {Name} {Surname}\n" +
                $"Место работы: {Univer}");
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //Задание 3.1
            Console.WriteLine("Задание 3.1");
            AccountType accountType = AccountType.Current;
            Console.WriteLine($"Тип банковского счета: {accountType}");

            //Задание 3.2
            Console.WriteLine("Задание 3.2");
            AccountInformation account = new AccountInformation("1234567890", "Текущий", 10000.50m);
            account.PrintInformation();

            //Дом.Задание 3.1
            Console.WriteLine("Дом.Задание 3.1");
            EmployeeInformation employeeInformation = new EmployeeInformation("Иван", "Иванов", University.КГУ);
            employeeInformation.PrintInformation();
        }
    }
}
















