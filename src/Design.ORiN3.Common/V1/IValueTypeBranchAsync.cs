using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Common.V1;

/// <summary>
/// Class used to branch the process for each value type in ORiN3. (asynchronous version)
/// </summary>
public interface IValueTypeBranchAsync
{
    /// <summary>
    /// For bool
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfBoolAsync(CancellationToken token);

    /// <summary>
    /// For bool array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfBoolArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable bool
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableBoolAsync(CancellationToken token);

    /// <summary>
    /// For nullable bool array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableBoolArrayAsync(CancellationToken token);

    /// <summary>
    /// For int8
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt8Async(CancellationToken token);

    /// <summary>
    /// For int8 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt8ArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable int8
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt8Async(CancellationToken token);

    /// <summary>
    /// For nullable int8 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt8ArrayAsync(CancellationToken token);

    /// <summary>
    /// For int16
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt16Async(CancellationToken token);

    /// <summary>
    /// For int16 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt16ArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable int16
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt16Async(CancellationToken token);

    /// <summary>
    /// For nullable int16 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt16ArrayAsync(CancellationToken token);

    /// <summary>
    /// For int32
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt32Async(CancellationToken token);

    /// <summary>
    /// For int32 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt32ArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable int32
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt32Async(CancellationToken token);

    /// <summary>
    /// For nullable int32 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt32ArrayAsync(CancellationToken token);

    /// <summary>
    /// For int64
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt64Async(CancellationToken token);

    /// <summary>
    /// For int64 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfInt64ArrayAsync(CancellationToken token);

    /// <summary>
    /// for nullable int64
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt64Async(CancellationToken token);

    /// <summary>
    /// For nullable int64 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableInt64ArrayAsync(CancellationToken token);

    /// <summary>
    /// For unsigned int8
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt8Async(CancellationToken token);

    /// <summary>
    /// For unsigned int8 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt8ArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int8
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt8Async(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int8 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt8ArrayAsync(CancellationToken token);

    /// <summary>
    /// For unsigned int16
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt16Async(CancellationToken token);

    /// <summary>
    /// For unsigned int16 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt16ArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int16
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt16Async(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int16 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt16ArrayAsync(CancellationToken token);

    /// <summary>
    /// For unsigned int32
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt32Async(CancellationToken token);

    /// <summary>
    /// For unsigned int32 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt32ArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int32
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt32Async(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int32 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt32ArrayAsync(CancellationToken token);

    /// <summary>
    /// For unsigned int64
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt64Async(CancellationToken token);

    /// <summary>
    /// For unsigned int64 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfUInt64ArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int64
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt64Async(CancellationToken token);

    /// <summary>
    /// For nullable unsigned int64 array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableUInt64ArrayAsync(CancellationToken token);

    /// <summary>
    /// For float
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfFloatAsync(CancellationToken token);

    /// <summary>
    /// For float array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfFloatArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable float
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableFloatAsync(CancellationToken token);

    /// <summary>
    /// For nullable float array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableFloatArrayAsync(CancellationToken token);

    /// <summary>
    /// For double
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfDoubleAsync(CancellationToken token);

    /// <summary>
    /// For double array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfDoubleArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable double
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableDoubleAsync(CancellationToken token);

    /// <summary>
    /// For nullable double array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableDoubleArrayAsync(CancellationToken token);

    /// <summary>
    /// For string
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfStringAsync(CancellationToken token);

    /// <summary>
    /// For string array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfStringArrayAsync(CancellationToken token);

    /// <summary>
    /// For dateTime
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfDateTimeAsync(CancellationToken token);

    /// <summary>
    /// For dateTime arrayn
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfDateTimeArrayAsync(CancellationToken token);

    /// <summary>
    /// For nullable dateTime
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableDateTimeAsync(CancellationToken token);

    /// <summary>
    /// For nullable dateTime array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfNullableDateTimeArrayAsync(CancellationToken token);

    /// <summary>
    /// For object array
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfObjectAsync(CancellationToken token);

    /// <summary>
    /// For error
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfErrorAsync(CancellationToken token);
}
