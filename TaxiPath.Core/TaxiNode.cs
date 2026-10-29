using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPath.Core
{
    /// <summary>
    /// Represents a taxiway node/intersection
    /// </summary>
    public class TaxiNode
    {
        /// <summary>
        /// Unique identifier for the node
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Name of the node (e.g., "A1", "B2")
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
        /// Type of node (e.g., "intersection", "runway", "parking")
        /// </summary>
        public string Type { get; set; }
    }
}