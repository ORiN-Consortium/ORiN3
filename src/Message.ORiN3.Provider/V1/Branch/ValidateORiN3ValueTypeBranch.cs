using Design.ORiN3.Common.V1;

namespace Message.ORiN3.Provider.V1.Branch;

public class ValidateORiN3ValueTypeBranch : IValueTypeBranch
{
    public bool IsValid { get; private set; } = false;

    public void CaseOfBool()
    {
        IsValid = true;
    }

    public void CaseOfBoolArray()
    {
        IsValid = true;
    }

    public void CaseOfNullableBool()
    {
        IsValid = true;
    }

    public void CaseOfNullableBoolArray()
    {
        IsValid = true;
    }

    public void CaseOfInt8()
    {
        IsValid = true;
    }

    public void CaseOfInt8Array()
    {
        IsValid = true;
    }

    public void CaseOfNullableUInt8()
    {
        IsValid = true;
    }

    public void CaseOfNullableUInt8Array()
    {
        IsValid = true;
    }

    public void CaseOfUInt16()
    {
        IsValid = true;
    }

    public void CaseOfUInt16Array()
    {
        IsValid = true;
    }
    public void CaseOfNullableUInt16()
    {
        IsValid = true;
    }

    public void CaseOfNullableUInt16Array()
    {
        IsValid = true;
    }

    public void CaseOfUInt32()
    {
        IsValid = true;
    }

    public void CaseOfUInt32Array()
    {
        IsValid = true;
    }

    public void CaseOfNullableUInt32()
    {
        IsValid = true;
    }

    public void CaseOfNullableUInt32Array()
    {
        IsValid = true;
    }

    public void CaseOfUInt64()
    {
        IsValid = true;
    }

    public void CaseOfUInt64Array()
    {
        IsValid = true;
    }

    public void CaseOfNullableUInt64()
    {
        IsValid = true;
    }

    public void CaseOfNullableUInt64Array()
    {
        IsValid = true;
    }

    public void CaseOfUInt8()
    {
        IsValid = true;
    }

    public void CaseOfUInt8Array()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt8()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt8Array()
    {
        IsValid = true;
    }

    public void CaseOfInt16()
    {
        IsValid = true;
    }

    public void CaseOfInt16Array()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt16()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt16Array()
    {
        IsValid = true;
    }

    public void CaseOfInt32()
    {
        IsValid = true;
    }

    public void CaseOfInt32Array()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt32()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt32Array()
    {
        IsValid = true;
    }

    public void CaseOfInt64()
    {
        IsValid = true;
    }

    public void CaseOfInt64Array()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt64()
    {
        IsValid = true;
    }

    public void CaseOfNullableInt64Array()
    {
        IsValid = true;
    }

    public void CaseOfFloat()
    {
        IsValid = true;
    }

    public void CaseOfFloatArray()
    {
        IsValid = true;
    }

    public void CaseOfNullableFloat()
    {
        IsValid = true;
    }

    public void CaseOfNullableFloatArray()
    {
        IsValid = true;
    }

    public void CaseOfDouble()
    {
        IsValid = true;
    }

    public void CaseOfDoubleArray()
    {
        IsValid = true;
    }

    public void CaseOfNullableDouble()
    {
        IsValid = true;
    }

    public void CaseOfNullableDoubleArray()
    {
        IsValid = true;
    }

    public void CaseOfString()
    {
        IsValid = true;
    }

    public void CaseOfStringArray()
    {
        IsValid = true;
    }

    public void CaseOfDateTime()
    {
        IsValid = true;
    }

    public void CaseOfDateTimeArray()
    {
        IsValid = true;
    }

    public void CaseOfNullableDateTime()
    {
        IsValid = true;
    }

    public void CaseOfNullableDateTimeArray()
    {
        IsValid = true;
    }

    public void CaseOfObject()
    {
        IsValid = true;
    }

    public void CaseOfError()
    {
        //Errorの場合のみfalse
        IsValid = false;
    }
}
