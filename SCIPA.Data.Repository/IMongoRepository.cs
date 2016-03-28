using DOM = SCIPA.Models;

namespace SCIPA.Data.Repository
{
    /// <summary>
    /// Interface for the Mongo Repository.
    /// </summary>
    public interface IMongoRepository
    {
        void AddNewDevice(DOM.Device device);

        void UpdateDevice(DOM.Device device);

        void AddNewValue(DOM.Value value);
    }
}