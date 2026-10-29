using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPath.Core
{
    /// <summary>
    /// Represents a segment connecting two taxi nodes
    /// </summary>
    public class TaxiSegment
    {
        /// <summary>
        /// Unique identifier for the segment
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Start node ID
        /// </summary>
        public string StartNodeId { get; set; }
        
        /// <summary>
        /// End node ID
        /// </summary>
        public string EndNodeId { get; set; }
        
        /// <summary>
        /// Name of the taxiway (e.g., "A", "B", "C")
        /// </summary>
        public string TaxiwayName { get; set; }
        
        /// <summary>
        /// Length of segment in feet
        /// </summary>
        public double Length { get; set; }
    }
}