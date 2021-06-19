using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Aluno [] alunos = new Aluno [5];
            var indicealuno = 0;
            
            string opcaoUsuario = ObteropcaoUsuario();

            while (opcaoUsuario.ToUpper() !="X")
            {
                switch (opcaoUsuario)
                {
                    case "1" :
                        Console.WriteLine("informe o nome do aluno:");
                        var aluno =new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota));
                        {
                            aluno.Nota = nota;
                        
                        }
                        

                        alunos[indicealuno] = aluno;
                        indicealuno++;
                        

                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                           if (!string.IsNullOrEmpty(a.Nome)) 
                          {  
                            Console.WriteLine($"ALUNO:{a.Nome} - Nota {a.Nota}" );
                          }

                        }    
                        break;

                    
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos=0;
                        for (int i = 0; i < alunos.Length;i++)
                    {
                        if (!string.IsNullOrEmpty(alunos[i].Nome)) 
                        {
                          notaTotal = notaTotal + alunos[i].Nota;
                          nrAlunos++;
                        }

                    }    
                    var mediaGeral = notaTotal / nrAlunos;
                    Conceito conceitoGeral;
                    
                    if (mediaGeral < 2) 
                    {
                        conceitoGeral = Conceito.E;
                    }

                    else if (mediaGeral <4)
                    {
                        conceitoGeral = Conceito.D;
                    }

                    else if (mediaGeral <6)
                    {
                        conceitoGeral = Conceito.C;
                    }

                    else if (mediaGeral <8)
                    {
                        conceitoGeral = Conceito.B;
                    }

                    else
                    {
                        conceitoGeral = Conceito.A;
                    }

                    Console.WriteLine($"MÉDIAGERAL:{mediaGeral} - CONCEITO:{conceitoGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

          

            
            opcaoUsuario = ObteropcaoUsuario();
            }

        }
            private static string ObteropcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular Média geral");
            Console.WriteLine("X-sair");
            Console.WriteLine();

            
            
            string opcaoUsuario = Console.ReadLine();
        
            return opcaoUsuario;
        }

    }

}
