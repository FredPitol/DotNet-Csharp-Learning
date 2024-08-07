using WorkerIncome.Entities.Enums; // Referencia/"Import" do enum  
using System.Collections.Generic;

namespace WorkerIncome.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // Enum 
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Implementando Composição com department
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); // Composição para muitos, new.. -> garante que lista não será nula

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            // Boa prática -> não existe construtor para composições para muitos, objetos são adicionados posterior a instanciação
        }

        // Adiciona contrato a lista de contratos
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // Remove Contrato
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        // Retorna total de ganha do trabalhador 
        public double Income(int year, int month)
        {
            double sum = BaseSalary; // Inicia ja com o valor base
            // Percorre a lista de contratos somando 
            foreach (HourContract contract in Contracts)
            {   
                // se ano e mes recebido como argumento for igual a do elemento da lista -> Adiciona valor total 
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    } 
}
