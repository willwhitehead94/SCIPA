using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Controllers
{
    /// <summary>
    /// Interface for all controller objects within the Domain Logic Layer. Provides standardised access to data from the Data Access Layer, working with generic objects and Lists of such.
    /// </summary>
    interface IController
    {
        /// <summary>
        /// Method to collect a list of objects from the implementing controller object. 
        /// </summary>
        /// <param name="count">If a valid number given, this parameter will return only the top X from the list.</param>
        /// <returns>List of generic object types, housing the implementing controllers object type.</returns>
        List<object> GetModels(int count = int.MinValue);

        /// <summary>
        /// Collects a single object from the Data Access Layer.
        /// </summary>
        /// <param name="id">The id number of the object to collect from the RDBMS.</param>
        /// <returns>Generic object housing the implementing controller's object type.</returns>
        object GetFromId(int id);
    }
}
