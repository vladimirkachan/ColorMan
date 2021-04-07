using System;
using ColorMan.ColorSpaces;

namespace ColorMan
{
	public class TwoColorton
	{
		IBaseSpace space1, space2;
		
		public event EventHandler SpaceSwapped;
		public event EventHandler Space1Changed;
		public event EventHandler Space2Changed;

		public IBaseSpace Space1
		{
			get { return space1; }
			set
			{
				space1 = value;
				OnSpace1Changed(null);
			}
		}
		
		public IBaseSpace Space2
		{
			get { return space2; }
			set
			{
				space2 = value;
				OnSpace2Changed(null);
			}
		}
		
		public void Swap()
		{
			IBaseSpace space = space1;
			space1 = space2;
			space2 = space;
			OnSpaceSwapped(null);
		}
		void OnSpaceSwapped(EventArgs e)
		{
			if (SpaceSwapped != null) SpaceSwapped(this, e);
		}
		void OnSpace1Changed(EventArgs e)
		{
			if (Space1Changed != null) Space1Changed(this, e);
		}
		void OnSpace2Changed(EventArgs e)
		{
			if (Space2Changed != null) Space2Changed(this, e);
		}

		#region Singleton

	    static readonly TwoColorton instance = new TwoColorton();
		TwoColorton() { }
		public static TwoColorton Instance { get { return instance; } }

		#endregion
	}
}