namespace Cadete
{
    using Pedido;

    public class Cadete
    {
        private int id;
        private string? nombre;
        private string? dir;
        private int tel;
        private List<Pedido>? pedidos;
        private int cantPedAsignados;
        private int cantPedEntregados;


        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Dir { get => dir; set => dir = value; }
        public int Tel { get => tel; set => tel = value; }
        public List<Pedido>? Pedidos { get => pedidos; set => pedidos = value; }
        public int CantPedAsignados { get => cantPedAsignados; set => cantPedAsignados = value; }
        public int CantPedEntregados { get => cantPedEntregados; set => cantPedEntregados = value; }

        public Cadete(int id, string? nombre, string? dir, int tel)
        {
            Id = id;
            Nombre = nombre;
            Dir = dir;
            Tel = tel;
            Pedidos = new List<Pedido>();
            CantPedAsignados = 0;
            CantPedEntregados = 0;
        }
        public Cadete(string? id, string? nombre, string? dir, int tel)
        {
            Id = Convert.ToInt32(id);
            Nombre = nombre;
            Dir = dir;
            Tel = tel;
            Pedidos = new List<Pedido>();
            CantPedAsignados = 0;
            CantPedEntregados = 0;
        }

        public void AgregarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
            cantPedAsignados++;
        }

        public bool CambiarEstadoPedido(int nro)
        {
            if (pedidos.Any(Pedido => Pedido.Nro == nro))
            {
                foreach(var p in pedidos){
                    if(p.Nro == nro){
                        p.Entregado();
                        cantPedEntregados++;
                        return true;
                    }
                }
            }
            Console.WriteLine("El pedido no existe");
            return false;
        }
    
        public void EliminarPedido(int nro)
        {
            if (pedidos.Any(Pedido => Pedido.Nro == nro))
            {
                pedidos.RemoveAll(Pedido => Pedido.Nro == nro);
            }else{
                Console.WriteLine("El pedido no existe");
            }
        }
        public Pedido QuitarPedido(int nro)
        {
            Pedido pedidoAQuitar = pedidos.Find(p => p.Nro == nro);
            if(pedidoAQuitar != null){
                pedidos.Remove(pedidoAQuitar);
            }
            return pedidoAQuitar;
        }
        public int JornalACobrar()
        {
            return(500 * CantPedEntregados);
        }
    }
}
