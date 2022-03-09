using Curso.Entities.Enums;
using System.Collections.Generic;

namespace Curso.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; } /*fazendo associação entre duas classes diferentes*/
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); /*Criando List e Instanciando para que não seja nula > */

        //Construtor Padrão
        public Worker()
        {
        }

        //Construtor com Argumentos
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Metodo Adicionar Contrato
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); /*adicionando na Lista Contract o contract recebido*/
        }

        //Metodo Remover Contrato
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); /*removendo da Lista Contract o contract recebido*/
        }

        //Metodo Ganho do Funcionario
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); /*soma vai receber ela mesma + o total do contrato*/
                }
            }
            return sum;
        }




    }
}
