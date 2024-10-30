﻿using Design.ORiN3.Common.V1;
using Design.ORiN3.Provider.V1.AutoGenerated;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Message.ORiN3.Provider.Test.Mock
{
    internal class ValueTypeBranchAsyncMock : IValueTypeBranchAsync
    {
        public List<ORiN3ValueType> History { get; private set; } = [];

        public Task CaseOfBoolAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Bool); return Task.CompletedTask; }
        public Task CaseOfBoolArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3BoolArray); return Task.CompletedTask; }
        public Task CaseOfNullableBoolAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableBool); return Task.CompletedTask; }
        public Task CaseOfNullableBoolArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableBoolArray); return Task.CompletedTask; }

        public Task CaseOfInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int8); return Task.CompletedTask; }
        public Task CaseOfInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int8Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt8); return Task.CompletedTask; }
        public Task CaseOfNullableInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt8Array); return Task.CompletedTask; }

        public Task CaseOfInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int16); return Task.CompletedTask; }
        public Task CaseOfInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int16Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt16); return Task.CompletedTask; }
        public Task CaseOfNullableInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt16Array); return Task.CompletedTask; }

        public Task CaseOfInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int32); return Task.CompletedTask; }
        public Task CaseOfInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int32Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt32); return Task.CompletedTask; }
        public Task CaseOfNullableInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt32Array); return Task.CompletedTask; }

        public Task CaseOfInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int64); return Task.CompletedTask; }
        public Task CaseOfInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Int64Array); return Task.CompletedTask; }
        public Task CaseOfNullableInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt64); return Task.CompletedTask; }
        public Task CaseOfNullableInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableInt64Array); return Task.CompletedTask; }

        public Task CaseOfUInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint8); return Task.CompletedTask; }
        public Task CaseOfUInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint8Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt8Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint8); return Task.CompletedTask; }
        public Task CaseOfNullableUInt8ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint8Array); return Task.CompletedTask; }

        public Task CaseOfUInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint16); return Task.CompletedTask; }
        public Task CaseOfUInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint16Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt16Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint16); return Task.CompletedTask; }
        public Task CaseOfNullableUInt16ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint16Array); return Task.CompletedTask; }

        public Task CaseOfUInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint32); return Task.CompletedTask; }
        public Task CaseOfUInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint32Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt32Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint32); return Task.CompletedTask; }
        public Task CaseOfNullableUInt32ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint32Array); return Task.CompletedTask; }

        public Task CaseOfUInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint64); return Task.CompletedTask; }
        public Task CaseOfUInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Uint64Array); return Task.CompletedTask; }
        public Task CaseOfNullableUInt64Async(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint64); return Task.CompletedTask; }
        public Task CaseOfNullableUInt64ArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableUint64Array); return Task.CompletedTask; }

        public Task CaseOfFloatAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Float); return Task.CompletedTask; }
        public Task CaseOfFloatArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3FloatArray); return Task.CompletedTask; }
        public Task CaseOfNullableFloatAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableFloat); return Task.CompletedTask; }
        public Task CaseOfNullableFloatArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableFloatArray); return Task.CompletedTask; }

        public Task CaseOfDoubleAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Double); return Task.CompletedTask; }
        public Task CaseOfDoubleArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3DoubleArray); return Task.CompletedTask; }
        public Task CaseOfNullableDoubleAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableDouble); return Task.CompletedTask; }
        public Task CaseOfNullableDoubleArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableDoubleArray); return Task.CompletedTask; }

        public Task CaseOfDateTimeAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Datetime); return Task.CompletedTask; }
        public Task CaseOfDateTimeArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3DatetimeArray); return Task.CompletedTask; }
        public Task CaseOfNullableDateTimeAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableDatetime); return Task.CompletedTask; }
        public Task CaseOfNullableDateTimeArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3NullableDatetimeArray); return Task.CompletedTask; }

        public Task CaseOfStringAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3String); return Task.CompletedTask; }
        public Task CaseOfStringArrayAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3StringArray); return Task.CompletedTask; }

        public Task CaseOfObjectAsync(CancellationToken token = default) { History.Add(ORiN3ValueType.Orin3Object); return Task.CompletedTask; }

        public Task CaseOfErrorAsync(CancellationToken token = default) { History.Add(0); return Task.CompletedTask; }
    }
}