namespace SingletonThreadSafe
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static readonly object _lock = new object();
        private static Singleton _instance = null;

        public static Singleton getInstance()
        {
            lock (_lock)
            {

                if (_instance == null)
                {
                    _instance = new Singleton();
                }


            }
            return _instance;
        }
    }
}