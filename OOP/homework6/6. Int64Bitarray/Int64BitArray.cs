using System;
using System.Collections;
using System.Collections.Generic;

//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

public class Int64BitArray : IEnumerable<int>
{
    public ulong Bits { get; private set; }

    public Int64BitArray(ulong bits)
    {
        this.Bits = bits;
    }

    public int this[int index]
    {
        get
        {
            if (index >= 0 || index < 64)
            {
                if ((Bits & ((ulong)1 << index)) == 0)
                    return 0;

                return 1;
            }

            throw new IndexOutOfRangeException("Index must be in range [0, 63].");
        }
    }

    public override bool Equals(object param)
    {
        Int64BitArray bitArray64 = param as Int64BitArray;
        if (bitArray64 == null)
            return false;

        return this.Bits == bitArray64.Bits;
    }

    public override int GetHashCode()
    {
        return this.Bits.GetHashCode();
    }

    public static bool operator ==(Int64BitArray bitArray64A, Int64BitArray bitArray64B)
    {
        return Int64BitArray.Equals(bitArray64A, bitArray64B);
    }

    public static bool operator !=(Int64BitArray bitArray64A, Int64BitArray bitArray64B)
    {
        return !Int64BitArray.Equals(bitArray64A, bitArray64B);
    }

    public override string ToString()
    {
        return Convert.ToString((long)this.Bits, 2).PadLeft(64, '0');
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 63; i >= 0; i--)
            yield return this[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (this as IEnumerable<int>).GetEnumerator();
    }
}