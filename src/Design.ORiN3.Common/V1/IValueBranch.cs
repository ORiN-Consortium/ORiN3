namespace Design.ORiN3.Common.V1;

/// <summary>
/// Value branch
/// </summary>
public interface IValueBranch
{
    /// <summary>
    /// For bool
    /// </summary>
    void CaseOfBool();

    /// <summary>
    /// For bool array
    /// </summary>
    void CaseOfBoolArray();

    /// <summary>
    ///  For nullable bool array
    /// </summary>
    void CaseOfNullableBoolArray();

    /// <summary>
    /// For int8
    /// </summary>
    void CaseOfInt8();

    /// <summary>
    /// For int8 array
    /// </summary>
    void CaseOfInt8Array();

    /// <summary>
    /// For nullable int8 array
    /// </summary>
    void CaseOfNullableInt8Array();

    /// <summary>
    /// For int16
    /// </summary>
    void CaseOfInt16();

    /// <summary>
    /// For int16 array
    /// </summary>
    void CaseOfInt16Array();

    /// <summary>
    /// For nullable int16 array
    /// </summary>
    void CaseOfNullableInt16Array();

    /// <summary>
    /// For int32
    /// </summary>
    void CaseOfInt32();

    /// <summary>
    /// For int32 array
    /// </summary>
    void CaseOfInt32Array();

    /// <summary>
    /// For nullable int32 array
    /// </summary>
    void CaseOfNullableInt32Array();

    /// <summary>
    /// For int64
    /// </summary>
    void CaseOfInt64();

    /// <summary>
    /// For inta64 array
    /// </summary>
    void CaseOfInt64Array();

    /// <summary>
    /// For nullable int64 array
    /// </summary>
    void CaseOfNullableInt64Array();

    /// <summary>
    /// For unsigned int8
    /// </summary>
    void CaseOfUInt8();

    /// <summary>
    /// For unsigned int8 array
    /// </summary>
    void CaseOfUInt8Array();

    /// <summary>
    /// For nullable unsigned int8 array
    /// </summary>
    void CaseOfNullableUInt8Array();

    /// <summary>
    /// For unsigned int16
    /// </summary>
    void CaseOfUInt16();

    /// <summary>
    /// For unsigned int16 array
    /// </summary>
    void CaseOfUInt16Array();

    /// <summary>
    /// For nullable unsigned int16 array
    /// </summary>
    void CaseOfNullableUInt16Array();

    /// <summary>
    /// For unsigned int32
    /// </summary>
    void CaseOfUInt32();

    /// <summary>
    /// For unsigend int32 array
    /// </summary>
    void CaseOfUInt32Array();

    /// <summary>
    /// For nullable unsigned int32 array
    /// </summary>
    void CaseOfNullableUInt32Array();

    /// <summary>
    /// For unsigned int64
    /// </summary>
    void CaseOfUInt64();

    /// <summary>
    /// For unsigned int64 array
    /// </summary>
    void CaseOfUInt64Array();

    /// <summary>
    /// For nullable unsigned int64 array
    /// </summary>
    void CaseOfNullableUInt64Array();

    /// <summary>
    /// For float
    /// </summary>
    void CaseOfFloat();

    /// <summary>
    /// For float array
    /// </summary>
    void CaseOfFloatArray();

    /// <summary>
    /// For nullable float array
    /// </summary>
    void CaseOfNullableFloatArray();

    /// <summary>
    /// For double
    /// </summary>
    void CaseOfDouble();

    /// <summary>
    /// For double array
    /// </summary>
    void CaseOfDoubleArray();

    /// <summary>
    /// For nullable double array
    /// </summary>
    void CaseOfNullableDoubleArray();

    /// <summary>
    /// For string
    /// </summary>
    void CaseOfString();

    /// <summary>
    /// For string array
    /// </summary>
    void CaseOfStringArray();

    /// <summary>
    /// For dateTime
    /// </summary>
    void CaseOfDateTime();

    /// <summary>
    /// For dateTime array
    /// </summary>
    void CaseOfDateTimeArray();

    /// <summary>
    /// For nullable dateTime array
    /// </summary>
    void CaseOfNullableDateTimeArray();

    /// <summary>
    /// For null
    /// </summary>
    void CaseOfNull();

    /// <summary>
    /// For object array
    /// </summary>
    void CaseOfObject();
}
