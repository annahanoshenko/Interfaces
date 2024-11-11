using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_interfaces
{
 
    public interface IPrintable 
    {
        void Print();
    }

    public interface ISaveable 
    {
        void Save();
    }

    public interface IDocument : IPrintable, ISaveable
    {
        void Open();
        void Close();
    }
    public interface IScannable : IDocument
    {
        void Scan();
    }


}
