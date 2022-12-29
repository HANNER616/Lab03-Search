using System.Diagnostics;
namespace Lab03_Search;

class EjercicioFinal
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int countSuccess = 0;
        int countFail = 0;
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 201);
        }

        foreach (int n in array)
        {
            Console.Write(n + ",");
        }
        Console.WriteLine("");

        for (int i = 0; i < 50; i++)
        {
            int numAleatorio = random.Next(1, 201);
            if (busquedaSecuencial(array, numAleatorio) >= 0)
            {
                countSuccess++;
            }
            else
            {
                countFail++;
            }

        }

        Console.WriteLine("Numero de busquedas exitosas:" + countSuccess);
        Console.WriteLine("Numero de busquedas fallidas:" + countFail);

        Console.WriteLine("Porcentaje de exito:" + (countSuccess * 100) / 50 + "%");
        Console.WriteLine("Porcentaje de fallo:" + (countFail * 100) / 50 + "%");

        Array.Sort(array);
        Console.WriteLine("Arreglo ordenado:");
        foreach (int n in array)
        {
            Console.Write(n + ",");
        }
        Console.WriteLine("");
    }
    public static int busquedaSecuencial(int[] list, int searchValue)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] == searchValue)
            {
                return i;
            }
        }
        return -1;
    }
}
