namespace TrabajoFinal.Model
{
    public static class SuperHeroFactory
    {
        public static ISuperHero CrearSuperHeroe(string nombre, string tipo)
        {
            return tipo.ToLower() switch
            {
                "caballero" => new Caballero(nombre),
                "espadachin" => new Espadachin(nombre),
                "guerrero" => new Guerrero(nombre),
                _ => throw new ArgumentException("Tipo de héroe incompatible."),
            };

        }
    }
}
