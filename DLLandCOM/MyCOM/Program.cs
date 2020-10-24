using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCOM
{
    [Guid("F28527C8-ED50-4D97-861B-699E29E2D747")]
    public interface MyCom_Interface
    {
        [DispId(1)]
        int Add(int a, int b);
        [DispId(2)]
        int Mul(int a, int b);
    }
    [Guid("295929D8-0820-433F-AF8F-C27F2818B5C4"),
    InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface MyCom_Events
    {
    }
    [Guid("664C245A-EAD4-444D-B57E-133A7A69BFBB"),
    ClassInterface(ClassInterfaceType.None),
    ComSourceInterfaces(typeof(MyCom_Events))]
    [ComVisible(true)]
    public class Class1 : MyCom_Interface
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }
    }
}
