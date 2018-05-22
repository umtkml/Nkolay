using System;
using Xunit;
using Nkolay.Data.Mapping;
using Nkolay.Core.Domain.D.Bayi;

namespace Nkolay.Data.Test
{
    public class UnitTest1
    {
        [Fact]
        public static void Test1()
        {
            var sch = SchemaUtility.GetSchema(typeof(D_BAYI_LIMIT));
            Console.WriteLine(sch);
        }
    }
}
