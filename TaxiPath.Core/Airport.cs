using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPath.Core
{
    /// <summary>
    /// Represents an airport with basic identifying information
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// ICAO code of the airport
        /// </summary>
        public string Icao { get; set; }
        
        /// <summary>
        /// Name of the airport
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Latitude in decimal degrees
        /// </summary>
        public double Latitude { get; set; }
        
        /// <summary>
        /// Longitude in decimal degrees
        /// </summary>
        public double Longitude { get; set; }
        
        /// <summary>
        /// Elevation in feet
        /// </summary>
        public int Elevation { get; set; }
    }
}