using System;
using System.Globalization;

namespace ExercicioSalarioFuncionario
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas serão cadastradas? ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Empregado Nº {i + 1}");
                Console.Write("Digite o Id do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                if (i >= 1)
                {
                    for (int j = 0; j < list.Count; j++)
                    {

                        while (id == list[j].Id)
                        {
                            Console.Write("Esta Id já está em uso! Por favor, digite outra: ");
                            id = int.Parse(Console.ReadLine());
                            

                            if (id != list[j].Id && j > 0)
                            {
                                j = -1;
                                break;
                            }
                        }
                                

                    }
                }
                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o salário do funcionário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                list.Add(new Funcionario(id, nome, salario));

            }
            Console.Write("Digite o Id do funcionário que você deseja aumentar o salário: ");
            int idSalario = int.Parse(Console.ReadLine());
            Funcionario func = list.Find(x => x.Id == idSalario);

            if (func != null)
            {
                Console.Write($"Digite quantos % você deseja aumentar o salário do funcionário {func.Nome}: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Aumento(porc);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Id inválida!");
                Console.Clear();
            }

            foreach (Funcionario funcc in list)
            {
                Console.WriteLine(funcc);
            }



        }
    }

}



















