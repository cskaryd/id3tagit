namespace ID3_TagIT
{
    using System;
    using System.IO;

    public class CRC32
    {
        private const int BUFFER_SIZE = 0x400;
        private int[] crc32Table;

        public CRC32()
        {
            int num2 = -306674912;
            this.crc32Table = new int[0x101];
            int index = 0;
            do
            {
                int num = index;
                int num4 = 8;
                do
                {
                    if ((num & 1) > 0)
                    {
                        num = (int) ((((long) (num & -2)) / 2L) & 0x7fffffffL);
                        num ^= num2;
                    }
                    else
                    {
                        num = (int) ((((long) (num & -2)) / 2L) & 0x7fffffffL);
                    }
                    num4 += -1;
                }
                while (num4 >= 1);
                this.crc32Table[index] = num;
                index++;
            }
            while (index <= 0xff);
        }

        public int CRC32(int intCRC32, ref byte[] bArrayIn, long Length)
        {
            int num2 = -1;
            int num6 = (int) Length;
            for (int i = 0; i <= num6; i++)
            {
                int index = (num2 & 0xff) ^ bArrayIn[i];
                num2 = ((num2 & -256) / 0x100) & 0xffffff;
                num2 ^= this.crc32Table[index];
            }
            return ~num2;
        }

        public int CRC32(int intCRC32, ref FileStream objFileStream, int vintStart, int Length)
        {
            int num2 = -1;
            objFileStream.Seek((long) vintStart, SeekOrigin.Begin);
            int num6 = Length - 1;
            for (int i = 0; i <= num6; i++)
            {
                int index = (num2 & 0xff) ^ Convert.ToByte(objFileStream.ReadByte());
                num2 = ((num2 & -256) / 0x100) & 0xffffff;
                num2 ^= this.crc32Table[index];
            }
            return ~num2;
        }
    }
}

