int numeroEntero;

Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingrese el numero de dia");

numeroEntero = Convert.ToInt32(Console.ReadLine());

if (numeroEntero < 1)
{
    Console.WriteLine("Error:El nùmero a ingresar debe estar contenido entre 1 y 7");
}
if (numeroEntero > 7)
{
    Console.WriteLine("Error:El nùmero a ingresar debe estar contenido entre 1 y 7");
}
if (numeroEntero == 1)
{
    Console.WriteLine("El dia es: Lunes");
}
if (numeroEntero == 2)
{
    Console.WriteLine("El dia es: Martes");
}
if (numeroEntero == 3)
{
    Console.WriteLine("El dia es: Miercoles");
}
if (numeroEntero == 4)
{
    Console.WriteLine("El dia es: Jueves");
}
if (numeroEntero == 5)
{
    Console.WriteLine("El dia es: Viernes");
}
if (numeroEntero == 6)
{
    Console.WriteLine("El dia es: Sabado");
}
if (numeroEntero == 7)
{
    Console.WriteLine("El dia es: Domingo");
}

