using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FeelingLucky
{
    class StaticMethodFilter : MethodFilter
    {
        public StaticMethodFilter()
        {

        }

        public override IEnumerable<MethodInfo> Filter(IEnumerable<MethodInfo> methods)
        {
            return methods.Where(m => (m.CallingConvention & CallingConventions.Standard) != 0);
        }
    }
}