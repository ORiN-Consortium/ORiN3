namespace Design.ORiN3.Provider.V1.Type;

/// <summary>
/// Types of data available in ORiN3
/// </summary>
public enum ORiN3ValueType
{
    /// <summary>
    /// Boolean value
    /// </summary>
    ORiN3Bool = 10,

    /// <summary>
    /// Boolean array type
    /// </summary>
    ORiN3BoolArray = 11,

    /// <summary>
    /// Boolean value of null-allowed type
    /// </summary>
    ORiN3NullableBool = 12,

    /// <summary>
    /// Boolean value of null-allowed array type
    /// </summary>
    ORiN3NullableBoolArray = 13,

    /// <summary>
    /// 8-bit signed integer
    /// </summary>
    ORiN3Int8 = 20,

    /// <summary>
    /// 8-bit signed integer of array type
    /// </summary>
    ORiN3Int8Array = 21,

    /// <summary>
    /// 8-bit signed integer of null-allowed type
    /// </summary>
    ORiN3NullableInt8 = 22,

    /// <summary>
    /// 8-bit signed integer of null-allowed array type
    /// </summary>
    ORiN3NullableInt8Array = 23,

    /// <summary>
    /// 16-bit signed integer
    /// </summary>
    ORiN3Int16 = 30,

    /// <summary>
    /// 16-bit signed integer of array type
    /// </summary>
    ORiN3Int16Array = 31,

    /// <summary>
    /// 16-bit signed integer of null-allowed type
    /// </summary>
    ORiN3NullableInt16 = 32,

    /// <summary>
    /// 16-bit signed integer of null-tolerant array type
    /// </summary>
    ORiN3NullableInt16Array = 33,

    /// <summary>
    /// 32-bit signed integer
    /// </summary>
    ORiN3Int32 = 40,

    /// <summary>
    /// 32-bit signed integer of array type
    /// </summary>
    ORiN3Int32Array = 41,

    /// <summary>
    /// 32-bit signed integer of null-allowed type
    /// </summary>
    ORiN3NullableInt32 = 42,

    /// <summary>
    /// 32-bit signed integer of null-allowed array type
    /// </summary>
    ORiN3NullableInt32Array = 43,

    /// <summary>
    /// 64-bit signed integer
    /// </summary>
    ORiN3Int64 = 50,

    /// <summary>
    /// 64-bit signed integer of array type
    /// </summary>
    ORiN3Int64Array = 51,

    /// <summary>
    /// 64-bit signed integer of null-allowed type
    /// </summary>
    ORiN3NullableInt64 = 52,

    /// <summary>
    /// 64-bit signed integer of null-allowed array type
    /// </summary>
    ORiN3NullableInt64Array = 53,

    /// <summary>
    /// 8-bit unsigned integer
    /// </summary>
    ORiN3UInt8 = 60,

    /// <summary>
    /// 8-bit unsigned integer of array type
    /// </summary>
    ORiN3UInt8Array = 61,

    /// <summary>
    /// 8-bit unsigned integer of null-allowed type
    /// </summary>
    ORiN3NullableUInt8 = 62,

    /// <summary>
    /// 8-bit unsigned integer of null-allowed array type
    /// </summary>
    ORiN3NullableUInt8Array = 63,

    /// <summary>
    /// 16-bit unsigned integer
    /// </summary>
    ORiN3UInt16 = 70,

    /// <summary>
    /// 16-bit unsigned integer of array type
    /// </summary>
    ORiN3UInt16Array = 71,

    /// <summary>
    /// 16-bit unsigned integer of null-allowed type
    /// </summary>
    ORiN3NullableUInt16 = 72,

    /// <summary>
    /// 16-bit unsigned integer of null-allowed array type
    /// </summary>
    ORiN3NullableUInt16Array = 73,

    /// <summary>
    /// 32-bit unsigned integer
    /// </summary>
    ORiN3UInt32 = 80,

    /// <summary>
    /// 32-bit unsigned integer of array type
    /// </summary>
    ORiN3UInt32Array = 81,

    /// <summary>
    /// 32-bit unsigned integer of null-allowed type
    /// </summary>
    ORiN3NullableUInt32 = 82,

    /// <summary>
    /// 32-bit unsigned integer of null-allowed array type
    /// </summary>
    ORiN3NullableUInt32Array = 83,

    /// <summary>
    /// 64-bit unsigned integer
    /// </summary>
    ORiN3UInt64 = 90,

    /// <summary>
    /// 64-bit unsigned integer of array type
    /// </summary>
    ORiN3UInt64Array = 91,

    /// <summary>
    /// 64-bit unsigned integer of null-allowed type
    /// </summary>
    ORiN3NullableUInt64 = 92,

    /// <summary>
    /// 64-bit unsigned integer of null-allowed array type
    /// </summary>
    ORiN3NullableUInt64Array = 93,

    /// <summary>
    /// Single precision floating point number
    /// </summary>
    ORiN3Float = 100,

    /// <summary>
    /// Single-precision floating-point numbers of array type
    /// </summary>
    ORiN3FloatArray = 101,

    /// <summary>
    /// Single-precision floating-point number of null-allowed type
    /// </summary>
    ORiN3NullableFloat = 102,

    /// <summary>
    /// Single-precision floating-point number of null-tolerant array type
    /// </summary>
    ORiN3NullableFloatArray = 103,

    /// <summary>
    /// Double precision floating point number
    /// </summary>
    ORiN3Double = 110,

    /// <summary>
    /// Double precision floating-point numbers of array type
    /// </summary>
    ORiN3DoubleArray = 111,

    /// <summary>
    /// Double-precision floating-point number of null-allowed type
    /// </summary>
    ORiN3NullableDouble = 112,

    /// <summary>
    /// Double-precision floating-point number of null-tolerant array type
    /// </summary>
    ORiN3NullableDoubleArray = 113,

    /// <summary>
    /// String type
    /// </summary>
    ORiN3String = 120,

    /// <summary>
    /// String of array type
    /// </summary>
    ORiN3StringArray = 121,

    /// <summary>
    /// Date and Time
    /// </summary>
    ORiN3DateTime = 130,

    /// <summary>
    /// Date and time of array type
    /// </summary>
    ORiN3DateTimeArray = 131,

    /// <summary>
    /// null-tolerant date and time
    /// </summary>
    ORiN3NullableDateTime = 132,

    /// <summary>
    /// Date and time of null-allowed array type
    /// </summary>
    ORiN3NullableDateTimeArray = 133,

    /// <summary>
    /// object type
    /// </summary>
    ORiN3Object = 140,
}