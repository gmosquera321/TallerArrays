//Dado un vector de tamaño N, llenar el vector aleatoriamente con números enteros. Pedir por pantalla un número y determinar si ese número se encuentra en el vector, en caso afirmativo, indicar su posición (índice) dentro del vector, en caso negativo, mostrar el mensaje “El número no existe”.
using System;
public class parial2
{
    static void Main(string[] args)
    {

        Console.Write("Ingrese un numero: ");
        int N = int.Parse(Console.ReadLine());

        int[] vector = new int[N];
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            vector[i] = random.Next(1, 60);

        }
        Console.WriteLine("Vector generado:");
        foreach (var num in vector)
        {
            Console.Write(num + " ");
        }

        Console.Write("\nIngrese un número para buscar en el vector: ");
        int numeroBuscado = int.Parse(Console.ReadLine());
        int indice = Array.IndexOf(vector, numeroBuscado);

        if (indice != -1)
        {
