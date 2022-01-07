using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest1.Data.ApiData
{
    public class CurrentDirection
    {
        public double fcoo { get; set; }
        public double meto { get; set; }
        public double sg { get; set; }
    }

    public class CurrentSpeed
    {
        public double fcoo { get; set; }
        public double meto { get; set; }
        public double sg { get; set; }
    }

    public class WaterTemperature
    {
        public double meto { get; set; }
        public double noaa { get; set; }
        public double sg { get; set; }
    }

    public class WaveDirection
    {
        public double fcoo { get; set; }
        public double icon { get; set; }
        public double meteo { get; set; }
        public double noaa { get; set; }
        public double sg { get; set; }
    }

    public class WaveHeight
    {
        public double dwd { get; set; }
        public double fcoo { get; set; }
        public double icon { get; set; }
        public double meteo { get; set; }
        public double noaa { get; set; }
        public double sg { get; set; }
    }

    public class WavePeriod
    {
        public double fcoo { get; set; }
        public double meteo { get; set; }
        public double noaa { get; set; }
        public double sg { get; set; }
    }

    public class Hour
    {
        public CurrentDirection currentDirection { get; set; }
        public CurrentSpeed currentSpeed { get; set; }
        public DateTime time { get; set; }
        public WaterTemperature waterTemperature { get; set; }
        public WaveDirection waveDirection { get; set; }
        public WaveHeight waveHeight { get; set; }
        public WavePeriod wavePeriod { get; set; }
    }

    public class Meta
    {
        public int cost { get; set; }
        public int dailyQuota { get; set; }
        public string end { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public List<string> @params { get; set; }
        public int requestCount { get; set; }
        public string start { get; set; }
    }

    public class Root
    {
        public List<Hour> hours { get; set; }
        public Meta meta { get; set; }
    }
}
