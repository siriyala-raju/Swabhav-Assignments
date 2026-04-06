using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetGravityEnum
{
    enum Planet
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }
    internal class Planets
    {
        public static double Gravity(Planet p)
        {
            switch (p)
            {
                case Planet.Mercury: return 3.7;
                case Planet.Venus: return 8.87;
                case Planet.Earth: return 9.8;
                case Planet.Mars: return 3.71;
                case Planet.Jupiter: return 24.79;
                case Planet.Saturn: return 10.44;
                case Planet.Uranus: return 8.69;
                case Planet.Neptune: return 11.15;
                default: return 9.8;
            }
        }
    }
}
