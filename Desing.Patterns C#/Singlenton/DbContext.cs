using System;
using System.Collections.Generic;
using System.Text;

namespace Singlenton
{
    public class DbContext
    {
        private static DbContext instance { get; set; }

        private DbContext()
        {

        }

        public static DbContext GetInstances()
        {
            return (instance ?? new DbContext()); 
        }

        public void ConnectDb()
        {
            Console.WriteLine("Connecting....");
        }

        public void Disconnect()
        {
            Console.WriteLine("disconnecting.....");
        }
    }
}
