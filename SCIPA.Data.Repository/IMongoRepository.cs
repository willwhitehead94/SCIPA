using DOM = SCIPA.Models;

namespace SCIPA.Data.Repository
{
    public interface IMongoRepository
    {
        void AddNewDevice(DOM.Device device);

        void UpdateDevice(DOM.Device device);

        void AddNewValue(DOM.Value value);
    }
}