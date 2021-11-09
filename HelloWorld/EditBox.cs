using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface IDataBound
    {
        void Bind(System.Reflection.Binder b);
    }

    public class EditBox : IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(System.Reflection.Binder b) { }
    }
}
