using System.Runtime.CompilerServices;
using DesafioPOO.Models;

Smartphone nokia = new Nokia("(11)948571574", "Smartphone Nokia G60", "11111", 64);
Console.WriteLine($"{nokia.ModeloDoCelular()}");
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n------------------------------------------------------\n");

Smartphone iphone = new Iphone("(19)964872654", "Apple Iphone 15 Pro", "22222", 1000);
Console.WriteLine($"{iphone.ModeloDoCelular()}");
iphone.Ligar();
iphone.InstalarAplicativo("Ítau");