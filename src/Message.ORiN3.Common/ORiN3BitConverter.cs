using System;
using System.Diagnostics.Contracts;

namespace Message.ORiN3.Common;

public static class ORiN3BitConverter
{
    internal static readonly bool IsLittleEndian = BitConverter.IsLittleEndian;

    public static unsafe int FillBytes(Span<byte> target, int startIndex, short value)
    {
        if (startIndex < 0)
        {
            throw new ArgumentException($"The argument cannot be a negative value. [startIndex={startIndex}]", nameof(startIndex));
        }
        if (target.Length - sizeof(short) < startIndex)
        {
            throw new ArgumentException($"The value of the start index is too large. [target.Length={target.Length}, startIndex={startIndex}]", nameof(startIndex));
        }

        fixed (byte* unsafePointer = &target[startIndex])
        {
            *(short*)unsafePointer = IsLittleEndian ? value : (short)(value << 8 | (0xFF00 & value) >> 8);
        }
        return sizeof(short);
    }

    public static unsafe int FillBytes(Span<byte> target, int startIndex, ushort value)
    {
        return FillBytes(target, startIndex, (short)value);
    }

    public static int FillBytes(Span<byte> target, int value)
    {
        return FillBytes(target, 0, value);
    }

    public static unsafe int FillBytes(Span<byte> target, int startIndex, int value)
    {
        if (startIndex < 0)
        {
            throw new ArgumentException($"The argument cannot be a negative value. [startIndex={startIndex}]", nameof(startIndex));
        }
        if (target.Length - sizeof(int) < startIndex)
        {
            throw new ArgumentException($"The value of the start index is too large. [target.Length={target.Length}, startIndex={startIndex}]", nameof(startIndex));
        }

        fixed (byte* unsafePointer = &target[startIndex])
        {
            *(int*)unsafePointer = IsLittleEndian
                ? value
                : (int)((uint)(value << 24) | (0x0000FF00 & (uint)value) << 8
                    | (0x00FF0000 & (uint)value) >> 8 | (0xFF000000 & (uint)value) >> 24);
        }
        return sizeof(int);
    }

    public static unsafe int FillBytes(Span<byte> target, int startIndex, uint value)
    {
        return FillBytes(target, startIndex, (int)value);
    }

    public static unsafe int FillBytes(Span<byte> target, int startIndex, long value)
    {
        if (startIndex < 0)
        {
            throw new ArgumentException($"The argument cannot be a negative value. [startIndex={startIndex}]", nameof(startIndex));
        }
        if (target.Length - sizeof(long) < startIndex)
        {
            throw new ArgumentException($"The value of the start index is too large. [target.Length={target.Length}, startIndex={startIndex}]", nameof(startIndex));
        }

        fixed (byte* unsafePointer = &target[startIndex])
        {
            *(long*)unsafePointer = IsLittleEndian
                ? value
                : (long)((ulong)(value << 56) | (0x000000000000FF00 & (ulong)value) << 40
                    | (0x0000000000FF0000 & (ulong)value) << 24 | (0x00000000FF000000 & (ulong)value) << 8
                    | (0x000000FF00000000 & (ulong)value) >> 8 | (0x0000FF0000000000 & (ulong)value) >> 24
                    | (0x00FF000000000000 & (ulong)value) >> 40 | (0xFF00000000000000 & (ulong)value) >> 56);
        }
        return sizeof(long);
    }

    public static unsafe int FillBytes(Span<byte> target, int startIndex, ulong value)
    {
        return FillBytes(target, startIndex, (long)value);
    }

    public static unsafe int FillBytes(Span<byte> target, int startIndex, float value)
    {
        return FillBytes(target, startIndex, *(int*)&value);
    }

    public static unsafe int FillBytes(Span<byte> target, int startIndex, double value)
    {
        return FillBytes(target, startIndex, *(long*)&value);
    }

    public static short ToInt16(ReadOnlySpan<byte> target)
    {
        return ToInt16(target, 0);
    }

    public static unsafe short ToInt16(ReadOnlySpan<byte> target, int startIndex)
    {
        if (startIndex < 0)
        {
            throw new ArgumentException($"The argument cannot be a negative value. [startIndex={startIndex}]", nameof(startIndex));
        }
        if (target.Length - sizeof(short) < startIndex)
        {
            throw new ArgumentException($"The value of the start index is too large. [target.Length={target.Length}, startIndex={startIndex}]", nameof(startIndex));
        }

        fixed (byte* unsafePointer = &target[startIndex])
        {
            return IsLittleEndian
                ? (short)(*unsafePointer | *(unsafePointer + 1) << 8)
                : (short)(*unsafePointer << 8 | *(unsafePointer + 1));
        }
    }

