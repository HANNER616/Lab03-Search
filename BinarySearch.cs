using System.Diagnostics;
namespace Lab03_Search;
class BinarySearch
{
    static void MainTemp2(string[] args)
    {
      Stopwatch cronometro = new Stopwatch();  
      int[] A = new int[] { 3, 8, 6, 9, 43, 12, 23,11, 18, 93, 34, 35,73,22,44,66,55,59,91,21 };
      int n= A.Length;
      int num=0;

      Console.WriteLine("El arreglo desordenado es:");
      for(int i=0 ; i<n; i++){
            Console.Write("A[" +i + "]=" + A[i] +",");
        }
        Console.WriteLine("");

        Array.Sort(A);
        Console.WriteLine("El arreglo ordenado es:");

        for(int i=0 ; i<n; i++){
            Console.Write("A[" +i + "]=" + A[i] +",");
        }
        Console.WriteLine("");
        Console.WriteLine("Ingrese el elemento a buscar:");
        num=int.Parse(Console.ReadLine());
        cronometro.Start();
        int posicionEncontrada = busquedaBinaria(A,n,num);
        Console.WriteLine("Elemento encontrado en posicion: " + posicionEncontrada);
        cronometro.Stop();
        TimeSpan tiempoTranscurrido = cronometro.Elapsed;
        double tiempoEnMilisegundos = tiempoTranscurrido.TotalMilliseconds;
        Console.WriteLine("Tiempo transcurrido: " + tiempoEnMilisegundos + "ms");
    }
    static int busquedaBinaria(int[] lista, int n, int clave){
        int central, bajo=0 , alto=n-1;
        int valorCentral;
        while(bajo<=alto){
            central = (bajo+alto) /2;
            //indice de elemento central
            valorCentral = lista[central];
            //valor de indice central
            if(lista[central]==clave){
                return central;
            }else if(clave<lista[central]){
                alto=central-1;
            }else{
                bajo=central +1;
            }
        }
        return -1;
        //elemento no encontrado
    }
    static int BusquedaBinariaa(int[] lista, int n, int clave){
        int central=-1, bajo=0 , alto=n-1;
        bool encontrado = false;

        while((bajo<=alto)&&(!encontrado)){
            central = (bajo+alto) /2;
            if(lista[central]==clave){
                encontrado=true;
            }else if(clave<lista[central]){
                alto=central-1;
            }else{
                bajo=central+1;
            }
        }
        return encontrado ? central : -1;
    } 
}
