using System;
using System.Threading;

namespace Singleton
{
    public class SingletonClass
    {
        private static Lazy<SingletonClass> instance = new Lazy<SingletonClass>(() => new SingletonClass(), LazyThreadSafetyMode.ExecutionAndPublication);

        private SingletonClass()
        {}

        public static SingletonClass GetInstance()
        {
            return instance.Value;
        }
    }
}
