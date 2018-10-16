using System;
using System.Collections.Generic;
using _03_Defining_Classes_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_2_Tests
{
    [TestClass]
    public class WeatherTests
    {
        //-- Fields
        private Weather _weather;
        private WeatherRepository _weatherRepo;

        //--TODO Reference Assemblies
        //-- Test Initialize
        [TestInitialize]
        public void Arrange()
        {
            _weatherRepo = new WeatherRepository();
            _weather = new Weather
            {
                WeatherID = 1,
                IsPrecipitating = true,
                WindSpeed = 30,
                WindDirection = WindDirection.East,
                Temperature = 55,
                WeatherDate = DateTimeOffset.Now
            };
            _weatherRepo.AddWeatherItemToList(_weather);
        } 

        [TestMethod]
        public void WeatherRepo_NumberOfItemsInList_IsCorrectInt()
        {
            //--Act
            var expected = 1;
            var actual = _weatherRepo.GetWeatherList().Count;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
