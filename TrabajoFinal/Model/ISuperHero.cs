namespace TrabajoFinal.Model
{
    public interface ISuperHero
    {
        string Nombre { get; set; }
        string PoderEspecial { get; set; }
        int Fuerza { get; set; }
        int Salud { get; set; }

        string Atacar();
        string Defender();
    }
}
