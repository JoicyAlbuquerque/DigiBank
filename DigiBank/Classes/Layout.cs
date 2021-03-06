﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Classes
{
    public class Layout
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        private static int opcao = 0;
        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                         ");
            Console.WriteLine("           Digite a Opção Desejada :     ");
            Console.WriteLine("          ============================== ");
            Console.WriteLine("           1 - Criar Conta :             ");
            Console.WriteLine("          ============================== ");
            Console.WriteLine("           2 - Entrar com CPF e Senha:   ");
            Console.WriteLine("          ============================== ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

        private static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("                                         ");
            Console.WriteLine("           Digite seu nome :             ");
            string nome = Console.ReadLine();
            Console.WriteLine("          ============================== ");
            Console.WriteLine("           1 - Digite seu CPF :          ");
            string cpf = Console.ReadLine();
            Console.WriteLine("          ============================== ");
            Console.WriteLine("           2 - Digite sua senha:         ");
            string senha = Console.ReadLine();
            Console.WriteLine("          ============================== ");

            // Criar uma conta

            ContaCorrente contaCorrente = new ContaCorrente();
            Pessoa pessoa = new Pessoa();

            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);
            pessoa.Conta = contaCorrente;

            pessoas.Add(pessoa);

            Console.Clear();

            Console.WriteLine("           Conta Cadastrada com Sucesso! ");
            Console.WriteLine("          ============================== ");

        }

        private static void TelaLogin()
        {
            Console.Clear();

            Console.WriteLine("                                         ");
            Console.WriteLine("           Digite o CPF :                ");
            string cpf = Console.ReadLine();
            Console.WriteLine("          ============================== ");
            Console.WriteLine("           Digite sua senha :            ");
            string senha = Console.ReadLine();
            Console.WriteLine("          ============================== ");

            //Logar no Sistema
 
        }
    }
}
