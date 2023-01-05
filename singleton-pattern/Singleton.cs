namespace singleton_pattern
{
    public sealed class Singleton
    {
        private Singleton()
        {

        }

        private static Singleton? _instance;

        private static readonly object _lock = new();

        public static Singleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new Singleton
                        {
                            // This is here for test purposes
                            Value = value
                        };
                }
            }

            return _instance;
        }

        public string Value { get; set; } = new ("");
    }
}
