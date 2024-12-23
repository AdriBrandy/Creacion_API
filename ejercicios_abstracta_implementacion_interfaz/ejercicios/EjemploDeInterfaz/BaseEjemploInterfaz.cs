namespace ejercicios.EjemploDeInterfaz
{
    public class BaseEjemploInterfaz
    {
        
        public string HacerSonido(IAnimal animal)
        {
            return animal.HacerSonido();
        }
    }
}
