using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPath.Core
{
    /// <summary>
    /// Represents a taxi route from start to finish
    /// </summary>
    public class TaxiRoute
    {
        /// <summary>
        /// Unique identifier for the route
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Airport ICAO code this route is for
        /// </summary>
        public string AirportIcao { get; set; }
        
        /// <summary>
        /// Name of the route
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// List of steps in the route
        /// </summary>
        public List<RouteStep> Steps { get; set; } = new List<RouteStep>();
        
        /// <summary>
        /// Start node ID
        /// </summary>
        public string StartNodeId { get; set; }
        
        /// <summary>
        /// End node ID (runway or parking stand)
        /// </summary>
        public string EndNodeId { get; set; }
        
        /// <summary>
        /// Creation timestamp
        /// </summary>
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// Last modified timestamp
        /// </summary>
        public DateTime ModifiedAt { get; set; }
    }
}