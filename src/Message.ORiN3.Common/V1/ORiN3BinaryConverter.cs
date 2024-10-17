using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Message.ORiN3.Common.V1;

public static class ORiN3BinaryConverter
{
    private enum DataType : byte
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

    private static byte[] ToBinaryInternal(object[] target)
    {
        var objects = new List<byte[]>
        {
            new byte[] { (byte)DataType.ObjectArray },
            ORiN3BitConverter.GetBytes(target.Length)
        };
        for (var i = 0; i < target.Length; ++i)
        {
            objects.Add(ToBinary(target[i]));
        }
        return objects.SelectMany(_ => _).ToArray();
    }

    private static byte[] ToBinaryInternal(bool target)
    {
        var buffer = new byte[2];
        buffer[0] = (byte)DataType.Bool;
        buffer[1] = target ? (byte)1 : (byte)0;
        return buffer;
    }

    private static byte[] ToBinaryInternal(bool[] target)
    {
        var buffer = new byte[target.Length + 5];
        buffer[0] = (byte)DataType.BoolArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            buffer[i + 5] = target[i] ? (byte)1 : (byte)0;
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(bool?[] target)
    {
        var buffer = new byte[target.Length + 5];
        buffer[0] = (byte)DataType.NullableBoolArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
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
        return buffer;
    }

    private static byte[] ToBinaryInternal(byte target)
    {
        var buffer = new byte[2];
        buffer[0] = (byte)DataType.UInt8;
        buffer[1] = target;
        return buffer;
    }

    private static byte[] ToBinaryInternal(byte[] target)
    {
        var buffer = new byte[target.Length + 5];
        buffer[0] = (byte)DataType.UInt8Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            buffer[i + 5] = target[i];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(byte?[] target)
    {
        var buffer = new byte[(target.Length * 2) + 5];
        buffer[0] = (byte)DataType.NullableUInt8Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 2) + 5] = 1;
                buffer[(i * 2) + 6] = temp.Value;
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(sbyte target)
    {
        var buffer = new byte[2];
        buffer[0] = (byte)DataType.Int8;
        buffer[1] = (byte)target;
        return buffer;
    }

    private static byte[] ToBinaryInternal(sbyte[] target)
    {
        var buffer = new byte[target.Length + 5];
        buffer[0] = (byte)DataType.Int8Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            buffer[i + 5] = (byte)target[i];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(sbyte?[] target)
    {
        var buffer = new byte[(target.Length * 2) + 5];
        buffer[0] = (byte)DataType.NullableInt8Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                buffer[(i * 2) + 5] = 1;
                buffer[(i * 2) + 6] = (byte)temp.Value;
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(short target)
    {
        var buffer = new byte[3];
        buffer[0] = (byte)DataType.Int16;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        return buffer;
    }

    private static byte[] ToBinaryInternal(short[] target)
    {
        var buffer = new byte[(target.Length * 2) + 5];
        buffer[0] = (byte)DataType.Int16Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 2) + 5] = temp[0];
            buffer[(i * 2) + 6] = temp[1];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(short?[] target)
    {
        var buffer = new byte[(target.Length * 3) + 5];
        buffer[0] = (byte)DataType.NullableInt16Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 3) + 5] = 1;
                buffer[(i * 3) + 6] = temp2[0];
                buffer[(i * 3) + 7] = temp2[1];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(ushort target)
    {
        var buffer = new byte[3];
        buffer[0] = (byte)DataType.UInt16;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        return buffer;
    }

    private static byte[] ToBinaryInternal(ushort[] target)
    {
        var buffer = new byte[(target.Length * 2) + 5];
        buffer[0] = (byte)DataType.UInt16Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 2) + 5] = temp[0];
            buffer[(i * 2) + 6] = temp[1];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(ushort?[] target)
    {
        var buffer = new byte[(target.Length * 3) + 5];
        buffer[0] = (byte)DataType.NullableUInt16Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 3) + 5] = 1;
                buffer[(i * 3) + 6] = temp2[0];
                buffer[(i * 3) + 7] = temp2[1];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(int target)
    {
        var buffer = new byte[5];
        buffer[0] = (byte)DataType.Int32;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        buffer[3] = temp[2];
        buffer[4] = temp[3];
        return buffer;
    }

    private static byte[] ToBinaryInternal(int[] target)
    {
        var buffer = new byte[(target.Length * 4) + 5];
        buffer[0] = (byte)DataType.Int32Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 4) + 5] = temp[0];
            buffer[(i * 4) + 6] = temp[1];
            buffer[(i * 4) + 7] = temp[2];
            buffer[(i * 4) + 8] = temp[3];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(int?[] target)
    {
        var buffer = new byte[(target.Length * 5) + 5];
        buffer[0] = (byte)DataType.NullableInt32Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 5) + 5] = 1;
                buffer[(i * 5) + 6] = temp2[0];
                buffer[(i * 5) + 7] = temp2[1];
                buffer[(i * 5) + 8] = temp2[2];
                buffer[(i * 5) + 9] = temp2[3];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(uint target)
    {
        var buffer = new byte[5];
        buffer[0] = (byte)DataType.UInt32;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        buffer[3] = temp[2];
        buffer[4] = temp[3];
        return buffer;
    }

    private static byte[] ToBinaryInternal(uint[] target)
    {
        var buffer = new byte[(target.Length * 4) + 5];
        buffer[0] = (byte)DataType.UInt32Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 4) + 5] = temp[0];
            buffer[(i * 4) + 6] = temp[1];
            buffer[(i * 4) + 7] = temp[2];
            buffer[(i * 4) + 8] = temp[3];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(uint?[] target)
    {
        var buffer = new byte[(target.Length * 5) + 5];
        buffer[0] = (byte)DataType.NullableUInt32Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 5) + 5] = 1;
                buffer[(i * 5) + 6] = temp2[0];
                buffer[(i * 5) + 7] = temp2[1];
                buffer[(i * 5) + 8] = temp2[2];
                buffer[(i * 5) + 9] = temp2[3];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(long target)
    {
        var buffer = new byte[9];
        buffer[0] = (byte)DataType.Int64;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        buffer[3] = temp[2];
        buffer[4] = temp[3];
        buffer[5] = temp[4];
        buffer[6] = temp[5];
        buffer[7] = temp[6];
        buffer[8] = temp[7];
        return buffer;
    }

    private static byte[] ToBinaryInternal(long[] target)
    {
        var buffer = new byte[(target.Length * 8) + 5];
        buffer[0] = (byte)DataType.Int64Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 8) + 5] = temp[0];
            buffer[(i * 8) + 6] = temp[1];
            buffer[(i * 8) + 7] = temp[2];
            buffer[(i * 8) + 8] = temp[3];
            buffer[(i * 8) + 9] = temp[4];
            buffer[(i * 8) + 10] = temp[5];
            buffer[(i * 8) + 11] = temp[6];
            buffer[(i * 8) + 12] = temp[7];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(long?[] target)
    {
        var buffer = new byte[(target.Length * 9) + 5];
        buffer[0] = (byte)DataType.NullableInt64Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 9) + 5] = 1;
                buffer[(i * 9) + 6] = temp2[0];
                buffer[(i * 9) + 7] = temp2[1];
                buffer[(i * 9) + 8] = temp2[2];
                buffer[(i * 9) + 9] = temp2[3];
                buffer[(i * 9) + 10] = temp2[4];
                buffer[(i * 9) + 11] = temp2[5];
                buffer[(i * 9) + 12] = temp2[6];
                buffer[(i * 9) + 13] = temp2[7];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(ulong target)
    {
        var buffer = new byte[9];
        buffer[0] = (byte)DataType.UInt64;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        buffer[3] = temp[2];
        buffer[4] = temp[3];
        buffer[5] = temp[4];
        buffer[6] = temp[5];
        buffer[7] = temp[6];
        buffer[8] = temp[7];
        return buffer;
    }

    private static byte[] ToBinaryInternal(ulong[] target)
    {
        var buffer = new byte[(target.Length * 8) + 5];
        buffer[0] = (byte)DataType.UInt64Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 8) + 5] = temp[0];
            buffer[(i * 8) + 6] = temp[1];
            buffer[(i * 8) + 7] = temp[2];
            buffer[(i * 8) + 8] = temp[3];
            buffer[(i * 8) + 9] = temp[4];
            buffer[(i * 8) + 10] = temp[5];
            buffer[(i * 8) + 11] = temp[6];
            buffer[(i * 8) + 12] = temp[7];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(ulong?[] target)
    {
        var buffer = new byte[(target.Length * 9) + 5];
        buffer[0] = (byte)DataType.NullableUInt64Array;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 9) + 5] = 1;
                buffer[(i * 9) + 6] = temp2[0];
                buffer[(i * 9) + 7] = temp2[1];
                buffer[(i * 9) + 8] = temp2[2];
                buffer[(i * 9) + 9] = temp2[3];
                buffer[(i * 9) + 10] = temp2[4];
                buffer[(i * 9) + 11] = temp2[5];
                buffer[(i * 9) + 12] = temp2[6];
                buffer[(i * 9) + 13] = temp2[7];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(float target)
    {
        var buffer = new byte[5];
        buffer[0] = (byte)DataType.Float;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        buffer[3] = temp[2];
        buffer[4] = temp[3];
        return buffer;
    }

    private static byte[] ToBinaryInternal(float[] target)
    {
        var buffer = new byte[(target.Length * 4) + 5];
        buffer[0] = (byte)DataType.FloatArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 4) + 5] = temp[0];
            buffer[(i * 4) + 6] = temp[1];
            buffer[(i * 4) + 7] = temp[2];
            buffer[(i * 4) + 8] = temp[3];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(float?[] target)
    {
        var buffer = new byte[(target.Length * 5) + 5];
        buffer[0] = (byte)DataType.NullableFloatArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 5) + 5] = 1;
                buffer[(i * 5) + 6] = temp2[0];
                buffer[(i * 5) + 7] = temp2[1];
                buffer[(i * 5) + 8] = temp2[2];
                buffer[(i * 5) + 9] = temp2[3];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(double target)
    {
        var buffer = new byte[9];
        buffer[0] = (byte)DataType.Double;
        var temp = ORiN3BitConverter.GetBytes(target);
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        buffer[3] = temp[2];
        buffer[4] = temp[3];
        buffer[5] = temp[4];
        buffer[6] = temp[5];
        buffer[7] = temp[6];
        buffer[8] = temp[7];
        return buffer;
    }

    private static byte[] ToBinaryInternal(double[] target)
    {
        var buffer = new byte[(target.Length * 8) + 5];
        buffer[0] = (byte)DataType.DoubleArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i]);
            buffer[(i * 8) + 5] = temp[0];
            buffer[(i * 8) + 6] = temp[1];
            buffer[(i * 8) + 7] = temp[2];
            buffer[(i * 8) + 8] = temp[3];
            buffer[(i * 8) + 9] = temp[4];
            buffer[(i * 8) + 10] = temp[5];
            buffer[(i * 8) + 11] = temp[6];
            buffer[(i * 8) + 12] = temp[7];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(double?[] target)
    {
        var buffer = new byte[(target.Length * 9) + 5];
        buffer[0] = (byte)DataType.NullableDoubleArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value);
                buffer[(i * 9) + 5] = 1;
                buffer[(i * 9) + 6] = temp2[0];
                buffer[(i * 9) + 7] = temp2[1];
                buffer[(i * 9) + 8] = temp2[2];
                buffer[(i * 9) + 9] = temp2[3];
                buffer[(i * 9) + 10] = temp2[4];
                buffer[(i * 9) + 11] = temp2[5];
                buffer[(i * 9) + 12] = temp2[6];
                buffer[(i * 9) + 13] = temp2[7];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(DateTime target)
    {
        var buffer = new byte[9];
        buffer[0] = (byte)DataType.DateTime;
        var temp = ORiN3BitConverter.GetBytes(target.ToBinary());
        buffer[1] = temp[0];
        buffer[2] = temp[1];
        buffer[3] = temp[2];
        buffer[4] = temp[3];
        buffer[5] = temp[4];
        buffer[6] = temp[5];
        buffer[7] = temp[6];
        buffer[8] = temp[7];
        return buffer;
    }

    private static byte[] ToBinaryInternal(DateTime[] target)
    {
        var buffer = new byte[(target.Length * 8) + 5];
        buffer[0] = (byte)DataType.DateTimeArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = ORiN3BitConverter.GetBytes(target[i].ToBinary());
            buffer[(i * 8) + 5] = temp[0];
            buffer[(i * 8) + 6] = temp[1];
            buffer[(i * 8) + 7] = temp[2];
            buffer[(i * 8) + 8] = temp[3];
            buffer[(i * 8) + 9] = temp[4];
            buffer[(i * 8) + 10] = temp[5];
            buffer[(i * 8) + 11] = temp[6];
            buffer[(i * 8) + 12] = temp[7];
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(DateTime?[] target)
    {
        var buffer = new byte[(target.Length * 9) + 5];
        buffer[0] = (byte)DataType.NullableDateTimeArray;
        var length = ORiN3BitConverter.GetBytes(target.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        for (var i = 0; i < target.Length; ++i)
        {
            var temp = target[i];
            if (temp.HasValue)
            {
                var temp2 = ORiN3BitConverter.GetBytes(temp.Value.ToBinary());
                buffer[(i * 9) + 5] = 1;
                buffer[(i * 9) + 6] = temp2[0];
                buffer[(i * 9) + 7] = temp2[1];
                buffer[(i * 9) + 8] = temp2[2];
                buffer[(i * 9) + 9] = temp2[3];
                buffer[(i * 9) + 10] = temp2[4];
                buffer[(i * 9) + 11] = temp2[5];
                buffer[(i * 9) + 12] = temp2[6];
                buffer[(i * 9) + 13] = temp2[7];
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(string target)
    {
        var temp = Encoding.UTF8.GetBytes(target);
        var buffer = new byte[temp.Length + 5];
        buffer[0] = (byte)DataType.String;
        var length = ORiN3BitConverter.GetBytes(temp.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        temp.CopyTo(buffer, 5);
        return buffer;
    }

    private static byte[] ToBinaryInternal(string[] target)
    {
        var temp = target.Select(_ =>
        {
            if (_ != null)
            {
                return Encoding.UTF8.GetBytes(_);
            }
            return [];
        });
        var count = temp.Count();
        var buffer = new byte[temp.Sum(_ => _.Length) + (count * 5) + 5];
        buffer[0] = (byte)DataType.StringArray;
        var length = ORiN3BitConverter.GetBytes(count);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        var index = 5;
        for (var i = 0; i < target.Length; ++i)
        {
            if (target[i] != null)
            {
                var temp2 = temp.ElementAt(i);
                var length2 = ORiN3BitConverter.GetBytes(temp2.Length);
                buffer[index++] = 1;
                buffer[index++] = length2[0];
                buffer[index++] = length2[1];
                buffer[index++] = length2[2];
                buffer[index++] = length2[3];
                temp2.CopyTo(buffer, index);
                index += temp2.Count();
            }
            else
            {
                index += 5;
            }
        }
        return buffer;
    }

    private static byte[] ToBinaryInternal(IDictionary<string, object?> target)
    {
        var binary = FromDictionaryToBinary(target);
        var buffer = new byte[binary.Length + 5];
        buffer[0] = (byte)DataType.Dictionary;
        var length = ORiN3BitConverter.GetBytes(binary.Length);
        buffer[1] = length[0];
        buffer[2] = length[1];
        buffer[3] = length[2];
        buffer[4] = length[3];
        Array.Copy(binary, 0, buffer, 5, binary.Length);
        return buffer;
    }

    public static byte[] ToBinary(object? target)
    {
        if (target == null)
        {
            return [(byte)DataType.Null];
        }

        var targetType = target.GetType();
        switch (Type.GetTypeCode(targetType))
        {
            case TypeCode.Boolean:
                return ToBinaryInternal((bool)target);
            case TypeCode.Byte:
                return ToBinaryInternal((byte)target);
            case TypeCode.SByte:
                return ToBinaryInternal((sbyte)target);
            case TypeCode.Int16:
                return ToBinaryInternal((short)target);
            case TypeCode.UInt16:
                return ToBinaryInternal((ushort)target);
            case TypeCode.Int32:
                return ToBinaryInternal((int)target);
            case TypeCode.UInt32:
                return ToBinaryInternal((uint)target);
            case TypeCode.Int64:
                return ToBinaryInternal((long)target);
            case TypeCode.UInt64:
                return ToBinaryInternal((ulong)target);
            case TypeCode.Single:
                return ToBinaryInternal((float)target);
            case TypeCode.Double:
                return ToBinaryInternal((double)target);
            case TypeCode.String:
                return ToBinaryInternal((string)target);
            case TypeCode.DateTime:
                return ToBinaryInternal((DateTime)target);
            case TypeCode.Object:
                if (targetType.IsArray)
                {
                    if (targetType == typeof(object[]))
                    {
                        return ToBinaryInternal((object[])target);
                    }
                    else if (targetType == typeof(bool[]))
                    {
                        return ToBinaryInternal((bool[])target);
                    }
                    else if (targetType == typeof(bool?[]))
                    {
                        return ToBinaryInternal((bool?[])target);
                    }
                    else if (targetType == typeof(byte[]))
                    {
                        return ToBinaryInternal((byte[])target);
                    }
                    else if (targetType == typeof(byte?[]))
                    {
                        return ToBinaryInternal((byte?[])target);
                    }
                    else if (targetType == typeof(sbyte[]))
                    {
                        return ToBinaryInternal((sbyte[])target);
                    }
                    else if (targetType == typeof(sbyte?[]))
                    {
                        return ToBinaryInternal((sbyte?[])target);
                    }
                    else if (targetType == typeof(ushort[]))
                    {
                        return ToBinaryInternal((ushort[])target);
                    }
                    else if (targetType == typeof(ushort?[]))
                    {
                        return ToBinaryInternal((ushort?[])target);
                    }
                    else if (targetType == typeof(short[]))
                    {
                        return ToBinaryInternal((short[])target);
                    }
                    else if (targetType == typeof(short?[]))
                    {
                        return ToBinaryInternal((short?[])target);
                    }
                    else if (targetType == typeof(uint[]))
                    {
                        return ToBinaryInternal((uint[])target);
                    }
                    else if (targetType == typeof(uint?[]))
                    {
                        return ToBinaryInternal((uint?[])target);
                    }
                    else if (targetType == typeof(int[]))
                    {
                        return ToBinaryInternal((int[])target);
                    }
                    else if (targetType == typeof(int?[]))
                    {
                        return ToBinaryInternal((int?[])target);
                    }
                    else if (targetType == typeof(ulong[]))
                    {
                        return ToBinaryInternal((ulong[])target);
                    }
                    else if (targetType == typeof(ulong?[]))
                    {
                        return ToBinaryInternal((ulong?[])target);
                    }
                    else if (targetType == typeof(long[]))
                    {
                        return ToBinaryInternal((long[])target);
                    }
                    else if (targetType == typeof(long?[]))
                    {
                        return ToBinaryInternal((long?[])target);
                    }
                    else if (targetType == typeof(float[]))
                    {
                        return ToBinaryInternal((float[])target);
                    }
                    else if (targetType == typeof(float?[]))
                    {
                        return ToBinaryInternal((float?[])target);
                    }
                    else if (targetType == typeof(double[]))
                    {
                        return ToBinaryInternal((double[])target);
                    }
                    else if (targetType == typeof(double?[]))
                    {
                        return ToBinaryInternal((double?[])target);
                    }
                    else if (targetType == typeof(DateTime[]))
                    {
                        return ToBinaryInternal((DateTime[])target);
                    }
                    else if (targetType == typeof(DateTime?[]))
                    {
                        return ToBinaryInternal((DateTime?[])target);
                    }
                    else if (targetType == typeof(string[]))
                    {
                        return ToBinaryInternal((string[])target);
                    }
                }
                else if (target is IDictionary<string, object>)
                {
                    return ToBinaryInternal((IDictionary<string, object?>)target);
                }
                throw new NotSupportedException($"The specified data type is not supported. [Data type={targetType.Name}]");
            default:
                throw new NotSupportedException($"The specified data type is not supported. [Data type={targetType.Name}]");
        }
    }

    public static byte[] FromDictionaryToBinary(IDictionary<string, object?> target)
    {
        var objects = new List<byte[]>
        {
            ORiN3BitConverter.GetBytes(target.Keys.Count)
        };
        foreach (var key in target.Keys)
        {
            var value = target[key];
            objects.Add(ToBinary(key));
            objects.Add(ToBinary(value));
        }
        return objects.SelectMany(_ => _).ToArray();
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

    public static ReadOnlySpan<byte> ToObjectInternal(ReadOnlySpan<byte> bytes, out object? result)
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
                    return bytes[(5 + length)..];
                }
            default:
                throw new NotSupportedException();
        }
    }
}
