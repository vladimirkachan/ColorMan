using System;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace ColorMan.ControlsLibrary
{
    [Serializable]
    public class ZoomViewerSettings
    {
        readonly ZoomViewerAverageSize averageMode;
        readonly InterpolationMode interpolationMode;
        readonly int zoomIndex;

        public ZoomViewerAverageSize AverageMode { get { return averageMode; } }
        public InterpolationMode InterpolationMode { get { return interpolationMode; } }
        public int ZoomIndex { get { return zoomIndex; } }

        public ZoomViewerSettings(ZoomViewerAverageSize averageMode, InterpolationMode interpolationMode, int zoomIndex)
        {
            this.averageMode = averageMode;
            this.interpolationMode = interpolationMode;
            this.zoomIndex = zoomIndex;
        }
        public ZoomViewerSettings(string settings)
        {
            string[] field = settings.Split();
            bool success = Enum.TryParse(field[0], out averageMode);
            success &= Enum.TryParse(field[1], out interpolationMode);
            success &= int.TryParse(field[2], out zoomIndex);
            if (!success) throw new ArgumentException(settings);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2}", AverageMode, InterpolationMode, ZoomIndex);
        }
    }
}
