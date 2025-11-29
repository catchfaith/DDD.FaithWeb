using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Shared.mapper
{
    public static class MapperHelper
    {
        /// <summary>
        /// 单对象映射
        /// </summary>
        public static TTarget Map<TSource, TTarget>(TSource source) where TTarget : new()
        {
            if (source == null) return default;

            TTarget target = new TTarget();
            var sourceProps = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var targetProps = typeof(TTarget).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var targetProp in targetProps)
            {
                var sourceProp = sourceProps.FirstOrDefault(p => p.Name == targetProp.Name && p.PropertyType == targetProp.PropertyType);
                if (sourceProp != null)
                {
                    var value = sourceProp.GetValue(source);
                    targetProp.SetValue(target, value);
                }
            }

            return target;
        }

        /// <summary>
        /// 集合映射
        /// </summary>
        public static List<TTarget> MapList<TSource, TTarget>(IEnumerable<TSource> sourceList) where TTarget : new()
        {
            if (sourceList == null) return null;

            return sourceList.Select(Map<TSource, TTarget>).ToList();
        }
    }
}
