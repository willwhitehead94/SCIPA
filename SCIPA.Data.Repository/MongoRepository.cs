using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DOM = SCIPA.Models;
using MON = SCIPA.Data.MongoLayer;

namespace SCIPA.Data.Repository
{
    /// <summary>
    /// Application facing class for the MongoDB. Allows the application to interact
    /// with the Mongo database without any requirement of repeated knowledge as to the 
    /// collection, the documents or the entities used within it.
    /// </summary>
    public class MongoRepository : IMongoRepository
    {
        /// <summary>
        /// Automapper object to map between MongoLayer and Domain models.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Local instantiation of the data controller object from the Mongo layer.
        /// </summary>
        private readonly MON.DataController _controller;

        /// <summary>
        /// Initialises the AutoMapper configuration for detailed and complex maps between
        /// Domain and MongoLayer models used within the application. 
        /// Important to note is that the mapping of 'virtual' properties should always
        /// be ignored so as to prevent circular mapping, as well as any ID fields
        /// when used as primary keys so as not to override EF's database and entity
        /// understanding incorrectly.
        /// </summary>
        public MongoRepository()
        {
            // Initialise the Data Controller object.
            _controller = new MON.DataController();

            // Configure AutoMapper for update operations.
            _mapper = new MapperConfiguration(cfg =>
            {
                /*
                * All Maps will ignore the ID and any form of navigational
                * properties. Reduces any issues AutoMapper may face
                * with regards to Circular dependencies.
                */

                // Domain to Data Converstions
                cfg.CreateMap<DOM.Value, MON.Value>()
                    .ForMember(m=>m.ValueId, opt=>opt.Ignore());

                cfg.CreateMap<DOM.Device, MON.Device>()
                   .ForMember(m => m.ObjectId, opt => opt.Ignore());


                // Data to domain Converstions
                cfg.CreateMap<MON.Value, DOM.Value>()
                   .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<MON.Device, DOM.Device>()
                .ForMember(m => m.Rules, opt => opt.Ignore());



            }).CreateMapper();
        }

        /// <summary>
        /// Adds a new Device to the MongoDB database.
        /// </summary>
        /// <param name="device"></param>
        public void AddNewDevice(DOM.Device device)
        {
            _controller.AddNewDevice(_mapper.Map(device, new MON.Device()));
        }

        /// <summary>
        /// Updates and existing Device within the MongoDB datbase.
        /// </summary>
        /// <param name="device"></param>
        public void UpdateDevice(DOM.Device device)
        {
            _controller.UpdateDevice(_mapper.Map(device, new MON.Device()));
        }

        /// <summary>
        /// Adds a new value to the MongoDB database.
        /// </summary>
        /// <param name="value"></param>
        public void AddNewValue(DOM.Value value)
        {
            _controller.AddNewValue(_mapper.Map(value, new MON.Value()));
        }

        public ICollection<DOM.Value> GetAllValuesForDevice(int deviceId)
        {
            var result  = _controller.GetAllProcessValuesForDevice(deviceId);

            return result != null && result.Any() ? result.Select(dbVal => ConvertMONToDOMValues(dbVal)).ToList() : new List<DOM.Value>();
        }

        private DOM.Value ConvertMONToDOMValues(MON.Value dbVal)
        {
            return new DOM.Value()
            {
                Id = dbVal.ValueId,
                BooleanValue = dbVal.BooleanValue,
                FloatValue = dbVal.FloatValue,
                IntegerValue = dbVal.IntegerValue,
                StringValue = dbVal.StringValue,
                Inbound = dbVal.Inbound,
                EventTime = dbVal.EventTime
            };
        }

        /// <summary>
        /// Informs the controller to drop the entire SCIPA database.
        /// </summary>
        public void ClearMongo()
        {
            _controller.ClearMongo();
        }
    }
}