using Message.ORiN3.Common.V1;
using System;
using System.Collections.Generic;
using Xunit;

namespace Message.ORiN3.Common.Test.TestByDeveloper
{
    public class ORiN3BinaryConverterTest
    {
        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "bool")]
        public void Test001()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(true);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(true, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(false);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(false, actual2);

            bool? value3 = null;
            var converted3 = ORiN3BinaryConverter.ToBinary(value3);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Null(actual3);

            bool? value4 = true;
            var converted4 = ORiN3BinaryConverter.ToBinary(value4);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal(true, actual4);

            bool? value5 = false;
            var converted5 = ORiN3BinaryConverter.ToBinary(value5);
            var actual5 = ORiN3BinaryConverter.ToObject(converted5);
            Assert.Equal(false, actual5);

            var value6 = new[] { true, false };
            var converted6 = ORiN3BinaryConverter.ToBinary(value6);
            var actual6 = ORiN3BinaryConverter.ToObject(converted6);
            Assert.Equal(new[] { true, false }, actual6);

            var value7 = Array.Empty<bool>();
            var converted7 = ORiN3BinaryConverter.ToBinary(value7);
            var actual7 = ORiN3BinaryConverter.ToObject(converted7);
            Assert.Equal(Array.Empty<bool>(), actual7);

            var value8 = new bool?[] { false, null, true };
            var converted8 = ORiN3BinaryConverter.ToBinary(value8);
            var actual8 = ORiN3BinaryConverter.ToObject(converted8);
            Assert.Equal(new bool?[] { false, null, true }, actual8);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "byte")]
        public void Test002()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(byte.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(byte.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(byte.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(byte.MaxValue, actual2);

            byte? value3 = null;
            var converted3 = ORiN3BinaryConverter.ToBinary(value3);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Null(actual3);

            byte? value4 = byte.MinValue;
            var converted4 = ORiN3BinaryConverter.ToBinary(value4);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal(byte.MinValue, actual4);

            byte? value5 = byte.MaxValue;
            var converted5 = ORiN3BinaryConverter.ToBinary(value5);
            var actual5 = ORiN3BinaryConverter.ToObject(converted5);
            Assert.Equal(byte.MaxValue, actual5);

            var value6 = new[] { byte.MinValue, 2, byte.MaxValue };
            var converted6 = ORiN3BinaryConverter.ToBinary(value6);
            var actual6 = ORiN3BinaryConverter.ToObject(converted6);
            Assert.Equal(new[] { byte.MinValue, 2, byte.MaxValue }, actual6);

            var value7 = Array.Empty<byte>();
            var converted7 = ORiN3BinaryConverter.ToBinary(value7);
            var actual7 = ORiN3BinaryConverter.ToObject(converted7);
            Assert.Equal(Array.Empty<byte>(), actual7);

            var value8 = new byte?[] { byte.MaxValue, null, 2, byte.MinValue };
            var converted8 = ORiN3BinaryConverter.ToBinary(value8);
            var actual8 = ORiN3BinaryConverter.ToObject(converted8);
            Assert.Equal(new byte?[] { byte.MaxValue, null, 2, byte.MinValue }, actual8);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "sbyte")]
        public void Test003()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(sbyte.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(sbyte.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(sbyte.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(sbyte.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((sbyte)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((sbyte)1, actual3);

            sbyte? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            sbyte? value11 = sbyte.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(sbyte.MinValue, actual11);

            sbyte? value12 = sbyte.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(sbyte.MaxValue, actual12);

            var value20 = new sbyte[] { sbyte.MinValue, 2, sbyte.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new sbyte[] { sbyte.MinValue, 2, sbyte.MaxValue }, actual20);

            var value21 = Array.Empty<sbyte>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<sbyte>(), actual21);

            var value30 = new sbyte?[] { sbyte.MaxValue, null, 2, sbyte.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new sbyte?[] { sbyte.MaxValue, null, 2, sbyte.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "ushort")]
        public void Test004()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(ushort.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(ushort.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(ushort.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(ushort.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((ushort)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((ushort)1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary((ushort)256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal((ushort)256, actual4);

            ushort? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            ushort? value11 = ushort.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(ushort.MinValue, actual11);

            ushort? value12 = ushort.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(ushort.MaxValue, actual12);

            var value20 = new ushort[] { ushort.MinValue, 2, 257, ushort.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new ushort[] { ushort.MinValue, 2, 257, ushort.MaxValue }, actual20);

            var value21 = Array.Empty<ushort>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<ushort>(), actual21);

            var value30 = new ushort?[] { ushort.MaxValue, null, 2, 257, ushort.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new ushort?[] { ushort.MaxValue, null, 2, 257, ushort.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "short")]
        public void Test005()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(short.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(short.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(short.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(short.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((short)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((short)1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary((short)256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal((short)256, actual4);

            short? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            short? value11 = short.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(short.MinValue, actual11);

            short? value12 = short.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(short.MaxValue, actual12);

            var value20 = new short[] { short.MinValue, 2, 257, short.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new short[] { short.MinValue, 2, 257, short.MaxValue }, actual20);

            var value21 = Array.Empty<short>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<short>(), actual21);

            var value30 = new short?[] { short.MaxValue, null, 2, 257, short.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new short?[] { short.MaxValue, null, 2, 257, short.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "uint")]
        public void Test006()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(uint.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(uint.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(uint.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(uint.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((uint)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((uint)1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary((uint)256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal((uint)256, actual4);

            uint? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            uint? value11 = uint.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(uint.MinValue, actual11);

            uint? value12 = uint.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(uint.MaxValue, actual12);

            var value20 = new uint[] { uint.MinValue, 2, 257, uint.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new uint[] { uint.MinValue, 2, 257, uint.MaxValue }, actual20);

            var value21 = Array.Empty<uint>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<uint>(), actual21);

            var value30 = new uint?[] { uint.MaxValue, null, 2, 257, uint.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new uint?[] { uint.MaxValue, null, 2, 257, uint.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "int")]
        public void Test007()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(int.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(int.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(int.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(int.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary(1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal(1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary(256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal(256, actual4);

            int? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            int? value11 = int.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(int.MinValue, actual11);

            int? value12 = int.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(int.MaxValue, actual12);

            var value20 = new int[] { int.MinValue, 2, 257, int.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new int[] { int.MinValue, 2, 257, int.MaxValue }, actual20);

            var value21 = Array.Empty<int>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<int>(), actual21);

            var value30 = new int?[] { int.MaxValue, null, 2, 257, int.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new int?[] { int.MaxValue, null, 2, 257, int.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "ulong")]
        public void Test008()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(ulong.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(ulong.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(ulong.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(ulong.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((ulong)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((ulong)1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary((ulong)256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal((ulong)256, actual4);

            ulong? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            ulong? value11 = ulong.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(ulong.MinValue, actual11);

            ulong? value12 = ulong.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(ulong.MaxValue, actual12);

            var value20 = new ulong[] { ulong.MinValue, 2, 257, ulong.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new ulong[] { ulong.MinValue, 2, 257, ulong.MaxValue }, actual20);

            var value21 = Array.Empty<ulong>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<ulong>(), actual21);

            var value30 = new ulong?[] { ulong.MaxValue, null, 2, 257, ulong.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new ulong?[] { ulong.MaxValue, null, 2, 257, ulong.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "long")]
        public void Test009()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(long.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(long.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(long.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(long.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((long)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((long)1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary((long)256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal((long)256, actual4);

            long? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            long? value11 = long.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(long.MinValue, actual11);

            long? value12 = long.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(long.MaxValue, actual12);

            var value20 = new long[] { long.MinValue, 2, 257, long.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new long[] { long.MinValue, 2, 257, long.MaxValue }, actual20);

            var value21 = Array.Empty<long>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<long>(), actual21);

            var value30 = new long?[] { long.MaxValue, null, 2, 257, long.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new long?[] { long.MaxValue, null, 2, 257, long.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "float")]
        public void Test010()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(float.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(float.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(float.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(float.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((float)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((float)1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary((float)256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal((float)256, actual4);

            var converted5 = ORiN3BinaryConverter.ToBinary(float.PositiveInfinity);
            var actual5 = ORiN3BinaryConverter.ToObject(converted5);
            Assert.Equal(float.PositiveInfinity, actual5);

            var converted6 = ORiN3BinaryConverter.ToBinary(float.NegativeInfinity);
            var actual6 = ORiN3BinaryConverter.ToObject(converted6);
            Assert.Equal(float.NegativeInfinity, actual6);

            var converted7 = ORiN3BinaryConverter.ToBinary(float.NaN);
            var actual7 = ORiN3BinaryConverter.ToObject(converted7);
            Assert.Equal(float.NaN, actual7);

            float? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            float? value11 = float.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(float.MinValue, actual11);

            float? value12 = float.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(float.MaxValue, actual12);

            var value20 = new float[] { float.MinValue, 2, 257, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new float[] { float.MinValue, 2, 257, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.MaxValue }, actual20);

            var value21 = Array.Empty<float>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<float>(), actual21);

            var value30 = new float?[] { float.MaxValue, null, 2, 257, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new float?[] { float.MaxValue, null, 2, 257, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "double")]
        public void Test011()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(double.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(double.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(double.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(double.MaxValue, actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary((double)1);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal((double)1, actual3);

            var converted4 = ORiN3BinaryConverter.ToBinary((double)256);
            var actual4 = ORiN3BinaryConverter.ToObject(converted4);
            Assert.Equal((double)256, actual4);

            var converted5 = ORiN3BinaryConverter.ToBinary(double.PositiveInfinity);
            var actual5 = ORiN3BinaryConverter.ToObject(converted5);
            Assert.Equal(double.PositiveInfinity, actual5);

            var converted6 = ORiN3BinaryConverter.ToBinary(double.NegativeInfinity);
            var actual6 = ORiN3BinaryConverter.ToObject(converted6);
            Assert.Equal(double.NegativeInfinity, actual6);

            var converted7 = ORiN3BinaryConverter.ToBinary(double.NaN);
            var actual7 = ORiN3BinaryConverter.ToObject(converted7);
            Assert.Equal(double.NaN, actual7);

            double? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            double? value11 = double.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(double.MinValue, actual11);

            double? value12 = double.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(double.MaxValue, actual12);

            var value20 = new double[] { double.MinValue, 2, 257, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new double[] { double.MinValue, 2, 257, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.MaxValue }, actual20);

            var value21 = Array.Empty<double>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<double>(), actual21);

            var value30 = new double?[] { double.MaxValue, null, 2, 257, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.MinValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new double?[] { double.MaxValue, null, 2, 257, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.MinValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "DateTime")]
        public void Test012()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(DateTime.MinValue);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(DateTime.MinValue, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary(DateTime.MaxValue);
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal(DateTime.MaxValue, actual2);

            var now = DateTime.Now;
            var converted3 = ORiN3BinaryConverter.ToBinary(now);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Equal(now, actual3);

            DateTime? value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            DateTime? value11 = DateTime.MinValue;
            var converted11 = ORiN3BinaryConverter.ToBinary(value11);
            var actual11 = ORiN3BinaryConverter.ToObject(converted11);
            Assert.Equal(DateTime.MinValue, actual11);

            DateTime? value12 = DateTime.MaxValue;
            var converted12 = ORiN3BinaryConverter.ToBinary(value12);
            var actual12 = ORiN3BinaryConverter.ToObject(converted12);
            Assert.Equal(DateTime.MaxValue, actual12);

            var value20 = new DateTime[] { DateTime.MinValue, now, DateTime.MaxValue };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new DateTime[] { DateTime.MinValue, now, DateTime.MaxValue }, actual20);

            var value21 = Array.Empty<DateTime>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<DateTime>(), actual21);

            var value30 = new DateTime?[] { DateTime.MinValue, now, DateTime.MaxValue };
            var converted30 = ORiN3BinaryConverter.ToBinary(value30);
            var actual30 = ORiN3BinaryConverter.ToObject(converted30);
            Assert.Equal(new DateTime?[] { DateTime.MinValue, now, DateTime.MaxValue }, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "string")]
        public void Test013()
        {
            var converted1 = ORiN3BinaryConverter.ToBinary(string.Empty);
            var actual1 = ORiN3BinaryConverter.ToObject(converted1);
            Assert.Equal(string.Empty, actual1);

            var converted2 = ORiN3BinaryConverter.ToBinary("abcあいう");
            var actual2 = ORiN3BinaryConverter.ToObject(converted2);
            Assert.Equal("abcあいう", actual2);

            var converted3 = ORiN3BinaryConverter.ToBinary(null);
            var actual3 = ORiN3BinaryConverter.ToObject(converted3);
            Assert.Null(actual3);

            string value10 = null;
            var converted10 = ORiN3BinaryConverter.ToBinary(value10);
            var actual10 = ORiN3BinaryConverter.ToObject(converted10);
            Assert.Null(actual10);

            var value20 = new string[] { string.Empty, "abcあいう", null, "" };
            var converted20 = ORiN3BinaryConverter.ToBinary(value20);
            var actual20 = ORiN3BinaryConverter.ToObject(converted20);
            Assert.Equal(new string[] { string.Empty, "abcあいう", null, "" }, actual20);

            var value21 = Array.Empty<string>();
            var converted21 = ORiN3BinaryConverter.ToBinary(value21);
            var actual21 = ORiN3BinaryConverter.ToObject(converted21);
            Assert.Equal(Array.Empty<string>(), actual21);
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                {
                    yield return new object[] { new object[] { true, new bool[] { false, true } } };
                    yield return new object[] { new object[] { new bool[] { false, true }, new bool?[] { true, null, false } } };
                    yield return new object[] { new object[] { new bool?[] { true, null, false }, (byte)123 } };
                    yield return new object[] { new object[] { (byte)123, new byte[] { byte.MinValue, byte.MaxValue, 123 } } };
                    yield return new object[] { new object[] { new byte[] { byte.MinValue, byte.MaxValue, 123 }, new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new byte?[] { byte.MinValue, byte.MaxValue, null, 123 }, (sbyte)12 } };
                    yield return new object[] { new object[] { (sbyte)12, new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } } };
                    yield return new object[] { new object[] { new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 }, new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 }, (ushort)12345 } };
                    yield return new object[] { new object[] { (ushort)12345, new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } } };
                    yield return new object[] { new object[] { new ushort[] { ushort.MinValue, ushort.MaxValue, 123 }, new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 }, (short)111 } };
                    yield return new object[] { new object[] { (short)111, new short[] { short.MinValue, short.MaxValue, 123 } } };
                    yield return new object[] { new object[] { new short[] { short.MinValue, short.MaxValue, 123 }, new short?[] { short.MinValue, short.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new short?[] { short.MinValue, short.MaxValue, null, 123 }, (uint)123456 } };
                    yield return new object[] { new object[] { (uint)123456, new uint[] { uint.MinValue, uint.MaxValue, 123 } } };
                    yield return new object[] { new object[] { new uint[] { uint.MinValue, uint.MaxValue, 123 }, new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new uint?[] { uint.MinValue, uint.MaxValue, null, 123 }, 654321 } };
                    yield return new object[] { new object[] { 654321, new int[] { int.MinValue, int.MaxValue, 123 }, } };
                    yield return new object[] { new object[] { new int[] { int.MinValue, int.MaxValue, 123 }, new int?[] { int.MinValue, int.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new int?[] { int.MinValue, int.MaxValue, null, 123 }, (ulong)5555455 } };
                    yield return new object[] { new object[] { (ulong)5555455, new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } } };
                    yield return new object[] { new object[] { new ulong[] { ulong.MinValue, ulong.MaxValue, 123 }, new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 }, (long)3333321 } };
                    yield return new object[] { new object[] { (long)3333321, new long[] { long.MinValue, long.MaxValue, 123 } } };
                    yield return new object[] { new object[] { new long[] { long.MinValue, long.MaxValue, 123 }, new long?[] { long.MinValue, long.MaxValue, null, 123 } } };
                    yield return new object[] { new object[] { new long?[] { long.MinValue, long.MaxValue, null, 123 }, 0.1F } };
                    yield return new object[] { new object[] { 0.1F, new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F }, } };
                    yield return new object[] { new object[] { new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F }, new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F }, } };
                    yield return new object[] { new object[] { new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F }, 1.1D } };
                    yield return new object[] { new object[] { 1.1D, new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } } };
                    yield return new object[] { new object[] { new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F }, new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } } };
                    yield return new object[] { new object[] { new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F }, DateTime.Now } };
                    yield return new object[] { new object[] { DateTime.Now, new DateTime[] { DateTime.MinValue, DateTime.MinValue } } };
                    yield return new object[] { new object[] { new DateTime[] { DateTime.MinValue, DateTime.MinValue }, new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } } };
                    yield return new object[] { new object[] { new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue }, "aaaaabbbbbcccc" } };
                    yield return new object[] { new object[] { "aaaaabbbbbcccc", new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } } };
                    yield return new object[] { new object[] { new string[] { "12345", string.Empty, null, "AAAABBBBCCC" }, true } };
                }
            }
        }

        [Theory]
        [Trait(nameof(ORiN3BinaryConverter), "object")]
        [MemberData(nameof(TestData))]
        public void Test100(object data)
        {
            var converted = ORiN3BinaryConverter.ToBinary(data);
            var actual = ORiN3BinaryConverter.ToObject(converted);
            Assert.Equal(data, actual);
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
            var data1 = new Dictionary<string, object>() { { "key", true } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", false } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            bool? value3 = null;
            var data3 = new Dictionary<string, object>() { { "key", value3 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            bool? value4 = true;
            var data4 = new Dictionary<string, object>() { { "key", value4 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            bool? value5 = false;
            var data5 = new Dictionary<string, object>() { { "key", value5 } };
            var converted5 = ORiN3BinaryConverter.FromDictionaryToBinary(data5);
            var actual5 = ORiN3BinaryConverter.ToDictionary(converted5);
            Assert.Equal(data5, actual5);

            var value6 = new[] { true, false };
            var data6 = new Dictionary<string, object>() { { "key", value6 } };
            var converted6 = ORiN3BinaryConverter.FromDictionaryToBinary(data6);
            var actual6 = ORiN3BinaryConverter.ToDictionary(converted6);
            Assert.Equal(data6, actual6);

            var value7 = Array.Empty<bool>();
            var data7 = new Dictionary<string, object>() { { "key", value7 } };
            var converted7 = ORiN3BinaryConverter.FromDictionaryToBinary(data7);
            var actual7 = ORiN3BinaryConverter.ToDictionary(converted7);
            Assert.Equal(data7, actual7);

            var value8 = new bool?[] { false, null, true };
            var data8 = new Dictionary<string, object>() { { "key", value8 } };
            var converted8 = ORiN3BinaryConverter.FromDictionaryToBinary(data8);
            var actual8 = ORiN3BinaryConverter.ToDictionary(converted8);
            Assert.Equal(data8, actual8);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - byte")]
        public void Test202()
        {
            var data1 = new Dictionary<string, object>() { { "key", byte.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", byte.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            byte? value3 = null;
            var data3 = new Dictionary<string, object>() { { "key", value3 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            byte? value4 = byte.MinValue;
            var data4 = new Dictionary<string, object>() { { "key", value4 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            byte? value5 = byte.MaxValue;
            var data5 = new Dictionary<string, object>() { { "key", value5 } };
            var converted5 = ORiN3BinaryConverter.FromDictionaryToBinary(data5);
            var actual5 = ORiN3BinaryConverter.ToDictionary(converted5);
            Assert.Equal(data5, actual5);

            var value6 = new[] { byte.MinValue, 2, byte.MaxValue };
            var data6 = new Dictionary<string, object>() { { "key", value6 } };
            var converted6 = ORiN3BinaryConverter.FromDictionaryToBinary(data6);
            var actual6 = ORiN3BinaryConverter.ToDictionary(converted6);
            Assert.Equal(data6, actual6);

            var value7 = Array.Empty<byte>();
            var data7 = new Dictionary<string, object>() { { "key", value7 } };
            var converted7 = ORiN3BinaryConverter.FromDictionaryToBinary(data7);
            var actual7 = ORiN3BinaryConverter.ToDictionary(converted7);
            Assert.Equal(data7, actual7);

            var value8 = new byte?[] { byte.MaxValue, null, 2, byte.MinValue };
            var data8 = new Dictionary<string, object>() { { "key", value8 } };
            var converted8 = ORiN3BinaryConverter.FromDictionaryToBinary(data8);
            var actual8 = ORiN3BinaryConverter.ToDictionary(converted8);
            Assert.Equal(data8, actual8);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - sbyte")]
        public void Test203()
        {
            var data1 = new Dictionary<string, object>() { { "key", sbyte.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", sbyte.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (sbyte)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            sbyte? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            sbyte? value11 = sbyte.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            sbyte? value12 = sbyte.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new sbyte[] { sbyte.MinValue, 2, sbyte.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<sbyte>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new sbyte?[] { sbyte.MaxValue, null, 2, sbyte.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - ushort")]
        public void Test204()
        {
            var data1 = new Dictionary<string, object>() { { "key", ushort.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", ushort.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (ushort)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", (ushort)256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            ushort? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            ushort? value11 = ushort.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            ushort? value12 = ushort.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new ushort[] { ushort.MinValue, 2, 257, ushort.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<ushort>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new ushort?[] { ushort.MaxValue, null, 2, 257, ushort.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - short")]
        public void Test205()
        {
            var data1 = new Dictionary<string, object>() { { "key", short.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", short.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (short)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", (short)256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            short? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            short? value11 = short.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            short? value12 = short.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new short[] { short.MinValue, 2, 257, short.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<short>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new short?[] { short.MaxValue, null, 2, 257, short.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - uint")]
        public void Test206()
        {
            var data1 = new Dictionary<string, object>() { { "key", uint.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", uint.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (uint)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", (uint)256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            uint? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            uint? value11 = uint.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            uint? value12 = uint.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new uint[] { uint.MinValue, 2, 257, uint.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<uint>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new uint?[] { uint.MaxValue, null, 2, 257, uint.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - int")]
        public void Test207()
        {
            var data1 = new Dictionary<string, object>() { { "key", int.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", int.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", 1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", 256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            int? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            int? value11 = int.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            int? value12 = int.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new int[] { int.MinValue, 2, 257, int.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<int>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new int?[] { int.MaxValue, null, 2, 257, int.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - ulong")]
        public void Test208()
        {
            var data1 = new Dictionary<string, object>() { { "key", ulong.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", ulong.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (ulong)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", (ulong)256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            ulong? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            ulong? value11 = ulong.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            ulong? value12 = ulong.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new ulong[] { ulong.MinValue, 2, 257, ulong.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<ulong>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new ulong?[] { ulong.MaxValue, null, 2, 257, ulong.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - long")]
        public void Test209()
        {
            var data1 = new Dictionary<string, object>() { { "key", long.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", long.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (long)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", (long)256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            long? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            long? value11 = long.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            long? value12 = long.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new long[] { long.MinValue, 2, 257, long.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<long>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new long?[] { long.MaxValue, null, 2, 257, long.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - float")]
        public void Test210()
        {
            var data1 = new Dictionary<string, object>() { { "key", float.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", float.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (float)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", (float)256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            var data5 = new Dictionary<string, object>() { { "key", float.PositiveInfinity } };
            var converted5 = ORiN3BinaryConverter.FromDictionaryToBinary(data5);
            var actual5 = ORiN3BinaryConverter.ToDictionary(converted5);
            Assert.Equal(data5, actual5);

            var data6 = new Dictionary<string, object>() { { "key", float.NegativeInfinity } };
            var converted6 = ORiN3BinaryConverter.FromDictionaryToBinary(data6);
            var actual6 = ORiN3BinaryConverter.ToDictionary(converted6);
            Assert.Equal(data6, actual6);

            var data7 = new Dictionary<string, object>() { { "key", float.NaN } };
            var converted7 = ORiN3BinaryConverter.FromDictionaryToBinary(data7);
            var actual7 = ORiN3BinaryConverter.ToDictionary(converted7);
            Assert.Equal(data7, actual7);

            float? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            float? value11 = float.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            float? value12 = float.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new float[] { float.MinValue, 2, 257, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<float>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new float?[] { float.MaxValue, null, 2, 257, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - double")]
        public void Test211()
        {
            var data1 = new Dictionary<string, object>() { { "key", double.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", double.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", (double)1 } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            var data4 = new Dictionary<string, object>() { { "key", (double)256 } };
            var converted4 = ORiN3BinaryConverter.FromDictionaryToBinary(data4);
            var actual4 = ORiN3BinaryConverter.ToDictionary(converted4);
            Assert.Equal(data4, actual4);

            var data5 = new Dictionary<string, object>() { { "key", double.PositiveInfinity } };
            var converted5 = ORiN3BinaryConverter.FromDictionaryToBinary(data5);
            var actual5 = ORiN3BinaryConverter.ToDictionary(converted5);
            Assert.Equal(data5, actual5);

            var data6 = new Dictionary<string, object>() { { "key", double.NegativeInfinity } };
            var converted6 = ORiN3BinaryConverter.FromDictionaryToBinary(data6);
            var actual6 = ORiN3BinaryConverter.ToDictionary(converted6);
            Assert.Equal(data6, actual6);

            var data7 = new Dictionary<string, object>() { { "key", double.NaN } };
            var converted7 = ORiN3BinaryConverter.FromDictionaryToBinary(data7);
            var actual7 = ORiN3BinaryConverter.ToDictionary(converted7);
            Assert.Equal(data7, actual7);

            double? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            double? value11 = double.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            double? value12 = double.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new double[] { double.MinValue, 2, 257, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<double>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new double?[] { double.MaxValue, null, 2, 257, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.MinValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - DateTime")]
        public void Test212()
        {
            var data1 = new Dictionary<string, object>() { { "key", DateTime.MinValue } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", DateTime.MaxValue } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var now = DateTime.Now;
            var data3 = new Dictionary<string, object>() { { "key", now } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            DateTime? value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            DateTime? value11 = DateTime.MinValue;
            var data11 = new Dictionary<string, object>() { { "key", value11 } };
            var converted11 = ORiN3BinaryConverter.FromDictionaryToBinary(data11);
            var actual11 = ORiN3BinaryConverter.ToDictionary(converted11);
            Assert.Equal(data11, actual11);

            DateTime? value12 = DateTime.MaxValue;
            var data12 = new Dictionary<string, object>() { { "key", value12 } };
            var converted12 = ORiN3BinaryConverter.FromDictionaryToBinary(data12);
            var actual12 = ORiN3BinaryConverter.ToDictionary(converted12);
            Assert.Equal(data12, actual12);

            var value20 = new DateTime[] { DateTime.MinValue, now, DateTime.MaxValue };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<DateTime>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);

            var value30 = new DateTime?[] { DateTime.MinValue, now, DateTime.MaxValue };
            var data30 = new Dictionary<string, object>() { { "key", value30 } };
            var converted30 = ORiN3BinaryConverter.FromDictionaryToBinary(data30);
            var actual30 = ORiN3BinaryConverter.ToDictionary(converted30);
            Assert.Equal(data30, actual30);
        }

        [Fact]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary - string")]
        public void Test213()
        {
            var data1 = new Dictionary<string, object>() { { "key", string.Empty } };
            var converted1 = ORiN3BinaryConverter.FromDictionaryToBinary(data1);
            var actual1 = ORiN3BinaryConverter.ToDictionary(converted1);
            Assert.Equal(data1, actual1);

            var data2 = new Dictionary<string, object>() { { "key", "abcあいう" } };
            var converted2 = ORiN3BinaryConverter.FromDictionaryToBinary(data2);
            var actual2 = ORiN3BinaryConverter.ToDictionary(converted2);
            Assert.Equal(data2, actual2);

            var data3 = new Dictionary<string, object>() { { "key", null } };
            var converted3 = ORiN3BinaryConverter.FromDictionaryToBinary(data3);
            var actual3 = ORiN3BinaryConverter.ToDictionary(converted3);
            Assert.Equal(data3, actual3);

            string value10 = null;
            var data10 = new Dictionary<string, object>() { { "key", value10 } };
            var converted10 = ORiN3BinaryConverter.FromDictionaryToBinary(data10);
            var actual10 = ORiN3BinaryConverter.ToDictionary(converted10);
            Assert.Equal(data10, actual10);

            var value20 = new string[] { string.Empty, "abcあいう", null, "" };
            var data20 = new Dictionary<string, object>() { { "key", value20 } };
            var converted20 = ORiN3BinaryConverter.FromDictionaryToBinary(data20);
            var actual20 = ORiN3BinaryConverter.ToDictionary(converted20);
            Assert.Equal(data20, actual20);

            var value21 = Array.Empty<string>();
            var data21 = new Dictionary<string, object>() { { "key", value21 } };
            var converted21 = ORiN3BinaryConverter.FromDictionaryToBinary(data21);
            var actual21 = ORiN3BinaryConverter.ToDictionary(converted21);
            Assert.Equal(data21, actual21);
        }

        public static IEnumerable<object[]> DicTestData
        {
            get
            {
                {
                    yield return new[] { new Dictionary<string, object>() { { "key1", true }, { "key2", new bool[] { false, true } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new bool[] { false, true } }, { "key2", new bool?[] { true, null, false } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new bool?[] { true, null, false } }, { "key2", (byte)123 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", (byte)123 }, { "key2", new byte[] { byte.MinValue, byte.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new byte[] { byte.MinValue, byte.MaxValue, 123 } }, { "key2", new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } }, { "key2", (sbyte)12 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", (sbyte)12 }, { "key2", new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } }, { "key2", new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } }, { "key2", (ushort)12345 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", (ushort)12345 }, { "key2", new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } }, { "key2", new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } }, { "key2", (short)111 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", (short)111 }, { "key2", new short[] { short.MinValue, short.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new short[] { short.MinValue, short.MaxValue, 123 } }, { "key2", new short?[] { short.MinValue, short.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new short?[] { short.MinValue, short.MaxValue, null, 123 } }, { "key2", (uint)123456 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", (uint)123456 }, { "key2", new uint[] { uint.MinValue, uint.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new uint[] { uint.MinValue, uint.MaxValue, 123 } }, { "key2", new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } }, { "key2", 654321 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", 654321 }, { "key2", new int[] { int.MinValue, int.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new int[] { int.MinValue, int.MaxValue, 123 } }, { "key2", new int?[] { int.MinValue, int.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new int?[] { int.MinValue, int.MaxValue, null, 123 } }, { "key2", (ulong)5555455 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", (ulong)5555455 }, { "key2", new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } }, { "key2", new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } }, { "key2", (long)3333321 } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", (long)3333321 }, { "key2", new long[] { long.MinValue, long.MaxValue, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new long[] { long.MinValue, long.MaxValue, 123 } }, { "key2", new long?[] { long.MinValue, long.MaxValue, null, 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new long?[] { long.MinValue, long.MaxValue, null, 123 } }, { "key2", 0.1F } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", 0.1F }, { "key2", new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F } }, { "key2", new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F } }, { "key2", 1.1D } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", 1.1D }, { "key2", new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } }, { "key2", new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } }, { "key2", DateTime.Now } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", DateTime.Now }, { "key2", new DateTime[] { DateTime.MinValue, DateTime.MinValue } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new DateTime[] { DateTime.MinValue, DateTime.MinValue } }, { "key2", new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } }, { "key2", "aaaaabbbbbcccc" } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", "aaaaabbbbbcccc" }, { "key2", new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } }, { "key2", true } } };
                }
            }
        }

        [Theory]
        [Trait(nameof(ORiN3BinaryConverter), "Dictionary")]
        [MemberData(nameof(DicTestData))]
        public void Test300(Dictionary<string, object> data)
        {
            var converted = ORiN3BinaryConverter.FromDictionaryToBinary(data);
            var actual = ORiN3BinaryConverter.ToDictionary(converted);
            Assert.Equal(data, actual);
        }

        public static IEnumerable<object[]> UnsupportedDicTestData
        {
            get
            {
                {
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<bool> { false, true } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<bool[]> { new bool[] { false, true } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<bool?[]> { new bool?[] { true, null, false } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<byte> { 123 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<byte[]> { new byte[] { byte.MinValue, byte.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<byte?[]> { new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<sbyte> { 12 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<sbyte[]> { new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<sbyte?[]> { new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<ushort> { 12345 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<ushort[]> { new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<ushort?[]> { new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<short> { 111 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<short[]> { new short[] { short.MinValue, short.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<short?[]> { new short?[] { short.MinValue, short.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<uint> { 123456 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<uint[]> { new uint[] { uint.MinValue, uint.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<uint?[]> { new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<int> { 654321 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<int[]> { new int[] { int.MinValue, int.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<int?[]> { new int?[] { int.MinValue, int.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<ulong> { 5555455 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<ulong[]> { new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<ulong?[]> { new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<long> { 3333321 } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<long[]> { new long[] { long.MinValue, long.MaxValue, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<long?[]> { new long?[] { long.MinValue, long.MaxValue, null, 123 } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<float> { 0.1F } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<float[]> { new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<float?[]> { new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<double> { 1.1D } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<double[]> { new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<double?[]> { new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<DateTime> { DateTime.Now } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<DateTime[]> { new DateTime[] { DateTime.MinValue, DateTime.MinValue } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<DateTime?[]> { new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<string> { "aaaaabbbbbcccc" } } } };
                    yield return new[] { new Dictionary<string, object>() { { "key1", new List<string[]> { new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } } } } };
                }
            }
        }

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
                    // キーが同じで、両方の値が null の場合に true を返す
                    if (Equals(x.Value, y.Value) && x.Value == null)
                    {
                        return true;
                    }

                    // それ以外の場合はデフォルトの等価判定を行う
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
