using DomainLogicLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Controllers
{
    public abstract class DefaultController
    {
        /// <summary>
        /// This method attempts to connect to the database, and if that connection is available, checks to make sure that the application is enabled.
        /// </summary>
        /// <returns>Success or Fail boolean.</returns>
        public static bool EnsureDatabaseEnabled()
        {
            DataAccessLayer.DatabaseHandler dbHandler = new DataAccessLayer.DatabaseHandler();
            dbHandler.Execute("SELECT TOP 1 ApplicationEnabled FROM [SCIPA].[dbo].[ApplicationInformation] WHERE ApplicationEnabled = 1");

            bool appEnabled = false;
            try { appEnabled = Convert.ToBoolean(dbHandler.GetSingleValueFromFirstTableInSet()); }
            catch { appEnabled = false; }

            if (appEnabled)
            {
                return true;
            }

            return false;
        }

        public static bool EnsureDatabaseAvailable()
        {
            DataAccessLayer.DatabaseHandler dbHandler = new DataAccessLayer.DatabaseHandler();
            return dbHandler.CheckDatabaseIsAvailable();
        }

        /// <summary>
        /// Generic method to convert from an 'object' to a model following the use of other controller methods that
        /// convert to generic types.
        /// </summary>
        /// <typeparam name="T">The type of object to convert to.</typeparam>
        /// <param name="obj">The list of objects that must be converted.</param>
        /// <returns>List of specialised objects.</returns>
        public List<T> ConvertToModel<T>(List<object> obj)
        {
            List<T> toReturn = new List<T>();

            foreach (object genericObj in obj)
            {
                toReturn.Add(SpecialiseGenericObject<T>(genericObj));
            }

            return toReturn;
        }

        /// <summary>
        /// Generic method to convert from an 'object' to a model following the use of other controller methods that
        /// convert to generic types.
        /// </summary>
        /// <typeparam name="T">The type of object to convert to.</typeparam>
        /// <param name="obj">The list of objects that must be converted.</param>
        /// <returns>List of specialised objects.</returns>
        public List<T> ConvertToModel<T>(object obj)
        {
            List<object> genericList = new List<object>();
            genericList.Add(obj);

            return ConvertToModel<T>(genericList);
        }

        /// <summary>
        /// Casts the generic parameterised object into the given Type.
        /// </summary>
        /// <typeparam name="T">Specialised model type.</typeparam>
        /// <param name="generic">Generic 'object' model.</param>
        /// <returns>Specialised version of generic object.</returns>
        public T SpecialiseGenericObject<T>(object generic)
        {
            return (T)generic;
            //try
            //{
            //    T specific = (T)generic;
            //    Service.DebugPrint("The generic object has been converted to a specialised one.");
            //    return specific;
            //}
            //catch
            //{
            //    Service.DebugPrint("There was an issue converting the generic object to a specialised one.");
            //    return generic;
            //}
        }
    }
}
