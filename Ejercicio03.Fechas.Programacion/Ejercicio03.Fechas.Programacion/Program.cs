namespace Ejercicio03.Fechas.Programacion;

class Program
{

    public static void Main(string[] args)
    {

        DateTime fechaActual = DateTime.Now;
        Console.WriteLine(fechaActual.ToString());

        DateTime fechaModificada = DateTime.Now;


        fechaModificada = fechaModificada.AddDays(1).AddMonths(-24) ;
        Console.WriteLine(fechaModificada.ToString());


        Random rnd = new Random();
        int numeroAleatorio = rnd.Next(4);

        fechaModificada = fechaModificada.AddYears(numeroAleatorio);
        Console.WriteLine(fechaModificada.ToString());


        //Comparativa de las fechas
        if (fechaActual.CompareTo(fechaModificada) >0)
        {

            Console.WriteLine("El hoy es mas Grande: ");


        }

        else
        {
            Console.WriteLine("El hoy no es mas grande");
        }




    }


}