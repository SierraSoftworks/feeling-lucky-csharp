using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FeelingLucky
{
    class ReturnTypeMethodFilter : MethodFilter
    {
        public ReturnTypeMethodFilter(Type returnType)
        {
            ReturnType = returnType;
        }

        public Type ReturnType { get; private set; }

        public override IEnumerable<MethodInfo> Filter(IEnumerable<MethodInfo> methods)
        {
            return methods.Where(m => ReturnType.IsAssignableFrom(m.ReturnType));
        }
    }
}