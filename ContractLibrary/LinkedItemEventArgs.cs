using System;

namespace ColorMan.ContractLibrary
{
    public class LinkedItemEventArgs<T> : EventArgs
    {
        public T Val { get; private set; }

        public LinkedItemEventArgs() { }
        public LinkedItemEventArgs(T val)
        {
            Val = val;
        }
    }
}
