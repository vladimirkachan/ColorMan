using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ColorMan.ColorSpaces
{
    public static class SpaceParser
    {
        public static bool TryGetSpaceFromTypeAndHex(string input, out IBaseSpace space)
        {
            space = null;
            try
            {
                string[] ss = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                space = (IBaseSpace)Activator.CreateInstance(Type.GetType("ColorMan.ColorSpaces." + ss[0], false, true), ss[1]);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (NotSupportedException)
            {
                return false;
            }
            catch (TargetInvocationException)
            {
                return false;
            }
            catch (MethodAccessException)
            {
                return false;
            }
            catch (MissingMethodException)
            {
                return false;
            }
            catch (MemberAccessException)
            {
                return false;
            }
            catch (InvalidComObjectException)
            {
                return false;
            }
            catch (COMException)
            {
                return false;
            }
            catch (TypeLoadException)
            {
                return false;
            }
        }
    }
}