using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 30";

            BaseDatos FacturaUno = new BaseDatos("Franco", "4256-8011", "Caracas", "Buenos Aires", "1882", "27-37710062-5");
            BaseDatos FacturaUnoB = new BaseDatos(5, "Notebook", 14000);

            Console.WriteLine("DATOS DEL COMPRADOR\nNombre: " + FacturaUno.Nombre + "\nTelefono: " + FacturaUno.Telefono + "\nDireccion: " + FacturaUno.Direccion);
            Console.WriteLine("Ciudad: " + FacturaUno.Ciudad + "\nCodigo Postal: " + FacturaUno.CodPostal + "\nCUIT: " + FacturaUno.Cuit);

            Console.WriteLine("\nDATOS DEL PRODUCTO COMPRADO\nDescripcion: " + FacturaUnoB.Descripcion + "\nCantidad: " + FacturaUnoB.Cantidad + "\nPrecio Unitario: " + FacturaUnoB.PrecioUnit);

            Console.WriteLine("\nDETALLES DEL PRECIO E IMPUESTO\nBase Imponible: " + FacturaUnoB.Importe + "\nIVA: " + FacturaUnoB.Iva + "\nTotal a pagar: " + FacturaUnoB.TotalPagar);

            Console.ReadKey();
        }
    }
}
