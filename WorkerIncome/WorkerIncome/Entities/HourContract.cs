using System;

namespace WorkerIncome.Entities
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // Retorna valor total do contrato
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
