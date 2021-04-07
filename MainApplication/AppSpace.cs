using System;
using System.Collections.Generic;
using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;

namespace ColorMan
{
    public abstract class AppSpace : ILinkedItem<IBaseSpace>
    {
        readonly Dictionary<string, ColorSpaceComponent> component = new Dictionary<string, ColorSpaceComponent>();
        protected Dictionary<string, ColorSpaceComponent> Component { get { return component; } }
        public ColorSpaceComponent this[string name] { get { return component[name]; } }
		public IBaseSpace Val { get; protected set; }
        protected Type SpaceType { get; private set; }
        public event EventHandler<LinkedItemEventArgs<IBaseSpace>> NewValue;
		public abstract void SetValIn(IBaseSpace value);
	    public abstract void NewColor(object sender, LinkedItemEventArgs<float> args);

        protected AppSpace(Type spaceType, params string[] name)
        {
            SpaceType = spaceType;
            foreach (string n in name)
            {
                component[n] = new ColorSpaceComponent();
                component[n].NewColor += NewColor;
            }
        }
        protected void OnNewValue()
        {
            if (NewValue != null) NewValue(this, new LinkedItemEventArgs<IBaseSpace>(Val));
        }

    }
}
