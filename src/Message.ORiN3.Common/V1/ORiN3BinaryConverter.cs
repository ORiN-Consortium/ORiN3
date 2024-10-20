using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Message.ORiN3.Common.V1;

public static class ORiN3BinaryConverter
{
    internal enum DataType : byte
    {
        Null,
        ObjectArray,
        Bool,
        BoolArray,
        NullableBool,
        NullableBoolArray,
        UInt8,
        UInt8Array,
        NullableUInt8,
        NullableUInt8Array,
        UInt16,
        UInt16Array,
        NullableUInt16,
        NullableUInt16Array,
        UInt32,
        UInt32Array,
        NullableUInt32,
        NullableUInt32Array,
        UInt64,
        UInt64Array,
        NullableUInt64,
        NullableUInt64Array,
        Int8,
        Int8Array,
        NullableInt8,
        NullableInt8Array,
        Int16,
        Int16Array,
        NullableInt16,
        NullableInt16Array,
        Int32,
        Int32Array,
        NullableInt32,
        NullableInt32Array,
        Int64,
        Int64Array,
        NullableInt64,
        NullableInt64Array,
        Float,
        FloatArray,
        NullableFloat,
        NullableFloatArray,
        Double,
        DoubleArray,
        NullableDouble,
        NullableDoubleArray,
        String,
        StringArray,
        DateTime,
        DateTimeArray,
        NullableDateTime,
        NullableDateTimeArray,
        Dictionary,
    }

    private static Span<byte> FillBytes(bool target, Span<byte> buffer)
    {
        Debug.Assert(2 <= buffer.Length);
        buffer[0] = (byte)DataType.Bool;
        buffer[1] = target ? (byte)1 : (byte)0;
        return buffer[2..];
    }

    private static Span<byte> FillBytes(bool[] target, Span<byte> buffer)
    {
        Debug.Assert(target.Length + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.BoolArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            buffer[i + 5] = target[i] ? (byte)1 : (byte)0;
        }
        return buffer[(target.Length + 5)..];
    }

