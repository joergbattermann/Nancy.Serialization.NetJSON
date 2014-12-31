using NetJSON;

namespace Nancy.Serialization.NetJSON
{
    public static class Options
    {
        /// <summary>
        /// This merely forwards the provided value to <see cref="NetJSON.UseISOFormat" />.
        /// As that property does not expose a getter, no one can reliably be provided here, too.
        /// </summary>
        /// <value>
        /// <c>true</c> if ISO8601 date time format shall be used; otherwise, <c>false</c> (which means ticks will be used).
        /// </value>
        public static bool UseIso8601DateTimeFormat
        {
            set { global::NetJSON.NetJSON.UseISOFormat = value; }
        }

        /// <summary>
        /// This merely forwards the provided value to <see cref="NetJSON.CaseSensitive" />.
        /// As that property does not expose a getter, no one can reliably be provided here, too.
        /// </summary>
        /// <value>
        ///   <c>true</c> if (de-)serialization shall be case sensitive; otherwise, <c>false</c>.
        /// </value>
        public static bool CaseSensitive
        {
            set { global::NetJSON.NetJSON.CaseSensitive = value; }
        }

        /// <summary>
        /// This merely forwards the provided value to <see cref="NetJSON.UseEnumString" />.
        /// As that property does not expose a getter, no one can reliably be provided here, too.
        /// </summary>
        /// <value>
        ///   <c>true</c> if use enums shall be (de-)serialized via their string representation; otherwise, <c>false</c>.
        /// </value>
        public static bool UseEnumString
        {
            set { global::NetJSON.NetJSON.UseEnumString = value; }
        }

        /// <summary>
        /// This merely forwards the provided value to <see cref="NetJSON.SkipDefaultValue" />.
        /// As that property does not expose a getter, no one can reliably be provided here, too.
        /// </summary>
        /// <value>
        ///   <c>true</c> if default values shall be skipped entirely; otherwise, <c>false</c>.
        /// </value>
        public static bool SkipDefaultValue
        {
            set { global::NetJSON.NetJSON.SkipDefaultValue = value; }
        }

        /// <summary>
        /// This merely forwards the provided value to <see cref="NetJSON.GenerateAssembly" />.
        /// As that property does not expose a getter, no one can reliably be provided here, too.
        /// </summary>
        /// <value>
        ///   <c>true</c> if a serialization assembly shall be generated during runtime; otherwise, <c>false</c>.
        /// </value>
        public static bool GenerateAssembly
        {
            set { global::NetJSON.NetJSON.GenerateAssembly = value; }
        }

        /// <summary>
        /// This merely forwards the provided value to <see cref="NetJSON.IncludeFields"/>.
        /// As that property does not expose a getter, no one can reliably be provided here, too.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fields shall be included in serialization, otherwise, <c>false</c>.
        /// </value>
        public static bool IncludeFields
        {
            set { global::NetJSON.NetJSON.IncludeFields = value; }
        }
    }
}