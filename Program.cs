using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcao = Menu();  
            int indice = 0;

        while(opcao.ToUpper() != "X"){
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Nome:");
                    
                    Aluno aluno = new Aluno();
                    aluno.nome = Console.ReadLine();

                    Console.WriteLine("Nota:");
                    if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        aluno.nota = nota;
                    else
                        throw new ArgumentException("O valor deve ser decimal");

                    alunos[indice] = aluno;
                    indice++;
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    foreach(var a in alunos){
                        if(!string.IsNullOrEmpty(a.nome))
                            Console.WriteLine($"Nome: {a.nome}\nNota:{a.nota}\n");
                    }
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    decimal notaTotal = 0;
                    int contador = 0;

                    for(int i = 0; i < alunos.Length; i++){
                        if(!string.IsNullOrEmpty(alunos[i].nome)){
                            notaTotal += alunos[i].nota;
                            contador++;
                        }
                    }
                    Console.WriteLine($"A media da turma é: {notaTotal/contador}");
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;
            }
            Console.Clear();
            opcao = Menu();
        }
 
    }

        private static string Menu()
        {
            Console.WriteLine("\nMenu\n");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media");
            Console.WriteLine("X - Exit");

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}
