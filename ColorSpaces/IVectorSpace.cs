using System.Drawing;

namespace ColorMan.ColorSpaces
{
    public interface IVectorSpace
    {
		Vector Linear { get; }
        string Hex { get; }
        IVectorSpace Create(Vector vector);
        Color ToColor();
		Color FromSpace(Vector linear);
    }
}
