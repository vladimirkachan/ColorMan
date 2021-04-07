using System;
using System.Collections.Generic;
using ColorMan.ContractLibrary;

namespace ColorMan
{
    public class ColorSpaceComponent
    {
        public event EventHandler ValueChanged;
        public event EventHandler<LinkedItemEventArgs<float>>  NewColor;
        readonly List<Pack> packs = new List<Pack>();
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
        public void AddPacks(params Pack[] pp)
        {
            foreach (var p in pp)
            {
                packs.Add(p);
                p.ValueChanged += pack_ValueChanged;
            }
        }
        public void SetValIn(float value)
        {
            foreach (var pack in packs)
            {
                pack.ValueChanged -= pack_ValueChanged;
                Val = value;
                pack.SetValIn(value);
                pack.ValueChanged += pack_ValueChanged;
            }
        }
        void pack_ValueChanged(object sender, EventArgs e)
        {
            Pack caller = (Pack)sender;
            Val = caller.Val;
            foreach (var item in packs) if (item != caller) item.SetValIn(Val);
            OnNewColor();
        }
        void OnNewColor()
        {
            if (NewColor != null) NewColor(this, new LinkedItemEventArgs<float>(Val));
        }
        void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(this, e);
        }


    }
}
