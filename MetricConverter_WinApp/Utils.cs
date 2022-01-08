//  Metric Converter
//
//  Created by Geoffrey Overfield on 1/5/2022.
//  Copyright © 2022 Geoffrey Overfield. All rights reserved.

using System.Collections.Generic;

namespace MetricConverter_WinApp
{
    internal class Utils
    {
        internal class Consts
        {
            internal const string NaN = "NaN";

            internal static List<string> DistanceUnits = new List<string>()
            {
                "Inches",
                "Feet",
                "Yards",
                "Miles",
                "Nautical Miles",
                "Leagues",
                "Millimeters",
                "Centimeters",
                "Meters",
                "Kilometers",
                "Astronomical Units",
                "Light-Years",
                "Parsecs",
            };
            internal static List<string> SpeedUnits = new List<string>()
            {
                "Feet/Second",
                "Miles/Hour",
                "Meters/Second",
                "Kilometers/Hour",
                "Knots",
                "Speed of Sound",
                "Speed of Light"
            };
            internal static List<string> MassUnits = new List<string>()
            {
                "Ounces",
                "Pounds",
                "Tons",
                "Milligrams",
                "Grams",
                "Kilograms",
            };
            internal static List<string> VolumeUnits = new List<string>()
            {
                "teaspoons",
                "Tablespoons",
                "Fluid Ounce",
                "Cups",
                "Pints",
                "Quarts",
                "Gallons",
                "Barrels",
                "Milliliters",
                "Liters",
                "Cubic Meters"
            };
            internal static List<string> TemperatureUnits = new List<string>()
            {
                "Fahrenheit",
                "Celsius",
                "Kelvin"
            };

            internal static List<string> DistanceToUnits = new List<string>()
            {
                "Inches",
                "Feet",
                "Yards",
                "Miles",
                "Nautical Miles",
                "Leagues",
                "Millimeters",
                "Centimeters",
                "Meters",
                "Kilometers",
                "Astronomical Units",
                "Light-Years",
                "Parsecs",
            };
            internal static List<string> SpeedToUnits = new List<string>()
            {
                "Feet/Second",
                "Miles/Hour",
                "Meters/Second",
                "Kilometers/Hour",
                "Knots",
                "Speed of Sound",
                "Speed of Light"
            };
            internal static List<string> MassToUnits = new List<string>()
            {
                "Ounces",
                "Pounds",
                "Tons",
                "Milligrams",
                "Grams",
                "Kilograms",
            };
            internal static List<string> VolumeToUnits = new List<string>()
            {
                "teaspoons",
                "Tablespoons",
                "Fluid Ounce",
                "Cups",
                "Pints",
                "Quarts",
                "Gallons",
                "Barrels",
                "Milliliters",
                "Liters",
                "Cubic Meters"
            };
            internal static List<string> TemperatureToUnits = new List<string>()
            {
                "Fahrenheit",
                "Celsius",
                "Kelvin"
            };
        }

        internal class Enumerations
        {
            internal enum ConversionType
            {
                Invalid,
                Distance,
                Speed,
                Mass,
                Volume,
                Temperature
            };
        }
    }
}
