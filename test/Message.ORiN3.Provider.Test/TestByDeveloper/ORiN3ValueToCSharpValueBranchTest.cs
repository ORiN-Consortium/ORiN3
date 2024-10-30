using Message.ORiN3.Provider.V1.Branch;
using Message.ORiN3.Provider.V1.Branch.Switcher;
using Message.ORiN3.Provider.V1.Factory;
using System;
using System.Linq;
using Xunit;

namespace Message.ORiN3.Provider.Test.TestByDeveloper
{
    public class ORiN3ValueToCSharpValueBranchTest
    {
        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<bool>), "bool")]
        [InlineData(true)]
        [InlineData(false)]
        public void BoolTest(bool data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<bool>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<bool[]>), "bool[]")]
        [InlineData(new bool[0])]
        [InlineData(new[] { true })]
        [InlineData(new[] { false })]
        [InlineData(new[] { true, false, true })]
        public void BoolArrayTest(bool[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<bool[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<bool?>), "bool?")]
        [InlineData(null)]
        [InlineData(true)]
        [InlineData(false)]
        public void NullableBoolTest(bool? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<bool?>(orin3Value);
            TypeSwitcher.Execute(typeof(bool?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<bool?[]>), "bool?[]")]
        public void NullableBoolArrayTest()
        {
            var data1 = Array.Empty<bool?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<bool?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(bool?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new bool?[] { true };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<bool?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(bool?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new bool?[] { false };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<bool?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(bool?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new bool?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<bool?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(bool?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new bool?[] { true, false, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<bool?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(bool?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<byte>), "byte")]
        [InlineData(byte.MinValue)]
        [InlineData(byte.MaxValue)]
        public void UInt8Test(byte data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<byte>(orin3Value);
            TypeSwitcher.Execute(typeof(byte), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<byte[]>), "byte[]")]
        [InlineData(new byte[0])]
        [InlineData(new[] { byte.MinValue })]
        [InlineData(new[] { byte.MaxValue })]
        [InlineData(new[] { byte.MinValue, byte.MaxValue, byte.MinValue })]
        public void UInt8ArrayTest(byte[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<byte[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<byte?>), "byte?")]
        [InlineData(null)]
        [InlineData(byte.MinValue)]
        [InlineData(byte.MaxValue)]
        public void NullableUInt8Test(byte? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<byte?>(orin3Value);
            TypeSwitcher.Execute(typeof(byte?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<byte?[]>), "byte?[]")]
        public void NullableUInt8ArrayTest()
        {
            var data1 = Array.Empty<byte?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<byte?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(byte?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new byte?[] { byte.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<byte?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(byte?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new byte?[] { byte.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<byte?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(byte?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new byte?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<byte?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(byte?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new byte?[] { byte.MinValue, byte.MaxValue, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<byte?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(byte?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ushort>), "ushort")]
        [InlineData(ushort.MinValue)]
        [InlineData(ushort.MaxValue)]
        public void UInt16Test(ushort data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<ushort>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ushort[]>), "ushort[]")]
        [InlineData(new ushort[0])]
        [InlineData(new[] { ushort.MinValue })]
        [InlineData(new[] { ushort.MaxValue })]
        [InlineData(new[] { ushort.MinValue, ushort.MaxValue, ushort.MinValue })]
        public void UInt16ArrayTest(ushort[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<ushort[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ushort?>), "ushort?")]
        [InlineData(null)]
        [InlineData(ushort.MinValue)]
        [InlineData(ushort.MaxValue)]
        public void NullableUInt16Test(ushort? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<ushort?>(orin3Value);
            TypeSwitcher.Execute(typeof(ushort?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ushort?[]>), "ushort?[]")]
        public void NullableUInt16ArrayTest()
        {
            var data1 = Array.Empty<ushort?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<ushort?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(ushort?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new ushort?[] { ushort.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<ushort?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(ushort?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new ushort?[] { ushort.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<ushort?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(ushort?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new ushort?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<ushort?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(ushort?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new ushort?[] { ushort.MinValue, ushort.MaxValue, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<ushort?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(ushort?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<uint>), "uint")]
        [InlineData(uint.MinValue)]
        [InlineData(uint.MaxValue)]
        public void UInt32Test(uint data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<uint>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<uint[]>), "uint[]")]
        [InlineData(new uint[0])]
        [InlineData(new[] { uint.MinValue })]
        [InlineData(new[] { uint.MaxValue })]
        [InlineData(new[] { uint.MinValue, uint.MaxValue, uint.MinValue })]
        public void UInt32ArrayTest(uint[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<uint[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<uint?>), "uint?")]
        [InlineData(null)]
        [InlineData(uint.MinValue)]
        [InlineData(uint.MaxValue)]
        public void NullableUInt32Test(uint? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<uint?>(orin3Value);
            TypeSwitcher.Execute(typeof(uint?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<uint?[]>), "uint?[]")]
        public void NullableUInt32ArrayTest()
        {
            var data1 = Array.Empty<uint?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<uint?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(uint?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new uint?[] { uint.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<uint?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(uint?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new uint?[] { uint.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<uint?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(uint?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new uint?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<uint?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(uint?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new uint?[] { uint.MinValue, uint.MaxValue, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<uint?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(uint?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ulong>), "ulong")]
        [InlineData(ulong.MinValue)]
        [InlineData(ulong.MaxValue)]
        public void UInt64Test(ulong data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<ulong>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ulong[]>), "ulong[]")]
        [InlineData(new ulong[0])]
        [InlineData(new[] { ulong.MinValue })]
        [InlineData(new[] { ulong.MaxValue })]
        [InlineData(new[] { ulong.MinValue, ulong.MaxValue })]
        public void UInt164ArrayTest(ulong[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<ulong[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ulong?>), "ulong?")]
        [InlineData(null)]
        [InlineData(ulong.MinValue)]
        [InlineData(ulong.MaxValue)]
        public void NullableUInt64Test(ulong? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<ulong?>(orin3Value);
            TypeSwitcher.Execute(typeof(ulong?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<ulong?[]>), "ulong?[]")]
        public void NullableUInt64ArrayTest()
        {
            var data1 = Array.Empty<ulong?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<ulong?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(ulong?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new ulong?[] { ulong.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<ulong?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(ulong?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new ulong?[] { ulong.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<ulong?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(ulong?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new ulong?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<ulong?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(ulong?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new ulong?[] { ulong.MinValue, ulong.MaxValue, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<ulong?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(ulong?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<sbyte>), "sbyte")]
        [InlineData(sbyte.MinValue)]
        [InlineData(sbyte.MaxValue)]
        [InlineData(0)]
        public void Int8Test(sbyte data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<sbyte>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<sbyte[]>), "sbyte[]")]
        [InlineData(new sbyte[0])]
        [InlineData(new[] { sbyte.MinValue })]
        [InlineData(new[] { sbyte.MaxValue })]
        [InlineData(new[] { (sbyte)0 })]
        [InlineData(new[] { sbyte.MinValue, sbyte.MaxValue, (sbyte)0 })]
        public void Int8ArrayTest(sbyte[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<sbyte[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<sbyte?>), "sbyte?")]
        [InlineData(null)]
        [InlineData(sbyte.MinValue)]
        [InlineData(sbyte.MaxValue)]
        [InlineData((sbyte)0)]
        public void NullableInt8Test(sbyte? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<sbyte?>(orin3Value);
            TypeSwitcher.Execute(typeof(sbyte?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<sbyte?[]>), "sbyte?[]")]
        public void NullableInt8ArrayTest()
        {
            var data1 = Array.Empty<sbyte?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<sbyte?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(sbyte?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new sbyte?[] { sbyte.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<sbyte?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(sbyte?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new sbyte?[] { sbyte.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<sbyte?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(sbyte?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new sbyte?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<sbyte?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(sbyte?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, 0, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<sbyte?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(sbyte?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<short>), "short")]
        [InlineData(short.MinValue)]
        [InlineData(short.MaxValue)]
        [InlineData(0)]
        public void Int16Test(short data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<short>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<short[]>), "short[]")]
        [InlineData(new short[0])]
        [InlineData(new[] { short.MinValue })]
        [InlineData(new[] { short.MaxValue })]
        [InlineData(new[] { (short)0 })]
        [InlineData(new[] { short.MinValue, short.MaxValue, (short)0 })]
        public void Int16ArrayTest(short[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<short[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<short?>), "short?")]
        [InlineData(null)]
        [InlineData(short.MinValue)]
        [InlineData(short.MaxValue)]
        [InlineData((short)0)]
        public void NullableInt16Test(short? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<short?>(orin3Value);
            TypeSwitcher.Execute(typeof(short?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<short?[]>), "short?[]")]
        public void NullableInt16ArrayTest()
        {
            var data1 = Array.Empty<short?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<short?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(short?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new short?[] { short.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<short?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(short?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new short?[] { short.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<short?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(short?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new short?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<short?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(short?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new short?[] { short.MinValue, short.MaxValue, 0, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<short?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(short?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<int>), "int")]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        [InlineData(0)]
        public void Int32Test(int data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<int>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<int[]>), "int[]")]
        [InlineData(new int[0])]
        [InlineData(new[] { int.MinValue })]
        [InlineData(new[] { int.MaxValue })]
        [InlineData(new[] { 0 })]
        [InlineData(new[] { int.MinValue, int.MaxValue, 0 })]
        public void Int132ArrayTest(int[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<int[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<int?>), "int?")]
        [InlineData(null)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        [InlineData(0)]
        public void NullableInt32Test(int? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<int?>(orin3Value);
            TypeSwitcher.Execute(typeof(int?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<int?[]>), "int?[]")]
        public void NullableInt32ArrayTest()
        {
            var data1 = Array.Empty<int?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<int?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(int?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new int?[] { int.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<int?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(int?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new int?[] { int.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<int?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(int?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new int?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<int?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(int?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new int?[] { int.MinValue, int.MaxValue, 0, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<int?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(int?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<long>), "long")]
        [InlineData(long.MinValue)]
        [InlineData(long.MaxValue)]
        [InlineData(0L)]
        public void Int64Test(long data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<long>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<long[]>), "long[]")]
        [InlineData(new long[0])]
        [InlineData(new[] { long.MinValue })]
        [InlineData(new[] { long.MaxValue })]
        [InlineData(new[] { 0L })]
        [InlineData(new[] { long.MinValue, long.MaxValue, 0L })]
        public void Int64ArrayTest(long[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<long[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<long?>), "long?")]
        [InlineData(null)]
        [InlineData(long.MinValue)]
        [InlineData(long.MaxValue)]
        [InlineData(0L)]
        public void NullableInt64Test(long? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<long?>(orin3Value);
            TypeSwitcher.Execute(typeof(long?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<long?[]>), "long?[]")]
        public void NullableInt64ArrayTest()
        {
            var data1 = Array.Empty<long?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<long?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(long?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new long?[] { long.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<long?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(long?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new long?[] { long.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<long?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(long?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new long?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<long?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(long?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new long?[] { long.MinValue, long.MaxValue, 0L, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<long?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(long?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<float>), "float")]
        [InlineData(float.MinValue)]
        [InlineData(float.MaxValue)]
        [InlineData(float.NegativeInfinity)]
        [InlineData(float.PositiveInfinity)]
        [InlineData(float.NaN)]
        [InlineData(float.Epsilon)]
        [InlineData(0f)]
        public void FloatTest(float data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<float>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<float[]>), "float[]")]
        [InlineData(new float[0])]
        [InlineData(new[] { float.MinValue })]
        [InlineData(new[] { float.MaxValue })]
        [InlineData(new[] { float.NegativeInfinity })]
        [InlineData(new[] { float.PositiveInfinity })]
        [InlineData(new[] { float.NaN })]
        [InlineData(new[] { float.Epsilon })]
        [InlineData(new[] { 0f })]
        [InlineData(new[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.Epsilon, 0f })]
        public void FloatArrayTest(float[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<float[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<float?>), "float?")]
        [InlineData(null)]
        [InlineData(float.MinValue)]
        [InlineData(float.MaxValue)]
        [InlineData(float.NegativeInfinity)]
        [InlineData(float.PositiveInfinity)]
        [InlineData(float.NaN)]
        [InlineData(float.Epsilon)]
        [InlineData(0f)]
        public void NullableFloatTest(float? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<float?>(orin3Value);
            TypeSwitcher.Execute(typeof(float?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<float?[]>), "float?[]")]
        public void NullableFloatArrayTest()
        {
            var data1 = Array.Empty<float?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<float?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(float?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new float?[] { float.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<float?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(float?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new float?[] { float.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<float?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(float?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new float?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<float?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(float?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, float.Epsilon, 0f, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<float?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(float?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<double>), "double")]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [InlineData(double.NaN)]
        [InlineData(double.Epsilon)]
        [InlineData(0f)]
        public void DoubleTest(double data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<double>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<double[]>), "double[]")]
        [InlineData(new double[0])]
        [InlineData(new[] { double.MinValue })]
        [InlineData(new[] { double.MaxValue })]
        [InlineData(new[] { double.NegativeInfinity })]
        [InlineData(new[] { double.PositiveInfinity })]
        [InlineData(new[] { double.NaN })]
        [InlineData(new[] { double.Epsilon })]
        [InlineData(new[] { 0.0 })]
        [InlineData(new[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.Epsilon, 0.0 })]
        public void DoubleArrayTest(double[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<double[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<double?>), "double?")]
        [InlineData(null)]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [InlineData(double.NaN)]
        [InlineData(double.Epsilon)]
        [InlineData(0.0)]
        public void NullableDoubleTest(double? data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<double?>(orin3Value);
            TypeSwitcher.Execute(typeof(double?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<double?[]>), "double?[]")]
        public void NullableDoubleArrayTest()
        {
            var data1 = Array.Empty<double?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<double?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(double?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new double?[] { double.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<double?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(double?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new double?[] { double.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<double?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(double?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new double?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<double?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(double?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, double.Epsilon, 0.0, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<double?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(double?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<DateTime>), "DateTime")]
        [InlineData(0)]
        [InlineData(3155378975999999999)]
        public void DateTimeTest(long ticks)
        {
            var data = DateTime.FromBinary(ticks);
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<DateTime>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<DateTime[]>), "DateTime[]")]
        [InlineData(new long[0])]
        [InlineData(new long[] { 0 })]
        [InlineData(new long[] { 3155378975999999999 })]
        [InlineData(new long[] { 0, 3155378975999999999, 0 })]
        public void DateTimeArrayTest(long[] ticks)
        {
            var data = ticks.Select(_ => DateTime.FromBinary(_)).ToArray();
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<DateTime[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<DateTime?>), "DateTime?")]
        [InlineData(null)]
        [InlineData(0L)]
        [InlineData(3155378975999999999)]
        public void NullableDateTimeTest(long? ticks)
        {
            DateTime? data = ticks.HasValue ? DateTime.FromBinary(ticks.Value) : null;
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<DateTime?>(orin3Value);
            TypeSwitcher.Execute(typeof(DateTime?), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<DateTime?[]>), "DateTime?[]")]
        public void NullableDateTimeArrayTest()
        {
            var data1 = Array.Empty<DateTime?>();
            var orin3Value1 = ORiN3ValueFactory.Create(data1);
            var sut1 = new ORiN3ValueToCSharpValueBranch<DateTime?[]>(orin3Value1);
            TypeSwitcher.Execute(typeof(DateTime?[]), sut1);
            Assert.Equal(data1, sut1.Result);

            var data2 = new DateTime?[] { DateTime.MinValue };
            var orin3Value2 = ORiN3ValueFactory.Create(data2);
            var sut2 = new ORiN3ValueToCSharpValueBranch<DateTime?[]>(orin3Value2);
            TypeSwitcher.Execute(typeof(DateTime?[]), sut2);
            Assert.Equal(data2, sut2.Result);

            var data3 = new DateTime?[] { DateTime.MaxValue };
            var orin3Value3 = ORiN3ValueFactory.Create(data3);
            var sut3 = new ORiN3ValueToCSharpValueBranch<DateTime?[]>(orin3Value3);
            TypeSwitcher.Execute(typeof(DateTime?[]), sut3);
            Assert.Equal(data3, sut3.Result);

            var data4 = new DateTime?[] { null };
            var orin3Value4 = ORiN3ValueFactory.Create(data4);
            var sut4 = new ORiN3ValueToCSharpValueBranch<DateTime?[]>(orin3Value4);
            TypeSwitcher.Execute(typeof(DateTime?[]), sut4);
            Assert.Equal(data4, sut4.Result);

            var data5 = new DateTime?[] { DateTime.MinValue, DateTime.MaxValue, null };
            var orin3Value5 = ORiN3ValueFactory.Create(data5);
            var sut5 = new ORiN3ValueToCSharpValueBranch<DateTime?[]>(orin3Value5);
            TypeSwitcher.Execute(typeof(DateTime?[]), sut5);
            Assert.Equal(data5, sut5.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<string>), "string")]
        [InlineData("")]
        [InlineData("test")]
        public void StringTest(string data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<string>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<string[]>), "string[]")]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void StringArrayTest(int count)
        {
            var data = new string[count];
            for (var i = 0; i < count; ++i)
            {
                data[i] = count.ToString();
            }
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<string[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        public static TheoryData<object[]> ObjectArrayTestData => new()
        {
            Array.Empty<object>(),
            new object[] { true, new bool[] { false, true } },
            new object[] { new bool[] { false, true }, new bool?[] { true, null, false } },
            new object[] { new bool?[] { true, null, false }, (byte)123 },
            new object[] { (byte)123, new byte[] { byte.MinValue, byte.MaxValue, 123 } },
            new object[] { new byte[] { byte.MinValue, byte.MaxValue, 123 }, new byte?[] { byte.MinValue, byte.MaxValue, null, 123 } },
            new object[] { new byte?[] { byte.MinValue, byte.MaxValue, null, 123 }, (sbyte)12 },
            new object[] { (sbyte)12, new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 } },
            new object[] { new sbyte[] { sbyte.MinValue, sbyte.MaxValue, 123 }, new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 } },
            new object[] { new sbyte?[] { sbyte.MinValue, sbyte.MaxValue, null, 123 }, (ushort)12345 },
            new object[] { (ushort)12345, new ushort[] { ushort.MinValue, ushort.MaxValue, 123 } },
            new object[] { new ushort[] { ushort.MinValue, ushort.MaxValue, 123 }, new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 } },
            new object[] { new ushort?[] { ushort.MinValue, ushort.MaxValue, null, 123 }, (short)111 },
            new object[] { (short)111, new short[] { short.MinValue, short.MaxValue, 123 } },
            new object[] { new short[] { short.MinValue, short.MaxValue, 123 }, new short?[] { short.MinValue, short.MaxValue, null, 123 } },
            new object[] { new short?[] { short.MinValue, short.MaxValue, null, 123 }, (uint)123456 },
            new object[] { (uint)123456, new uint[] { uint.MinValue, uint.MaxValue, 123 } },
            new object[] { new uint[] { uint.MinValue, uint.MaxValue, 123 }, new uint?[] { uint.MinValue, uint.MaxValue, null, 123 } },
            new object[] { new uint?[] { uint.MinValue, uint.MaxValue, null, 123 }, 654321 },
            new object[] { 654321, new int[] { int.MinValue, int.MaxValue, 123 }, },
            new object[] { new int[] { int.MinValue, int.MaxValue, 123 }, new int?[] { int.MinValue, int.MaxValue, null, 123 } },
            new object[] { new int?[] { int.MinValue, int.MaxValue, null, 123 }, (ulong)5555455 },
            new object[] { (ulong)5555455, new ulong[] { ulong.MinValue, ulong.MaxValue, 123 } },
            new object[] { new ulong[] { ulong.MinValue, ulong.MaxValue, 123 }, new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 } },
            new object[] { new ulong?[] { ulong.MinValue, ulong.MaxValue, null, 123 }, (long)3333321 },
            new object[] { (long)3333321, new long[] { long.MinValue, long.MaxValue, 123 } },
            new object[] { new long[] { long.MinValue, long.MaxValue, 123 }, new long?[] { long.MinValue, long.MaxValue, null, 123 } },
            new object[] { new long?[] { long.MinValue, long.MaxValue, null, 123 }, 0.1F },
            new object[] { 0.1F, new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F }, },
            new object[] { new float[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, 123F }, new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F }, },
            new object[] { new float?[] { float.MinValue, float.MaxValue, float.PositiveInfinity, float.NegativeInfinity, float.NaN, null, 123F }, 1.1D },
            new object[] { 1.1D, new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F } },
            new object[] { new double[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, 123F }, new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F } },
            new object[] { new double?[] { double.MinValue, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN, null, 123F }, DateTime.Now },
            new object[] { DateTime.Now, new DateTime[] { DateTime.MinValue, DateTime.MinValue } },
            new object[] { new DateTime[] { DateTime.MinValue, DateTime.MinValue }, new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue } },
            new object[] { new DateTime?[] { DateTime.MinValue, null, DateTime.MinValue }, "aaaaabbbbbcccc" },
            new object[] { "aaaaabbbbbcccc", new string[] { "12345", string.Empty, null, "AAAABBBBCCC" } },
            new object[] { new string[] { "12345", string.Empty, null, "AAAABBBBCCC" }, true },
        };

        [Theory]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<object[]>), "object[]")]
        [MemberData(nameof(ObjectArrayTestData))]
        public void ObjectArrayTest(object[] data)
        {
            var orin3Value = ORiN3ValueFactory.Create(data);
            var sut = new ORiN3ValueToCSharpValueBranch<object[]>(orin3Value);
            TypeSwitcher.Execute(data.GetType(), sut);
            Assert.Equal(data, sut.Result);
        }

        [Fact]
        [Trait(nameof(ORiN3ValueToCSharpValueBranch<int>), "error")]
        public void UnsupportedTypeTest()
        {
            Assert.Throws<TypeSwitcherException>(() =>
            {
                var orin3Value = ORiN3ValueFactory.Create(0);
                var sut = new ORiN3ValueToCSharpValueBranch<int>(orin3Value);
                TypeSwitcher.Execute(GetType(), sut);
            });
        }
    }
}
