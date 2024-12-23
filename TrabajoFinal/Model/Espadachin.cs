namespace TrabajoFinal.Model
{
    public class Espadachin : ISuperHero
    {
        public string Nombre { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;

        public Espadachin(string nombre)
        {
            Nombre = nombre;
            PoderEspecial = "Espada Escalibur";
            Fuerza = 8;
        }

        public string Atacar()
        {
            return $"{Nombre} usó {PoderEspecial}";
        }

        public string Defender()
        {
            return $"{Nombre} esquivó el ataque";
        }
    }
}
