﻿using Design.ORiN3.Provider.V1.Type;
using Message.ORiN3.Common.Test.Mock;
using Message.ORiN3.Common.V1.AutoGenerated;
using Message.ORiN3.Common.V1.Branch.Switcher;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Message.ORiN3.Common.Test.TestByDeveloper
{
    public class TypeSwitcherTest
    {
        [Theory]
        [Trait(nameof(TypeSwitcher), "Execute")]
        [InlineData(ORiN3ValueType.ORiN3Bool)]
        [InlineData(ORiN3ValueType.ORiN3BoolArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableBool)]
        [InlineData(ORiN3ValueType.ORiN3NullableBoolArray)]
        [InlineData(ORiN3ValueType.ORiN3Int8)]
        [InlineData(ORiN3ValueType.ORiN3Int8Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt8)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt8Array)]
        [InlineData(ORiN3ValueType.ORiN3Int16)]
        [InlineData(ORiN3ValueType.ORiN3Int16Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt16)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt16Array)]
        [InlineData(ORiN3ValueType.ORiN3Int32)]
        [InlineData(ORiN3ValueType.ORiN3Int32Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt32)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt32Array)]
        [InlineData(ORiN3ValueType.ORiN3Int64)]
        [InlineData(ORiN3ValueType.ORiN3Int64Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt64)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt64Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt8)]
        [InlineData(ORiN3ValueType.ORiN3UInt8Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt8)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt8Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt16)]
        [InlineData(ORiN3ValueType.ORiN3UInt16Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt16)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt16Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt32)]
        [InlineData(ORiN3ValueType.ORiN3UInt32Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt32)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt32Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt64)]
        [InlineData(ORiN3ValueType.ORiN3UInt64Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt64)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt64Array)]
        [InlineData(ORiN3ValueType.ORiN3Float)]
        [InlineData(ORiN3ValueType.ORiN3FloatArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableFloat)]
        [InlineData(ORiN3ValueType.ORiN3NullableFloatArray)]
        [InlineData(ORiN3ValueType.ORiN3Double)]
        [InlineData(ORiN3ValueType.ORiN3DoubleArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableDouble)]
        [InlineData(ORiN3ValueType.ORiN3NullableDoubleArray)]
        [InlineData(ORiN3ValueType.ORiN3String)]
        [InlineData(ORiN3ValueType.ORiN3StringArray)]
        [InlineData(ORiN3ValueType.ORiN3DateTime)]
        [InlineData(ORiN3ValueType.ORiN3DateTimeArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableDateTime)]
        [InlineData(ORiN3ValueType.ORiN3NullableDateTimeArray)]
        [InlineData(ORiN3ValueType.ORiN3Object)]
        public void FE227FCCC44B4C4BA45E327E098D315A(ORiN3ValueType valueType)
        {
            var mock = new ValueTypeBranchMock();
            TypeSwitcher.Execute(valueType, mock);
            Assert.Single(mock.History);
            Assert.Equal(valueType, mock.History[0]);
        }

        [Theory]
        [Trait(nameof(TypeSwitcher), "ExecuteAsync")]
        [InlineData(ORiN3ValueType.ORiN3Bool)]
        [InlineData(ORiN3ValueType.ORiN3BoolArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableBool)]
        [InlineData(ORiN3ValueType.ORiN3NullableBoolArray)]
        [InlineData(ORiN3ValueType.ORiN3Int8)]
        [InlineData(ORiN3ValueType.ORiN3Int8Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt8)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt8Array)]
        [InlineData(ORiN3ValueType.ORiN3Int16)]
        [InlineData(ORiN3ValueType.ORiN3Int16Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt16)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt16Array)]
        [InlineData(ORiN3ValueType.ORiN3Int32)]
        [InlineData(ORiN3ValueType.ORiN3Int32Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt32)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt32Array)]
        [InlineData(ORiN3ValueType.ORiN3Int64)]
        [InlineData(ORiN3ValueType.ORiN3Int64Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt64)]
        [InlineData(ORiN3ValueType.ORiN3NullableInt64Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt8)]
        [InlineData(ORiN3ValueType.ORiN3UInt8Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt8)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt8Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt16)]
        [InlineData(ORiN3ValueType.ORiN3UInt16Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt16)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt16Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt32)]
        [InlineData(ORiN3ValueType.ORiN3UInt32Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt32)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt32Array)]
        [InlineData(ORiN3ValueType.ORiN3UInt64)]
        [InlineData(ORiN3ValueType.ORiN3UInt64Array)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt64)]
        [InlineData(ORiN3ValueType.ORiN3NullableUInt64Array)]
        [InlineData(ORiN3ValueType.ORiN3Float)]
        [InlineData(ORiN3ValueType.ORiN3FloatArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableFloat)]
        [InlineData(ORiN3ValueType.ORiN3NullableFloatArray)]
        [InlineData(ORiN3ValueType.ORiN3Double)]
        [InlineData(ORiN3ValueType.ORiN3DoubleArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableDouble)]
        [InlineData(ORiN3ValueType.ORiN3NullableDoubleArray)]
        [InlineData(ORiN3ValueType.ORiN3String)]
        [InlineData(ORiN3ValueType.ORiN3StringArray)]
        [InlineData(ORiN3ValueType.ORiN3DateTime)]
        [InlineData(ORiN3ValueType.ORiN3DateTimeArray)]
        [InlineData(ORiN3ValueType.ORiN3NullableDateTime)]
        [InlineData(ORiN3ValueType.ORiN3NullableDateTimeArray)]
        [InlineData(ORiN3ValueType.ORiN3Object)]
        public async Task FE8E83AFA3E44F17AFDCA1EDDF46E874(ORiN3ValueType valueType)
        {
            var mock = new ValueTypeBranchAsyncMock();
            await TypeSwitcher.ExecuteAsync(valueType, mock, token: default);
            Assert.Single(mock.History);
            Assert.Equal(valueType, mock.History[0]);
        }

        [Theory]
        [Trait(nameof(TypeSwitcher), "Execute")]
        [InlineData(typeof(bool), ORiN3ValueType.ORiN3Bool)]
        [InlineData(typeof(bool[]), ORiN3ValueType.ORiN3BoolArray)]
        [InlineData(typeof(bool?), ORiN3ValueType.ORiN3NullableBool)]
        [InlineData(typeof(bool?[]), ORiN3ValueType.ORiN3NullableBoolArray)]
        [InlineData(typeof(sbyte), ORiN3ValueType.ORiN3Int8)]
        [InlineData(typeof(sbyte[]), ORiN3ValueType.ORiN3Int8Array)]
        [InlineData(typeof(sbyte?), ORiN3ValueType.ORiN3NullableInt8)]
        [InlineData(typeof(sbyte?[]), ORiN3ValueType.ORiN3NullableInt8Array)]
        [InlineData(typeof(short), ORiN3ValueType.ORiN3Int16)]
        [InlineData(typeof(short[]), ORiN3ValueType.ORiN3Int16Array)]
        [InlineData(typeof(short?), ORiN3ValueType.ORiN3NullableInt16)]
        [InlineData(typeof(short?[]), ORiN3ValueType.ORiN3NullableInt16Array)]
        [InlineData(typeof(int), ORiN3ValueType.ORiN3Int32)]
        [InlineData(typeof(int[]), ORiN3ValueType.ORiN3Int32Array)]
        [InlineData(typeof(int?), ORiN3ValueType.ORiN3NullableInt32)]
        [InlineData(typeof(int?[]), ORiN3ValueType.ORiN3NullableInt32Array)]
        [InlineData(typeof(long), ORiN3ValueType.ORiN3Int64)]
        [InlineData(typeof(long[]), ORiN3ValueType.ORiN3Int64Array)]
        [InlineData(typeof(long?), ORiN3ValueType.ORiN3NullableInt64)]
        [InlineData(typeof(long?[]), ORiN3ValueType.ORiN3NullableInt64Array)]
        [InlineData(typeof(byte), ORiN3ValueType.ORiN3UInt8)]
        [InlineData(typeof(byte[]), ORiN3ValueType.ORiN3UInt8Array)]
        [InlineData(typeof(byte?), ORiN3ValueType.ORiN3NullableUInt8)]
        [InlineData(typeof(byte?[]), ORiN3ValueType.ORiN3NullableUInt8Array)]
        [InlineData(typeof(ushort), ORiN3ValueType.ORiN3UInt16)]
        [InlineData(typeof(ushort[]), ORiN3ValueType.ORiN3UInt16Array)]
        [InlineData(typeof(ushort?), ORiN3ValueType.ORiN3NullableUInt16)]
        [InlineData(typeof(ushort?[]), ORiN3ValueType.ORiN3NullableUInt16Array)]
        [InlineData(typeof(uint), ORiN3ValueType.ORiN3UInt32)]
        [InlineData(typeof(uint[]), ORiN3ValueType.ORiN3UInt32Array)]
        [InlineData(typeof(uint?), ORiN3ValueType.ORiN3NullableUInt32)]
        [InlineData(typeof(uint?[]), ORiN3ValueType.ORiN3NullableUInt32Array)]
        [InlineData(typeof(ulong), ORiN3ValueType.ORiN3UInt64)]
        [InlineData(typeof(ulong[]), ORiN3ValueType.ORiN3UInt64Array)]
        [InlineData(typeof(ulong?), ORiN3ValueType.ORiN3NullableUInt64)]
        [InlineData(typeof(ulong?[]), ORiN3ValueType.ORiN3NullableUInt64Array)]
        [InlineData(typeof(float), ORiN3ValueType.ORiN3Float)]
        [InlineData(typeof(float[]), ORiN3ValueType.ORiN3FloatArray)]
        [InlineData(typeof(float?), ORiN3ValueType.ORiN3NullableFloat)]
        [InlineData(typeof(float?[]), ORiN3ValueType.ORiN3NullableFloatArray)]
        [InlineData(typeof(double), ORiN3ValueType.ORiN3Double)]
        [InlineData(typeof(double[]), ORiN3ValueType.ORiN3DoubleArray)]
        [InlineData(typeof(double?), ORiN3ValueType.ORiN3NullableDouble)]
        [InlineData(typeof(double?[]), ORiN3ValueType.ORiN3NullableDoubleArray)]
        [InlineData(typeof(string), ORiN3ValueType.ORiN3String)]
        [InlineData(typeof(string[]), ORiN3ValueType.ORiN3StringArray)]
        [InlineData(typeof(DateTime), ORiN3ValueType.ORiN3DateTime)]
        [InlineData(typeof(DateTime[]), ORiN3ValueType.ORiN3DateTimeArray)]
        [InlineData(typeof(DateTime?), ORiN3ValueType.ORiN3NullableDateTime)]
        [InlineData(typeof(DateTime?[]), ORiN3ValueType.ORiN3NullableDateTimeArray)]
        [InlineData(typeof(object[]), ORiN3ValueType.ORiN3Object)]
        public void C12C8FAE86D94914848FE57E3416CE96(Type type, ORiN3ValueType expected)
        {
            var mock = new ValueTypeBranchMock();
            TypeSwitcher.Execute(type, mock);
            Assert.Single(mock.History);
            Assert.Equal(expected, mock.History[0]);
        }

        [Fact(DisplayName="引数NULLのときの例外確認")]
        [Trait("category", nameof(TypeSwitcher))]
        public async Task D21D78AC50F94E0DAA043928E836C96D()
        {
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(ORiN3Value.ValueOneofCase.Bool, null));
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(null, new ValueTypeBranchMock()));
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(typeof(bool), null));
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(ORiN3ValueType.ORiN3Bool, null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => TypeSwitcher.ExecuteAsync(ORiN3ValueType.ORiN3Bool, null, CancellationToken.None));
        }

        [Fact(DisplayName = "引数が予期せぬ型の場合の動作確認")]
        [Trait("category", nameof(TypeSwitcher))]
        public void F7775CF916BE458DA93A6D26D2525E32()
        {
            var mock = new ValueTypeBranchMock();
            TypeSwitcher.Execute(typeof(Guid), mock);
            Assert.Equal(0, (int)mock.History[0]);
        }
    }
}