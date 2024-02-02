// See https://aka.ms/new-console-template for more information
using Programa4;

Console.WriteLine("Programa 4");
Persona persona = new Persona("Yuberkis", 22);
persona.Imprimir($"El nombre de la persona es {persona.Nombre} y tiene la edad de {persona.Edad}.");

Empleado empleado = new Empleado("Carmela", 53, 50000);
empleado.Imprimir($"El nombre del empleado es {empleado.Nombre} y tiene la edad de {empleado.Edad} con un sueldo de {empleado.Sueldo}.");