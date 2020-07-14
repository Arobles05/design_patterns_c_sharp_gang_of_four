using System;

namespace Singlenton
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext obj = DbContext.GetInstances();
            obj.ConnectDb();

            obj.Disconnect();
        }
    }
}
