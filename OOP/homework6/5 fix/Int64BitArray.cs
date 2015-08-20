using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Int64BitArray : IEnumerable<int>
    {
        public ulong Bits { get; private set; }


        public Int64BitArray(ulong bits = 0)
        {
            this.Bits = bits;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }
                else
                {
                    ulong mask = (ulong)1 << index;

                    // Check the bit at position index and return it
                    if ((Bits & mask) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("Value must be 0 or 1.");
                }

                ulong mask = (ulong)1 << index;
                if (value == 1)
                {
                    this.Bits = this.Bits | mask;
                }
                else
                {
                    this.Bits = this.Bits & ~mask;
                }
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Int64BitArray bitArray64 = obj as Int64BitArray;
            if (bitArray64 == null)
            {
                return false;
            }

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
            /*StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                sb.AppendFormat("[{0}] = {1} \n", i, this[i]);
            }
            return sb.ToString();*/
            return Convert.ToString((long)this.Bits, 2).PadLeft(64, '0');
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<int>).GetEnumerator();
        }


    }