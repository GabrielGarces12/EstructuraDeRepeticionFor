
namespace EstructuraDeRepeticionFor.Class
{
    internal class Imprimir
    {
        public void NumerosMayorIgualMil()
        {
            int contador = 0;

            Console.WriteLine("Introduce la cantidad de numeros a calcular: ");


            try
            {

                int cantNumero = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < cantNumero; i++)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    int numeroIngresado = Convert.ToInt32(Console.ReadLine());


                    if (numeroIngresado >= 1000)
                    {
                        contador++;
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error: {ex.Message} ");
            }

            Console.WriteLine($"La cantidad de numeros mayores o igual a mil: {contador} ");

            Console.Read();

        }


        public void MedidaTriangulo()
        {
            int contadorMayorDoce = 0;

            Console.WriteLine("Introduzca la cantidad de tringulos a calcular: ");

            try
            {
                int cantidadTringulos = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < cantidadTringulos; i++)
                {
                    Console.WriteLine("Ingrese la base de el tringulo: ");
                    float baseTriangulo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura de el triangulo: ");
                    float alturaTriangulo = Convert.ToInt32(Console.ReadLine());

                    float resultado = (baseTriangulo * alturaTriangulo) / 2;

                    if (resultado > 12)
                    {
                        contadorMayorDoce++;
                    }

                    Console.WriteLine($"La base de este triangulo es: {baseTriangulo}");
                    Console.WriteLine($"La altura de este triangulo es: {alturaTriangulo}");
                    Console.WriteLine($"La superficie o area de este triangulo es: {resultado} \n\n");


                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Ha ocurrido un error: {e.Message}");
            }

            Console.WriteLine($"La cantidad de triangulos mayores a doce: {contadorMayorDoce}");
        }
        public void TablaDeMultiplicar()
        {
            Console.WriteLine("Tabla de multiplicar del 5");
            int numero = 5;

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;

                Console.WriteLine($"5 x { i } = { resultado }" );
            }

        }
    }
}
