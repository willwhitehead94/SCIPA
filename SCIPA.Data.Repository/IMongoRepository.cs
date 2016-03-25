using MON = SCIPA.Data.MongoLayer;

namespace SCIPA.Data.Repository
{
    public interface IMongoRepository
    {
        void AddNewDevice(MON.Device device);

        void UpdateDevice(MON.Device device);

        void AddNewValue(MON.Value value);
    }
}