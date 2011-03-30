using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoBugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InstanceConfig.LoadSettings();
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine(e.StackTrace);
                    Console.ReadLine();
                }
                throw;
            }
            
            
        }
    }
}
