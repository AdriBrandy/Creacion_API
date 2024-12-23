namespace TrabajoFinal.Model
{
    public class Guerrero : ISuperHero
    {
        public string Nombre { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;

        public Guerrero(string nombre)
        {
            Nombre = nombre;
            PoderEspecial = "Hacha Pesada";
            Fuerza = 6;
        }

        public string Atacar()
        {
            return $"{Nombre} atacó con {PoderEspecial}";
        }

        public string Defender()
        {
            return $"{Nombre} usó su escudo";
        }
    }
}