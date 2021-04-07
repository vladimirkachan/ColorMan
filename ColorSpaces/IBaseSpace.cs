using System.Drawing;

namespace ColorMan.ColorSpaces
{
    public interface IBaseSpace
    {
        float[] GetValues();
        string Hex { get; }
        Color ToColor();
        IBaseSpace Create(Color color);
        IBaseSpace Create(string hex);
    }
}