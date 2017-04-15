using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011112243
{
    public class Sistema
    {
        Cliente[] cliente = new Cliente[50];
        Empleado[] empleado = new Empleado[50];
        Administrativo[] administrativo = new Administrativo[50];
        Tripulacion[] tripulacion = new Tripulacion[50];
        Bus[] bus = new Bus[50];
        Encomienda[] encomienda = new Encomienda[50];
        LugarViaje[] lugarviaje = new LugarViaje[50];
        TipoComprobante[] tipocomprobante = new TipoComprobante[50];
        TipoLugar[] tipolugar = new TipoLugar[50];
        TipoPago[] tipopago = new TipoPago[50];
        TipoTripulacion[] tipotripulacion = new TipoTripulacion[50];
        TipoViaje[] tipoviaje = new TipoViaje[50];
        Transporte[] transporte = new Transporte[50];
        Venta[] venta = new Venta[50];



        public void SeleccionarServicio()
        {
            Console.WriteLine("Seleccione el Servicio Deseado" + "\n 1: Transporte" + "\n 2:Encomienda" + "\n 3:Ingresar Empleado" + "\n 4:Ingresar Vehiculo" + "\n 5:Mostrar Relacion de Ventas");
            String seleccion = Console.ReadKey().ToString();
            switch (seleccion)
            {
                case "1":
                    Console.WriteLine("Servicio de Transporte Seleccionado");

                    break;

                case "2":
                    Console.WriteLine("Servicio de Encomienda Seleccionado");

                    break;

                case "3":
                    Console.WriteLine("Ingresar un Nuevo Empleado  Seleccionado");



                    break;


                case "4":
                    Console.WriteLine("Ingresar un Nuevo Vehiculo  Seleccionado");

                    break;

                case "5":
                    Console.WriteLine("Mostrar Relacion de Ventas  Seleccionado");

                    break;
            }

        }
        public void RealizarTransporte()
        {




        }

        public void RealizarEncomienda()
        {


        }

        public void IngresarVehiculo()
        {

        }

        public void IngresarEmpleado()
        {

        }


        public void MostrarVentas()
        {
            for (int i = 0; i < 50; i++)
            {
                if (venta[0].idVenta == null)
                {
                    Console.WriteLine("No existen ventas");
                    Console.WriteLine("¿Volver al inicio?" + "\n [y/n]");

                    String seleccionar = Console.ReadKey().ToString();
                    if (seleccionar == "y")
                    {

                        SeleccionarServicio();
                    }
                }
                else if(venta[i].idVenta== null) {


                    Console.WriteLine("¿Volver al inicio?" + "\n [y/n]");

                   String seleccionar = Console.ReadKey().ToString();
                    if (seleccionar == "y")
                    {

                        SeleccionarServicio();
                    }
                }
                else
                {
                    Console.WriteLine("[i+1]");
                    Console.WriteLine("Codigo de Venta: " + venta[i].idVenta + "\n Tipo de Servicio: " + venta[i]._Servicio.tipoServicio + "\n Tipo de Pago: " + venta[i]._TipoPago.tipodePago + "\n Tipo de Comprobante: " + venta[i]._tipoComprobante.TipodeComprobante + "\n dni del cliente: " + venta[i]._Cliente.dni + "\n Nombre del Cliente: "
                        + venta[i]._Cliente.nom+ "\nEncargado de la venta"+ venta[i]._Administrativo.nom+ " "+ venta[i]._Administrativo.apePat+" " + venta[i]._Administrativo.apeMat + "\n Costo: "+venta[i].Costo);

                }

            }

        }
    }
}
