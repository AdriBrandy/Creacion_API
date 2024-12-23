namespace ejercicios.EjemploDeInterfaz
{
    public class Lobo : IAnimal
    {
        public string HacerSonido()
        {
            return "El lobo aulló";
        }

 
        public string Caminar()
        {
            throw new NotImplementedException();
        }
    }
}
