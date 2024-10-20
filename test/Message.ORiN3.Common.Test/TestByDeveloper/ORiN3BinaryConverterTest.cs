using Message.ORiN3.Common.V1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Message.ORiN3.Common.Test.TestByDeveloper
{
    public class ORiN3BinaryConverterTest
    {
        private static void ExecuteTest<T>(T target, ORiN3BinaryConverter.DataType expectedDataType)
        {
            var converted = ORiN3BinaryConverter.ToBinary(target);
            Assert.Equal((byte)expectedDataType, converted[0]);
            var actual1 = ORiN3BinaryConverter.ToObject(converted);
            Assert.Equal(target, actual1);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "bool")]
        public void Test001()
        {
            ExecuteTest(true, ORiN3BinaryConverter.DataType.Bool);
            ExecuteTest(false, ORiN3BinaryConverter.DataType.Bool);
            ExecuteTest<bool?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<bool?>(true, ORiN3BinaryConverter.DataType.Bool);
            ExecuteTest<bool?>(false, ORiN3BinaryConverter.DataType.Bool);
            ExecuteTest<bool[]>([true, false], ORiN3BinaryConverter.DataType.BoolArray);
            ExecuteTest<bool[]>([], ORiN3BinaryConverter.DataType.BoolArray);
            ExecuteTest<bool?[]>([false, null, true], ORiN3BinaryConverter.DataType.NullableBoolArray);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "byte")]
        public void Test002()
        {
            ExecuteTest(byte.MinValue, ORiN3BinaryConverter.DataType.UInt8);
            ExecuteTest(byte.MaxValue, ORiN3BinaryConverter.DataType.UInt8);
            ExecuteTest<byte?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<byte?>(byte.MinValue, ORiN3BinaryConverter.DataType.UInt8);
            ExecuteTest<byte?>(byte.MaxValue, ORiN3BinaryConverter.DataType.UInt8);
            ExecuteTest<byte[]>([byte.MinValue, 2, byte.MaxValue], ORiN3BinaryConverter.DataType.UInt8Array);
            ExecuteTest<byte[]>([], ORiN3BinaryConverter.DataType.UInt8Array);
            ExecuteTest<byte?[]>([byte.MaxValue, null, 2, byte.MinValue, null], ORiN3BinaryConverter.DataType.NullableUInt8Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "sbyte")]
        public void Test003()
        {
            ExecuteTest(sbyte.MinValue, ORiN3BinaryConverter.DataType.Int8);
            ExecuteTest(sbyte.MaxValue, ORiN3BinaryConverter.DataType.Int8);
            ExecuteTest<sbyte>(1, ORiN3BinaryConverter.DataType.Int8);
            ExecuteTest<sbyte?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<sbyte?>(sbyte.MinValue, ORiN3BinaryConverter.DataType.Int8);
            ExecuteTest<sbyte?>(sbyte.MaxValue, ORiN3BinaryConverter.DataType.Int8);
            ExecuteTest<sbyte[]>([sbyte.MinValue, 2, sbyte.MaxValue], ORiN3BinaryConverter.DataType.Int8Array);
            ExecuteTest<sbyte[]>([], ORiN3BinaryConverter.DataType.Int8Array);
            ExecuteTest<sbyte?[]>([sbyte.MinValue, null, 2, sbyte.MaxValue, null], ORiN3BinaryConverter.DataType.NullableInt8Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "ushort")]
        public void Test004()
        {
            ExecuteTest(ushort.MinValue, ORiN3BinaryConverter.DataType.UInt16);
            ExecuteTest(ushort.MaxValue, ORiN3BinaryConverter.DataType.UInt16);
            ExecuteTest<ushort>(2, ORiN3BinaryConverter.DataType.UInt16);
            ExecuteTest<ushort>(256, ORiN3BinaryConverter.DataType.UInt16);
            ExecuteTest<ushort?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<ushort?>(ushort.MinValue, ORiN3BinaryConverter.DataType.UInt16);
            ExecuteTest<ushort?>(ushort.MaxValue, ORiN3BinaryConverter.DataType.UInt16);
            ExecuteTest<ushort[]>([ushort.MinValue, 2, 257, ushort.MaxValue], ORiN3BinaryConverter.DataType.UInt16Array);
            ExecuteTest<ushort[]>([], ORiN3BinaryConverter.DataType.UInt16Array);
            ExecuteTest<ushort?[]>([ushort.MinValue, 2, 257, ushort.MaxValue, null], ORiN3BinaryConverter.DataType.NullableUInt16Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "short")]
        public void Test005()
        {
            ExecuteTest(short.MinValue, ORiN3BinaryConverter.DataType.Int16);
            ExecuteTest(short.MaxValue, ORiN3BinaryConverter.DataType.Int16);
            ExecuteTest<short>(1, ORiN3BinaryConverter.DataType.Int16);
            ExecuteTest<short>(256, ORiN3BinaryConverter.DataType.Int16);
            ExecuteTest<short?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<short?>(short.MinValue, ORiN3BinaryConverter.DataType.Int16);
            ExecuteTest<short?>(short.MaxValue, ORiN3BinaryConverter.DataType.Int16);
            ExecuteTest<short[]>([short.MinValue, 2, 257, short.MaxValue], ORiN3BinaryConverter.DataType.Int16Array);
            ExecuteTest<short[]>([], ORiN3BinaryConverter.DataType.Int16Array);
            ExecuteTest<short?[]>([short.MinValue, 2, 257, short.MaxValue, null], ORiN3BinaryConverter.DataType.NullableInt16Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "uint")]
        public void Test006()
        {
            ExecuteTest(uint.MinValue, ORiN3BinaryConverter.DataType.UInt32);
            ExecuteTest(uint.MaxValue, ORiN3BinaryConverter.DataType.UInt32);
            ExecuteTest<uint>(1, ORiN3BinaryConverter.DataType.UInt32);
            ExecuteTest<uint>(256, ORiN3BinaryConverter.DataType.UInt32);
            ExecuteTest<uint?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<uint?>(uint.MinValue, ORiN3BinaryConverter.DataType.UInt32);
            ExecuteTest<uint?>(uint.MaxValue, ORiN3BinaryConverter.DataType.UInt32);
            ExecuteTest<uint[]>([uint.MinValue, 2, 257, uint.MaxValue], ORiN3BinaryConverter.DataType.UInt32Array);
            ExecuteTest<uint[]>([], ORiN3BinaryConverter.DataType.UInt32Array);
            ExecuteTest<uint?[]>([uint.MinValue, 2, 257, uint.MaxValue, null], ORiN3BinaryConverter.DataType.NullableUInt32Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "int")]
        public void Test007()
        {
            ExecuteTest(int.MinValue, ORiN3BinaryConverter.DataType.Int32);
            ExecuteTest(int.MaxValue, ORiN3BinaryConverter.DataType.Int32);
            ExecuteTest(1, ORiN3BinaryConverter.DataType.Int32);
            ExecuteTest(256, ORiN3BinaryConverter.DataType.Int32);
            ExecuteTest<int?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<int?>(int.MinValue, ORiN3BinaryConverter.DataType.Int32);
            ExecuteTest<int?>(int.MaxValue, ORiN3BinaryConverter.DataType.Int32);
            ExecuteTest<int[]>([int.MinValue, 2, 257, int.MaxValue], ORiN3BinaryConverter.DataType.Int32Array);
            ExecuteTest<int[]>([], ORiN3BinaryConverter.DataType.Int32Array);
            ExecuteTest<int?[]>([int.MinValue, 2, 257, int.MaxValue, null], ORiN3BinaryConverter.DataType.NullableInt32Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "ulong")]
        public void Test008()
        {
            ExecuteTest(ulong.MinValue, ORiN3BinaryConverter.DataType.UInt64);
            ExecuteTest(ulong.MaxValue, ORiN3BinaryConverter.DataType.UInt64);
            ExecuteTest<ulong>(1, ORiN3BinaryConverter.DataType.UInt64);
            ExecuteTest<ulong>(256, ORiN3BinaryConverter.DataType.UInt64);
            ExecuteTest<ulong?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<ulong?>(ulong.MinValue, ORiN3BinaryConverter.DataType.UInt64);
            ExecuteTest<ulong?>(ulong.MaxValue, ORiN3BinaryConverter.DataType.UInt64);
            ExecuteTest<ulong[]>([ulong.MinValue, 2, 257, ulong.MaxValue], ORiN3BinaryConverter.DataType.UInt64Array);
            ExecuteTest<ulong[]>([], ORiN3BinaryConverter.DataType.UInt64Array);
            ExecuteTest<ulong?[]>([ulong.MinValue, 2, 257, ulong.MaxValue, null], ORiN3BinaryConverter.DataType.NullableUInt64Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "long")]
        public void Test009()
        {
            ExecuteTest(long.MinValue, ORiN3BinaryConverter.DataType.Int64);
            ExecuteTest(long.MaxValue, ORiN3BinaryConverter.DataType.Int64);
            ExecuteTest<long>(1, ORiN3BinaryConverter.DataType.Int64);
            ExecuteTest<long>(256, ORiN3BinaryConverter.DataType.Int64);
            ExecuteTest<long?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<long?>(long.MinValue, ORiN3BinaryConverter.DataType.Int64);
            ExecuteTest<long?>(long.MaxValue, ORiN3BinaryConverter.DataType.Int64);
            ExecuteTest<long[]>([long.MinValue, 2, 257, long.MaxValue], ORiN3BinaryConverter.DataType.Int64Array);
            ExecuteTest<long[]>([], ORiN3BinaryConverter.DataType.Int64Array);
            ExecuteTest<long?[]>([long.MinValue, 2, 257, long.MaxValue, null], ORiN3BinaryConverter.DataType.NullableInt64Array);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "float")]
        public void Test010()
        {
            ExecuteTest(float.MinValue, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest(float.MaxValue, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest<float>(1, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest<float>(256, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest(float.PositiveInfinity, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest(float.NegativeInfinity, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest(float.NaN, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest<float?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<float?>(float.MinValue, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest<float?>(float.MaxValue, ORiN3BinaryConverter.DataType.Float);
            ExecuteTest<float[]>([float.MinValue, 2, 257, float.MaxValue], ORiN3BinaryConverter.DataType.FloatArray);
            ExecuteTest<float[]>([], ORiN3BinaryConverter.DataType.FloatArray);
            ExecuteTest<float?[]>([float.MinValue, 2, 257, float.MaxValue, null], ORiN3BinaryConverter.DataType.NullableFloatArray);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "double")]
        public void Test011()
        {
            ExecuteTest(double.MinValue, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest(double.MaxValue, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest<double>(1, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest<double>(256, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest(double.PositiveInfinity, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest(double.NegativeInfinity, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest(double.NaN, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest<double?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<double?>(double.MinValue, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest<double?>(double.MaxValue, ORiN3BinaryConverter.DataType.Double);
            ExecuteTest<double[]>([double.MinValue, 2, 257, double.MaxValue], ORiN3BinaryConverter.DataType.DoubleArray);
            ExecuteTest<double[]>([], ORiN3BinaryConverter.DataType.DoubleArray);
            ExecuteTest<double?[]>([double.MinValue, 2, 257, double.MaxValue, null], ORiN3BinaryConverter.DataType.NullableDoubleArray);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "DateTime")]
        public void Test012()
        {
            ExecuteTest(DateTime.MinValue, ORiN3BinaryConverter.DataType.DateTime);
            ExecuteTest(DateTime.MaxValue, ORiN3BinaryConverter.DataType.DateTime);
            ExecuteTest(DateTime.Now, ORiN3BinaryConverter.DataType.DateTime);
            ExecuteTest<DateTime?>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<DateTime?>(DateTime.MinValue, ORiN3BinaryConverter.DataType.DateTime);
            ExecuteTest<DateTime?>(DateTime.MaxValue, ORiN3BinaryConverter.DataType.DateTime);
            ExecuteTest<DateTime[]>([DateTime.MinValue, DateTime.Now, DateTime.MaxValue], ORiN3BinaryConverter.DataType.DateTimeArray);
            ExecuteTest<DateTime[]>([], ORiN3BinaryConverter.DataType.DateTimeArray);
            ExecuteTest<DateTime?[]>([DateTime.MinValue, DateTime.Now, DateTime.MaxValue, null], ORiN3BinaryConverter.DataType.NullableDateTimeArray);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "string")]
        public void Test013()
        {
            ExecuteTest(string.Empty, ORiN3BinaryConverter.DataType.String);
            ExecuteTest("abcあいう𩸽", ORiN3BinaryConverter.DataType.String);
            ExecuteTest<string>(null, ORiN3BinaryConverter.DataType.Null);
            ExecuteTest<string[]>([string.Empty, "abcあいう𩸽", null, ""], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>([], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>([null], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>([string.Empty], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>(["a"], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>(["\u304C", "\u304B\u3099", "e\u0301", "u\u0308", "\u0E01\u0E34", "\u0646\u064E", "\U0001F468\u200D\U0001F469\u200D\U0001F467\u200D\U0001F466"], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>(["あ", null], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>([null, "あ"], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>(["あ", string.Empty], ORiN3BinaryConverter.DataType.StringArray);
            ExecuteTest<string[]>([string.Empty, "あ"], ORiN3BinaryConverter.DataType.StringArray);
        }

        public static TheoryData<object> TestData =>
        [
            new object[] { true, new bool[] { false, true } },
            new object[] { new bool[] { false, true }, new bool?[] { true, null, false } },
            new object[] { new bool?[] { true, null, false }, (byte)123 } ,
            new object[] { (byte)123, new byte[] { byte.MinValue, byte.MaxValue, 123 } } ,
            new object[] { new byte[] { byte.MinValue, byte.MaxValue, 123 }, new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } } ,
            new object[] { new byte?[] { byte.MinValue, byte.MaxValue, null, 123 }, (sbyte)12 } ,
            new object[] { (sbyte)12, new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } } ,
            new object[] { new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 }, new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } } ,
            new object[] { new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 }, (ushort)12345 } ,
            new object[] { (ushort)12345, new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } } ,
            new object[] { new ushort[] { ushort.MinValue, ushort.MaxValue, 123 }, new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } } ,
            new object[] { new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 }, (short)111 } ,
            new object[] { (short)111, new short[] { short.MinValue, short.MaxValue, 123 } } ,
            new object[] { new short[] { short.MinValue, short.MaxValue, 123 }, new short?[] { short.MinValue, short.MaxValue, null, 123 } } ,
            new object[] { new short?[] { short.MinValue, short.MaxValue, null, 123 }, (uint)123456 } ,
            new object[] { (uint)123456, new uint[] { uint.MinValue, uint.MaxValue, 123 } } ,
            new object[] { new uint[] { uint.MinValue, uint.MaxValue, 123 }, new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } } ,
            new object[] { new uint?[] { uint.MinValue, uint.MaxValue, null, 123 }, 654321 } ,
            new object[] { 654321, new int[] { int.MinValue, int.MaxValue, 123 }, } ,
            new object[] { new int[] { int.MinValue, int.MaxValue, 123 }, new int?[] { int.MinValue, int.MaxValue, null, 123 } } ,
            new object[] { new int?[] { int.MinValue, int.MaxValue, null, 123 }, (ulong)5555455 } ,
            new object[] { (ulong)5555455, new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } } ,
            new object[] { new ulong[] { ulong.MinValue, ulong.MaxValue, 123 }, new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } } ,
            new object[] { new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 }, (long)3333321 } ,
            new object[] { (long)3333321, new long[] { long.MinValue, long.MaxValue, 123 } } ,
            new object[] { new long[] { long.MinValue, long.MaxValue, 123 }, new long?[] { long.MinValue, long.MaxValue, null, 123 } } ,
            new object[] { new long?[] { long.MinValue, long.MaxValue, null, 123 }, 0.1F } ,
            new object[] { 0.1F, new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F }, } ,
            new object[] { new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F }, new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F }, } ,
            new object[] { new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F }, 1.1D } ,
            new object[] { 1.1D, new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } } ,
            new object[] { new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F }, new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } } ,
            new object[] { new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F }, DateTime.Now } ,
            new object[] { DateTime.Now, new DateTime[] { DateTime.MinValue, DateTime.MinValue } } ,
            new object[] { new DateTime[] { DateTime.MinValue, DateTime.MinValue }, new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } } ,
            new object[] { new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue }, "aaaaabbbbbcccc" } ,
            new object[] { "aaaaabbbbbcccc", new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } } ,
            new object[] { new string[] { "12345", string.Empty, null, "AAAABBBBCCC" }, true } ,
        ];

        [Theory]
        [Trait(nameof(ORiN3BinaryConverter), "object")]
        [MemberData(nameof(TestData))]
        public void Test100(object data)
        {
            var converted = ORiN3BinaryConverter.ToBinary(data);
            Assert.Equal((byte)ORiN3BinaryConverter.DataType.ObjectArray, converted[0]);
            var actual = ORiN3BinaryConverter.ToObject(converted);
            Assert.Equal(data, actual);
        }

        private static void ExecuteDictionaryTest(ORiN3BinaryConverter.DataType expectedDataType, Dictionary<string, object> target)
        {
            var converted = ORiN3BinaryConverter.FromDictionaryToBinary(target);
            var actual = ORiN3BinaryConverter.ToDictionary(converted);
            Assert.Equal(target, actual);

            var converted2 = ORiN3BinaryConverter.ToBinary(target).AsSpan();
            Assert.Equal((byte)ORiN3BinaryConverter.DataType.Dictionary, converted2[0]);
            var valueCount = ORiN3BitConverter.ToInt32(converted2[5..]);
            Assert.Equal(1, valueCount);
            Assert.Equal((byte)ORiN3BinaryConverter.DataType.String, converted2[9]);
            var keyLength = ORiN3BitConverter.ToInt32(converted2[10..]);
            Assert.Equal((byte)expectedDataType, converted2[14 + keyLength]);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(target, actual2);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - Empty")]
        public void Test200()
        {
            var data1 = new Dictionary<string, object>();
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);
            Assert.Empty(actual1);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - bool")]
        public void Test201()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Bool, new Dictionary<string, object>() { { "key", true } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Bool, new Dictionary<string, object>() { { "key", false } });
            bool? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            bool? value2 = true;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Bool, new Dictionary<string, object>() { { "key", value2 } });
            bool? value3 = false;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Bool, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.BoolArray, new Dictionary<string, object>() { { "key", new bool[] { true, false } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.BoolArray, new Dictionary<string, object>() { { "key", Array.Empty<bool>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableBoolArray, new Dictionary<string, object>() { { "key", new bool?[] { true, null, false } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - byte")]
        public void Test202()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt8, new Dictionary<string, object>() { { "key", byte.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt8, new Dictionary<string, object>() { { "key", byte.MaxValue } });
            byte? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            byte? value2 = byte.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt8, new Dictionary<string, object>() { { "key", value2 } });
            byte? value3 = byte.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt8, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt8Array, new Dictionary<string, object>() { { "key", new byte[] { byte.MinValue, 2, byte.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt8Array, new Dictionary<string, object>() { { "key", Array.Empty<byte>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableUInt8Array, new Dictionary<string, object>() { { "key", new byte?[] { byte.MaxValue, null, 2, byte.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - sbyte")]
        public void Test203()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int8, new Dictionary<string, object>() { { "key", sbyte.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int8, new Dictionary<string, object>() { { "key", sbyte.MaxValue } });
            sbyte? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            sbyte? value2 = sbyte.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int8, new Dictionary<string, object>() { { "key", value2 } });
            sbyte? value3 = sbyte.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int8, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int8Array, new Dictionary<string, object>() { { "key", new sbyte[] { sbyte.MinValue, 2, sbyte.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int8Array, new Dictionary<string, object>() { { "key", Array.Empty<sbyte>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableInt8Array, new Dictionary<string, object>() { { "key", new sbyte?[] { sbyte.MaxValue, null, 2, sbyte.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - ushort")]
        public void Test204()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16, new Dictionary<string, object>() { { "key", ushort.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16, new Dictionary<string, object>() { { "key", ushort.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16, new Dictionary<string, object>() { { "key", (ushort)1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16, new Dictionary<string, object>() { { "key", (ushort)256 } });
            ushort? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            ushort? value2 = ushort.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16, new Dictionary<string, object>() { { "key", value2 } });
            ushort? value3 = ushort.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16Array, new Dictionary<string, object>() { { "key", new ushort[] { ushort.MinValue, 2, 257, ushort.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt16Array, new Dictionary<string, object>() { { "key", Array.Empty<ushort>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableUInt16Array, new Dictionary<string, object>() { { "key", new ushort?[] { ushort.MaxValue, null, 2, 257, ushort.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - short")]
        public void Test205()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16, new Dictionary<string, object>() { { "key", short.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16, new Dictionary<string, object>() { { "key", short.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16, new Dictionary<string, object>() { { "key", (short)1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16, new Dictionary<string, object>() { { "key", (short)256 } });
            short? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            short? value2 = short.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16, new Dictionary<string, object>() { { "key", value2 } });
            short? value3 = short.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16Array, new Dictionary<string, object>() { { "key", new short[] { short.MinValue, 2, 257, short.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int16Array, new Dictionary<string, object>() { { "key", Array.Empty<short>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableInt16Array, new Dictionary<string, object>() { { "key", new short?[] { short.MaxValue, null, 2, 257, short.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - uint")]
        public void Test206()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32, new Dictionary<string, object>() { { "key", uint.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32, new Dictionary<string, object>() { { "key", uint.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32, new Dictionary<string, object>() { { "key", (uint)1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32, new Dictionary<string, object>() { { "key", (uint)256 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32, new Dictionary<string, object>() { { "key", (uint)65536 } });
            uint? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            uint? value2 = uint.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32, new Dictionary<string, object>() { { "key", value2 } });
            uint? value3 = uint.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32Array, new Dictionary<string, object>() { { "key", new uint[] { uint.MinValue, 2, 257, 65537, uint.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt32Array, new Dictionary<string, object>() { { "key", Array.Empty<uint>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableUInt32Array, new Dictionary<string, object>() { { "key", new uint?[] { uint.MaxValue, null, 2, 257, 65537, uint.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - int")]
        public void Test207()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32, new Dictionary<string, object>() { { "key", int.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32, new Dictionary<string, object>() { { "key", int.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32, new Dictionary<string, object>() { { "key", 1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32, new Dictionary<string, object>() { { "key", 256 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32, new Dictionary<string, object>() { { "key", 65536 } });
            int? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            int? value2 = int.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32, new Dictionary<string, object>() { { "key", value2 } });
            int? value3 = int.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32Array, new Dictionary<string, object>() { { "key", new int[] { int.MinValue, 2, 257, 65537, int.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int32Array, new Dictionary<string, object>() { { "key", Array.Empty<int>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableInt32Array, new Dictionary<string, object>() { { "key", new int?[] { int.MaxValue, null, 2, 257, 65537, int.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - ulong")]
        public void Test208()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", ulong.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", ulong.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", (ulong)1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", (ulong)256 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", (ulong)65536 } }); 
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", (ulong)4294967296 } });
            ulong? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            ulong? value2 = ulong.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", value2 } });
            ulong? value3 = ulong.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64Array, new Dictionary<string, object>() { { "key", new ulong[] { ulong.MinValue, 2, 257, 65537, 4294967297, ulong.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.UInt64Array, new Dictionary<string, object>() { { "key", Array.Empty<ulong>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableUInt64Array, new Dictionary<string, object>() { { "key", new ulong?[] { ulong.MaxValue, null, 2, 257, 65537, 4294967297, ulong.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - long")]
        public void Test209()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", long.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", long.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", (long)1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", (long)256 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", (long)65536 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", 4294967296 } });
            long? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            long? value2 = long.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", value2 } });
            long? value3 = long.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64Array, new Dictionary<string, object>() { { "key", new long[] { long.MinValue, 2, 257, 65537, 4294967297, long.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Int64Array, new Dictionary<string, object>() { { "key", Array.Empty<long>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableInt64Array, new Dictionary<string, object>() { { "key", new long?[] { long.MaxValue, null, 2, 257, 65537, 4294967297, long.MinValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - float")]
        public void Test210()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", float.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", float.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", float.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", float.PositiveInfinity } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", float.NegativeInfinity } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", float.NaN } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", float.Epsilon } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", (float)1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", (float)256 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", (float)65536 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", (float)16777216 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", (float)-16777216 } });
            float? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            float? value2 = float.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", value2 } });
            float? value3 = float.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Float, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.FloatArray, new Dictionary<string, object>() { { "key", new float[] { float.MinValue, 2, 257, 65537, 16777216, -16777216, float.MaxValue, float.MinValue, float.MaxValue, float.NaN, float.Epsilon } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.FloatArray, new Dictionary<string, object>() { { "key", Array.Empty<float>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableFloatArray, new Dictionary<string, object>() { { "key", new float?[] { float.MaxValue, null, 2, 257, 65537, 16777216, -16777216, float.MinValue, float.MinValue, float.MaxValue, float.NaN, float.Epsilon } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - double")]
        public void Test211()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", double.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", double.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", double.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", double.PositiveInfinity } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", double.NegativeInfinity } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", double.NaN } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", double.Epsilon } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", (double)1 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", (double)256 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", (double)65536 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", (double)16777216 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", (double)-16777216 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", (double)9007199254740991 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", (double)-9007199254740991 } });
            double? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            double? value2 = double.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", value2 } });
            double? value3 = double.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Double, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DoubleArray, new Dictionary<string, object>() { { "key", new double[] { double.MinValue, 2, 257, 65537, 16777216, -16777216, 9007199254740991, -9007199254740991, double.MaxValue, double.MinValue, double.MaxValue, double.NaN, double.Epsilon } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DoubleArray, new Dictionary<string, object>() { { "key", Array.Empty<double>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableDoubleArray, new Dictionary<string, object>() { { "key", new double?[] { double.MaxValue, null, 2, 257, 65537, 16777216, -16777216, 9007199254740991, -9007199254740991, double.MinValue, double.MinValue, double.MaxValue, double.NaN, double.Epsilon } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - DateTime")]
        public void Test212()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DateTime, new Dictionary<string, object>() { { "key", DateTime.MinValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DateTime, new Dictionary<string, object>() { { "key", DateTime.MaxValue } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DateTime, new Dictionary<string, object>() { { "key", DateTime.Now } });
            DateTime? value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            DateTime? value2 = DateTime.MinValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DateTime, new Dictionary<string, object>() { { "key", value2 } });
            DateTime? value3 = DateTime.MaxValue;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DateTime, new Dictionary<string, object>() { { "key", value3 } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DateTimeArray, new Dictionary<string, object>() { { "key", new DateTime[] { DateTime.MinValue, DateTime.Now, DateTime.MaxValue } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.DateTimeArray, new Dictionary<string, object>() { { "key", Array.Empty<DateTime>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.NullableDateTimeArray, new Dictionary<string, object>() { { "key", new DateTime?[] { DateTime.MaxValue, DateTime.Now, DateTime.MaxValue } } });
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - string")]
        public void Test213()
        {
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.String, new Dictionary<string, object>() { { "key", string.Empty } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.String, new Dictionary<string, object>() { { "key", "abcあいう𩸽" } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", null } });
            string value = null;
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.Null, new Dictionary<string, object>() { { "key", value } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.StringArray, new Dictionary<string, object>() { { "key", new string[] { string.Empty, "abcあいう", null, "" } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.StringArray, new Dictionary<string, object>() { { "key", new string[] { "\u304C", "\u304B\u3099", "e\u0301", "u\u0308", "\u0E01\u0E34", "\u0646\u064E", "\U0001F468\u200D\U0001F469\u200D\U0001F467\u200D\U0001F466" } } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.StringArray, new Dictionary<string, object>() { { "key", Array.Empty<string>() } });
            ExecuteDictionaryTest(ORiN3BinaryConverter.DataType.StringArray, new Dictionary<string, object>() { { "key", new string[] { null } } });
        }

        public static TheoryData<Dictionary<string, object>> DicTestData => new()
        {
            new Dictionary<string, object>() { { "key1", true }, { "key2", new bool[] { false, true } } },
            new Dictionary<string, object>() { { "key1", new bool[] { false, true } }, { "key2", new bool?[] { true, null, false } } },
            new Dictionary<string, object>() { { "key1", new bool?[] { true, null, false } }, { "key2", (byte)123 } },
            new Dictionary<string, object>() { { "key1", (byte)123 }, { "key2", new byte[] { byte.MinValue, byte.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new byte[] { byte.MinValue, byte.MaxValue, 123 } }, { "key2", new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } }, { "key2", (sbyte)12 } },
            new Dictionary<string, object>() { { "key1", (sbyte)12 }, { "key2", new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } }, { "key2", new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } }, { "key2", (ushort)12345 } },
            new Dictionary<string, object>() { { "key1", (ushort)12345 }, { "key2", new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } }, { "key2", new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } }, { "key2", (short)111 } },
            new Dictionary<string, object>() { { "key1", (short)111 }, { "key2", new short[] { short.MinValue, short.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new short[] { short.MinValue, short.MaxValue, 123 } }, { "key2", new short?[] { short.MinValue, short.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new short?[] { short.MinValue, short.MaxValue, null, 123 } }, { "key2", (uint)123456 } },
            new Dictionary<string, object>() { { "key1", (uint)123456 }, { "key2", new uint[] { uint.MinValue, uint.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new uint[] { uint.MinValue, uint.MaxValue, 123 } }, { "key2", new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } }, { "key2", 654321 } },
            new Dictionary<string, object>() { { "key1", 654321 }, { "key2", new int[] { int.MinValue, int.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new int[] { int.MinValue, int.MaxValue, 123 } }, { "key2", new int?[] { int.MinValue, int.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new int?[] { int.MinValue, int.MaxValue, null, 123 } }, { "key2", (ulong)5555455 } },
            new Dictionary<string, object>() { { "key1", (ulong)5555455 }, { "key2", new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } }, { "key2", new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } }, { "key2", (long)3333321 } },
            new Dictionary<string, object>() { { "key1", (long)3333321 }, { "key2", new long[] { long.MinValue, long.MaxValue, 123 } } },
            new Dictionary<string, object>() { { "key1", new long[] { long.MinValue, long.MaxValue, 123 } }, { "key2", new long?[] { long.MinValue, long.MaxValue, null, 123 } } },
            new Dictionary<string, object>() { { "key1", new long?[] { long.MinValue, long.MaxValue, null, 123 } }, { "key2", 0.1F } },
            new Dictionary<string, object>() { { "key1", 0.1F }, { "key2", new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F } } },
            new Dictionary<string, object>() { { "key1", new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F } }, { "key2", new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F } } },
            new Dictionary<string, object>() { { "key1", new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F } }, { "key2", 1.1D } },
            new Dictionary<string, object>() { { "key1", 1.1D }, { "key2", new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } } },
            new Dictionary<string, object>() { { "key1", new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } }, { "key2", new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } } },
            new Dictionary<string, object>() { { "key1", new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } }, { "key2", DateTime.Now } },
            new Dictionary<string, object>() { { "key1", DateTime.Now }, { "key2", new DateTime[] { DateTime.MinValue, DateTime.MinValue } } },
            new Dictionary<string, object>() { { "key1", new DateTime[] { DateTime.MinValue, DateTime.MinValue } }, { "key2", new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } } },
            new Dictionary<string, object>() { { "key1", new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } }, { "key2", "aaaaabbbbbcccc" } },
            new Dictionary<string, object>() { { "key1", "aaaaabbbbbcccc" }, { "key2", new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } } },
            new Dictionary<string, object>() { { "key1", new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } }, { "key2", true } },
        };

        [Theory]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary")]
        [MemberData(nameof(DicTestData))]
        public void Test300(Dictionary<string, object> data)
        {
            var converted = ORiN3BinaryConverter.FromDictionaryToBinary(data);
            var actual = ORiN3BinaryConverter.ToDictionary(converted);
            Assert.Equal(data, actual);

            var converted2 = ORiN3BinaryConverter.ToBinary(data);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(data, actual2);
        }

        public static TheoryData<Dictionary<string, object>> UnsupportedDicTestData => new()
        {
            new Dictionary<string, object>() { { "key1", new List<bool> { false, true } } },
            new Dictionary<string, object>() { { "key1", new List<bool[]> { new bool[] { false, true } } } },
            new Dictionary<string, object>() { { "key1", new List<bool?[]> { new bool?[] { true, null, false } } } },
            new Dictionary<string, object>() { { "key1", new List<byte> { 123 } } },
            new Dictionary<string, object>() { { "key1", new List<byte[]> { new byte[] { byte.MinValue, byte.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<byte?[]> { new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<sbyte> { 12 } } },
            new Dictionary<string, object>() { { "key1", new List<sbyte[]> { new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<sbyte?[]> { new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<ushort> { 12345 } } },
            new Dictionary<string, object>() { { "key1", new List<ushort[]> { new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<ushort?[]> { new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<short> { 111 } } },
            new Dictionary<string, object>() { { "key1", new List<short[]> { new short[] { short.MinValue, short.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<short?[]> { new short?[] { short.MinValue, short.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<uint> { 123456 } } },
            new Dictionary<string, object>() { { "key1", new List<uint[]> { new uint[] { uint.MinValue, uint.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<uint?[]> { new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<int> { 654321 } } },
            new Dictionary<string, object>() { { "key1", new List<int[]> { new int[] { int.MinValue, int.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<int?[]> { new int?[] { int.MinValue, int.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<ulong> { 5555455 } } },
            new Dictionary<string, object>() { { "key1", new List<ulong[]> { new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<ulong?[]> { new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<long> { 3333321 } } },
            new Dictionary<string, object>() { { "key1", new List<long[]> { new long[] { long.MinValue, long.MaxValue, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<long?[]> { new long?[] { long.MinValue, long.MaxValue, null, 123 } } } },
            new Dictionary<string, object>() { { "key1", new List<float> { 0.1F } } },
            new Dictionary<string, object>() { { "key1", new List<float[]> { new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F } } } },
            new Dictionary<string, object>() { { "key1", new List<float?[]> { new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F } } } },
            new Dictionary<string, object>() { { "key1", new List<double> { 1.1D } } },
            new Dictionary<string, object>() { { "key1", new List<double[]> { new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } } } },
            new Dictionary<string, object>() { { "key1", new List<double?[]> { new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } } } },
            new Dictionary<string, object>() { { "key1", new List<DateTime> { DateTime.Now } } },
            new Dictionary<string, object>() { { "key1", new List<DateTime[]> { new DateTime[] { DateTime.MinValue, DateTime.MinValue } } } },
            new Dictionary<string, object>() { { "key1", new List<DateTime?[]> { new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } } } },
            new Dictionary<string, object>() { { "key1", new List<string> { "aaaaabbbbbcccc" } } },
            new Dictionary<string, object>() { { "key1", new List<string[]> { new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } } } },
        };

        [Theory]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - unsupported value")]
        [MemberData(nameof(UnsupportedDicTestData))]
        public void Test400(Dictionary<string, object> data)
        {
            var exception = Assert.Throws<NotSupportedException>(() =>
            {
                var converted = ORiN3BinaryConverter.FromDictionaryToBinary(data);
            });
            Assert.Contains(data["key1"].GetType().Name, exception.Message);
        }

        public static TheoryData<object, int> DataSize => new()
        {
            { default(bool), 2 },
            { default(byte), 2 },
            { default(sbyte), 2 },
            { default(ushort), 3 },
            { default(short), 3 },
            { default(uint), 5 },
            { default(int), 5 },
            { default(ulong), 9 },
            { default(long), 9 },
            { default(float), 5 },
            { default(double), 9 },
            { DateTime.Now, 9 },
            { "abc", Encoding.UTF8.GetByteCount("abc") + 5 },
            { "あいう𩸽", Encoding.UTF8.GetByteCount("あいう𩸽") + 5 },
            // nullable
            { default(bool?), 1 },
            { default(byte?), 1 },
            { default(sbyte?), 1 },
            { default(ushort?), 1 },
            { default(short?), 1 },
            { default(uint?), 1 },
            { default(int?), 1 },
            { default(ulong?), 1 },
            { default(long?), 1 },
            { default(float?), 1 },
            { default(double?), 1 },
            { (DateTime?)null, 1 },
            // array
            { new bool[] { true, false }, 7 },
            { new bool[] { true, false, true }, 8 },
            { new byte[] { 0, 1 }, 7 },
            { new byte[] { 0, 1, 2 }, 8 },
            { new sbyte[] { 0, 1 }, 7 },
            { new sbyte[] { 0, 1, 2 }, 8 },
            { new ushort[] { 0, 1 }, 9 },
            { new ushort[] { 0, 1, 2 }, 11 },
            { new short[] { 0, 1 }, 9 },
            { new short[] { 0, 1, 2 }, 11 },
            { new uint[] { 0, 1 }, 13 },
            { new uint[] { 0, 1, 2 }, 17 },
            { new int[] { 0, 1 }, 13 },
            { new int[] { 0, 1, 2 }, 17 },
            { new ulong[] { 0, 1 }, 21 },
            { new ulong[] { 0, 1, 2 }, 29 },
            { new long[] { 0, 1 }, 21 },
            { new long[] { 0, 1, 2 }, 29 },
            { new float[] { 0, 1 }, 13 },
            { new float[] { 0, 1, 2 }, 17 },
            { new double[] { 0, 1 }, 21 },
            { new double[] { 0, 1, 2 }, 29 },
            { new DateTime[] { DateTime.MinValue, DateTime.MaxValue }, 21 },
            { new DateTime[] { DateTime.MinValue, DateTime.MaxValue, DateTime.Now }, 29 },
            { new string[] { "abc", "あいう𩸽" }, Encoding.UTF8.GetByteCount("abc") + Encoding.UTF8.GetByteCount("あいう𩸽") + 15 },
            // nullable array
            { new bool?[] { true, false, null }, 8 },
            { new bool?[] { true, false, true, null }, 9 },
            { new byte?[] { 0, 1, null }, 11 },
            { new byte?[] { 0, 1, 2, null }, 13 },
            { new sbyte?[] { 0, 1, null }, 11 },
            { new sbyte?[] { 0, 1, 2, null }, 13 },
            { new ushort?[] { 0, 1, null }, 14 },
            { new ushort?[] { 0, 1, 2, null }, 17 },
            { new short?[] { 0, 1, null }, 14 },
            { new short?[] { 0, 1, 2, null }, 17 },
            { new uint?[] { 0, 1, null }, 20 },
            { new uint?[] { 0, 1, 2, null }, 25 },
            { new int?[] { 0, 1, null }, 20 },
            { new int?[] { 0, 1, 2, null }, 25 },
            { new ulong?[] { 0, 1, null }, 32 },
            { new ulong?[] { 0, 1, 2, null }, 41 },
            { new long?[] { 0, 1, null }, 32 },
            { new long?[] { 0, 1, 2, null }, 41 },
            { new float?[] { 0, 1, null }, 20 },
            { new float?[] { 0, 1, 2, null }, 25 },
            { new double?[] { 0, 1, null }, 32 },
            { new double?[] { 0, 1, 2, null }, 41 },
            { new DateTime?[] { DateTime.MinValue, DateTime.MaxValue, null }, 32 },
            { new DateTime?[] { DateTime.MinValue, DateTime.MaxValue, DateTime.Now, null }, 41 },
            // object array
            { new object[] { true, 1 }, 12 },
            { new object[] { true, 1, 1.1D }, 21 },
            { new object[] { true, 1, 1.1D, "abc" }, Encoding.UTF8.GetByteCount("abc") + 26 },
            { new object[] { true, 1, 1.1D, "abc", new sbyte?[] { 0, 1, null } }, Encoding.UTF8.GetByteCount("abc") + 37 },
            { new object[] { true, 1, 1.1D, "abc", new sbyte?[] { 0, 1, null }, new object[] { true, 1 } }, Encoding.UTF8.GetByteCount("abc") + 49 },
            { new object[] { true, 1, 1.1D, "abc", new sbyte?[] { 0, 1, null }, new object[] { true, 1 }, new object[] { true, 1 } }, Encoding.UTF8.GetByteCount("abc") + 61 },
            { new object[] { true, 1, 1.1D, "abc", new sbyte?[] { 0, 1, null }, new object[] { true, 1 }, new object[] { true, new object[] { true, 1 } } }, Encoding.UTF8.GetByteCount("abc") + 68 },
            // dictionary
            { new Dictionary<string, object>() { { "key", true } }, 9 + Encoding.UTF8.GetByteCount("key") + 5 + 2 },
            { new Dictionary<string, object>() { { "key", new object[] { true, 1 } } }, 9 + Encoding.UTF8.GetByteCount("key") + 5 + 12 },
            // others
            { new object[] { true, (byte)1 }, 5 + 4 },
            { new object[] { (byte)1, (sbyte)2 }, 5 + 4 },
            { new object[] { (sbyte)2, (ushort)3 }, 5 + 5 },
            { new object[] { (ushort)3, (short)4 }, 5 + 6 },
            { new object[] { (short)4, (uint)5 }, 5 + 8 },
            { new object[] { (uint)5, 6 }, 5 + 10 },
            { new object[] { 6, (ulong)7 }, 5 + 14 },
            { new object[] { (ulong)7, (long)8 }, 5 + 18 },
            { new object[] { (long)8, (float)9 }, 5 + 14 },
            { new object[] { (float)10, (double)11 }, 5 + 14 },
            { new object[] { (double)11, DateTime.Now }, 5 + 18 },
            { new object[] { DateTime.Now, "abc" }, 5 + Encoding.UTF8.GetByteCount("abc") + 5 + 9 },
            { new object[] { "abc", null }, 5 + Encoding.UTF8.GetByteCount("abc") + 5 + 1 },
            { new object[] {  null, new byte[] { 12, 13 } }, 5 + 1 + 7 },
            { new object[] {  new byte[] { 12, 13 }, new sbyte[] { 14, 15 } }, 5 + 7 + 7 },
            { new object[] {  new sbyte[] { 14, 15 }, new ushort[] { 16, 17 } }, 5 + 7 + 9 },
            { new object[] {  new ushort[] { 16, 17 }, new short[] { 18, 19 } }, 5 + 9 + 9 },
            { new object[] {  new short[] { 18, 19 }, new uint[] { 20, 21 } }, 5 + 9 + 13 },
            { new object[] {  new uint[] { 20, 21 }, new int[] { 22, 23 } }, 5 + 13 + 13 },
            { new object[] {  new int[] { 22, 23 }, new ulong[] { 24, 25 } }, 5 + 13 + 21 },
            { new object[] {  new ulong[] { 24, 25 }, new long[] { 26, 27 } }, 5 + 21 + 21 },
            { new object[] {  new long[] { 26, 27 }, new float[] { 28, 29 } }, 5 + 21 + 13 },
            { new object[] {  new float[] { 28, 29 }, new double[] { 30, 31 } }, 5 + 13 + 21 },
            { new object[] {  new double[] { 30, 31 }, new DateTime[] { DateTime.MinValue, DateTime.MaxValue } }, 5 + 21 + 21 },
            { new object[] {  new DateTime[] { DateTime.MinValue, DateTime.MaxValue }, new string[] { "abc", "あいう" } }, 5 + 21 + Encoding.UTF8.GetByteCount("abc") + Encoding.UTF8.GetByteCount("あいう") + 15 },
            { new object[] {  new string[] { "abc", "あいう" }, new bool?[] { true, false, null } }, 5 + Encoding.UTF8.GetByteCount("abc") + Encoding.UTF8.GetByteCount("あいう") + 15 + 8 },
            { new object[] {  new bool?[] { true, false, null }, new byte?[] { 32, 33, null } }, 5 + 8 + 11 },
            { new object[] {  new byte?[] { 32, 33, null }, new sbyte?[] { 34, 35, null } }, 5 + 11 + 11 },
            { new object[] {  new sbyte?[] { 34, 35, null }, new ushort?[] { 36, 37, null } }, 5 + 11 + 14 },
            { new object[] {  new ushort?[] { 36, 37, null }, new short?[] { 38, 39, null } }, 5 + 14 + 14 },
            { new object[] {  new short?[] { 38, 39, null }, new uint?[] { 40, 41, null } }, 5 + 14 + 20 },
            { new object[] {  new uint?[] { 40, 41, null }, new int?[] { 42, 43, null } }, 5 + 20 + 20 },
            { new object[] {  new int?[] { 42, 43, null }, new ulong?[] { 44, 45, null } }, 5 + 20 + 32 },
            { new object[] {  new ulong?[] { 44, 45, null }, new float?[] { 46, 47, null } }, 5 + 32 + 20 },
            { new object[] {  new float?[] { 46, 47, null }, new double?[] { 48, 49, null } }, 5 + 20 + 32 },
            { new object[] {  new double?[] { 48, 49, null }, new DateTime?[] { DateTime.MinValue, DateTime.MaxValue, null } }, 5 + 32 + 32 },
            { new object[] {  new DateTime?[] { DateTime.MinValue, DateTime.MaxValue, null }, new string[] { "abc", "あいう", null, string.Empty } }, 5 + 32 + Encoding.UTF8.GetByteCount("abc") + Encoding.UTF8.GetByteCount("あいう") + Encoding.UTF8.GetByteCount(string.Empty) + 25 },
            { new object[] {  new string[] { "abc", "あいう", null, string.Empty }, new object[] { true, (byte)50 } }, 5 + Encoding.UTF8.GetByteCount("abc") + Encoding.UTF8.GetByteCount("あいう") + Encoding.UTF8.GetByteCount(string.Empty) + 25 + 9 },
            { new object[] {  new object[] { true, (byte)50 }, new Dictionary<string, object>() { { "key", 51 } } }, 5 + 9 + 9 + Encoding.UTF8.GetByteCount("abc") + 5 + 5  },
            { new object[] {  new Dictionary<string, object>() { { "key", 51 } }, null }, 5 + 9 + Encoding.UTF8.GetByteCount("abc") + 5 + 5 + 1  },
        };

        [Theory]
        [Trait(nameof(ORiN3BinaryConverter), "CalcBinarySize and FillBytes")]
        [MemberData(nameof(DataSize))]
        public void Test500(object target, int expected)
        {
            Assert.Equal(expected, ORiN3BinaryConverter.CalcBinarySize(target));

            var buffer = new byte[expected + 1];
            buffer[^1] = 123;
            var actual = ORiN3BinaryConverter.FillBytes(target, buffer);
            Assert.Equal(123, actual[0]);
            Assert.Equal(1, actual.Length);

            var actual2 = ORiN3BinaryConverter.ToObject(buffer);
            Assert.Equal(target, actual2);
        }

        internal class CustomDictionaryEqualityComparer : IEqualityComparer<KeyValuePair<string, object>>
        {
            private readonly IEqualityComparer<KeyValuePair<string, object>> _comparer;
            public CustomDictionaryEqualityComparer()
            {
                _comparer = EqualityComparer<KeyValuePair<string, object>>.Default;
            }

            public bool Equals(KeyValuePair<string, object> x, KeyValuePair<string, object> y)
            {
                if (Equals(x.Key, y.Key))
                {
                    if (Equals(x.Value, y.Value) && x.Value == null)
                    {
                        return true;
                    }

                    return _comparer.Equals(x, y);
                }

                return false;
            }

            public int GetHashCode(KeyValuePair<string, object> obj)
            {
                return _comparer.GetHashCode(obj);
            }
        }
    }
}
