namespace ejercicios.EjemploDeHerencia
{
    public class Animal
    {

        public int Edad { get; set; }
        private int Peso { get; set; }

        public Animal()
        {
            this.Peso = 1;
        }

        public Animal(int peso)
        {
            this.Peso = 15;
        }


        public int devolverPeso()
        {
            return this.Peso;
        }

        public string Caminar()
        {
            return "El animal caminó";
        }

        public virtual string HacerSonido()
        {
            return "El animal hizo un sonido";
        }
    }
}
