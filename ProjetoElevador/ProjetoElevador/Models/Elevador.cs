using System;

namespace ProjetoElevador
{
    internal class Elevador
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Sistema de elevador ###");
            Console.Write("Insira quantos andares há no prédio: "); //usuário define a quantidade de andares
            int andares = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira a capacidade máxima do elevador: "); //usuário define a capacidade máxima do elevador
            int capacidade = Convert.ToInt32(Console.ReadLine());
            int pessoas = 0; //elevador inicia vazio
            int andarAtual = 0; //elevador inicia no térreo
            int opcao = 0;
            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1: Adicionar pessoa;");
                Console.WriteLine("2: Remover pessoa;");
                Console.WriteLine("3: Subir;");
                Console.WriteLine("4: Descer;");
                Console.WriteLine("0: Finalizar execução.");
                Console.Write("Insira a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1) //comando de entrar
                {
                    if (pessoas < capacidade) //só adiciona pessoas caso não esteja cheio
                    {
                        pessoas++; //contator de pessoas adiciona 1
                        Console.WriteLine("+1");
                        Console.WriteLine("Ocupação atual do elevador: " + pessoas); //lista a nova quantidade de pessoas
                    }
                    else 
                    {
                        Console.WriteLine("Impossível. Capacidade já máxima atingida!");
                    }
                }
                else if (opcao == 2) //comando de sair
                {
                    if (pessoas == 0) //caso elevador esteja vazio
                    {
                        Console.WriteLine("Não há ninguém no elevador.");
                    }
                    else
                    {
                        pessoas--; //contador de pessoas decrementa
                        Console.WriteLine("-1");
                        Console.WriteLine("Ocupação atual do elevador: " + pessoas); //lista a nova quantidade de pessoas
                    }
                } 
                else if (opcao == 3) //subir
                {
                    if (andarAtual == andares) //caso já esteja no andar máximo
                    {
                        Console.WriteLine("Impossível subir mais.");
                        Console.WriteLine("Você está no último andar");
                    }
                    else
                    {
                        andarAtual++; //incrementa o andar/sobe
                        Console.WriteLine("Pronto!");
                        Console.WriteLine("Andar atual: " + andarAtual);
                    }
                }
                else if (opcao == 4) //descer
                {
                    if (andarAtual == 0) //caso já esteja no andar mínimo
                    {
                        Console.WriteLine("Impossível descer mais.");
                        Console.WriteLine("Você está no térreo.");
                    } 
                    else
                    {
                        andarAtual--; //decrementa o andar/desce
                        Console.WriteLine("Pronto!");
                        Console.WriteLine("Andar atual: " + andarAtual);
                    }
                }
                else if (opcao == 0)
                {
                    Console.WriteLine("Fim de execução.");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            while(opcao != 0);

        }
    }
}
