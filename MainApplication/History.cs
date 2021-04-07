using ColorMan.ColorSpaces;
using ColorMan.ControlsLibrary;

namespace ColorMan
{
    public class History
    {
        IBaseSpace currentValue;

        public HistoryBox BackBox { get; set; }
        public HistoryBox ForwardBox { get; set; }

        public void InitValue(IBaseSpace value)
        {
            currentValue = value;
        }
        public void SetCurrentValue(IBaseSpace value)
        {
            if (value == null || BackBox == null || Equals(currentValue, value)) return;
            BackBox.Push(currentValue);
            currentValue = value;
        }
        public IBaseSpace Back()
        {
            for (int i = 0; i < BackBox.SelectedIndex + 1; i++)
            {
                ForwardBox.Push(currentValue);
                currentValue = BackBox.Pop();
            }
            return currentValue;
        }
        public IBaseSpace Forward()
        {
            for (int i = 0; i < ForwardBox.SelectedIndex + 1; i++)
            {
                BackBox.Push(currentValue);
                currentValue = ForwardBox.Pop();
            }
            return currentValue;
        }
        static bool Equals(IBaseSpace x, IBaseSpace y)
        {
            if (x == null || y == null) return false;
            string xh = x.ToColor().ToHex(), yh = y.ToColor().ToHex();
            return xh == yh;
        }

        #region Singleton

        static readonly History instance = new History();
        public static History Instance { get { return instance; } }
        History() { }

        #endregion
    }
}
