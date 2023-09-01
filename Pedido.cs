public enum EstadoPedido{
    Entregado,
    Pendiente
}

namespace Pedido
{
    using Cliente;
    public class Pedido
    {
        private int nro;
        private string? obs;
        private Cliente? cliente;
        private EstadoPedido estado;


        public int Nro { get => nro; set => nro = value; }
        public string? Obs { get => obs; set => obs = value; }
        public Cliente? Cliente { get => cliente; set => cliente = value; }
        public EstadoPedido Estado { get => estado; set => estado = value; }

        public Pedido(int nro, string obs, string nombreCliente, string dirCliente, int telCliente, string RefDirCliente){
            this.Nro = nro;
            this.Obs = obs;
            this.Estado = EstadoPedido.Pendiente;
            this.cliente = new Cliente(nombreCliente, dirCliente, telCliente, RefDirCliente);
        }
        public Pedido(){}
        public void VerDatosCliente(Cliente cliente)
        {
            Console.WriteLine("===Datos del cliente===");
            Console.WriteLine($"Nombre: {cliente.Nombre}");
            Console.WriteLine($"Direccion: {cliente.Dir}");
            Console.WriteLine($"Tel: {cliente.Tel}");
            Console.WriteLine($"Ref. Direccion: {cliente.RefDir}");
        }

        public void Entregado()
        {
            Estado = EstadoPedido.Entregado;
        }
    }
    
}