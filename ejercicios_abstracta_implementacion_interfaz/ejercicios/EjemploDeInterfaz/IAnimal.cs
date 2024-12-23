namespace ejercicios.EjemploDeInterfaz
{
   
    public interface IAnimal
    {
        public string HacerSonido();

        public string Caminar()
        {
            return "El animal Camino";
        }
    }
}
