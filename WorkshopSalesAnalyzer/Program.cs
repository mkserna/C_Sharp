using System;
using System.Collections.Generic;
using System.Linq;

public class Venta
{
    public Guid Id { get; set; } // Tipo especial para ID
    public DateTime FechaDeVenta { get; set; }
    public decimal ValorProducto { get; set; }
    public int CantidadDeProductos { get; set; }
    public string Vendedor { get; set; }
    public string Comprador { get; set; }
    public int TiempoGarantia { get; set; } // En meses

    public Venta(DateTime fechaDeVenta, decimal valorProducto, int cantidadDeProductos, string vendedor, string comprador, int tiempoGarantia)
    {
        Id = Guid.NewGuid();
        FechaDeVenta = fechaDeVenta;
        ValorProducto = valorProducto;
        CantidadDeProductos = cantidadDeProductos;
        Vendedor = vendedor;
        Comprador = comprador;
        TiempoGarantia = tiempoGarantia;
    }

    public decimal CalcularValorTotal()
    {
        return ValorProducto * CantidadDeProductos;
    }
}

public class Program
{
    static List<Venta> ventas = new List<Venta>();

    public static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Registrar nueva venta");
            Console.WriteLine("2. Calcular valor total de una venta específica");
            Console.WriteLine("3. Calcular promedio de ventas diarias");
            Console.WriteLine("4. Mostrar empleado del mes");
            Console.WriteLine("5. Mostrar cliente del mes");
            Console.WriteLine("6. Filtrar ventas por fecha");
            Console.WriteLine("7. Seleccionar vendedores por valor de venta");
            Console.WriteLine("8. Agrupar ventas por mes");
            Console.WriteLine("9. Encontrar vendedor con más ventas en un período");
            Console.WriteLine("10. Ordenar ventas por valor total");
            Console.WriteLine("11. Encontrar productos más vendidos en un año");
            Console.WriteLine("12. Validar existencia de venta por valor");
            Console.WriteLine("13. Buscar ventas por cliente");
            Console.WriteLine("14. Calcular total de ventas por vendedor");
            Console.WriteLine("15. Encontrar mes con más ventas");
            Console.WriteLine("16. Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarVenta();
                    break;
                case 2:
                    CalcularValorTotalVenta();
                    break;
                case 3:
                    CalcularPromedioVentasDiarias();
                    break;
                case 4:
                    MostrarEmpleadoDelMes();
                    break;
                case 5:
                    MostrarClienteDelMes();
                    break;
                case 6:
                    FiltrarVentasPorFecha();
                    break;
                case 7:
                    SeleccionarVendedoresPorValor();
                    break;
                case 8:
                    AgruparVentasPorMes();
                    break;
                case 9:
                    EncontrarVendedorConMasVentasEnPeriodo();
                    break;
                case 10:
                    OrdenarVentasPorValorTotal();
                    break;
                case 11:
                    EncontrarProductosMasVendidosEnAnio();
                    break;
                case 12:
                    ValidarExistenciaDeVentaPorValor();
                    break;
                case 13:
                    BuscarVentasPorCliente();
                    break;
                case 14:
                    CalcularTotalDeVentasPorVendedor();
                    break;
                case 15:
                    EncontrarMesConMasVentas();
                    break;
                case 16:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    static void MostrarClienteDelMes()
    {
        var clienteDelMes = ventas
            .GroupBy(v => v.Comprador)
            .OrderByDescending(g => g.Sum(v => v.CalcularValorTotal()))
            .FirstOrDefault();

        if (clienteDelMes != null)
        {
            Console.WriteLine($"Cliente del mes: {clienteDelMes.Key} con un total de compras de {clienteDelMes.Sum(v => v.CalcularValorTotal())}");
        }
        else
        {
            Console.WriteLine("No hay ventas registradas.");
        }
    }

    static void EncontrarMesConMasVentas()
    {
        var mesConMasVentas = ventas
            .GroupBy(v => new { v.FechaDeVenta.Year, v.FechaDeVenta.Month })
            .OrderByDescending(g => g.Count())
            .FirstOrDefault();

        if (mesConMasVentas != null)
        {
            Console.WriteLine($"Mes con más ventas: {mesConMasVentas.Key.Month}/{mesConMasVentas.Key.Year} con un total de {mesConMasVentas.Count()} ventas");
            foreach (var venta in mesConMasVentas)
            {
                Console.WriteLine($"ID: {venta.Id}, Fecha: {venta.FechaDeVenta}, Vendedor: {venta.Vendedor}, Comprador: {venta.Comprador}, Valor Total: {venta.CalcularValorTotal()}");
            }
        }
        else
        {
            Console.WriteLine("No hay ventas registradas.");
        }
    }


    static void CalcularTotalDeVentasPorVendedor()
    {
        var ventasPorVendedor = ventas
            .GroupBy(v => v.Vendedor)
            .Select(g => new
            {
                Vendedor = g.Key,
                TotalVentas = g.Sum(v => v.CalcularValorTotal()),
                PromedioVentas = g.Average(v => v.CalcularValorTotal())
            });

        foreach (var vendedor in ventasPorVendedor)
        {
            Console.WriteLine($"Vendedor: {vendedor.Vendedor}, Total de Ventas: {vendedor.TotalVentas}, Promedio de Ventas: {vendedor.PromedioVentas}");
        }
    }
    static void BuscarVentasPorCliente()
    {
        Console.WriteLine("Ingrese el nombre del cliente: ");
        string cliente = Console.ReadLine();

        var ventasCliente = ventas.Where(v => v.Comprador.Equals(cliente, StringComparison.OrdinalIgnoreCase));
        foreach (var venta in ventasCliente)
        {
            Console.WriteLine($"ID: {venta.Id}, Fecha: {venta.FechaDeVenta}, Vendedor: {venta.Vendedor}, Valor Total: {venta.CalcularValorTotal()}");
        }
    }
    static void ValidarExistenciaDeVentaPorValor()
    {
        Console.WriteLine("Ingrese el valor específico de la venta: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        var existeVenta = ventas.Any(v => v.CalcularValorTotal() == valor);
        if (existeVenta)
        {
            Console.WriteLine("Existe una venta con el valor especificado.");
        }
        else
        {
            Console.WriteLine("No existe ninguna venta con el valor especificado.");
        }
    }
    static void EncontrarProductosMasVendidosEnAnio()
    {
        Console.WriteLine("Ingrese el año: ");
        int año = int.Parse(Console.ReadLine());

        var productosMasVendidos = ventas
            .Where(v => v.FechaDeVenta.Year == año)
            .GroupBy(v => v.ValorProducto)
            .OrderByDescending(g => g.Sum(v => v.CantidadDeProductos))
            .FirstOrDefault();

        if (productosMasVendidos != null)
        {
            Console.WriteLine($"Producto más vendido: {productosMasVendidos.Key} con un total de {productosMasVendidos.Sum(v => v.CantidadDeProductos)} unidades vendidas");
        }
        else
        {
            Console.WriteLine("No hay ventas en el año especificado.");
        }
    }
    static void OrdenarVentasPorValorTotal()
    {
        Console.WriteLine("Ingrese el número de ventas a mostrar: ");
        int n = int.Parse(Console.ReadLine());

        var ventasOrdenadas = ventas
            .OrderByDescending(v => v.CalcularValorTotal())
            .Take(n);

        foreach (var venta in ventasOrdenadas)
        {
            Console.WriteLine($"ID: {venta.Id}, Fecha: {venta.FechaDeVenta}, Vendedor: {venta.Vendedor}, Comprador: {venta.Comprador}, Valor Total: {venta.CalcularValorTotal()}");
        }
    }
    static void EncontrarVendedorConMasVentasEnPeriodo()
    {
        Console.WriteLine("Ingrese la fecha de inicio (yyyy-MM-dd): ");
        DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la fecha de fin (yyyy-MM-dd): ");
        DateTime fechaFin = DateTime.Parse(Console.ReadLine());

        var vendedorConMasVentas = ventas
            .Where(v => v.FechaDeVenta >= fechaInicio && v.FechaDeVenta <= fechaFin)
            .GroupBy(v => v.Vendedor)
            .OrderByDescending(g => g.Count())
            .FirstOrDefault();

        if (vendedorConMasVentas != null)
        {
            Console.WriteLine($"Vendedor con más ventas: {vendedorConMasVentas.Key} con un total de {vendedorConMasVentas.Count()} ventas");
        }
        else
        {
            Console.WriteLine("No hay ventas en el período especificado.");
        }
    }
    static void AgruparVentasPorMes()
    {
        var ventasPorMes = ventas
            .GroupBy(v => new { v.FechaDeVenta.Year, v.FechaDeVenta.Month })
            .Select(g => new
            {
                Año = g.Key.Year,
                Mes = g.Key.Month,
                TotalVentas = g.Sum(v => v.CalcularValorTotal())
            });

        foreach (var mes in ventasPorMes)
        {
            Console.WriteLine($"Año: {mes.Año}, Mes: {mes.Mes}, Total de Ventas: {mes.TotalVentas}");
        }
    }
    static void SeleccionarVendedoresPorValor()
    {
        Console.WriteLine("Ingrese el valor mínimo de ventas: ");
        decimal valorMinimo = decimal.Parse(Console.ReadLine());
        var vendedores = ventas
            .Where(v => v.CalcularValorTotal() > valorMinimo)
            .Select(v => v.Vendedor)
            .Distinct();
        foreach (var vendedor in vendedores)
        {
            Console.WriteLine(vendedor);
        }
    }



    static void RegistrarVenta()
    {
        Console.WriteLine("Fecha de venta (yyyy-MM-dd): ");
        DateTime fecha = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Valor del producto: ");
        decimal valor = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Cantidad de productos: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.WriteLine("Vendedor: ");
        string vendedor = Console.ReadLine();
        Console.WriteLine("Comprador: ");
        string comprador = Console.ReadLine();
        Console.WriteLine("Tiempo de garantía (meses): ");
        int garantia = int.Parse(Console.ReadLine());

        Venta nuevaVenta = new Venta(fecha, valor, cantidad, vendedor, comprador, garantia);
        ventas.Add(nuevaVenta);
        Console.WriteLine("Venta registrada con éxito");
    }

    static void CalcularValorTotalVenta()
    {
        Console.WriteLine("ID de la venta: ");
        Guid id = Guid.Parse(Console.ReadLine());
        Venta venta = ventas.FirstOrDefault(v => v.Id == id);
        if (venta != null)
        {
            Console.WriteLine($"Valor total de la venta: {venta.CalcularValorTotal()}");
        }
        else
        {
            Console.WriteLine("Venta no encontrada");
        }
    }

    static void CalcularPromedioVentasDiarias()
    {
        var promedio = ventas
            .GroupBy(v => v.FechaDeVenta.Date)
            .Select(g => g.Sum(v => v.CalcularValorTotal()))
            .Average();
        Console.WriteLine($"Promedio de ventas diarias: {promedio}");
    }

    static void MostrarEmpleadoDelMes()
    {
        var empleadoDelMes = ventas
            .GroupBy(v => v.Vendedor)
            .OrderByDescending(g => g.Sum(v => v.CalcularValorTotal()))
            .FirstOrDefault();
        if (empleadoDelMes != null)
        {
            Console.WriteLine($"Empleado del mes: {empleadoDelMes.Key} con un total de ventas de {empleadoDelMes.Sum(v => v.CalcularValorTotal())}");
        }
        else
        {
            Console.WriteLine("No hay ventas registradas.");
        }
    }

    static void FiltrarVentasPorFecha()
    {
        Console.WriteLine("Ingrese la fecha (yyyy-MM-dd) para filtrar las ventas posteriores: ");
        DateTime fecha = DateTime.Parse(Console.ReadLine());
        var ventasFiltradas = ventas.Where(v => v.FechaDeVenta > fecha);
        foreach (var venta in ventasFiltradas)
        {
            Console.WriteLine($"ID: {venta.Id}, Fecha: {venta.FechaDeVenta}, Vendedor: {venta.Vendedor}, Comprador: {venta.Comprador}, Valor Total: {venta.CalcularValorTotal()}");
        }
    }

}

