using Message.ORiN3.Provider.V1.Branch;
using Message.ORiN3.Provider.V1.Branch.Switcher;
using System;
using Xunit;

namespace Message.ORiN3.Provider.Test.TestByDeveloper
{
    public class ValidateORiN3ValueTypeBranchTest
    {
        [Theory]
        [Trait(nameof(TypeSwitcher), "IsValid")]
        [InlineData(typeof(bool))]
        [InlineData(typeof(bool[]))]
        [InlineData(typeof(bool?))]
        [InlineData(typeof(bool?[]))]
        [InlineData(typeof(byte))]
        [InlineData(typeof(byte[]))]
        [InlineData(typeof(byte?))]
        [InlineData(typeof(byte?[]))]
        [InlineData(typeof(ushort))]
        [InlineData(typeof(ushort[]))]
        [InlineData(typeof(ushort?))]
        [InlineData(typeof(ushort?[]))]
        [InlineData(typeof(uint))]
        [InlineData(typeof(uint[]))]
        [InlineData(typeof(uint?))]
        [InlineData(typeof(uint?[]))]
        [InlineData(typeof(ulong))]
        [InlineData(typeof(ulong[]))]
        [InlineData(typeof(ulong?))]
        [InlineData(typeof(ulong?[]))]
        [InlineData(typeof(sbyte))]
        [InlineData(typeof(sbyte[]))]
        [InlineData(typeof(sbyte?))]
        [InlineData(typeof(sbyte?[]))]
        [InlineData(typeof(short))]
        [InlineData(typeof(short[]))]
        [InlineData(typeof(short?))]
        [InlineData(typeof(short?[]))]
        [InlineData(typeof(int))]
        [InlineData(typeof(int[]))]
        [InlineData(typeof(int?))]
        [InlineData(typeof(int?[]))]
        [InlineData(typeof(long))]
        [InlineData(typeof(long[]))]
        [InlineData(typeof(long?))]
        [InlineData(typeof(long?[]))]
        [InlineData(typeof(float))]
        [InlineData(typeof(float[]))]
        [InlineData(typeof(float?))]
        [InlineData(typeof(float?[]))]
        [InlineData(typeof(double))]
        [InlineData(typeof(double[]))]
        [InlineData(typeof(double?))]
        [InlineData(typeof(double?[]))]
        [InlineData(typeof(DateTime))]
        [InlineData(typeof(DateTime[]))]
        [InlineData(typeof(DateTime?))]
        [InlineData(typeof(DateTime?[]))]
        [InlineData(typeof(string))]
        [InlineData(typeof(string[]))]
        [InlineData(typeof(object[]))]
        public void ValidValueTypeTest(Type type)
        {
            var sut = new ValidateORiN3ValueTypeBranch();
            TypeSwitcher.Execute(type, sut);
            Assert.True(sut.IsValid);
        }

        [Fact]
        [Trait(nameof(TypeSwitcher), "IsValid")]
        public void UnsupportedTypeTest()
        {
            var sut = new ValidateORiN3ValueTypeBranch();
            TypeSwitcher.Execute(GetType(), sut);
            Assert.False(sut.IsValid);
        }
    }
}
