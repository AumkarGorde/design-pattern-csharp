using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        public static Singleton _instance { get; set; }
        private Guid _guid;
        public static readonly object lockObject = new object();
        private Singleton()
        {
            _guid = Guid.NewGuid();
        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                lock (lockObject)
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public void Show()
        {
            Console.WriteLine($"The instance id is : {_guid} ");
        }
    }

    /*Points missed
        1. Writting of GetInstance Method
        2. The instance creation Method and instance property should be static
        3. Writing of lock object.
    */
}
