using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reprezent information about prices on specific place
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Number of place for which set a prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of place for which set a prize.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Prize for concrete position represent by money.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Prize for concrete position represent by percent of sum of entry fees for tournament.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string placeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal placeAmountValue = 0;
            decimal.TryParse(placeAmount, out placeAmountValue);
            PrizeAmount = placeAmountValue;

            double placePercentageValue = 0;
            double.TryParse(prizePercentage, out placePercentageValue);
            PrizePercentage = placePercentageValue;


        }
    }
}
 