using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPath.Core
{
    /// <summary>
    /// Provides validation logic for taxi path domain models
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Validates that an airport has valid data
        /// </summary>
        /// <param name="airport">Airport to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool IsValidAirport(Airport airport)
        {
            if (airport == null) return false;
            if (string.IsNullOrWhiteSpace(airport.Icao)) return false;
            if (string.IsNullOrWhiteSpace(airport.Name)) return false;
            // Latitude should be between -90 and 90
            if (airport.Latitude < -90 || airport.Latitude > 90) return false;
            // Longitude should be between -180 and 180
            if (airport.Longitude < -180 || airport.Longitude > 180) return false;
            return true;
        }

        /// <summary>
        /// Validates that a taxi node has valid data
        /// </summary>
        /// <param name="node">Node to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool IsValidTaxiNode(TaxiNode node)
        {
            if (node == null) return false;
            if (string.IsNullOrWhiteSpace(node.Id)) return false;
            if (string.IsNullOrWhiteSpace(node.Name)) return false;
            // Latitude should be between -90 and 90
            if (node.Latitude < -90 || node.Latitude > 90) return false;
            // Longitude should be between -180 and 180
            if (node.Longitude < -180 || node.Longitude > 180) return false;
            return true;
        }

        /// <summary>
        /// Validates that a taxi segment has valid data
        /// </summary>
        /// <param name="segment">Segment to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool IsValidTaxiSegment(TaxiSegment segment)
        {
            if (segment == null) return false;
            if (string.IsNullOrWhiteSpace(segment.Id)) return false;
            if (string.IsNullOrWhiteSpace(segment.StartNodeId)) return false;
            if (string.IsNullOrWhiteSpace(segment.EndNodeId)) return false;
            // Length should be positive
            if (segment.Length < 0) return false;
            return true;
        }

        /// <summary>
        /// Validates that a route step has valid data
        /// </summary>
        /// <param name="step">Step to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool IsValidRouteStep(RouteStep step)
        {
            if (step == null) return false;
            if (string.IsNullOrWhiteSpace(step.NodeId)) return false;
            // Instruction can be null/empty but that's not necessarily invalid
            return true;
        }

        /// <summary>
        /// Validates that a taxi route has valid data
        /// </summary>
        /// <param name="route">Route to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool IsValidTaxiRoute(TaxiRoute route)
        {
            if (route == null) return false;
            if (string.IsNullOrWhiteSpace(route.Id)) return false;
            if (string.IsNullOrWhiteSpace(route.AirportIcao)) return false;
            if (string.IsNullOrWhiteSpace(route.Name)) return false;
            if (route.Steps == null) return false;
            if (string.IsNullOrWhiteSpace(route.StartNodeId)) return false;
            if (string.IsNullOrWhiteSpace(route.EndNodeId)) return false;
            
            // Validate each step
            foreach (var step in route.Steps)
            {
                if (!IsValidRouteStep(step))
                    return false;
            }
            
            return true;
        }
    }
}