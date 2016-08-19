using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FeelingLucky
{
    class InstanceMethodFilter : MethodFilter
    {
        public InstanceMethodFilter()
        {

        }

        public override IEnumerable<MethodInfo> Filter(IEnumerable<MethodInfo> methods)
        {
            return methods.Where(m => (m.CallingConvention & CallingConventions.HasThis) != 0);
        }
    }
}