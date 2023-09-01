namespace Cliente
{
    public class Cliente
    {
        private string? nombre;
        private string? dir;
        private int tel;
        private string? refDir;


        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Dir { get => dir; set => dir = value; }
        public int Tel { get => tel; set => tel = value; }
        public string? RefDir { get => RefDir; set => RefDir = value; }

        public Cliente(string? nombre, string? dir, int tel, string? refDir)
        {
            Nombre = nombre;
            Dir = dir;
            Tel = tel;
            RefDir = refDir;
        }
    }
}