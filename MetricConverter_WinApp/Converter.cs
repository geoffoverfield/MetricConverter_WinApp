//  Metric Converter
//
//  Created by Geoffrey Overfield on 1/5/2022.
//  Copyright © 2022 Geoffrey Overfield. All rights reserved.

using System;
using System.Collections.Generic;

namespace MetricConverter_WinApp
{
    internal class Converter
    {
        internal class Units
        {
            internal enum DistanceUnits
            {
                Inches,
                Feet,
                Yards,
                Miles,
                Nautical_Miles,
                Leagues,
                Millimeters,
                Centimeters,
                Meters,
                Kilometers,
                Astronomical_Units,
                Light_Years,
                Parsecs
            };
            internal enum SpeedUnits
            {
                Feet_Second,
                Miles_Hour,
                Meters_Second,
                Kilometers_Hour
            };
            internal enum MassUnits
            {
                Ounces,
                Pounds,
                Tons,
                Milligrams,
                Grams,
                Kilograms,
            };
            internal enum VolumeUnits
            {
                teaspoons,
                Tablespoons,
                Fluid_Ounce,
                Cups,
                Pints,
                Quarts,
                Gallons,
                Barrels,
                Milliliters,
                Liters,
                Cubic_Meters
            };

            internal static Dictionary<string, DistanceUnits> m_dStringToUnits_Distance = new Dictionary<string, DistanceUnits>()
            {
                {"Inches", DistanceUnits.Inches },
                {"Feet", DistanceUnits.Feet },
                {"Yards", DistanceUnits.Yards },
                {"Miles", DistanceUnits.Miles },
                {"Nautical Miles", DistanceUnits.Nautical_Miles },
                {"Leagues", DistanceUnits.Leagues },
                {"Millimeters", DistanceUnits.Millimeters },
                {"Centimeters", DistanceUnits.Centimeters },
                {"Meters", DistanceUnits.Meters },
                {"Kilometers", DistanceUnits.Kilometers },
                {"Astronomical Units", DistanceUnits.Astronomical_Units },
                {"Light-Years", DistanceUnits.Light_Years },
                {"Parsecs", DistanceUnits.Parsecs }
            };
            internal static Dictionary<string, SpeedUnits> m_dStringToUnits_Speed = new Dictionary<string, SpeedUnits>()
            {
                {"Feet/Second", SpeedUnits.Feet_Second },
                {"Miles/Hour", SpeedUnits.Miles_Hour },
                {"Meters/Second", SpeedUnits.Meters_Second },
                {"Kilometers/Hour", SpeedUnits.Kilometers_Hour }
            };
            internal static Dictionary<string, MassUnits> m_dStringToUnits_Mass = new Dictionary<string, MassUnits>()
            {
                {"Ounces", MassUnits.Ounces },
                {"Pounds", MassUnits.Pounds },
                {"Tons", MassUnits.Tons },
                {"Milligrams", MassUnits.Milligrams },
                {"Grams", MassUnits.Grams },
                {"Kilograms", MassUnits.Kilograms }
            };
            internal static Dictionary<string, VolumeUnits> m_dStringToUnits_Volume = new Dictionary<string, VolumeUnits>()
            {
                {"teaspoons", VolumeUnits.teaspoons },
                {"Tablespoons", VolumeUnits.Tablespoons },
                {"Fluid Ounce", VolumeUnits.Fluid_Ounce },
                {"Cups", VolumeUnits.Cups },
                {"Pints", VolumeUnits.Pints },
                {"Quarts", VolumeUnits.Quarts },
                {"Gallons", VolumeUnits.Gallons },
                {"Barrels", VolumeUnits.Barrels },
                {"Milliliters", VolumeUnits.Milliliters },
                {"Liters", VolumeUnits.Liters },
                {"Cubic Meters", VolumeUnits.Cubic_Meters }
            };
        }

