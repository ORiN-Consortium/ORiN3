﻿using Design.ORiN3.Provider.V1.AutoGenerated;
using Message.ORiN3.Provider.Test.Mock;
using Message.ORiN3.Provider.V1.AutoGenerated;
using Message.ORiN3.Provider.V1.Branch.Switcher;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Message.ORiN3.Provider.Test.TestByDeveloper
{
    public class TypeSwitcherTest
    {
        [Theory]
        [Trait(nameof(TypeSwitcher), "Execute")]
        [InlineData(ORiN3ValueType.Orin3Bool)]
        [InlineData(ORiN3ValueType.Orin3BoolArray)]
        [InlineData(ORiN3ValueType.Orin3NullableBool)]
        [InlineData(ORiN3ValueType.Orin3NullableBoolArray)]
        [InlineData(ORiN3ValueType.Orin3Int8)]
        [InlineData(ORiN3ValueType.Orin3Int8Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt8)]
        [InlineData(ORiN3ValueType.Orin3NullableInt8Array)]
        [InlineData(ORiN3ValueType.Orin3Int16)]
        [InlineData(ORiN3ValueType.Orin3Int16Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt16)]
        [InlineData(ORiN3ValueType.Orin3NullableInt16Array)]
        [InlineData(ORiN3ValueType.Orin3Int32)]
        [InlineData(ORiN3ValueType.Orin3Int32Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt32)]
        [InlineData(ORiN3ValueType.Orin3NullableInt32Array)]
        [InlineData(ORiN3ValueType.Orin3Int64)]
        [InlineData(ORiN3ValueType.Orin3Int64Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt64)]
        [InlineData(ORiN3ValueType.Orin3NullableInt64Array)]
        [InlineData(ORiN3ValueType.Orin3Uint8)]
        [InlineData(ORiN3ValueType.Orin3Uint8Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint8)]
        [InlineData(ORiN3ValueType.Orin3NullableUint8Array)]
        [InlineData(ORiN3ValueType.Orin3Uint16)]
        [InlineData(ORiN3ValueType.Orin3Uint16Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint16)]
        [InlineData(ORiN3ValueType.Orin3NullableUint16Array)]
        [InlineData(ORiN3ValueType.Orin3Uint32)]
        [InlineData(ORiN3ValueType.Orin3Uint32Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint32)]
        [InlineData(ORiN3ValueType.Orin3NullableUint32Array)]
        [InlineData(ORiN3ValueType.Orin3Uint64)]
        [InlineData(ORiN3ValueType.Orin3Uint64Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint64)]
        [InlineData(ORiN3ValueType.Orin3NullableUint64Array)]
        [InlineData(ORiN3ValueType.Orin3Float)]
        [InlineData(ORiN3ValueType.Orin3FloatArray)]
        [InlineData(ORiN3ValueType.Orin3NullableFloat)]
        [InlineData(ORiN3ValueType.Orin3NullableFloatArray)]
        [InlineData(ORiN3ValueType.Orin3Double)]
        [InlineData(ORiN3ValueType.Orin3DoubleArray)]
        [InlineData(ORiN3ValueType.Orin3NullableDouble)]
        [InlineData(ORiN3ValueType.Orin3NullableDoubleArray)]
        [InlineData(ORiN3ValueType.Orin3String)]
        [InlineData(ORiN3ValueType.Orin3StringArray)]
        [InlineData(ORiN3ValueType.Orin3Datetime)]
        [InlineData(ORiN3ValueType.Orin3DatetimeArray)]
        [InlineData(ORiN3ValueType.Orin3NullableDatetime)]
        [InlineData(ORiN3ValueType.Orin3NullableDatetimeArray)]
        [InlineData(ORiN3ValueType.Orin3Object)]
        public void FE227FCCC44B4C4BA45E327E098D315A(ORiN3ValueType valueType)
        {
            var mock = new ValueTypeBranchMock();
            TypeSwitcher.Execute(valueType, mock);
            Assert.Single(mock.History);
            Assert.Equal(valueType, mock.History[0]);
        }

        [Theory]
        [Trait(nameof(TypeSwitcher), "ExecuteAsync")]
        [InlineData(ORiN3ValueType.Orin3Bool)]
        [InlineData(ORiN3ValueType.Orin3BoolArray)]
        [InlineData(ORiN3ValueType.Orin3NullableBool)]
        [InlineData(ORiN3ValueType.Orin3NullableBoolArray)]
        [InlineData(ORiN3ValueType.Orin3Int8)]
        [InlineData(ORiN3ValueType.Orin3Int8Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt8)]
        [InlineData(ORiN3ValueType.Orin3NullableInt8Array)]
        [InlineData(ORiN3ValueType.Orin3Int16)]
        [InlineData(ORiN3ValueType.Orin3Int16Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt16)]
        [InlineData(ORiN3ValueType.Orin3NullableInt16Array)]
        [InlineData(ORiN3ValueType.Orin3Int32)]
        [InlineData(ORiN3ValueType.Orin3Int32Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt32)]
        [InlineData(ORiN3ValueType.Orin3NullableInt32Array)]
        [InlineData(ORiN3ValueType.Orin3Int64)]
        [InlineData(ORiN3ValueType.Orin3Int64Array)]
        [InlineData(ORiN3ValueType.Orin3NullableInt64)]
        [InlineData(ORiN3ValueType.Orin3NullableInt64Array)]
        [InlineData(ORiN3ValueType.Orin3Uint8)]
        [InlineData(ORiN3ValueType.Orin3Uint8Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint8)]
        [InlineData(ORiN3ValueType.Orin3NullableUint8Array)]
        [InlineData(ORiN3ValueType.Orin3Uint16)]
        [InlineData(ORiN3ValueType.Orin3Uint16Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint16)]
        [InlineData(ORiN3ValueType.Orin3NullableUint16Array)]
        [InlineData(ORiN3ValueType.Orin3Uint32)]
        [InlineData(ORiN3ValueType.Orin3Uint32Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint32)]
        [InlineData(ORiN3ValueType.Orin3NullableUint32Array)]
        [InlineData(ORiN3ValueType.Orin3Uint64)]
        [InlineData(ORiN3ValueType.Orin3Uint64Array)]
        [InlineData(ORiN3ValueType.Orin3NullableUint64)]
        [InlineData(ORiN3ValueType.Orin3NullableUint64Array)]
        [InlineData(ORiN3ValueType.Orin3Float)]
        [InlineData(ORiN3ValueType.Orin3FloatArray)]
        [InlineData(ORiN3ValueType.Orin3NullableFloat)]
        [InlineData(ORiN3ValueType.Orin3NullableFloatArray)]
        [InlineData(ORiN3ValueType.Orin3Double)]
        [InlineData(ORiN3ValueType.Orin3DoubleArray)]
        [InlineData(ORiN3ValueType.Orin3NullableDouble)]
        [InlineData(ORiN3ValueType.Orin3NullableDoubleArray)]
        [InlineData(ORiN3ValueType.Orin3String)]
        [InlineData(ORiN3ValueType.Orin3StringArray)]
        [InlineData(ORiN3ValueType.Orin3Datetime)]
        [InlineData(ORiN3ValueType.Orin3DatetimeArray)]
        [InlineData(ORiN3ValueType.Orin3NullableDatetime)]
        [InlineData(ORiN3ValueType.Orin3NullableDatetimeArray)]
        [InlineData(ORiN3ValueType.Orin3Object)]
        public async Task FE8E83AFA3E44F17AFDCA1EDDF46E874(ORiN3ValueType valueType)
        {
            var mock = new ValueTypeBranchAsyncMock();
            await TypeSwitcher.ExecuteAsync(valueType, mock, token: default);
            Assert.Single(mock.History);
            Assert.Equal(valueType, mock.History[0]);
        }

        [Theory]
        [Trait(nameof(TypeSwitcher), "Execute")]
        [InlineData(typeof(bool), ORiN3ValueType.Orin3Bool)]
        [InlineData(typeof(bool[]), ORiN3ValueType.Orin3BoolArray)]
        [InlineData(typeof(bool?), ORiN3ValueType.Orin3NullableBool)]
        [InlineData(typeof(bool?[]), ORiN3ValueType.Orin3NullableBoolArray)]
        [InlineData(typeof(sbyte), ORiN3ValueType.Orin3Int8)]
        [InlineData(typeof(sbyte[]), ORiN3ValueType.Orin3Int8Array)]
        [InlineData(typeof(sbyte?), ORiN3ValueType.Orin3NullableInt8)]
        [InlineData(typeof(sbyte?[]), ORiN3ValueType.Orin3NullableInt8Array)]
        [InlineData(typeof(short), ORiN3ValueType.Orin3Int16)]
        [InlineData(typeof(short[]), ORiN3ValueType.Orin3Int16Array)]
        [InlineData(typeof(short?), ORiN3ValueType.Orin3NullableInt16)]
        [InlineData(typeof(short?[]), ORiN3ValueType.Orin3NullableInt16Array)]
        [InlineData(typeof(int), ORiN3ValueType.Orin3Int32)]
        [InlineData(typeof(int[]), ORiN3ValueType.Orin3Int32Array)]
        [InlineData(typeof(int?), ORiN3ValueType.Orin3NullableInt32)]
        [InlineData(typeof(int?[]), ORiN3ValueType.Orin3NullableInt32Array)]
        [InlineData(typeof(long), ORiN3ValueType.Orin3Int64)]
        [InlineData(typeof(long[]), ORiN3ValueType.Orin3Int64Array)]
        [InlineData(typeof(long?), ORiN3ValueType.Orin3NullableInt64)]
        [InlineData(typeof(long?[]), ORiN3ValueType.Orin3NullableInt64Array)]
        [InlineData(typeof(byte), ORiN3ValueType.Orin3Uint8)]
        [InlineData(typeof(byte[]), ORiN3ValueType.Orin3Uint8Array)]
        [InlineData(typeof(byte?), ORiN3ValueType.Orin3NullableUint8)]
        [InlineData(typeof(byte?[]), ORiN3ValueType.Orin3NullableUint8Array)]
        [InlineData(typeof(ushort), ORiN3ValueType.Orin3Uint16)]
        [InlineData(typeof(ushort[]), ORiN3ValueType.Orin3Uint16Array)]
        [InlineData(typeof(ushort?), ORiN3ValueType.Orin3NullableUint16)]
        [InlineData(typeof(ushort?[]), ORiN3ValueType.Orin3NullableUint16Array)]
        [InlineData(typeof(uint), ORiN3ValueType.Orin3Uint32)]
        [InlineData(typeof(uint[]), ORiN3ValueType.Orin3Uint32Array)]
        [InlineData(typeof(uint?), ORiN3ValueType.Orin3NullableUint32)]
        [InlineData(typeof(uint?[]), ORiN3ValueType.Orin3NullableUint32Array)]
        [InlineData(typeof(ulong), ORiN3ValueType.Orin3Uint64)]
        [InlineData(typeof(ulong[]), ORiN3ValueType.Orin3Uint64Array)]
        [InlineData(typeof(ulong?), ORiN3ValueType.Orin3NullableUint64)]
        [InlineData(typeof(ulong?[]), ORiN3ValueType.Orin3NullableUint64Array)]
        [InlineData(typeof(float), ORiN3ValueType.Orin3Float)]
        [InlineData(typeof(float[]), ORiN3ValueType.Orin3FloatArray)]
        [InlineData(typeof(float?), ORiN3ValueType.Orin3NullableFloat)]
        [InlineData(typeof(float?[]), ORiN3ValueType.Orin3NullableFloatArray)]
        [InlineData(typeof(double), ORiN3ValueType.Orin3Double)]
        [InlineData(typeof(double[]), ORiN3ValueType.Orin3DoubleArray)]
        [InlineData(typeof(double?), ORiN3ValueType.Orin3NullableDouble)]
        [InlineData(typeof(double?[]), ORiN3ValueType.Orin3NullableDoubleArray)]
        [InlineData(typeof(string), ORiN3ValueType.Orin3String)]
        [InlineData(typeof(string[]), ORiN3ValueType.Orin3StringArray)]
        [InlineData(typeof(DateTime), ORiN3ValueType.Orin3Datetime)]
        [InlineData(typeof(DateTime[]), ORiN3ValueType.Orin3DatetimeArray)]
        [InlineData(typeof(DateTime?), ORiN3ValueType.Orin3NullableDatetime)]
        [InlineData(typeof(DateTime?[]), ORiN3ValueType.Orin3NullableDatetimeArray)]
        [InlineData(typeof(object[]), ORiN3ValueType.Orin3Object)]
        public void C12C8FAE86D94914848FE57E3416CE96(Type type, ORiN3ValueType expected)
        {
            var mock = new ValueTypeBranchMock();
            TypeSwitcher.Execute(type, mock);
            Assert.Single(mock.History);
            Assert.Equal(expected, mock.History[0]);
        }

        [Fact(DisplayName = "引数NULLのときの例外確認")]
        [Trait("category", nameof(TypeSwitcher))]
        public async Task D21D78AC50F94E0DAA043928E836C96D()
        {
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(ORiN3Value.ValueOneofCase.Bool, null));
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(null, new ValueTypeBranchMock()));
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(typeof(bool), null));
            Assert.Throws<ArgumentNullException>(() => TypeSwitcher.Execute(ORiN3ValueType.Orin3Bool, null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => TypeSwitcher.ExecuteAsync(ORiN3ValueType.Orin3Bool, null, CancellationToken.None));
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
