using System;

namespace Business.CCS
{
    public class DatabseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
