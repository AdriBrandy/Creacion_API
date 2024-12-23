namespace ejercicios.EjemploDeHerencia
{

    public class Perro : Animal
    {
        public string Raza { get; set; }


        public override string HacerSonido()
        {
            return "El perro ladró";
        }

    }
}
