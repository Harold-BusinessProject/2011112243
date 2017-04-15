using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011112243
{
    public class Sistema
    {
        Cliente[] cliente = new Cliente[150];
        Empleado[] empleado = new Empleado[150];
        Administrativo[] administrativo = new Administrativo[150];
        Tripulacion[] tripulacion = new Tripulacion[150];
        Bus[] bus = new Bus[150];
        Encomienda[] encomienda = new Encomienda[150];
        LugarViaje[] lugarviaje = new LugarViaje[150];
        TipoComprobante[] tipocomprobante = new TipoComprobante[150];
        TipoLugar[] tipolugar = new TipoLugar[150];
        TipoPago[] tipopago = new TipoPago[150];
        TipoTripulacion[] tipotripulacion = new TipoTripulacion[150];
        TipoViaje[] tipoviaje = new TipoViaje[150];
        Transporte[] transporte = new Transporte[150];
        Venta[] venta = new Venta[150];



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
                    MostrarVentas();
                    break;
            }

        }
        public void RealizarTransporte()
        {
            for (int i = 0; i < 50; i++) {
                if (bus[i]._idBus == null)
                {

                    Random r = new Random();
                    int id = i;

                    Console.WriteLine("Ingrese los campos requeridos: \n");

                    Console.WriteLine("ID del Administrativo: ");
                    String idAdm = Console.ReadLine();
                    for (int j = 0; j < 50; j++) {
                        if (idAdm == venta[j]._Administrativo.idEmp)
                        {

                            Console.WriteLine("Nombre del CLiente: ");
                            venta[i]._Cliente.nom = Console.ReadLine();
                            Console.WriteLine("dni del CLiente: ");
                            venta[i]._Cliente.dni = Console.ReadLine();
                            Console.WriteLine("Direccion del CLiente: ");
                            venta[i]._Cliente.direccion = Console.ReadLine();
                            Console.WriteLine("Email del CLiente: ");
                            venta[i]._Cliente.email = Console.ReadLine();
                            Console.WriteLine("Origen de Transporte: ");
                            venta[i]._Servicio.Origen = Console.ReadLine();
                            Console.WriteLine("ID del Tripulante 1: ");
                            String idTripulante = Console.ReadLine();
                            for (int k = 0; k < 50; k++)
                            {
                                if (idTripulante == tripulacion[i].idEmp)
                                {
                                    Console.WriteLine("Estado de Tripulante 1");
                                    bus[k]._Tripulacion.estado = Console.ReadLine();
                                    Console.WriteLine("horas de Trabajo de Tripulante 1");
                                    bus[k]._Tripulacion.horasTrab = Console.ReadLine();
                                    Console.WriteLine("Tipo de Tripulacion de Tripulante 1 -Piloto  - Copiloto  -Azafata");
                                    bus[k]._Tripulacion._tipoTrip.tipodeTripulacion = Console.ReadLine();
                                }
                                else
                                {
                                    SeleccionarServicio();
                                }
                            }

                            Console.WriteLine("ID del Tripulante 2: ");
                            String idTripulante2 = Console.ReadLine();
                            for (int k = 0; k < 50; k++)
                            {
                                if (idTripulante == tripulacion[i].idEmp)
                                {
                                    Console.WriteLine("Estado de Tripulante 2");
                                    bus[k]._Tripulacion.estado = Console.ReadLine();
                                    Console.WriteLine("horas de Trabajo de Tripulante 2");
                                    bus[k]._Tripulacion.horasTrab = Console.ReadLine();
                                    Console.WriteLine("Tipo de Tripulacion de Tripulante 2 -Piloto  - Copiloto  -Azafata");
                                    bus[k]._Tripulacion._tipoTrip.tipodeTripulacion = Console.ReadLine();
                                }
                                else
                                {
                                    SeleccionarServicio();
                                }

                            }


                            Console.WriteLine("ID del Tripulante 3: ");
                            String idTripulante3 = Console.ReadLine();
                            for (int k = 0; k < 50; k++)
                            {
                                if (idTripulante == tripulacion[i].idEmp)
                                {
                                    Console.WriteLine("Estado de Tripulante 3");
                                    bus[k]._Tripulacion.estado = Console.ReadLine();
                                    Console.WriteLine("horas de Trabajo de Tripulante 3");
                                    bus[k]._Tripulacion.horasTrab = Console.ReadLine();
                                    Console.WriteLine("Tipo de Tripulacion de Tripulante 3 -Piloto  - Copiloto  -Azafata");
                                    bus[k]._Tripulacion._tipoTrip.tipodeTripulacion = Console.ReadLine();
                                }
                                else
                                {
                                    SeleccionarServicio();
                                }

                            }

                            Console.WriteLine("Tipo de Pago - Efectivo  -Tarjeta de Credito  -Tarjeta de Devito");
                            venta[j]._TipoPago.tipodePago = Console.ReadLine();
                            Console.WriteLine("Tipo de Comprobante -Boleta  -Factura");
                            venta[j]._tipoComprobante.TipodeComprobante = Console.ReadLine();
                            Console.WriteLine("Numero de Asientos");
                            transporte[i].nAsientos= Console.ReadLine();
                            transporte[i]._TipoViaje.tipoViaje = Console.ReadLine();

                            venta[i].idVenta = i.ToString();
                            venta[i]._Servicio.idServicio = i.ToString();
                            venta[i]._Servicio.tipoServicio = "Transpote";
                            venta[i].Costo = r.Next(50, 150);



                        }
                        else
                        {
                            SeleccionarServicio();

                        }

                        }
                    

                }



            }
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
                    Console.WriteLine("\n Codigo de Venta: " + venta[i].idVenta + "\n Tipo de Servicio: " + venta[i]._Servicio.tipoServicio + "\n Tipo de Pago: " + venta[i]._TipoPago.tipodePago + "\n Tipo de Comprobante: " + venta[i]._tipoComprobante.TipodeComprobante + "\n dni del cliente: " + venta[i]._Cliente.dni + "\n Nombre del Cliente: "
                        + venta[i]._Cliente.nom+ "\nEncargado de la venta"+ venta[i]._Administrativo.nom+ " "+ venta[i]._Administrativo.apePat+" " + venta[i]._Administrativo.apeMat + "\n Costo: "+venta[i].Costo);

                }

            }

        }
    }
}
