using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_storage_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StorageService storageService = new StorageService();

            ILocalStorage local = storageService;
            local.Save("Local data");

            IRemoteStorage remote = storageService;
            remote.Save("Remote data");

            Console.ReadKey();

        }
    }
}
