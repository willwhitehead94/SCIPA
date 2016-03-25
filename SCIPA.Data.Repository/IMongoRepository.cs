using System.Security.Cryptography.X509Certificates;
using SCIPA.Models;

namespace SCIPA.Data.Repository
{
    public interface IMongoRepository
    {
        void SaveNewDevice(Device device);

        void UpdateDevice(Device device);

        void AddNewValue(Value value);
    }
}