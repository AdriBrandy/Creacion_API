namespace TrabajoFinal.Model
{
    public class Enfermeria
    {
        private static Enfermeria _instance = new Enfermeria();
        private int _visitsAvailable = 5;
        private Enfermeria()
        {

        }
        public static Enfermeria Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool CurarSuperHeroe(ref int salud)
        {
            if (_visitsAvailable > 0 && salud < 5)
            {
                _visitsAvailable--;
                salud++;
                return true;
            }
            return false;
        }
    }
}
