﻿using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Sistema de estacionamento. Seja bem vindo!\n" +
                  "Valor de entrada no estacionamento:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Valor por hora estacionada:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Entrada de veículo");
    // Mostra menus apenas se existir cadastros
    if (estacionamento.ExistemVeiculos())
    {
        Console.WriteLine("2 - Saída de veículo");
        Console.WriteLine("3 - Listagem de veículos estacionados");
    }
    Console.WriteLine("4 - Encerrar aplicação");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.ListarVeiculos();
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("Sistema de estacionamento encerrado...");
