using System;
using Hospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome:"Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");
Pessoa p3 = new Pessoa(nome: "Hospede 3");
Pessoa p4 = new Pessoa(nome: "Hospede 4");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);
//hospedes.Add(p4);


Suite suite = new Suite(tipoSuite:"Premium", capacidade:3, valorDiaria:30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospede(hospedes);

Console.WriteLine("Hospedes:" + reserva.ObterQuantidadeHospedes());
Console.WriteLine("Valor diaria:" + reserva.CalcularValorDiaria());