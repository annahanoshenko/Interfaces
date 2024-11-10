using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IDataProvider
    {
        string GetDate();
    }


    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }


    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetDate());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from DB";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetDate() 
        {
            return "Data from file";

        }
    }

    class APIDataProvider : IDataProvider
    {
       public string GetDate()
        {
            return "Data from API";

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
        }
    }
}
