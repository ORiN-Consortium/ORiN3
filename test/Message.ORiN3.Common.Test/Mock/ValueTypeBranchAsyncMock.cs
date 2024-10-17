using Design.ORiN3.Common.V1;
using Design.ORiN3.Provider.V1.Type;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Message.ORiN3.Common.Test.Mock
{
    internal class ValueTypeBranchAsyncMock : IValueTypeBranchAsync
    {
        public List<ORiN3ValueType> History { get; private set; } = [];

        public Task CaseOfBoolAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Bool); return Task.CompletedTask; }
        public Task CaseOfBoolArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3BoolArray); return Task.CompletedTask; }
        public Task CaseOfNullableBoolAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableBool); return Task.CompletedTask; }
        public Task CaseOfNullableBoolArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableBoolArray); return Task.CompletedTask; }

        public Task CaseOfInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int8); return Task.CompletedTask; }
        public Task CaseOfInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int8Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt8); return Task.CompletedTask; }
        public Task CaseOfNullableInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt8Array); return Task.CompletedTask; }

        public Task CaseOfInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int16); return Task.CompletedTask; }
        public Task CaseOfInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int16Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt16); return Task.CompletedTask; }
        public Task CaseOfNullableInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt16Array); return Task.CompletedTask; }

        public Task CaseOfInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int32); return Task.CompletedTask; }
        public Task CaseOfInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int32Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt32); return Task.CompletedTask; }
        public Task CaseOfNullableInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt32Array); return Task.CompletedTask; }

        public Task CaseOfInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int64); return Task.CompletedTask; }
        public Task CaseOfInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Int64Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt64); return Task.CompletedTask; }
        public Task CaseOfNullableInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableInt64Array); return Task.CompletedTask; }

        public Task CaseOfUInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt8); return Task.CompletedTask; }
        public Task CaseOfUInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt8Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt8); return Task.CompletedTask; }
        public Task CaseOfNullableUInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt8Array); return Task.CompletedTask; }

        public Task CaseOfUInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt16); return Task.CompletedTask; }
        public Task CaseOfUInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt16Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt16); return Task.CompletedTask; }
        public Task CaseOfNullableUInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt16Array); return Task.CompletedTask; }

        public Task CaseOfUInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt32); return Task.CompletedTask; }
        public Task CaseOfUInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt32Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt32); return Task.CompletedTask; }
        public Task CaseOfNullableUInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt32Array); return Task.CompletedTask; }

        public Task CaseOfUInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt64); return Task.CompletedTask; }
        public Task CaseOfUInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3UInt64Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt64); return Task.CompletedTask; }
        public Task CaseOfNullableUInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableUInt64Array); return Task.CompletedTask; }

        public Task CaseOfFloatAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Float); return Task.CompletedTask; }
        public Task CaseOfFloatArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3FloatArray); return Task.CompletedTask; }
        public Task CaseOfNullableFloatAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableFloat); return Task.CompletedTask; }
        public Task CaseOfNullableFloatArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableFloatArray); return Task.CompletedTask; }

        public Task CaseOfDoubleAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Double); return Task.CompletedTask; }
        public Task CaseOfDoubleArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3DoubleArray); return Task.CompletedTask; }
        public Task CaseOfNullableDoubleAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableDouble); return Task.CompletedTask; }
        public Task CaseOfNullableDoubleArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableDoubleArray); return Task.CompletedTask; }

        public Task CaseOfDateTimeAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3DateTime); return Task.CompletedTask; }
        public Task CaseOfDateTimeArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3DateTimeArray); return Task.CompletedTask; }
        public Task CaseOfNullableDateTimeAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableDateTime); return Task.CompletedTask; }
        public Task CaseOfNullableDateTimeArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3NullableDateTimeArray); return Task.CompletedTask; }

        public Task CaseOfStringAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3String); return Task.CompletedTask; }
        public Task CaseOfStringArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3StringArray); return Task.CompletedTask; }

        public Task CaseOfObjectAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.ORiN3Object); return Task.CompletedTask; }

        public Task CaseOfErrorAsync(CancellationToken token = default) { History.Add((ORiN3ValueType)0); return Task.CompletedTask; }
    }
}
