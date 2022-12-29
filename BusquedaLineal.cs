using System.Diagnostics;

namespace Lab03_Search;

class BusquedaLineal
{
    static void MainTemp(string[] args)
    {
        Stopwatch cronometro = new Stopwatch();
        int[] A = new int[] { 3, 8, 6, 9, 43, 12, 23,11, 18, 93, 34, 35,73,22,44,66,55,59,91,21 };
        int n = A.Length;
        int num = 0;
        Console.WriteLine("Arreglo desordenado: ");
        for(int i=0 ; i<n; i++){
            Console.Write("A[" +i + "]=" + A[i] +",");
        }
        Console.WriteLine("");
        Console.WriteLine("Ingrese el elemento a buscar:");
        num=int.Parse(Console.ReadLine());
        cronometro.Start();
        float posicionEncontrada = (BusquedaLinealID(A,n,num))+1;
        Console.WriteLine("Elemento encontrada en posicion: " + posicionEncontrada);
        cronometro.Stop();
        TimeSpan tiempoTranscurrido = cronometro.Elapsed;
        double tiempoEnMilisegundos = tiempoTranscurrido.TotalMilliseconds;
        Console.WriteLine("Tiempo transcurrido: " + tiempoEnMilisegundos + "ms");
    }
    static int BusquedaLinealID(int[] A, int n, float clave){
        int i;
        for(i=0; i<n;i++){
            if(A[i]==clave){
                return i;
            }
        }
        return -1;
    }
}
