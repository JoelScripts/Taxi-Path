using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiPath.Core;

namespace TaxiPath.Tests
{
    [TestClass]
    public class CoreModelTests
    {
        [TestMethod]
        public void TestAirportValidation()
        {
            // Test valid airport
            var validAirport = new Airport
            {
                Icao = "KJFK",
                Name = "John F Kennedy International Airport",
                Latitude = 40.6397,
                Longitude = -73.7789,
                Elevation = 13
            };
            
            Assert.IsTrue(ValidationHelper.IsValidAirport(validAirport));
            
            // Test invalid airport (null)
            Assert.IsFalse(ValidationHelper.IsValidAirport(null));
            
            // Test invalid airport (missing ICAO)
            var invalidAirport = new Airport
            {
                Icao = "",
                Name = "John F Kennedy International Airport",
                Latitude = 40.6397,
                Longitude = -73.7789,
                Elevation = 13
            };
            
            Assert.IsFalse(ValidationHelper.IsValidAirport(invalidAirport));
        }
        
        [TestMethod]
        public void TestTaxiNodeValidation()
        {
            // Test valid taxi node
            var validNode = new TaxiNode
            {
                Id = "node1",
                Name = "A1",
                Latitude = 40.6397,
                Longitude = -73.7789,
                Type = "intersection"
            };
            
            Assert.IsTrue(ValidationHelper.IsValidTaxiNode(validNode));
            
            // Test invalid taxi node (null)
            Assert.IsFalse(ValidationHelper.IsValidTaxiNode(null));
            
            // Test invalid taxi node (missing ID)
            var invalidNode = new TaxiNode
            {
                Id = "",
                Name = "A1",
                Latitude = 40.6397,
                Longitude = -73.7789,
                Type = "intersection"
            };
            
            Assert.IsFalse(ValidationHelper.IsValidTaxiNode(invalidNode));
        }
        
        [TestMethod]
        public void TestTaxiSegmentValidation()
        {
            // Test valid taxi segment
            var validSegment = new TaxiSegment
            {
                Id = "segment1",
                StartNodeId = "node1",
                EndNodeId = "node2",
                TaxiwayName = "A",
                Length = 1000.0
            };
            
            Assert.IsTrue(ValidationHelper.IsValidTaxiSegment(validSegment));
            
            // Test invalid taxi segment (null)
            Assert.IsFalse(ValidationHelper.IsValidTaxiSegment(null));
            
            // Test invalid taxi segment (negative length)
            var invalidSegment = new TaxiSegment
            {
                Id = "segment1",
                StartNodeId = "node1",
                EndNodeId = "node2",
                TaxiwayName = "A",
                Length = -100.0
            };
            
            Assert.IsFalse(ValidationHelper.IsValidTaxiSegment(invalidSegment));
        }
        
        [TestMethod]
        public void TestRouteStepValidation()
        {
            // Test valid route step
            var validStep = new RouteStep
            {
                Id = "step1",
                NodeId = "node1",
                Instruction = "Turn right at A1",
                TurnDirection = "right",
                IsHoldShort = false
            };
            
            Assert.IsTrue(ValidationHelper.IsValidRouteStep(validStep));
            
            // Test invalid route step (null)
            Assert.IsFalse(ValidationHelper.IsValidRouteStep(null));
            
            // Test invalid route step (missing node ID)
            var invalidStep = new RouteStep
            {
                Id = "step1",
                NodeId = "",
                Instruction = "Turn right at A1",
                TurnDirection = "right",
                IsHoldShort = false
            };
            
            Assert.IsFalse(ValidationHelper.IsValidRouteStep(invalidStep));
        }
        
        [TestMethod]
        public void TestTaxiRouteValidation()
        {
            // Test valid taxi route
            var validRoute = new TaxiRoute
            {
                Id = "route1",
                AirportIcao = "KJFK",
                Name = "Test Route",
                StartNodeId = "node1",
                EndNodeId = "node2",
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };
            
            Assert.IsTrue(ValidationHelper.IsValidTaxiRoute(validRoute));
            
            // Test invalid taxi route (null)
            Assert.IsFalse(ValidationHelper.IsValidTaxiRoute(null));
            
            // Test invalid taxi route (missing ID)
            var invalidRoute = new TaxiRoute
            {
                Id = "",
                AirportIcao = "KJFK",
                Name = "Test Route",
                StartNodeId = "node1",
                EndNodeId = "node2",
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };
            
            Assert.IsFalse(ValidationHelper.IsValidTaxiRoute(invalidRoute));
        }
    }
}