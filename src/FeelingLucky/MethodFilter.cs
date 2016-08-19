using System;
using System.Collections.Generic;
using System.Reflection;

namespace FeelingLucky
{
    public abstract class MethodFilter
    {
        public abstract IEnumerable<MethodInfo> Filter(IEnumerable<MethodInfo> methods);
    }
}