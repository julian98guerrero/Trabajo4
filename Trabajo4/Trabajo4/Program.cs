// See https://aka.ms/new-console-template for more information
using Trabajo4;
using Trabajo4.Computadores;
using Trabajo4.Perifericos;

Console.WriteLine("Hello, World!");

IPerifericos perifericos = new Teclado();
IPerifericos perifericos1 = new TargetaExterna();

Computadora computadora = new Computadora(perifericos, perifericos1);