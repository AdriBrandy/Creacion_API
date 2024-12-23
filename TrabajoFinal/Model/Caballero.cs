namespace TrabajoFinal.Model
{
    public class Caballero : ISuperHero
    {
        public string Nombre { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;

        public Caballero(string nombre)
        {
            Nombre = nombre;
            PoderEspecial = "Hacha de Guerra";
            Fuerza = 5;
        }

        public string Atacar()
        {
            return $"{Nombre} usó su {PoderEspecial}";
        }

        public string Defender()
        {
            return $"{Nombre} se defendió con un escudo reforzado";
        }
    }
}
