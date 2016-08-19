using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FeelingLucky
{
    public class SuppressBoringMethodFilter : MethodFilter
    {
        public override IEnumerable<MethodInfo> Filter(IEnumerable<MethodInfo> methods)
        {
            var objType = typeof(object);
            return methods.Where(m => m.DeclaringType != objType);
        }
    }
}