    public static ushort ToUInt16(ReadOnlySpan<byte> target)
    {
        return ToUInt16(target, 0);
    }

    public static ushort ToUInt16(ReadOnlySpan<byte> target, int startIndex)
    {
        return (ushort)ToInt16(target, startIndex);
    }

    public static int ToInt32(ReadOnlySpan<byte> target)
    {
        return ToInt32(target, 0);
    }

    public static unsafe int ToInt32(ReadOnlySpan<byte> target, int startIndex)
    {
        if (startIndex < 0)
        {
            throw new ArgumentException($"The argument cannot be a negative value. [startIndex={startIndex}]", nameof(startIndex));
        }
        if (target.Length - sizeof(int) < startIndex)
        {
            throw new ArgumentException($"The value of the start index is too large. [target.Length={target.Length}, startIndex={startIndex}]", nameof(startIndex));
        }

        fixed (byte* unsafePointer = &target[startIndex])
        {
            return IsLittleEndian
                ? *unsafePointer | *(unsafePointer + 1) << 8
                    | *(unsafePointer + 2) << 16 | *(unsafePointer + 3) << 24
                : *unsafePointer << 24 | *(unsafePointer + 1) << 16
                    | *(unsafePointer + 2) << 8 | *(unsafePointer + 3);
        }
    }

    public static uint ToUInt32(ReadOnlySpan<byte> target)
    {
        return ToUInt32(target, 0);
    }

    public static uint ToUInt32(ReadOnlySpan<byte> target, int startIndex)
    {
        return (uint)ToInt32(target, startIndex);
    }

    public static long ToInt64(ReadOnlySpan<byte> target)
    {
        return ToInt64(target, 0);
    }

    public static unsafe long ToInt64(ReadOnlySpan<byte> target, int startIndex)
    {
        if (startIndex < 0)
        {
            throw new ArgumentException($"The argument cannot be a negative value. [startIndex={startIndex}]", nameof(startIndex));
        }
        if (target.Length - sizeof(long) < startIndex)
        {
            throw new ArgumentException($"The value of the start index is too large. [target.Length={target.Length}, startIndex={startIndex}]", nameof(startIndex));
        }

        fixed (byte* unsafePointer = &target[startIndex])
        {
            if (IsLittleEndian)
            {
                var i1 = *(unsafePointer + 3) << 24 | *(unsafePointer + 2) << 16
                    | *(unsafePointer + 1) << 8 | *unsafePointer;
                var i2 = *(unsafePointer + 7) << 24 | *(unsafePointer + 6) << 16
                    | *(unsafePointer + 5) << 8 | *(unsafePointer + 4);
                return (uint)i1 | (long)i2 << 32;
            }
            else
            {
                var i1 = *unsafePointer << 24 | *(unsafePointer + 1) << 16
                    | *(unsafePointer + 2) << 8 | *(unsafePointer + 3);
                var i2 = *(unsafePointer + 4) << 24 | *(unsafePointer + 5) << 16
                    | *(unsafePointer + 6) << 8 | *(unsafePointer + 7);
                return (uint)i2 | (long)i1 << 32;
            }
        }
    }

    public static ulong ToUInt64(ReadOnlySpan<byte> target)
    {
        return ToUInt64(target, 0);
    }

    public static ulong ToUInt64(ReadOnlySpan<byte> target, int startIndex)
    {
        return (ulong)ToInt64(target, startIndex);
    }

    public static unsafe float ToSingle(ReadOnlySpan<byte> target)
    {
        return ToSingle(target, 0);
    }

    public static unsafe float ToSingle(ReadOnlySpan<byte> target, int startIndex)
    {
        var val = ToInt32(target, startIndex);
        return *(float*)&val;
    }

    public static unsafe double ToDouble(ReadOnlySpan<byte> target)
    {
        return ToDouble(target, 0);
    }

    public static unsafe double ToDouble(ReadOnlySpan<byte> target, int startIndex)
    {
        var val = ToInt64(target, startIndex);
        return *(double*)&val;
    }
}
