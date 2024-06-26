﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

/**
	Caso de uso 1: Sucesso -> Realiza os cálculos corretamente
**/

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("Caso de uso 1:");
Console.WriteLine($"Valor da diária: {suite.ValorDiaria} | Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

/**
	Caso de uso 2: Sucesso -> Aplica 10% de desconto no valor da diária
**/

// Cria a suíte
suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("\nCaso de uso 2:");
Console.WriteLine($"Valor da diária: {suite.ValorDiaria} | Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

/**
	Caso de uso 3: Exceção -> Capacidade insuficiente da suíte
**/

Pessoa p3 = new Pessoa(nome: "Hóspede 3");

hospedes.Add(p3);

// Cria a suíte
suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
try
{
	reserva.CadastrarHospedes(hospedes);
}
catch (Exception e)
{
	Console.WriteLine("\nCaso de uso 3:");
	Console.WriteLine($"Erro na reserva: {e.Message}");
}
