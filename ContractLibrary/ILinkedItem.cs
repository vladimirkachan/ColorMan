
using System;

[assembly: CLSCompliant(true)]
namespace ColorMan.ContractLibrary
{
    public interface ILinkedItem<T>
    {
        T Val { get; }
        event EventHandler<LinkedItemEventArgs<T>> NewValue;
        void SetValIn(T value);
    }
}
