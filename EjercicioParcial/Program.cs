using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            char UltimaOpc;
            int i = 0, opc = 0;
            float cantCamisas = 0.0f, valorNoDescuento = 0.0f, valorConDescuentoDiez = 0.0f,valorConDescuentoVeinte=0.0f,auxPrecio=0.0f;
            float[] ArrayCamisas = new float[50];



            do
            {
                Console.WriteLine("Camisas PRABIT - Ventas minoristas y mayoristas\n-----------------------------------------------\nMENÚ PRINCIPAL:");
                Console.WriteLine("1- Añadir camisas al carro de compras\n2- Eleminar camisas del carro de compras\n3- Salir");
                opc = int.Parse(Console.ReadLine());


                switch (opc)
                {
                    case 1:
                        cargarCamisasCarro(ref ArrayCamisas, ref i, ref cantCamisas);
                        break;
                    //case 2:
                    //No puedo realizar lo que pide el programa.

                }


                Console.WriteLine("Candidad de camisas en el carro de compras: " + cantCamisas);
                Console.WriteLine("Precio unitario: $1000");

                //----VALORES EN PESOS
                if (cantCamisas < 3)
                {
                    Console.WriteLine("Usted realizo una compra menor a 3 camisas no se le aplica descuento");
                    PrecioSinDescuento(ref ArrayCamisas, ref i, ref cantCamisas, ref valorNoDescuento); //Muestra el precio total sin descuento
                }

                //----DESCUENTO DE 10%
                if (cantCamisas >= 3 && cantCamisas <= 5)
                {
                    Console.WriteLine("Usted realizo una compra mayor a 3 camisas, pero menor a 5.");
                    PrecioConDescuento_10(ref ArrayCamisas, ref i,ref auxPrecio, ref cantCamisas, ref valorConDescuentoDiez);
                }
                //----DESCUENTO DE 20%
                if(cantCamisas > 5)
                {
                    Console.WriteLine("Usted realizo una compra de una cantidad mayor a 5 camisas.");
                    PrecioConDescuento_20(ref ArrayCamisas, ref i,  ref auxPrecio,ref cantCamisas, ref cantCamisas, ref valorConDescuentoVeinte);
                }


            } while (opc != 3);

            if (opc == 3)
                Console.WriteLine("¿Esta seguro que desea salir?");
            UltimaOpc = Convert.ToChar(Console.ReadLine());
            Console.Clear();





            Console.ReadKey();
        }
        //-----SUBPROGRAMAS-----

        public static void cargarCamisasCarro(ref float[] ArrayCamisas, ref int i, ref float cantCamisas)
        {
            Console.WriteLine("Ingrese la cantidad de camisas: ");
            cantCamisas = int.Parse(Console.ReadLine());

            for (i = 0; i < cantCamisas; i++)
            {
                Console.WriteLine("Se agrego al carrito la camisa N° " + (i + 1) + " : ");
                ArrayCamisas[i] = ArrayCamisas[i] + 1;
                //ArrayCamisas[i] = Convert.ToSingle(Console.ReadLine());
            }

        }



        //----CAMISAS SIN DESCUENTO
        public static void PrecioSinDescuento(ref float[] ArrayCamisas, ref int i, ref float cantCamisas, ref float valorNoDescuento)
        {
            valorNoDescuento = cantCamisas * 1000;
            Console.WriteLine("Precio total sin descuento: " + valorNoDescuento);
            
        }

        //----- CAMISAS CON 10% DESCUENTO
        public static void PrecioConDescuento_10(ref float[] ArrayCamisas, ref int i, ref float auxPrecio, ref float cantCamisas, ref float valorConDescuentoDiez)
        {

            valorConDescuentoDiez = (10 * cantCamisas) / 100;
            valorConDescuentoDiez *= 1000;
            auxPrecio = cantCamisas * 1000;

            Console.WriteLine("Se aplico un descuento del %10");
            Console.WriteLine("El descuento que se aplica es de: $" + valorConDescuentoDiez);
            Console.WriteLine("Precio final con descuento: $" + (auxPrecio - valorConDescuentoDiez));

        }

        //----- CAMISAS CON 20% DESCUENTO
        
       public static void PrecioConDescuento_20(ref float[] ArrayCamisas, ref int i, ref float cantCamisas,ref float auxPrecio, ref float valorNoDescuento, ref float valorConDescuentoVeinte)
        {
            valorConDescuentoVeinte = (20 * cantCamisas) / 100;
            valorConDescuentoVeinte *= 1000;
            auxPrecio = cantCamisas * 1000;

            Console.WriteLine("Se aplico un descuento del %20");
            Console.WriteLine("El decuento que se aplica es de: $" + valorConDescuentoVeinte);
            Console.WriteLine("Precio final con descuento: $" + (auxPrecio - valorConDescuentoVeinte));
        }
     

    }
}



/*
 a) La pantalla principal debe mostrar siempre el menú de opciones y los datos de la
compra. Cuando agregue o quite camisas del carrito de compras, se deben ir
actualizando los datos de la compra (aplicando descuento según corresponda)
b) La pantalla principal debe ser similar a la siguiente:
 * Debajo del menú de opciones deben mostrarse los siguientes datos:
- Cantidad de camisas en el carro de compras: <cantidad>
- Precio unitario: $1000
- Precio total sin descuento: $<precio>
- Tipo de descuento aplicado: %<porcentaje aplicado>
- Precio final con descuento: $<precio>
d) Se debe poder agregar camisas al carro de compras
e) Se debe poder eliminar camisas del carro de compras
f) Si compra de tres a cinco camisas, el descuento es del 10% sobre el total de la compra.
g) Si compra más de cinco camisas el descuento es del %20 sobre el total de la compra.
h) Si selecciona la opción “3- Salir”, debe limpiarse la pantalla y mostrar un mensaje que
diga: “¿Está seguro que desea salir? S/N”. Si presiona “S” debe cerrar el programa. Si
presiona “N” debe ingresar nuevamente a la pantalla principal.
*/
