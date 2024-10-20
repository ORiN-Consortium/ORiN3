﻿using Design.ORiN3.Provider.V1.Type;
using Message.ORiN3.Common.Test.Mock;
using Message.ORiN3.Common.V1.AutoGenerated;
using Message.ORiN3.Common.V1.Branch.Switcher;
using Message.ORiN3.Common.V1.Factory;
using System;
using System.Collections.Generic;
using Xunit;

namespace Message.ORiN3.Common.Test.TestByDeveloper
{
    public class ValueSwitcherTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { (bool)true, ORiN3ValueType.ORiN3Bool, false, };
            yield return new object[] { (bool[])[true, false], ORiN3ValueType.ORiN3BoolArray, false, };
            yield return new object[] { (bool?[])[true, null], ORiN3ValueType.ORiN3NullableBoolArray, false, };
            yield return new object[] { (sbyte)1, ORiN3ValueType.ORiN3Int8, false, };
            yield return new object[] { (sbyte[])[1, 2], ORiN3ValueType.ORiN3Int8Array, false, };
            yield return new object[] { (sbyte?[])[1, null], ORiN3ValueType.ORiN3NullableInt8Array, false, };
            yield return new object[] { (short)1, ORiN3ValueType.ORiN3Int16, false, };
            yield return new object[] { (short[])[1, 2], ORiN3ValueType.ORiN3Int16Array, false, };
            yield return new object[] { (short?[])[1, null], ORiN3ValueType.ORiN3NullableInt16Array, false, };
            yield return new object[] { (int)1, ORiN3ValueType.ORiN3Int32, false, };
            yield return new object[] { (int[])[1, 2], ORiN3ValueType.ORiN3Int32Array, false, };
            yield return new object[] { (int?[])[1, null], ORiN3ValueType.ORiN3NullableInt32Array, false, };
            yield return new object[] { (long)1, ORiN3ValueType.ORiN3Int64, false, };
            yield return new object[] { (long[])[1, 2], ORiN3ValueType.ORiN3Int64Array, false, };
            yield return new object[] { (long?[])[1, null], ORiN3ValueType.ORiN3NullableInt64Array, false, };
            yield return new object[] { (byte)1, ORiN3ValueType.ORiN3UInt8, false, };
            yield return new object[] { (byte[])[1, 2], ORiN3ValueType.ORiN3UInt8Array, false, };
            yield return new object[] { (byte?[])[1, null], ORiN3ValueType.ORiN3NullableUInt8Array, false, };
            yield return new object[] { (ushort)1, ORiN3ValueType.ORiN3UInt16, false, };
            yield return new object[] { (ushort[])[1, 2], ORiN3ValueType.ORiN3UInt16Array, false, };
            yield return new object[] { (ushort?[])[1, null], ORiN3ValueType.ORiN3NullableUInt16Array, false, };
            yield return new object[] { (uint)1, ORiN3ValueType.ORiN3UInt32, false, };
            yield return new object[] { (uint[])[1, 2], ORiN3ValueType.ORiN3UInt32Array, false, };
            yield return new object[] { (uint?[])[1, null], ORiN3ValueType.ORiN3NullableUInt32Array, false, };
            yield return new object[] { (ulong)1, ORiN3ValueType.ORiN3UInt64, false, };
            yield return new object[] { (ulong[])[1, 2], ORiN3ValueType.ORiN3UInt64Array, false, };
            yield return new object[] { (ulong?[])[1, null], ORiN3ValueType.ORiN3NullableUInt64Array, false, };
            yield return new object[] { (float)1, ORiN3ValueType.ORiN3Float, false, };
            yield return new object[] { (float[])[1, 2], ORiN3ValueType.ORiN3FloatArray, false, };
            yield return new object[] { (float?[])[1, null], ORiN3ValueType.ORiN3NullableFloatArray, false, };
            yield return new object[] { (double)1, ORiN3ValueType.ORiN3Double, false, };
            yield return new object[] { (double[])[1, 2], ORiN3ValueType.ORiN3DoubleArray, false, };
            yield return new object[] { (double?[])[1, null], ORiN3ValueType.ORiN3NullableDoubleArray, false, };
            yield return new object[] { (string)"aaa", ORiN3ValueType.ORiN3String, false, };
            yield return new object[] { (string[])["aaa", "bbb"], ORiN3ValueType.ORiN3StringArray, false, };
            yield return new object[] { (DateTime)DateTime.Now, ORiN3ValueType.ORiN3DateTime, false, };
            yield return new object[] { (DateTime[])[DateTime.Now, DateTime.Now], ORiN3ValueType.ORiN3DateTimeArray, false, };
            yield return new object[] { (DateTime?[])[DateTime.Now, null], ORiN3ValueType.ORiN3NullableDateTimeArray, false, };
            yield return new object[] { (object[])[1, "aaa"], ORiN3ValueType.ORiN3Object, false, };
            yield return new object[] { null, ORiN3ValueType.ORiN3NullableBool, true, };
        }


        [Theory]
        [Trait(nameof(ValueSwitcher), "Execute")]
        [MemberData(nameof(TestData))]
        public void Test01(object value, ORiN3ValueType expected, bool isNull)
        {
            var mock = new ValueBranchMock();
            ValueSwitcher.Execute(value, mock);
            Assert.Single(mock.History);
            Assert.Equal(expected, mock.History[0]);
            Assert.Equal(isNull, mock.IsNull);
        }

        [Theory]
        [Trait(nameof(ValueSwitcher), "Execute")]
        [MemberData(nameof(TestData))]
        public void Test02(object value, ORiN3ValueType expected, bool isNull)
        {
            var mock = new ValueBranchMock();
            var orin3Value = !isNull ? ORiN3ValueFactory.Create((dynamic)value) : new ORiN3Value { Type = (int)ORiN3ValueType.ORiN3NullableBool, NullableBool = new() { IsNull = true, } };
            ValueSwitcher.Execute(orin3Value, mock);
            Assert.Single(mock.History);
            Assert.Equal(expected, mock.History[0]);
            Assert.Equal(isNull, mock.IsNull);
        }
    }
}
