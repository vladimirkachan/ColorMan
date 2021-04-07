using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
    public partial class WrapControl : LightingControl
    {
        IDirectedCrement directedCrement;

        public Button ButtonOk { get; set; }
        public Control Content
        {
            get { return Controls.Count > 0 ? Controls[0] : null; }
            set
            {
                if (value == null) return;
                Controls.Add(value);
                directedCrement = value as IDirectedCrement;
                value.Location = Point.Empty;
                value.Margin = new Padding(0);
                value.Dock = DockStyle.Fill;
                value.MouseEnter += ControlMouseEnter;
                value.MouseLeave += ControlMouseLeave;
                value.MouseDown += ControlEnter;
            }
        }

        public WrapControl()
        {
            InitializeComponent();
        }

        protected override void ControlEnter(object sender, EventArgs e)
        {
            base.ControlEnter(sender, e);
            if (Content != null) Content.Focus();
        }
       /// <summary>
       /// Обрабатывает управляющую клавишу.
       /// </summary>
       /// <returns>
       /// Значение true, если символ был обработан элементом управления; в противном случае — значение false.
       /// </returns>
       /// <param name="msg">Передаваемый по ссылке объект <see cref="T:System.Windows.Forms.Message"/>,
       ///  представляющий сообщение окна для обработки. 
       /// </param><param name="keyData">Одно из значений <see cref="T:System.Windows.Forms.Keys"/>, 
       /// представляющее обрабатываемую клавишу. </param>
       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
       {
           if (directedCrement == null) return base.ProcessCmdKey(ref msg, keyData);
           switch (keyData)
           {
               case Keys.Up: directedCrement.ToUp(); return true;
               case Keys.Down: directedCrement.ToDown(); return true;
               case Keys.Left: directedCrement.ToLeft(); return true;
               case Keys.Right: directedCrement.ToRight(); return true;
               case Keys.Enter: if (ButtonOk != null) ButtonOk.PerformClick(); return true;
           }
           return base.ProcessCmdKey(ref msg, keyData);
       }
    }
}
