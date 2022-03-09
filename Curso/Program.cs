using System;
using System.Globalization;
using Curso.Entities;
using Curso.Entities.Enums;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/ MidLevel/ Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);// Instanciando obj Departament
            Worker worker = new Worker(name, level, baseSalary, dept);// Instanciando o obj Worker

            Console.Write("How many contracts to this Worker?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) /*para a variavel i que começa com 1, se i for menor ou igual a n acrescentar o valor do i +1*/
            {
                Console.WriteLine($"Enter #{i} contract data: "); /*para funcionar a interpolação {} colocar o caractere $ no incio*/
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2)); //fazendo uma substring (começando na posição 0 e pegando 2 caracteres)
            int year = int.Parse(monthAndYear.Substring(3)); //substring cortando do 3 em diante

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
