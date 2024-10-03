// See https://aka.ms/new-console-template for more information
using Ejercicio1;

Cuenta primera = new Cuenta("Manuel");
Cuenta segunda = new Cuenta("Javier", 10);

primera.Ingresar(50);
segunda.Ingresar(50);
segunda.Retirar(70);

Console.WriteLine(primera);
Console.WriteLine(segunda);