using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nkolay.Web.Api.Data
{
    public static class SchemaUtility
    {
        public static EntityTypeBuilder ToNkolayTable(this EntityTypeBuilder entityTypeBuilder, Type type)
        {
            return entityTypeBuilder.ToTable(type.Name, GetSchema(type));
        }
        public static string GetSchema(Type type)
        {
            var arr = type.Namespace.Split(".");
            var baseSchema = arr[arr.Length - 2];
            var childSchema = arr[arr.Length - 1];
            return baseSchema[0].ToString();
            //return string.Format($"{baseSchema}.{childSchema}");
            //var baseSchema = ParseEnum<DbSchemas>(arr[arr.Length - 1]);
            //var childSchema = ParseEnum<DbSchemas>(arr[arr.Length - 2]);
            //return string.Format($"{baseSchema}.{childSchema}");
        }
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase: true);
        }
    }
}
