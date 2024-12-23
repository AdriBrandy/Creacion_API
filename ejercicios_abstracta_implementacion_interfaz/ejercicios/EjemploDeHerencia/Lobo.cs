namespace ejercicios.EjemploDeHerencia
{

    public class Lobo : Animal
    {

        public string Raza { get; set; }
        
        public override string HacerSonido()
        {
            return "El lobo aulló";
        }
    }
}
