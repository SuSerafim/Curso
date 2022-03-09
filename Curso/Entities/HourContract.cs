using System;

namespace Curso.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor Padrão
        public HourContract()
        {

        }

        //Construtor com argumentos
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Metodo
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
