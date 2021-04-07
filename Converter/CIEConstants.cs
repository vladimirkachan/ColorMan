using System;

[assembly: CLSCompliant(true)]
namespace ColorMan.ColorSpaces.Converter
{
    static class CIEConstants
    {
        public const double Epsilon = 216d / 24389d;
        public const double Kappa = 24389d / 27d;
    }
}
