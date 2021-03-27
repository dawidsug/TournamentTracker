using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent information about Person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Player id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Player first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Player second name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Player email adress.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Player cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }


        public string FullName
        {
            get { return $" { FirstName } { LastName} "; }
        }

    }
}
