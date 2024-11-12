using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_storage_system
{
    internal interface IRemoteStorage
    {
        void Save(string data);
    }
}
