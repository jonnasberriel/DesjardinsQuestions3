using DesjardinsQuestion3.Services;
using DesjardinsQuestion3.ServicesClient;

namespace DesjardinsQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = new Service();
            ServiceClient sc = new ServiceClient(service);
            sc.EffectuerTraitementUneFois();
        }
    }
}
