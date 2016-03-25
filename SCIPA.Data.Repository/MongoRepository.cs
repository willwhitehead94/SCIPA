using AutoMapper;
using DOM = SCIPA.Models;
using MON = SCIPA.Data.MongoLayer;

namespace SCIPA.Data.Repository
{
    public class MongoRepository : IMongoRepository
    {
        /// <summary>
        /// Automapper object to map between MongoLayer and Domain models.
        /// </summary>
        private readonly IMapper _mapper;

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
                cfg.CreateMap<DOM.Value, MON.Value>();

                cfg.CreateMap<DOM.Device, MON.Device>()
                    .ForMember(m => m.ObjectId, opt => opt.Ignore());


                // Data to domain Converstions
                cfg.CreateMap<MON.Value, DOM.Value>()
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<MON.Device, DOM.Device>()
                    .ForMember(m => m.Actions, opt => opt.Ignore())
                    .ForMember(m => m.Rules, opt => opt.Ignore());



            }).CreateMapper();
        }

        public void AddNewDevice(MON.Device device)
        {
            _controller.AddNewDevice(_mapper.Map(device, new MON.Device()));
        }

        public void UpdateDevice(MON.Device device)
        {
            _controller.UpdateDevice(_mapper.Map(device, new MON.Device()));
        }

        public void AddNewValue(MON.Value value)
        {
            _controller.AddNewValue(_mapper.Map(value, new MON.Value()));
        }
    }
}