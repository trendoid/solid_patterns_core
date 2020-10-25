using System;

namespace SolidPatternsCore.Patterns
{
    public class SingletonClass : IDisposable
    {
        private bool _disposed;
        private static volatile SingletonClass _instance;
        private static readonly object _syncLock = new object();
        private SingletonClass()
        {
        }

        public static SingletonClass Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClass();
                    }
                }
                return _instance;
            }
        }

        public int SomeValue { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _instance = null;
            }
            _disposed = true;
        }

    }

}