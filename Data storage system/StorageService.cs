using System;


namespace Data_storage_system
{
    internal class StorageService : ILocalStorage, IRemoteStorage
    {
        void ILocalStorage.Save(string data)
        {
            Console.WriteLine($"Saving data locally: {data}");
        }

        void IRemoteStorage.Save(string data)
        {
            Console.WriteLine($"Saving data remotely: {data}");
        }
    }
}
