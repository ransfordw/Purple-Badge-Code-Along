﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_2
{
    public class WeatherRepository
    {
        private List<Weather> _weatherList;

        public WeatherRepository()
        {
            _weatherList = new List<Weather>();
        }

        public void AddWeatherItemToList(Weather item)
        {
            _weatherList.Add(item);
        }

        public List<Weather> GetWeatherList()
        {
            return _weatherList;
        }
    }
}
