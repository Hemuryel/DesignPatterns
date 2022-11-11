namespace DDGofSingleton
{
    public class ExemploSingleton
    {
        private static ExemploSingleton instance = null;

        private ExemploSingleton()
        {

        }

        public static ExemploSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new ExemploSingleton();
            }

            return instance;
        }
    }
}