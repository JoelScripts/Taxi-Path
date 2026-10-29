using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPath.Core
{
    /// <summary>
    /// Represents a step in a taxi route
    /// </summary>
    public class RouteStep
    {
        /// <summary>
        /// Unique identifier for the route step
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Node ID where this step occurs
        /// </summary>
        public string NodeId { get; set; }
        
        /// <summary>
        /// Instruction for this step
        /// </summary>
        public string Instruction { get; set; }
        
        /// <summary>
        /// Turn direction (left, right, straight)
        /// </summary>
        public string TurnDirection { get; set; }
        
        /// <summary>
        /// Hold short marker if applicable
        /// </summary>
        public bool IsHoldShort { get; set; }
    }
}