    private static Span<byte> FillBytes(bool?[] target, Span<byte> buffer)
    {
        Debug.Assert(target.Length + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableBoolArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[i + 5] = temp.Value ? (byte)1 : (byte)0;
            }
            else
            {
                buffer[i + 5] = 2;
            }
        }
        return buffer[(target.Length + 5)..];
    }

    private static Span<byte> FillBytes(byte target, Span<byte> buffer)
    {
        Debug.Assert(2 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt8;
        buffer[1] = target;
        return buffer[2..];
    }

    private static Span<byte> FillBytes(byte[] target, Span<byte> buffer)
    {
        Debug.Assert(target.Length + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt8Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            buffer[i + 5] = target[i];
        }
        return buffer[(target.Length + 5)..];
    }

    private static Span<byte> FillBytes(byte?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 2) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableUInt8Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 2) + 5] = 1;
                buffer[(i * 2) + 6] = temp.Value;
            }
        }
        return buffer[((target.Length * 2) + 5)..];
    }

    private static Span<byte> FillBytes(sbyte target, Span<byte> buffer)
    {
        Debug.Assert(2 <= buffer.Length);
        buffer[0] = (byte)DataType.Int8;
        buffer[1] = (byte)target;
        return buffer[2..];
    }

    private static Span<byte> FillBytes(sbyte[] target, Span<byte> buffer)
    {
        Debug.Assert(target.Length + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.Int8Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            buffer[i + 5] = (byte)target[i];
        }
        return buffer[(target.Length + 5)..];
    }

    private static Span<byte> FillBytes(sbyte?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 2) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableInt8Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 2) + 5] = 1;
                buffer[(i * 2) + 6] = (byte)temp.Value;
            }
        }
        return buffer[((target.Length * 2) + 5)..];
    }

    private static Span<byte> FillBytes(short target, Span<byte> buffer)
    {
        Debug.Assert(3 <= buffer.Length);
        buffer[0] = (byte)DataType.Int16;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[3..];
    }

    private static Span<byte> FillBytes(short[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 2) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.Int16Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 2), target[i]);
        }
        return buffer[((target.Length * 2) + 5)..];
    }

    private static Span<byte> FillBytes(short?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 3) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableInt16Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 3) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 3) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 3) + 5)..];
    }

    private static Span<byte> FillBytes(ushort target, Span<byte> buffer)
    {
        Debug.Assert(3 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt16;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[3..];
    }

    private static Span<byte> FillBytes(ushort[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 2) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt16Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 2), target[i]);
        }
        return buffer[((target.Length * 2) + 5)..];
    }

    private static Span<byte> FillBytes(ushort?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 3) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableUInt16Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 3) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 3) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 3) + 5)..];
    }

    private static Span<byte> FillBytes(int target, Span<byte> buffer)
    {
        Debug.Assert(5 <= buffer.Length);
        buffer[0] = (byte)DataType.Int32;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[5..];
    }

    private static Span<byte> FillBytes(int[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 4) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.Int32Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 4), target[i]);
        }
        return buffer[((target.Length * 4) + 5)..];
    }

    private static Span<byte> FillBytes(int?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 5) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableInt32Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 5) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 5) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 5) + 5)..];
    }

    private static Span<byte> FillBytes(uint target, Span<byte> buffer)
    {
        Debug.Assert(5 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt32;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[5..];
    }

    private static Span<byte> FillBytes(uint[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 4) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt32Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 4), target[i]);
        }
        return buffer[((target.Length * 4) + 5)..];
    }

    private static Span<byte> FillBytes(uint?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 5) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableUInt32Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 5) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 5) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 5) + 5)..];
    }

    private static Span<byte> FillBytes(long target, Span<byte> buffer)
    {
        Debug.Assert(9 <= buffer.Length);
        buffer[0] = (byte)DataType.Int64;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[9..];
    }

    private static Span<byte> FillBytes(long[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 8) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.Int64Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 8), target[i]);
        }
        return buffer[((target.Length * 8) + 5)..];
    }

    private static Span<byte> FillBytes(long?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 9) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableInt64Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 9) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 9) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 9) + 5)..];
    }

    private static Span<byte> FillBytes(ulong target, Span<byte> buffer)
    {
        Debug.Assert(9 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt64;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[9..];
    }

    private static Span<byte> FillBytes(ulong[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 8) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.UInt64Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 8), target[i]);
        }
        return buffer[((target.Length * 8) + 5)..];
    }

    private static Span<byte> FillBytes(ulong?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 9) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableUInt64Array;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 9) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 9) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 9) + 5)..];
    }

    private static Span<byte> FillBytes(float target, Span<byte> buffer)
    {
        Debug.Assert(5 <= buffer.Length);
        buffer[0] = (byte)DataType.Float;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[5..];
    }

    private static Span<byte> FillBytes(float[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 4) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.FloatArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 4), target[i]);
        }
        return buffer[((target.Length * 4) + 5)..];
    }

    private static Span<byte> FillBytes(float?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 5) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableFloatArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 5) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 5) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 5) + 5)..];
    }

    private static Span<byte> FillBytes(double target, Span<byte> buffer)
    {
        Debug.Assert(9 <= buffer.Length);
        buffer[0] = (byte)DataType.Double;
        ORiN3BitConverter.FillBytes(buffer, 1, target);
        return buffer[9..];
    }

    private static Span<byte> FillBytes(double[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 8) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.DoubleArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 8), target[i]);
        }
        return buffer[((target.Length * 8) + 5)..];
    }

    private static Span<byte> FillBytes(double?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 9) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableDoubleArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 9) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 9) + 1, temp.Value);
            }
        }
        return buffer[((target.Length * 9) + 5)..];
    }

    private static Span<byte> FillBytes(DateTime target, Span<byte> buffer)
    {
        Debug.Assert(9 <= buffer.Length);
        buffer[0] = (byte)DataType.DateTime;
        ORiN3BitConverter.FillBytes(buffer, 1, target.ToBinary());
        return buffer[9..];
    }

    private static Span<byte> FillBytes(DateTime[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 8) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.DateTimeArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            ORiN3BitConverter.FillBytes(buffer, 5 + (i * 8), target[i].ToBinary());
        }
        return buffer[((target.Length * 8) + 5)..];
    }

    private static Span<byte> FillBytes(DateTime?[] target, Span<byte> buffer)
    {
        Debug.Assert((target.Length * 9) + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.NullableDateTimeArray;
        ORiN3BitConverter.FillBytes(buffer, 1, target.Length);
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 9) + 5] = 1;
                ORiN3BitConverter.FillBytes(buffer, 5 + (i * 9) + 1, temp.Value.ToBinary());
            }
        }
        return buffer[((target.Length * 9) + 5)..];
    }

    private static Span<byte> FillBytes(string target, Span<byte> buffer)
    {
        var length = Encoding.UTF8.GetByteCount(target);
        Debug.Assert(length + 5 <= buffer.Length);
        buffer[0] = (byte)DataType.String;
        ORiN3BitConverter.FillBytes(buffer, 1, length);
        Encoding.UTF8.GetBytes(target, buffer[5..]);
        return buffer[(length + 5)..];
    }

    private static Span<byte> FillBytes(string[] target, Span<byte> buffer)
    {
        var count = target.Length;
        var totalLength = target.Sum(_ => _ == null ? 0 : Encoding.UTF8.GetByteCount(_)) + (count * 5) + 5;
        Debug.Assert(totalLength <= buffer.Length);
        var index = 0;
        buffer[index++] = (byte)DataType.StringArray;
        index += ORiN3BitConverter.FillBytes(buffer, index, count);
        for (var i = 0; i < count; ++i)
        {
            if (target[i] != null)
            {
                var temp = target[i];
                buffer[index++] = 1;
                index += ORiN3BitConverter.FillBytes(buffer, index, Encoding.UTF8.GetByteCount(temp));
                index += Encoding.UTF8.GetBytes(temp, buffer[index..]);
            }
            else
            {
                index += 5;
            }
        }
        return buffer[totalLength..];
    }

    private static Span<byte> FillBytes(IDictionary<string, object?> target, Span<byte> buffer)
    {
        var index = 0;
        buffer[index++] = (byte)DataType.Dictionary;
        var lengthBuffer = buffer[index..];
        index += 4;
        index += ORiN3BitConverter.FillBytes(buffer[index..], target.Keys.Count);
        buffer = buffer[index..];
        foreach (var key in target.Keys)
        {
            var value = target[key];
            buffer = FillBytes(key, buffer);
            buffer = FillBytes(value, buffer);
        }

        ORiN3BitConverter.FillBytes(lengthBuffer, GetIndexDifference(lengthBuffer[4..], buffer));
        return buffer;
    }

    private static unsafe int GetIndexDifference(Span<byte> first, Span<byte> second)
    {
        Debug.Assert(!first.IsEmpty);

        // If span2 is empty, it's considered to be pointing at the end of span1.
        // Therefore, the difference is the entire length of span1.
        if (second.IsEmpty)
        {
            return first.Length;
        }

        fixed (byte* p1 = &first.GetPinnableReference())
        fixed (byte* p2 = &second.GetPinnableReference())
        {
            return (int)(p2 - p1) + 1;
        }
    }

    private static Span<byte> FillBytes(object[] target, Span<byte> buffer)
    {
        var index = 0;
        buffer[index++] = (byte)DataType.ObjectArray;
        index += ORiN3BitConverter.FillBytes(buffer[index..], target.Length);
        buffer = buffer[index..];
        for (var i = 0; i < target.Length; ++i)
        {
            buffer = FillBytes(target[i], buffer);
        }
        return buffer;
    }

    internal static int CalcBinarySize(object? target)
    {
        if (target == null)
        {
            return 1;
        }

        var targetType = target.GetType();
        switch (Type.GetTypeCode(targetType))
        {
            case TypeCode.Boolean:
            case TypeCode.Byte:
            case TypeCode.SByte:
                return 2;
            case TypeCode.Int16:
            case TypeCode.UInt16:
                return 3;
            case TypeCode.Int32:
            case TypeCode.UInt32:
            case TypeCode.Single:
                return 5;
            case TypeCode.Int64:
            case TypeCode.UInt64:
            case TypeCode.Double:
            case TypeCode.DateTime:
                return 9;
            case TypeCode.String:
                return Encoding.UTF8.GetByteCount((string)target) + 5;
            case TypeCode.Object:
                if (targetType.IsArray)
                {
                    if (targetType == typeof(object[]))
                    {
                        return ((object[])target).Sum(CalcBinarySize) + 5;
                    }
                    else if ((targetType == typeof(bool[])) || (targetType == typeof(bool?[])) || (targetType == typeof(byte[])) || (targetType == typeof(sbyte[])))
                    {
                        return ((Array)target).Length + 5;
                    }
                    else if ((targetType == typeof(byte?[])) || (targetType == typeof(sbyte?[])) || (targetType == typeof(ushort[])) || (targetType == typeof(short[])))
                    {
                        return (((Array)target).Length * 2) + 5;
                    }
                    else if ((targetType == typeof(ushort?[])) || (targetType == typeof(short?[])))
                    {
                        return (((Array)target).Length * 3) + 5;
                    }
                    else if ((targetType == typeof(uint[])) || (targetType == typeof(int[])) || (targetType == typeof(float[])))
                    {
                        return (((Array)target).Length * 4) + 5;
                    }
                    else if ((targetType == typeof(uint?[])) || (targetType == typeof(int?[])) || (targetType == typeof(float?[])))
                    {
                        return (((Array)target).Length * 5) + 5;
                    }
                    else if ((targetType == typeof(ulong[])) || (targetType == typeof(long[])) || (targetType == typeof(double[])) || (targetType == typeof(DateTime[])))
                    {
                        return (((Array)target).Length * 8) + 5;
                    }
                    else if ((targetType == typeof(ulong?[])) || (targetType == typeof(long?[])) || (targetType == typeof(double?[])) || (targetType == typeof(DateTime?[])))
                    {
                        return (((Array)target).Length * 9) + 5;
                    }
                    else if (targetType == typeof(string[]))
                    {
                        return ((string[])target).Sum(_ => _ == null ? 0 : Encoding.UTF8.GetByteCount(_)) + (((string[])target).Length * 5) + 5;
                    }
                }
                else if (target is IDictionary<string, object> dictionary)
                {
                    return dictionary.Sum(_ => CalcBinarySize(_.Key) + CalcBinarySize(_.Value)) + 4 + 5;
                }
                throw new NotSupportedException($"The specified data type is not supported. [Data type={targetType.Name}]");
            default:
                throw new NotSupportedException($"The specified data type is not supported. [Data type={targetType.Name}]");
        }
    }

    internal static Span<byte> FillBytes(object? target, Span<byte> buffer)
    {
        if (target == null)
        {
            buffer[0] = (byte)DataType.Null;
            return buffer[1..];
        }

        var targetType = target.GetType();
        switch (Type.GetTypeCode(targetType))
        {
            case TypeCode.Boolean:
                return FillBytes((bool)target, buffer);
            case TypeCode.Byte:
                return FillBytes((byte)target, buffer);
            case TypeCode.SByte:
                return FillBytes((sbyte)target, buffer);
            case TypeCode.Int16:
                return FillBytes((short)target, buffer);
            case TypeCode.UInt16:
                return FillBytes((ushort)target, buffer);
            case TypeCode.Int32:
                return FillBytes((int)target, buffer);
            case TypeCode.UInt32:
                return FillBytes((uint)target, buffer);
            case TypeCode.Int64:
                return FillBytes((long)target, buffer);
            case TypeCode.UInt64:
                return FillBytes((ulong)target, buffer);
            case TypeCode.Single:
                return FillBytes((float)target, buffer);
            case TypeCode.Double:
                return FillBytes((double)target, buffer);
            case TypeCode.String:
                return FillBytes((string)target, buffer);
            case TypeCode.DateTime:
                return FillBytes((DateTime)target, buffer);
            case TypeCode.Object:
                if (targetType.IsArray)
                {
                    if (targetType == typeof(object[]))
                    {
                        return FillBytes((object[])target, buffer);
                    }
                    else if (targetType == typeof(bool[]))
                    {
                        return FillBytes((bool[])target, buffer);
                    }
                    else if (targetType == typeof(bool?[]))
                    {
                        return FillBytes((bool?[])target, buffer);
                    }
                    else if (targetType == typeof(byte[]))
                    {
                        return FillBytes((byte[])target, buffer);
                    }
                    else if (targetType == typeof(byte?[]))
                    {
                        return FillBytes((byte?[])target, buffer);
                    }
                    else if (targetType == typeof(sbyte[]))
                    {
                        return FillBytes((sbyte[])target, buffer);
                    }
                    else if (targetType == typeof(sbyte?[]))
                    {
                        return FillBytes((sbyte?[])target, buffer);
                    }
                    else if (targetType == typeof(ushort[]))
                    {
                        return FillBytes((ushort[])target, buffer);
                    }
                    else if (targetType == typeof(ushort?[]))
                    {
                        return FillBytes((ushort?[])target, buffer);
                    }
                    else if (targetType == typeof(short[]))
                    {
                        return FillBytes((short[])target, buffer);
                    }
                    else if (targetType == typeof(short?[]))
                    {
                        return FillBytes((short?[])target, buffer);
                    }
                    else if (targetType == typeof(uint[]))
                    {
                        return FillBytes((uint[])target, buffer);
                    }
                    else if (targetType == typeof(uint?[]))
                    {
                        return FillBytes((uint?[])target, buffer);
                    }
                    else if (targetType == typeof(int[]))
                    {
                        return FillBytes((int[])target, buffer);
                    }
                    else if (targetType == typeof(int?[]))
                    {
                        return FillBytes((int?[])target, buffer);
                    }
                    else if (targetType == typeof(ulong[]))
                    {
                        return FillBytes((ulong[])target, buffer);
                    }
                    else if (targetType == typeof(ulong?[]))
                    {
                        return FillBytes((ulong?[])target, buffer);
                    }
                    else if (targetType == typeof(long[]))
                    {
                        return FillBytes((long[])target, buffer);
                    }
                    else if (targetType == typeof(long?[]))
                    {
                        return FillBytes((long?[])target, buffer);
                    }
                    else if (targetType == typeof(float[]))
                    {
                        return FillBytes((float[])target, buffer);
                    }
                    else if (targetType == typeof(float?[]))
                    {
                        return FillBytes((float?[])target, buffer);
                    }
                    else if (targetType == typeof(double[]))
                    {
                        return FillBytes((double[])target, buffer);
                    }
                    else if (targetType == typeof(double?[]))
                    {
                        return FillBytes((double?[])target, buffer);
                    }
                    else if (targetType == typeof(DateTime[]))
                    {
                        return FillBytes((DateTime[])target, buffer);
                    }
                    else if (targetType == typeof(DateTime?[]))
                    {
                        return FillBytes((DateTime?[])target, buffer);
                    }
                    else if (targetType == typeof(string[]))
                    {
                        return FillBytes((string[])target, buffer);
                    }
                }
                else if (target is IDictionary<string, object>)
                {
                    return FillBytes((IDictionary<string, object?>)target, buffer);
                }
                throw new NotSupportedException($"The specified data type is not supported. [Data type={targetType.Name}]");
            default:
                throw new NotSupportedException($"The specified data type is not supported. [Data type={targetType.Name}]");
        }
    }

    public static byte[] ToBinary(object? target)
    {
        var buffer = new byte[CalcBinarySize(target)];
        FillBytes(target, buffer);
        return buffer;
    }

    public static byte[] FromDictionaryToBinary(IDictionary<string, object?> target)
    {
        var buffer = new byte[target.Sum(_ => CalcBinarySize(_.Key) + CalcBinarySize(_.Value)) + 4];
        ORiN3BitConverter.FillBytes(buffer, target.Keys.Count);
        var temp = buffer.AsSpan()[4..];
        foreach (var key in target.Keys)
        {
            var value = target[key];
            temp = FillBytes(key, temp);
            temp = FillBytes(value, temp);
        }
        return buffer;
    }

    public static Dictionary<string, object?> ToDictionary(ReadOnlySpan<byte> bytes)
    {
        var count = ORiN3BitConverter.ToInt32(bytes);
        bytes = bytes[4..];
        var result = new Dictionary<string, object?>();
        for (var i = 0; i < count; ++i)
        {
            bytes = ToObjectInternal(bytes, out var key);
            bytes = ToObjectInternal(bytes, out var value);
            if (key is null)
            {
                throw new InvalidOperationException();
            }
            else if (key is not string)
            {
                throw new InvalidOperationException($"Key must be string. [Actual={key.GetType()}]");
            }
            result.Add((string)key, value);
        }
        return result;
    }

    public static object? ToObject(ReadOnlySpan<byte> bytes)
    {
        ToObjectInternal(bytes, out var result);
        return result;
    }

    internal static ReadOnlySpan<byte> ToObjectInternal(ReadOnlySpan<byte> bytes, out object? result)
    {
        switch ((DataType)bytes[0])
        {
            case DataType.Null:
                result = null;
                return bytes[1..];
            case DataType.ObjectArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new object?[length];
                    bytes = bytes[5..];
                    for (var i = 0; i < length; ++i)
                    {
                        bytes = ToObjectInternal(bytes, out var result2);
                        temp[i] = result2;
                    }
                    result = temp;
                    return bytes;
                }
            case DataType.Bool:
                result = bytes[1] == 1;
                return bytes[2..];
            case DataType.BoolArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new bool[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = bytes[i + 5] == 1;
                    }
                    result = temp;
                    return bytes[(length + 5)..];
                }
            case DataType.NullableBoolArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new bool?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = bytes[i + 5] == 1 ? true : bytes[i + 5] == 0 ? false : null;
                    }
                    result = temp;
                    return bytes[(length + 5)..];
                }
            case DataType.UInt8:
                result = bytes[1];
                return bytes[2..];
            case DataType.UInt8Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new byte[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = bytes[i + 5];
                    }
                    result = temp;
                    return bytes[(length + 5)..];
                }
            case DataType.NullableUInt8Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new byte?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 2) + 5] == 1)
                        {
                            temp[i] = bytes[(i * 2) + 6];
                        }
                    }
                    result = temp;
                    return bytes[(length * 2 + 5)..];
                }
            case DataType.Int8:
                result = (sbyte)bytes[1];
                return bytes[2..];
            case DataType.Int8Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new sbyte[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = (sbyte)bytes[i + 5];
                    }
                    result = temp;
                    return bytes[(length + 5)..];
                }
            case DataType.NullableInt8Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new sbyte?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 2) + 5] == 1)
                        {
                            temp[i] = (sbyte)bytes[(i * 2) + 6];
                        }
                    }
                    result = temp;
                    return bytes[(length * 2 + 5)..];
                }
            case DataType.UInt16:
                result = ORiN3BitConverter.ToUInt16(bytes[1..]);
                return bytes[3..];
            case DataType.UInt16Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new ushort[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToUInt16(bytes[(i * 2 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 2 + 5)..];
                }
            case DataType.NullableUInt16Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new ushort?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 3) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToUInt16(bytes[(i * 3 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 3 + 5)..];
                }
            case DataType.Int16:
                result = ORiN3BitConverter.ToInt16(bytes[1..]);
                return bytes[3..];
            case DataType.Int16Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new short[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToInt16(bytes[(i * 2 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 2 + 5)..];
                }
            case DataType.NullableInt16Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new short?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 3) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToInt16(bytes[(i * 3 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 3 + 5)..];
                }
            case DataType.UInt32:
                result = ORiN3BitConverter.ToUInt32(bytes[1..]);
                return bytes[5..];
            case DataType.UInt32Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new uint[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToUInt32(bytes[(i * 4 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 4 + 5)..];
                }
            case DataType.NullableUInt32Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new uint?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 5) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToUInt32(bytes[(i * 5 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 5 + 5)..];
                }
            case DataType.Int32:
                result = ORiN3BitConverter.ToInt32(bytes[1..]);
                return bytes[5..];
            case DataType.Int32Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new int[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToInt32(bytes[(i * 4 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 4 + 5)..];
                }
            case DataType.NullableInt32Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new int?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 5) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToInt32(bytes[(i * 5 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 5 + 5)..];
                }
            case DataType.UInt64:
                result = ORiN3BitConverter.ToUInt64(bytes[1..]);
                return bytes[9..];
            case DataType.UInt64Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new ulong[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToUInt64(bytes[(i * 8 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 8 + 5)..];
                }
            case DataType.NullableUInt64Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new ulong?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 9) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToUInt64(bytes[(i * 9 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 9 + 5)..];
                }
            case DataType.Int64:
                result = ORiN3BitConverter.ToInt64(bytes[1..]);
                return bytes[9..];
            case DataType.Int64Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new long[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToInt64(bytes[(i * 8 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 8 + 5)..];
                }
            case DataType.NullableInt64Array:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new long?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 9) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToInt64(bytes[(i * 9 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 9 + 5)..];
                }
            case DataType.Float:
                result = ORiN3BitConverter.ToSingle(bytes[1..]);
                return bytes[5..];
            case DataType.FloatArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new float[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToSingle(bytes[(i * 4 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 4 + 5)..];
                }
            case DataType.NullableFloatArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new float?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 5) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToSingle(bytes[(i * 5 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 5 + 5)..];
                }
            case DataType.Double:
                result = ORiN3BitConverter.ToDouble(bytes[1..]);
                return bytes[9..];
            case DataType.DoubleArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new double[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = ORiN3BitConverter.ToDouble(bytes[(i * 8 + 5)..]);
                    }
                    result = temp;
                    return bytes[(length * 8 + 5)..];
                }
            case DataType.NullableDoubleArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new double?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 9) + 5] == 1)
                        {
                            temp[i] = ORiN3BitConverter.ToDouble(bytes[(i * 9 + 6)..]);
                        }
                    }
                    result = temp;
                    return bytes[(length * 9 + 5)..];
                }
            case DataType.DateTime:
                result = DateTime.FromBinary(ORiN3BitConverter.ToInt64(bytes[1..]));
                return bytes[9..];
            case DataType.DateTimeArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new DateTime[length];
                    for (var i = 0; i < length; ++i)
                    {
                        temp[i] = DateTime.FromBinary(ORiN3BitConverter.ToInt64(bytes[(i * 8 + 5)..]));
                    }
                    result = temp;
                    return bytes[(length * 8 + 5)..];
                }
            case DataType.NullableDateTimeArray:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new DateTime?[length];
                    for (var i = 0; i < length; ++i)
                    {
                        if (bytes[(i * 9) + 5] == 1)
                        {
                            temp[i] = DateTime.FromBinary(ORiN3BitConverter.ToInt64(bytes[(i * 9 + 6)..]));
                        }
                    }
                    result = temp;
                    return bytes[(length * 9 + 5)..];
                }
            case DataType.String:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    result = Encoding.UTF8.GetString(bytes[5..(5 + length)]);
                    return bytes[(5 + length)..];
                }
            case DataType.StringArray:
                {
                    var count = ORiN3BitConverter.ToInt32(bytes[1..]);
                    var temp = new string[count];
                    bytes = bytes[5..];
                    for (var i = 0; i < count; ++i)
                    {
                        if (bytes[0] == 1)
                        {
                            var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                            temp[i] = Encoding.UTF8.GetString(bytes[5..(5 + length)]);
                            bytes = bytes[(5 + length)..];
                        }
                        else
                        {
                            bytes = bytes[5..];
                        }
                    }
                    result = temp;
                    return bytes;
                }
            case DataType.Dictionary:
                {
                    var length = ORiN3BitConverter.ToInt32(bytes[1..]);
                    result = ToDictionary(bytes[5..]);
                    return bytes[(5 + length - 1)..];
                }
            default:
                throw new NotSupportedException();
        }
    }
}
