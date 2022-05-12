using System;
using System.Collections.Generic;

namespace Projeto
{
    public struct InformacoesSolicitadas
    {
        public string nome;
        public int cpf;
        public string email;
        public int telefone;
        public string objetivo;
    }
    public class Program
    {
        public static List<InformacoesSolicitadas> usuarios = new List<InformacoesSolicitadas>();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("-----Bem-vindo a Academia de Noxus!-----\n");
                Console.WriteLine("Selecione a opção: ");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("4 - Deletar");
                Console.WriteLine("5 - Alterar");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1': Console.Clear(); Inserir(); break;
                    case '2': Console.Clear(); Listar(); break;
                    case '3': Console.Clear(); Consultar(); break;
                    case '4': Console.Clear(); Deletar(); break;
                    case '5': Console.Clear(); Alterar(); break;
                    default: Console.Clear(); Console.WriteLine("Opção Inválida!"); break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static void Inserir()
        {
            InformacoesSolicitadas S = new InformacoesSolicitadas();
            Console.Write($"Matrícula--{usuarios.Count}--");
            Console.Write("\nInforme o nome: ");
            S.nome = Console.ReadLine();
            Console.Write("Informe o Cpf: ");
            S.cpf = int.Parse(Console.ReadLine());
            Console.Write("Informe o E-mail: ");
            S.email = Console.ReadLine();
            Console.Write("Informe o telefone: ");
            S.telefone = int.Parse(Console.ReadLine());
            Console.Write("Informe o objetivo: ");
            S.objetivo = Console.ReadLine();
            usuarios.Add(S);
        }
        static void Listar()
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine($"Matrícula--{i}--");
                ListarUsuario(i);
            }
        }
        static void ListarUsuario(int i)
        {
            Console.WriteLine($"Nome: {usuarios[i].nome}");
            Console.WriteLine($"Cpf: {usuarios[i].cpf}");
            Console.WriteLine($"E-mail: {usuarios[i].email}");
            Console.WriteLine($"Telefone: {usuarios[i].telefone}");
            Console.WriteLine($"Objetivo: {usuarios[i].objetivo}");
            Console.WriteLine("===================================");
        }
        static void Consultar()
        {
            Console.Write("Digite um nome a ser consultado: ");
            string nome = Console.ReadLine();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].nome != null && usuarios[i].nome.ToLower().Contains(nome.ToLower()))
                {
                    Console.WriteLine($"Matrícula--{i}--");
                    ListarUsuario(i);
                }
            }
        }
        static void Deletar()
        {
            Console.Write("Digite um nome a ser consultado: ");
            string nome = Console.ReadLine();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].nome != null && usuarios[i].nome.ToLower().Contains(nome.ToLower()))
                {
                    Console.WriteLine($"Matrícula--{i}--");
                    ListarUsuario(i);
                }
            }
            Console.Write("Digite a matrícula do usuário a ser excluído:");
            usuarios.RemoveAt(int.Parse(Console.ReadLine()));
        }
        static void Alterar() 
        {
            Console.Write("Digite um nome a ser consultado: ");
            string nome = Console.ReadLine();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].nome != null && usuarios[i].nome.ToLower().Contains(nome.ToLower()))
                {
                    Console.WriteLine($"Matrícula--{i}--");
                    ListarUsuario(i);
                }
            }
            Console.Write("Digite a matrícula do usuário a ser alterado:");
            usuarios.RemoveAt(int.Parse(Console.ReadLine()));

            Console.Clear();

            InformacoesSolicitadas S = new InformacoesSolicitadas();
            Console.Write("Informe o nome: ");
            S.nome = Console.ReadLine();
            Console.Write("Informe o Cpf: ");
            S.cpf = int.Parse(Console.ReadLine());
            Console.Write("Informe o E-mail: ");
            S.email = Console.ReadLine();
            Console.Write("Informe o telefone: ");
            S.telefone = int.Parse(Console.ReadLine());
            Console.Write("Informe o objetivo: ");
            S.objetivo = Console.ReadLine();
            usuarios.Add(S);
        }
    }
}