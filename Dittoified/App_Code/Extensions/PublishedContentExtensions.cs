using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo
{
    public static class PublishedContentExtensions
    {
        public static object Get(this IPublishedContent content,
            string propertyAlias,
            bool recursive = false,
            object defaultValue = null)
        {
            return content.GetPropertyValue(propertyAlias, recursive, defaultValue);
        }

        public static T Get<T>(this IPublishedContent content,
            string propertyAlias,
            bool recursive = false,
            T defaultValue = default(T))
        {
            if (content == null)
                return defaultValue;

            return content.GetPropertyValue<T>(propertyAlias, recursive, defaultValue);
        }
    }
}
