using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nancy.Serialization.NetJSON.Tests
{
    [TestClass]
    public class NetJSONSerializerFixture
    {
        [TestMethod]
        public void when_serializing()
        {
            // Given
            var guid = Guid.NewGuid();
            var data = new TestClass { SomeString = "some string value", SomeGuid = guid };
            string expected
                = string.Format("{{\"SomeGuid\":\"{0}\",\"SomeString\":\"some string value\"}}", guid);

            // When
            string actual;
            using (var stream = new MemoryStream())
            {
                ISerializer serializer = new NetJSONSerializer();
                serializer.Serialize("application/json", data, stream);
                actual = Encoding.UTF8.GetString(stream.ToArray());
            }

            // Then
            Assert.AreEqual(expected, actual);
        }
    }

    public class TestClass
    {
        public Guid SomeGuid { get; set; }
        public string SomeString { get; set; }
    }
}
