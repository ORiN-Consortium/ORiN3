using Design.ORiN3.Common.V1;
using Design.ORiN3.Provider.V1.Type;
using System.Collections.Generic;

namespace Message.ORiN3.Common.Test.Mock
{
    internal class ValueTypeBranchMock : IValueTypeBranch
    {
        public List<ORiN3ValueType> History { get; private set; } = [];

        public void CaseOfBool() { History.Add(ORiN3ValueType.ORiN3Bool); }
        public void CaseOfBoolArray() { History.Add(ORiN3ValueType.ORiN3BoolArray); }
        public void CaseOfNullableBool() { History.Add(ORiN3ValueType.ORiN3NullableBool); }
        public void CaseOfNullableBoolArray() { History.Add(ORiN3ValueType.ORiN3NullableBoolArray); }

        public void CaseOfInt8() { History.Add(ORiN3ValueType.ORiN3Int8); }
        public void CaseOfInt8Array() { History.Add(ORiN3ValueType.ORiN3Int8Array); }
        public void CaseOfNullableInt8() { History.Add(ORiN3ValueType.ORiN3NullableInt8); }
        public void CaseOfNullableInt8Array() { History.Add(ORiN3ValueType.ORiN3NullableInt8Array); }

        public void CaseOfInt16() { History.Add(ORiN3ValueType.ORiN3Int16); }
        public void CaseOfInt16Array() { History.Add(ORiN3ValueType.ORiN3Int16Array); }
        public void CaseOfNullableInt16() { History.Add(ORiN3ValueType.ORiN3NullableInt16); }
        public void CaseOfNullableInt16Array() { History.Add(ORiN3ValueType.ORiN3NullableInt16Array); }

        public void CaseOfInt32() { History.Add(ORiN3ValueType.ORiN3Int32); }
        public void CaseOfInt32Array() { History.Add(ORiN3ValueType.ORiN3Int32Array); }
        public void CaseOfNullableInt32() { History.Add(ORiN3ValueType.ORiN3NullableInt32); }
        public void CaseOfNullableInt32Array() { History.Add(ORiN3ValueType.ORiN3NullableInt32Array); }

        public void CaseOfInt64() { History.Add(ORiN3ValueType.ORiN3Int64); }
        public void CaseOfInt64Array() { History.Add(ORiN3ValueType.ORiN3Int64Array); }
        public void CaseOfNullableInt64() { History.Add(ORiN3ValueType.ORiN3NullableInt64); }
        public void CaseOfNullableInt64Array() { History.Add(ORiN3ValueType.ORiN3NullableInt64Array); }

        public void CaseOfUInt8() { History.Add(ORiN3ValueType.ORiN3UInt8); }
        public void CaseOfUInt8Array() { History.Add(ORiN3ValueType.ORiN3UInt8Array); }
        public void CaseOfNullableUInt8() { History.Add(ORiN3ValueType.ORiN3NullableUInt8); }
        public void CaseOfNullableUInt8Array() { History.Add(ORiN3ValueType.ORiN3NullableUInt8Array); }

        public void CaseOfUInt16() { History.Add(ORiN3ValueType.ORiN3UInt16); }
        public void CaseOfUInt16Array() { History.Add(ORiN3ValueType.ORiN3UInt16Array); }
        public void CaseOfNullableUInt16() { History.Add(ORiN3ValueType.ORiN3NullableUInt16); }
        public void CaseOfNullableUInt16Array() { History.Add(ORiN3ValueType.ORiN3NullableUInt16Array); }

        public void CaseOfUInt32() { History.Add(ORiN3ValueType.ORiN3UInt32); }
        public void CaseOfUInt32Array() { History.Add(ORiN3ValueType.ORiN3UInt32Array); }
        public void CaseOfNullableUInt32() { History.Add(ORiN3ValueType.ORiN3NullableUInt32); }
        public void CaseOfNullableUInt32Array() { History.Add(ORiN3ValueType.ORiN3NullableUInt32Array); }

        public void CaseOfUInt64() { History.Add(ORiN3ValueType.ORiN3UInt64); }
        public void CaseOfUInt64Array() { History.Add(ORiN3ValueType.ORiN3UInt64Array); }
        public void CaseOfNullableUInt64() { History.Add(ORiN3ValueType.ORiN3NullableUInt64); }
        public void CaseOfNullableUInt64Array() { History.Add(ORiN3ValueType.ORiN3NullableUInt64Array); }

        public void CaseOfFloat() { History.Add(ORiN3ValueType.ORiN3Float); }
        public void CaseOfFloatArray() { History.Add(ORiN3ValueType.ORiN3FloatArray); }
        public void CaseOfNullableFloat() { History.Add(ORiN3ValueType.ORiN3NullableFloat); }
        public void CaseOfNullableFloatArray() { History.Add(ORiN3ValueType.ORiN3NullableFloatArray); }

        public void CaseOfDouble() { History.Add(ORiN3ValueType.ORiN3Double); }
        public void CaseOfDoubleArray() { History.Add(ORiN3ValueType.ORiN3DoubleArray); }
        public void CaseOfNullableDouble() { History.Add(ORiN3ValueType.ORiN3NullableDouble); }
        public void CaseOfNullableDoubleArray() { History.Add(ORiN3ValueType.ORiN3NullableDoubleArray); }

        public void CaseOfDateTime() { History.Add(ORiN3ValueType.ORiN3DateTime); }
        public void CaseOfDateTimeArray() { History.Add(ORiN3ValueType.ORiN3DateTimeArray); }
        public void CaseOfNullableDateTime() { History.Add(ORiN3ValueType.ORiN3NullableDateTime); }
        public void CaseOfNullableDateTimeArray() { History.Add(ORiN3ValueType.ORiN3NullableDateTimeArray); }

        public void CaseOfString() { History.Add(ORiN3ValueType.ORiN3String); }
        public void CaseOfStringArray() { History.Add(ORiN3ValueType.ORiN3StringArray); }

        public void CaseOfObject() { History.Add(ORiN3ValueType.ORiN3Object); }

        public void CaseOfError() { History.Add((ORiN3ValueType)0); }
    }
}
