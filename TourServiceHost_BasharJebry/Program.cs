using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TourServiceHost_BasharJebry
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(FinalExam_BasharJebry.TourService_Bashar)))
            {
                host.Open();

                Console.WriteLine("PROG32356 Final Take Home Exam by Bashar Jebry, 991504502");
                Console.WriteLine("Service has started at: " + DateTime.Now);
                Console.ReadLine();

            }
        }
    }
}
