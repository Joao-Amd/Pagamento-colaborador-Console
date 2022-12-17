﻿using System;
using System.Globalization;
using System.Collections.Generic;
using Colaborador.Entidades;
namespace Colaborador
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ColaboradorClt> list = new List<ColaboradorClt>();

            Console.Write("Entre com a quantidade de colaboradores: ");
            int quantidadeColaboradores = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeColaboradores; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados do Colaborador {i}");
                Console.Write("Colaborador é terceirizado? (S/N)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                double horas = double.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());

                if (ch == 's')
                {  
                    Console.Write("Adcional: ");
                    double adcional = double.Parse(Console.ReadLine());

                    list.Add(new ColaboradorTerceiro (nome, horas, valorPorHora, adcional));
                }
                else
                {
                    list.Add(new ColaboradorClt(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos:");
            foreach (ColaboradorClt colaborador in list)
            {
                Console.WriteLine($"{colaborador.Nome} - $ {colaborador.Pagamento().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
