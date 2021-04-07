using System;
using System.Collections.Generic;
using ColorMan.ContractLibrary;

namespace ColorMan
{
    public class Pack
    {
        public event EventHandler ValueChanged;
        readonly List<ILinkedItem<float>> items = new List<ILinkedItem<float>>();
        float val;

        public float Val
        {
            get { return val; }
            private set
            {
                val = value;
                OnValueChanged(null);
            }
        }
        public Pack(params ILinkedItem<float>[] controls)
        {
            foreach (ILinkedItem<float> ctrl in controls)
            {
                items.Add(ctrl);
                ctrl.NewValue += ctrl_NewValue;
            }
        }

        public void SetValIn(float value)
        {
            foreach (var item in items) if (!float.IsNaN(value )) item.SetValIn(value);
        }
        void ctrl_NewValue(object sender, LinkedItemEventArgs<float> args)
        {
            float v = args.Val;
            foreach (var item in items) if (item != sender) item.SetValIn(v);
            Val = v;
        }
        void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(this, e);
        }

    }
}
