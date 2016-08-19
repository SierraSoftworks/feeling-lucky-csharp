using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FeelingLucky
{
    public class FeelingLucky
    {
        public FeelingLucky(Type targetType, params MethodFilter[] methodFilters)
        {
            TargetType = targetType;
            MethodFilters = methodFilters;
        }

        public Type TargetType { get; private set; }

        public IEnumerable<MethodFilter> MethodFilters { get; set; }

        public object Execute(object targetInstance = null)
        {
            var methods = 
                MethodFilters.Prepend(targetInstance != null ? (MethodFilter)new InstanceMethodFilter() : (MethodFilter)new StaticMethodFilter())
                .Aggregate(TargetType.GetMethods() as IEnumerable<MethodInfo>, (m, filter) => filter.Filter(m))
                .ToArray();
            if (!methods.Any()) return null;

            var rand = new Random();
            var method = methods[rand.Next(0, methods.Length)];

            var args = BuildArgumentsList(method).ToArray();
            return method.Invoke(targetInstance, args);
        }

        private IEnumerable<object> BuildArgumentsList(MethodInfo method)
        {
            return method.GetParameters().Select(param => CreateDefault(param.ParameterType));
        }

        private object CreateDefault(Type type)
        {
            try
            {
                return Activator.CreateInstance(type);
            }
            catch
            {
                return null;
            }
        }
    }   
} 