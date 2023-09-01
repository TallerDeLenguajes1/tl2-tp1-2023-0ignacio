namespace Cadeteria
{
    using Cadete;
    using Pedido;
    public class Cadeteria
    {
        private string? nombre;
        private int tel;
        private List<Cadete> cadetes;

        public string? Nombre { get => nombre; set => nombre = value; }
        public int Tel { get => tel; set => tel = value; }
        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

        public Cadeteria(){}

        public Cadeteria(string? nombre, int tel, List<Cadete> cadetes)
        {
            Nombre = nombre;
            Tel = tel;
        }

        public void AgregarListaCadetes(List<Cadete> cadetes){
            this.Cadetes = cadetes;
        }

        public Pedido DarAltaPedido(int nro){
            string nombreCliente = "", dirCliente = "", telCliente = "", RefDirCliente = "";
            string obsPedido = "";
            Console.WriteLine("\n$========= DATOS DEL CLIENTE ==========\n");
            Console.Write("> Nombre:");
            nombreCliente = Console.ReadLine();
            Console.Write("> Dirección: ");
            direccionCliente = Console.ReadLine();
            Console.Write("> Teléfono: ");
            telCliente = Console.ReadLine();
            Console.Write("> Datos de referencia de su dirección: ");
            datosReferenciaDireccionCliente = Console.ReadLine();
            Console.Write("\n> OBSERVACIONES SOBRE EL PEDIDO: ");
            obsPedido = Console.ReadLine();
            Pedido ped = new Pedido(nro, obsPedido, nombreCliente, dirCliente, telCliente, RefDirCliente);

            return ped;
    }
    }
}