        internal string Convert(Utils.Enumerations.ConversionType conversionType,
                                string fromSelect, string toSelect, double input)
        {
            string sReturn = Utils.Consts.NaN;
            if (conversionType == Utils.Enumerations.ConversionType.Invalid) return sReturn;

            switch (conversionType)
            {
                case Utils.Enumerations.ConversionType.Mass:
                    Units.MassUnits fromMassUnits = Units.m_dStringToUnits_Mass[fromSelect];
                    Units.MassUnits toMassUnits = Units.m_dStringToUnits_Mass[toSelect];
                    switch (fromMassUnits)
                    {
                        case Units.MassUnits.Ounces:
                            switch (toMassUnits)
                            {
                                // Ounces to Ounces
                                case Units.MassUnits.Ounces:
                                    sReturn = string.Format("{0} oz", Math.Round(input, 4), 4);
                                    break;
                                // Ounces to Pounds
                                case Units.MassUnits.Pounds:
                                    sReturn = string.Format("{0} lbs", Math.Round(input / 16, 4));
                                    break;
                                // Ounces to Tons
                                case Units.MassUnits.Tons:
                                    sReturn = string.Format("{0} tons", Math.Round(input / 32000, 4));
                                    break;
                                // Ounces to Milligrams
                                case Units.MassUnits.Milligrams:
                                    sReturn = string.Format("{0} mg", Math.Round(input * 28349.5, 4));
                                    break;
                                // Ounces to Grams
                                case Units.MassUnits.Grams:
                                    sReturn = string.Format("{0} g", Math.Round(input * 28.35, 4));
                                    break;
                                // Ounces to Kilograms
                                case Units.MassUnits.Kilograms:
                                    sReturn = string.Format("{0} Kg", Math.Round(input / 35.274, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.MassUnits.Pounds:
                            switch (toMassUnits)
                            {
                                // Pounds to Ounces
                                case Units.MassUnits.Ounces:
                                    sReturn = string.Format("{0} oz", Math.Round(input * 16, 4));
                                    break;
                                // Pounds to Pounds
                                case Units.MassUnits.Pounds:
                                    sReturn = string.Format("{0} lbs", Math.Round(input, 4));
                                    break;
                                // Pounds to Tons
                                case Units.MassUnits.Tons:
                                    sReturn = string.Format("{0} tons", Math.Round(input / 2000, 4));
                                    break;
                                // Pounds to Milligrams
                                case Units.MassUnits.Milligrams:
                                    sReturn = string.Format("{0} mg", Math.Round(input * 453592, 4));
                                    break;
                                // Pounds to Grams
                                case Units.MassUnits.Grams:
                                    sReturn = string.Format("{0} g", Math.Round(input * 453.592, 4));
                                    break;
                                // Pounds to Kilograms
                                case Units.MassUnits.Kilograms:
                                    sReturn = string.Format("{0} Kg", Math.Round(input / 2.205, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.MassUnits.Tons:
                            switch (toMassUnits)
                            {
                                // Tons to Ounces
                                case Units.MassUnits.Ounces:
                                    sReturn = string.Format("{0} oz", Math.Round(input * 32000, 4));
                                    break;
                                // Tons to Pounds
                                case Units.MassUnits.Pounds:
                                    sReturn = string.Format("{0} lbs", Math.Round(input * 2000, 4));
                                    break;
                                // Tons to Tons
                                case Units.MassUnits.Tons:
                                    sReturn = string.Format("{0} ton", Math.Round(input, 4));
                                    break;
                                // Tons to Milligrams
                                case Units.MassUnits.Milligrams:
                                    sReturn = string.Format("{0} mg", Math.Round(input * 9.072e+8, 4));
                                    break;
                                // Tons to Grams
                                case Units.MassUnits.Grams:
                                    sReturn = string.Format("{0} g", Math.Round(input * 907185, 4));
                                    break;
                                // Tons to Kilograms
                                case Units.MassUnits.Kilograms:
                                    sReturn = string.Format("{0} Kg", Math.Round(input * 907.185, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.MassUnits.Milligrams:
                            switch (toMassUnits)
                            {
                                // Milligrams to Ounces
                                case Units.MassUnits.Ounces:
                                    sReturn = string.Format("{0} oz", Math.Round(input / 28350, 4));
                                    break;
                                // Milligrams to Pounds
                                case Units.MassUnits.Pounds:
                                    sReturn = string.Format("{0} lbs", Math.Round(input / 453592, 4));
                                    break;
                                // Milligrams to Tons
                                case Units.MassUnits.Tons:
                                    sReturn = string.Format("{0} tons", Math.Round(input / 9.072e+8, 4));
                                    break;
                                // Milligrams to Milligrams
                                case Units.MassUnits.Milligrams:
                                    sReturn = string.Format("{0} mg", Math.Round(input, 4));
                                    break;
                                // Milligrams to Grams
                                case Units.MassUnits.Grams:
                                    sReturn = string.Format("{0} g", Math.Round(input / 1000, 4));
                                    break;
                                // Milligrams to Kilograms
                                case Units.MassUnits.Kilograms:
                                    sReturn = string.Format("{0} Kg", Math.Round(input / 1e+6, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.MassUnits.Grams:
                            switch (toMassUnits)
                            {
                                // Grams to Ounces
                                case Units.MassUnits.Ounces:
                                    sReturn = string.Format("{0} oz", Math.Round(input / 28.35, 4));
                                    break;
                                // Grams to Pounds
                                case Units.MassUnits.Pounds:
                                    sReturn = string.Format("{0} lbs", Math.Round(input / 453.592, 4));
                                    break;
                                // Grams to Tons
                                case Units.MassUnits.Tons:
                                    sReturn = string.Format("{0} tons", Math.Round(input / 907185, 4));
                                    break;
                                // Grams to Milligrams
                                case Units.MassUnits.Milligrams:
                                    sReturn = string.Format("{0} mg", Math.Round(input * 1000, 4));
                                    break;
                                // Grams to Grams
                                case Units.MassUnits.Grams:
                                    sReturn = string.Format("{0} g", Math.Round(input, 4));
                                    break;
                                // Grams to Kilograms
                                case Units.MassUnits.Kilograms:
                                    sReturn = string.Format("{0} Kg", Math.Round(input / 1000, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.MassUnits.Kilograms:
                            switch (toMassUnits)
                            {
                                // Kilograms to Ounces
                                case Units.MassUnits.Ounces:
                                    sReturn = string.Format("{0} oz", Math.Round(input * 35.274, 4));
                                    break;
                                // Kilograms to Pounds
                                case Units.MassUnits.Pounds:
                                    sReturn = string.Format("{0} lbs", Math.Round(input * 2.205, 4));
                                    break;
                                // Kilograms to Tons
                                case Units.MassUnits.Tons:
                                    sReturn = string.Format("{0} tons", Math.Round(input / 907, 4));
                                    break;
                                // Kilograms to Milligrams
                                case Units.MassUnits.Milligrams:
                                    sReturn = string.Format("{0} mg", Math.Round(input * 1e+6, 4));
                                    break;
                                // Kilograms to Grams
                                case Units.MassUnits.Grams:
                                    sReturn = string.Format("{0} g", Math.Round(input * 1000, 4));
                                    break;
                                // Kilograms to Kilograms
                                case Units.MassUnits.Kilograms:
                                    sReturn = string.Format("{0} Kg", Math.Round(input, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        default: sReturn = Utils.Consts.NaN;
                            break;
                    }
                    break;
                case Utils.Enumerations.ConversionType.Distance:
                    Units.DistanceUnits fromDistUnits = Units.m_dStringToUnits_Distance[fromSelect];
                    Units.DistanceUnits toDistUnits = Units.m_dStringToUnits_Distance[toSelect];
                    switch (fromDistUnits)
                    {
                        case Units.DistanceUnits.Inches:
                            switch (toDistUnits)
                            {
                                // Inches to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input, 4));
                                    break;
                                // Inches to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input / 12, 4));
                                    break;
                                // Inches to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input / 36, 4));
                                    break;
                                // Inches to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input / 63360, 4));
                                    break;
                                // Inches to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 72913, 4));
                                    break;
                                // Inches to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 218740, 4));
                                    break;
                                // Inches to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input / 25.4, 4));
                                    break;
                                // Inches to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input / 254, 4));
                                    break;
                                // Inches to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input / 25400, 4));
                                    break;
                                // Inches to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input / 2540000, 4));
                                    break;
                                // Inches to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 5.89e+12, 4));
                                    break;
                                // Inches to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 3.725e+17, 4));
                                    break;
                                // Inches to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 1.215e+18, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Feet:
                            switch (toDistUnits)
                            {
                                // Feet to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 12, 4));
                                    break;
                                // Feet to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input, 4));
                                    break;
                                // Feet to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input / 3, 4));
                                    break;
                                // Feet to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input / 5280, 4));
                                    break;
                                // Feet to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 6076, 4));
                                    break;
                                // Feet to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 18228, 4));
                                    break;
                                // Feet to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 304.8, 4));
                                    break;
                                // Feet to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input * 30.48, 4));
                                    break;
                                // Feet to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input / 3.281, 4));
                                    break;
                                // Feet to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input / 3180.84, 4));
                                    break;
                                // Feet to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 4.908e+11, 4));
                                    break;
                                // Feet to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 3.104e+16, 4));
                                    break;
                                // Feet to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 1.012e+17, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Yards:
                            switch (toDistUnits)
                            {
                                // Yards to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 36, 4));
                                    break;
                                // Yards to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input * 3, 4));
                                    break;
                                // Yards to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input, 4));
                                    break;
                                // Yards to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input / 1760, 4));
                                    break;
                                // Yards to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 2025, 4));
                                    break;
                                // Yards to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 6076, 4));
                                    break;
                                // Yards to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 914.4, 4));
                                    break;
                                // Yards to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input * 91.44, 4));
                                    break;
                                // Yards to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input / 1.094, 4));
                                    break;
                                // Yards to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input / 1093.613, 4));
                                    break;
                                // Yards to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 1.636e+11, 4));
                                    break;
                                // Yards to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 1.035e+16, 4));
                                    break;
                                // Yards to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 3.375e+16, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Miles:
                            switch (toDistUnits)
                            {
                                // Miles to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 63360, 4));
                                    break;
                                // Miles to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input * 5280, 4));
                                    break;
                                // Miles to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input * 1760, 4));
                                    break;
                                // Miles to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input, 4));
                                    break;
                                // Miles to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 1.151, 4));
                                    break;
                                // Miles to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 3.452, 4));
                                    break;
                                // Miles to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 1.609e+6, 4));
                                    break;
                                // Miles to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input * 160900, 4));
                                    break;
                                // Miles to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input * 1609, 4));
                                    break;
                                // Miles to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input * 1.609, 4));
                                    break;
                                // Miles to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 9.296e+7, 4));
                                    break;
                                // Miles to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 5.879e+12, 4));
                                    break;
                                // Miles to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 1.917e+13, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Millimeters:
                            switch (toDistUnits)
                            {
                                // Millimeters to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input / 25.4, 4));
                                    break;
                                // Millimeters to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input / 304.8, 4));
                                    break;
                                // Millimeters to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input / 914.4, 4));
                                    break;
                                // Millimeters to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input / 1.609e+6, 4));
                                    break;
                                // Millimeters to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 1.852e+6, 4));
                                    break;
                                // Millimeters to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 5.556e+6, 4));
                                    break;
                                // mm to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input, 4));
                                    break;
                                // mm to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input / 10, 4));
                                    break;
                                // Millimeters to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input / 1000, 4));
                                    break;
                                // Millimeters to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input / 1e+6, 4));
                                    break;
                                // Millimeters to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 1.496e+14, 4));
                                    break;
                                // Millimeters to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = "~1.057e-19 LY";
                                    break;
                                // Millimeters to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = "~3.24078e-20 pc";
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Centimeters:
                            switch (toDistUnits)
                            {
                                // Centimeters to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input / 2.54, 4));
                                    break;
                                // Centimeters to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input / 30.48, 4));
                                    break;
                                // Centimeters to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input / 91.44, 4));
                                    break;
                                // Centimeters to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input / 160900, 4));
                                    break;
                                // Centimeters to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 185200, 4));
                                    break;
                                // Centimeters to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 555600, 4));
                                    break;
                                // Centimeters to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 10, 4));
                                    break;
                                // Centimeters to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input, 4));
                                    break;
                                // Centimeters to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input / 100, 4));
                                    break;
                                // Centimeters to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input / 1e+5, 4));
                                    break;
                                // Centimeters to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 1.496e+13, 4));
                                    break;
                                // Centimeters to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 9.461e+17, 4));
                                    break;
                                // Centimeters to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 3.086e+18, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Meters:
                            switch (toDistUnits)
                            {
                                // Meters to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 39.37, 4));
                                    break;
                                // Meters to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input * 3.281, 4));
                                    break;
                                // Meters to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input * 1.094, 4));
                                    break;
                                // Meters to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input / 1609, 4));
                                    break;
                                // Meters to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 1852, 4));
                                    break;
                                // Meters to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 5556, 4));
                                    break;
                                // Meters to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input / 1000, 4));
                                    break;
                                // Meters to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input / 100, 4));
                                    break;
                                // Meters to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input, 4));
                                    break;
                                // Meters to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input / 1000, 4));
                                    break;
                                // Meters to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 1.496e+11, 4));
                                    break;
                                // Meters to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 9.461e+15, 4));
                                    break;
                                // Meters to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 3.086e+16, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Kilometers:
                            switch (toDistUnits)
                            {
                                // Kilometers to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 39370.1, 4));
                                    break;
                                // Kilometers to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input * 3280.84, 4));
                                    break;
                                // Kilometers to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input * 1093.613, 4));
                                    break;
                                // Kilometers to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input * 1.609, 4));
                                    break;
                                // Kilometers to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input / 1.852, 4));
                                    break;
                                // Kilometers to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input / 5.556, 4));
                                    break;
                                // Kilometers to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 1e+6, 4));
                                    break;
                                // Kilometers to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input * 1e+5, 4));
                                    break;
                                // Kilometers to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input * 1000, 4));
                                    break;
                                // Kilometers to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input, 4));
                                    break;
                                // Kilometers to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input / 1.496e+8, 4));
                                    break;
                                // Kilometers to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 9.461e+12, 4));
                                    break;
                                // Kilometers to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 3.086e+13, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Astronomical_Units:
                            switch (toDistUnits)
                            {
                                // Astronomical Units to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 5.89e+12, 4));
                                    break;
                                // Astronomical Units to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input * 4.908e+11, 4));
                                    break;
                                // Astronomical Units to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input * 1.636e+11, 4));
                                    break;
                                // Astronomical Units to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input * 9.296e+7, 4));
                                    break;
                                // Astronomical Units to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input * 8.078e+7, 4));
                                    break;
                                // Astronomical Units to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input * 2.693e+7, 4));
                                    break;
                                // Astronomical Units to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 1.496e+14, 4));
                                    break;
                                // Astronomical Units to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input * 1.496e+13, 4));
                                    break;
                                // Astronomical Units to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input * 1.496e+11, 4));
                                    break;
                                // Astronomical Units to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input * 1.496e+8, 4));
                                    break;
                                // Astronomical Units to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input, 4));
                                    break;
                                // Astronomical Units to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input / 63241, 4));
                                    break;
                                // Astronomical Units to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 206265, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Light_Years:
                            switch (toDistUnits)
                            {
                                // Light Years Units to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 3.725e+17, 4));
                                    break;
                                // Light Years to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input * 3.104e+16, 4));
                                    break;
                                // Light Years to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input * 1.035e+16, 4));
                                    break;
                                // Light Years to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input * 5.879e+12, 4));
                                    break;
                                // Light Years to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input * 5.108e+12, 4));
                                    break;
                                // Light Years to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input * 1.703e+12, 4));
                                    break;
                                // Light Years to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 9.461e+18, 4));
                                    break;
                                // Light Years to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input * 9.461e+17, 4));
                                    break;
                                // ALight Years to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input * 9.461e+15, 4));
                                    break;
                                // Light Years to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input * 9.461e+12, 4));
                                    break;
                                // Light Years to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input * 63241, 4));
                                    break;
                                // Light Years to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input, 4));
                                    break;
                                // Light Years to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input / 3.262, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.DistanceUnits.Parsecs:
                            switch (toDistUnits)
                            {
                                // Parsecs to Inches
                                case Units.DistanceUnits.Inches:
                                    sReturn = string.Format("{0} in.", Math.Round(input * 1.215e+18, 4));
                                    break;
                                // Parsecs to Feet
                                case Units.DistanceUnits.Feet:
                                    sReturn = string.Format("{0} ft.", Math.Round(input * 1.012e+17, 4));
                                    break;
                                // Parsecs to Yards
                                case Units.DistanceUnits.Yards:
                                    sReturn = string.Format("{0} yd.", Math.Round(input * 3.375e+16, 4));
                                    break;
                                // Parsecs to Miles
                                case Units.DistanceUnits.Miles:
                                    sReturn = string.Format("{0} mi.", Math.Round(input * 1.917e+13, 4));
                                    break;
                                // Parsecs to Nautical Miles
                                case Units.DistanceUnits.Nautical_Miles:
                                    sReturn = string.Format("{0} NM", Math.Round(input * 1.666e+13, 4));
                                    break;
                                // Parsecs to Nautical Leagues
                                case Units.DistanceUnits.Leagues:
                                    sReturn = string.Format("{0} NL", Math.Round(input * 5.554e+12, 4));
                                    break;
                                // Parsecs to mm
                                case Units.DistanceUnits.Millimeters:
                                    sReturn = string.Format("{0} mm", Math.Round(input * 9.223e+18, 4));
                                    break;
                                // Parsecs to cm
                                case Units.DistanceUnits.Centimeters:
                                    sReturn = string.Format("{0} cm", Math.Round(input * 3.086e+18, 4));
                                    break;
                                // Parsecs to m
                                case Units.DistanceUnits.Meters:
                                    sReturn = string.Format("{0} m", Math.Round(input * 3.086e+16, 4));
                                    break;
                                // Parsecs to Km
                                case Units.DistanceUnits.Kilometers:
                                    sReturn = string.Format("{0} Km", Math.Round(input * 3.086e+13, 4));
                                    break;
                                // Parsecs to Astronomical Units
                                case Units.DistanceUnits.Astronomical_Units:
                                    sReturn = string.Format("{0} AU", Math.Round(input * 206265, 4));
                                    break;
                                // Parsecs to Light-Years
                                case Units.DistanceUnits.Light_Years:
                                    sReturn = string.Format("{0} LY", Math.Round(input * 3.26156, 4));
                                    break;
                                // Parsecs to Parsecs
                                case Units.DistanceUnits.Parsecs:
                                    sReturn = string.Format("{0} pc", Math.Round(input, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        default:
                            sReturn = Utils.Consts.NaN;
                            break;
                    }
                    break;
                case Utils.Enumerations.ConversionType.Speed:
                    Units.SpeedUnits fromSpeedUnits = Units.m_dStringToUnits_Speed[fromSelect];
                    Units.SpeedUnits toSpeedUnits = Units.m_dStringToUnits_Speed[toSelect];
                    switch (fromSpeedUnits)
                    {
                        case Units.SpeedUnits.Feet_Second:
                            switch (toSpeedUnits)
                            {
                                // ft/sec to ft/sec
                                case Units.SpeedUnits.Feet_Second:
                                    sReturn = string.Format("{0} ft./sec.", Math.Round(input, 4));
                                    break;
                                // ft/sec to MPH
                                case Units.SpeedUnits.Miles_Hour:
                                    sReturn = string.Format("{0} MPH", Math.Round(input / 1.4667, 4));
                                    break;
                                // ft/sec to m/sec
                                case Units.SpeedUnits.Meters_Second:
                                    sReturn = string.Format("{0} m/sec.", Math.Round(input / 3.281, 4));
                                    break;
                                // ft/sec to KmH
                                case Units.SpeedUnits.Kilometers_Hour:
                                    sReturn = string.Format("{0} KmH", Math.Round(input * 1.09728, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.SpeedUnits.Miles_Hour:
                            switch (toSpeedUnits)
                            {
                                // MPH to ft/sec
                                case Units.SpeedUnits.Feet_Second:
                                    sReturn = string.Format("{0} ft./sec.", Math.Round(input * 1.4667, 4));
                                    break;
                                // MPH to MPH
                                case Units.SpeedUnits.Miles_Hour:
                                    sReturn = string.Format("{0} MPH", Math.Round(input, 4));
                                    break;
                                // MPH to m/sec
                                case Units.SpeedUnits.Meters_Second:
                                    sReturn = string.Format("{0} m/sec.", Math.Round(input / 2.237, 4));
                                    break;
                                // MPH to KmH
                                case Units.SpeedUnits.Kilometers_Hour:
                                    sReturn = string.Format("{0} KmH", Math.Round(input * 1.609, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.SpeedUnits.Meters_Second:
                            switch (toSpeedUnits)
                            {
                                // m/sec to ft/sec
                                case Units.SpeedUnits.Feet_Second:
                                    sReturn = string.Format("{0} ft./sec.", Math.Round(input * 3.281, 4));
                                    break;
                                // m/sec to MPH
                                case Units.SpeedUnits.Miles_Hour:
                                    sReturn = string.Format("{0} MPH", Math.Round(input * 2.237, 4));
                                    break;
                                // m/sec to m/sec
                                case Units.SpeedUnits.Meters_Second:
                                    sReturn = string.Format("{0} m/sec.", Math.Round(input, 4));
                                    break;
                                // m/sec to KmH
                                case Units.SpeedUnits.Kilometers_Hour:
                                    sReturn = string.Format("{0} KmH", Math.Round(input * 3.6, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.SpeedUnits.Kilometers_Hour:
                            switch (toSpeedUnits)
                            {
                                // KmH to ft/sec
                                case Units.SpeedUnits.Feet_Second:
                                    sReturn = string.Format("{0} ft./sec.", Math.Round(input / 1.09728, 4));
                                    break;
                                // KmH to MPH
                                case Units.SpeedUnits.Miles_Hour:
                                    sReturn = string.Format("{0} MPH", Math.Round(input / 1.609, 4));
                                    break;
                                // KmH to m/sec
                                case Units.SpeedUnits.Meters_Second:
                                    sReturn = string.Format("{0} m/sec.", Math.Round(input / 3.6, 4));
                                    break;
                                // KmH to KmH
                                case Units.SpeedUnits.Kilometers_Hour:
                                    sReturn = string.Format("{0} KmH", Math.Round(input, 4));
                                    break;
                                default: sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                    }
                    break;
                case Utils.Enumerations.ConversionType.Volume:
                    Units.VolumeUnits fromVolumeUnits = Units.m_dStringToUnits_Volume[fromSelect];
                    Units.VolumeUnits toVolumeUnits = Units.m_dStringToUnits_Volume[toSelect];
                    switch (fromVolumeUnits)
                    {
                        case Units.VolumeUnits.teaspoons:
                            switch (toVolumeUnits)
                            {
                                // Teaspoons to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input, 4));
                                    break;
                                // Teaspoons to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input / 3, 4));
                                    break;
                                // Teaspoons to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input / 6, 4));
                                    break;
                                // Teaspoons to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input / 48.692, 4));
                                    break;
                                // Teaspoons to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input / 96, 4));
                                    break;
                                // Teaspoons to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input / 192, 4));
                                    break;
                                // Teaspoons to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 768, 4));
                                    break;
                                // Teaspoons to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 32256, 4));
                                    break;
                                // Teaspoons to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 4.92892, 4));
                                    break;
                                // Teaspoons to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 203, 4));
                                    break;
                                // Teaspoons to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 202884, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Tablespoons:
                            switch (toVolumeUnits)
                            {
                                // Tablespoons to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 3, 4));
                                    break;
                                // Tablespoons to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input, 4));
                                    break;
                                // Tablespoons to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input / 2, 4));
                                    break;
                                // Tablespoons to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input / 16.231, 4));
                                    break;
                                // Tablespoons to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input / 32, 4));
                                    break;
                                // Tablespoons to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input / 64, 4));
                                    break;
                                // Tablespoons to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 256, 4));
                                    break;
                                // Tablespoons to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 10752, 4));
                                    break;
                                // Tablespoons to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 14.7868, 4));
                                    break;
                                // Tablespoons to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 67.628, 4));
                                    break;
                                // Tablespoons to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 67628, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Fluid_Ounce:
                            switch (toVolumeUnits)
                            {
                                // Fluid_Ounce to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 6, 4));
                                    break;
                                // Fluid_Ounce to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 2, 4));
                                    break;
                                // Fluid_Ounce to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input, 4));
                                    break;
                                // Fluid_Ounce to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input / 8.115, 4));
                                    break;
                                // Fluid_Ounce to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input / 16, 4));
                                    break;
                                // Fluid_Ounce to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input / 32, 4));
                                    break;
                                // Fluid_Ounce to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 128, 4));
                                    break;
                                // Fluid_Ounce to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 5376, 4));
                                    break;
                                // Fluid_Ounce to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 29.574, 4));
                                    break;
                                // Fluid_Ounce to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 33.814, 4));
                                    break;
                                // Fluid_Ounce to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 33814, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Cups:
                            switch (toVolumeUnits)
                            {
                                // Cups to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 48.692, 4));
                                    break;
                                // Cups to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 16.2307, 4));
                                    break;
                                // Cups to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input * 8.115, 4));
                                    break;
                                // Cups to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input, 4));
                                    break;
                                // Cups to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input / 1.972, 4));
                                    break;
                                // TeasCupspoons to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input / 3.943, 4));
                                    break;
                                // Cups to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 15.773, 4));
                                    break;
                                // Cups to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 662, 4));
                                    break;
                                // Cups to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 240, 4));
                                    break;
                                // Cups to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 4.167, 4));
                                    break;
                                // Cups to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 4167, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Pints:
                            switch (toVolumeUnits)
                            {
                                // Pints to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 96, 4));
                                    break;
                                // Pints to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 32, 4));
                                    break;
                                // Pints to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input * 16, 4));
                                    break;
                                // Pints to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input * 1.972, 4));
                                    break;
                                // Pints to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input, 4));
                                    break;
                                // Pints to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input / 2, 4));
                                    break;
                                // Pints to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 8, 4));
                                    break;
                                // Pints to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 336, 4));
                                    break;
                                // Pints to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 473, 4));
                                    break;
                                // Pints to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 2.113, 4));
                                    break;
                                // Pints to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 2113, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Quarts:
                            switch (toVolumeUnits)
                            {
                                // Quarts to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 192, 4));
                                    break;
                                // Quarts to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 64, 4));
                                    break;
                                // Quarts to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input * 32, 4));
                                    break;
                                // Quarts to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input * 3.943, 4));
                                    break;
                                // Quarts to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input * 2, 4));
                                    break;
                                // Quarts to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input, 4));
                                    break;
                                // Quarts to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 4, 4));
                                    break;
                                // Quarts to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 168, 4));
                                    break;
                                // Quarts to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 946, 4));
                                    break;
                                // Quarts to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 1.057, 4));
                                    break;
                                // Quarts to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 1057, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Gallons:
                            switch (toVolumeUnits)
                            {
                                // Gallons to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 768, 4));
                                    break;
                                // Gallons to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 256, 4));
                                    break;
                                // Gallons to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input * 128, 4));
                                    break;
                                // Gallons to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input * 15.773, 4));
                                    break;
                                // Gallons to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input * 8, 4));
                                    break;
                                // Gallons to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input * 4, 4));
                                    break;
                                // Gallons to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input, 4));
                                    break;
                                // Gallons to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 42, 4));
                                    break;
                                // Gallons to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 3785, 4));
                                    break;
                                // Gallons to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input * 3.785, 4));
                                    break;
                                // Gallons to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 264, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Barrels:
                            switch (toVolumeUnits)
                            {
                                // Barrels to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 32256, 4));
                                    break;
                                // Barrels to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 10752, 4));
                                    break;
                                // Barrels to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input * 5376, 4));
                                    break;
                                // Barrels to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input * 662, 4));
                                    break;
                                // Barrels to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input * 336, 4));
                                    break;
                                // Barrels to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input * 168, 4));
                                    break;
                                // Barrels to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input * 42, 4));
                                    break;
                                // Barrels to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input, 4));
                                    break;
                                // Barrels to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 158987, 4));
                                    break;
                                // Barrels to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input * 158.987, 4));
                                    break;
                                // Barrels to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 6.29, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Milliliters:
                            switch (toVolumeUnits)
                            {
                                // Milliliters to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input / 4.929, 4));
                                    break;
                                // Milliliters to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input / 14.787, 4));
                                    break;
                                // Milliliters to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input / 29.574, 4));
                                    break;
                                // Milliliters to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input / 240, 4));
                                    break;
                                // Milliliters to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input / 473, 4));
                                    break;
                                // Milliliters to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input / 946, 4));
                                    break;
                                // Milliliters to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 3785, 4));
                                    break;
                                // Milliliters to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 158987, 4));
                                    break;
                                // Milliliters to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input, 4));
                                    break;
                                // Milliliters to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 1000, 4));
                                    break;
                                // Milliliters to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 1e+6, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Liters:
                            switch (toVolumeUnits)
                            {
                                // Liters to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 203, 4));
                                    break;
                                // Liters to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 67.628, 4));
                                    break;
                                // Liters to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input * 33.814, 4));
                                    break;
                                // Liters to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input * 4.167, 4));
                                    break;
                                // Liters to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input * 2.113, 4));
                                    break;
                                // Liters to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input * 1.057, 4));
                                    break;
                                // Liters to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input / 3.785, 4));
                                    break;
                                // Liters to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input / 159, 4));
                                    break;
                                // Liters to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 1000, 4));
                                    break;
                                // Liters to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input, 4));
                                    break;
                                // Liters to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input / 1000, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        case Units.VolumeUnits.Cubic_Meters:
                            switch (toVolumeUnits)
                            {
                                // Cubic_Meters to Teaspoons
                                case Units.VolumeUnits.teaspoons:
                                    sReturn = string.Format("{0} tspn", Math.Round(input * 202884, 4));
                                    break;
                                // Cubic_Meters to Tablespoons
                                case Units.VolumeUnits.Tablespoons:
                                    sReturn = string.Format("{0} Tbsp", Math.Round(input * 67628, 4));
                                    break;
                                // Cubic_Meters to Fluid_Ounce
                                case Units.VolumeUnits.Fluid_Ounce:
                                    sReturn = string.Format("{0} Fl. Oz.", Math.Round(input * 33814, 4));
                                    break;
                                // Cubic_Meters to Cups
                                case Units.VolumeUnits.Cups:
                                    sReturn = string.Format("{0} cups", Math.Round(input * 4167, 4));
                                    break;
                                // Cubic_Meters to Pints
                                case Units.VolumeUnits.Pints:
                                    sReturn = string.Format("{0} pints", Math.Round(input * 2113, 4));
                                    break;
                                // Cubic_Meters to Quarts
                                case Units.VolumeUnits.Quarts:
                                    sReturn = string.Format("{0} q", Math.Round(input * 1056, 4));
                                    break;
                                // Cubic_Meters to Gallons
                                case Units.VolumeUnits.Gallons:
                                    sReturn = string.Format("{0} g", Math.Round(input * 264, 4));
                                    break;
                                // Cubic_Meters to Barrels
                                case Units.VolumeUnits.Barrels:
                                    sReturn = string.Format("{0} barrels", Math.Round(input * 6.29, 4));
                                    break;
                                // Cubic_Meters to Milliliters
                                case Units.VolumeUnits.Milliliters:
                                    sReturn = string.Format("{0} mL", Math.Round(input * 1e+6, 4));
                                    break;
                                // Cubic_Meters to Liters
                                case Units.VolumeUnits.Liters:
                                    sReturn = string.Format("{0} L", Math.Round(input / 1000, 4));
                                    break;
                                // Cubic_Meters to Cubic Meters
                                case Units.VolumeUnits.Cubic_Meters:
                                    sReturn = string.Format("{0} m3", Math.Round(input, 4));
                                    break;
                                default:
                                    sReturn = Utils.Consts.NaN;
                                    break;
                            }
                            break;
                        default:
                            sReturn = Utils.Consts.NaN;
                            break;
                    }
                    break;
                case Utils.Enumerations.ConversionType.Invalid:
                default:
                    sReturn = Utils.Consts.NaN;
                    break;
            }
            return sReturn;
        }
    }
}
