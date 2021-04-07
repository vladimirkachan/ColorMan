using System;
using System.Drawing;

namespace ColorMan.ControlsLibrary
{
    [Serializable]
    public class ZoomViewerData
    {
        public ZoomViewerSettings CurrentSetting { get; private set; }
        public Bitmap Snapshot { get; private set; }
        public Point Center { get; private set; }
        public Size SourceSize { get; private set; }
        public Size SourceLocation { get; private set; }
        public Rectangle Source { get; private set; }
        public Point Coordinate { get; private set; }
        public Color PickedColor { get; private set; }
        public Color InvertedColor { get; private set; }
        public Image Picture { get; private set; }

        public ZoomViewerData(ZoomViewerSettings settings, Bitmap snapshot, Point center, Size sourceSize, 
            Size sourceLocation, Rectangle source, Point coordinate, Color pickedColor, Color invertedColor,
            Image picture)
        {
            CurrentSetting = settings;
            Snapshot = snapshot;
            Center = center;
            SourceSize = sourceSize;
            SourceLocation = sourceLocation;
            Source = source;
            Coordinate = coordinate;
            PickedColor = pickedColor;
            InvertedColor = invertedColor;
            Picture = picture;
        }
    }
}
