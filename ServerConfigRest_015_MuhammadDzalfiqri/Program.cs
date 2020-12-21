using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceRest_015_Muhammad_Dzalfiqri;

namespace ServerConfigRest_015_MuhammadDzalfiqri
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObject = null;

            try
            {
                hostObject = new ServiceHost(typeof(TI_UMY));
                hostObject.Open();
                Console.WriteLine("Server is Ready..");
                Console.ReadLine();
                hostObject.Close();
            }catch(Exception ex)
            {
                hostObject = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
