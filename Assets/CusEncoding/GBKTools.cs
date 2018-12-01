using System;
using System.Collections.Generic;
using System.Text;

namespace CusEncoding
{
    internal class CacheBuffer<T>
    {
        private int _cacheByteSize;
        private T[] _cacheByte = new T[32];

        public T[] GetCache(int size)
        {
            if (size > _cacheByteSize)
            {
                _cacheByteSize = size;
                _cacheByte = new T[_cacheByteSize];
            }
            Array.Clear(_cacheByte, 0, _cacheByteSize);
            return _cacheByte;
        }
    }

    internal class GBKTools
    {
        private static readonly CacheBuffer<byte> CacheByte = new CacheBuffer<byte>();
        private static readonly CacheBuffer<char> CacheChar = new CacheBuffer<char>();

        /// <summary>
        /// gbk->unicode->utf8
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="byteIndex"></param>
        /// <param name="length"></param>
        /// <param name="isCache">true返回缓冲</param>
        /// <returns></returns>
        public static void GbkConvertToUtf16(out char[] outChars, out int outCount, byte[] byteArray, int byteIndex, int length, bool isCache = false)
        {
            if (length <= 0)
            {
                outChars = null;
                outCount = 0;
                return;
            }
            // GBK To Unicode
            int bytesCount;
            byte[] bytes;
            int charsCount;
            char[] chars;

            GbkToUnicode(out bytes, out bytesCount, byteArray, byteIndex, length);

            if (isCache)
            {
                charsCount = Encoding.Unicode.GetCharCount(bytes, 0, bytesCount);
                chars = CacheChar.GetCache(charsCount);
                Encoding.Unicode.GetChars(bytes, 0, bytesCount, chars, 0);
            }
            else
            {
                chars = Encoding.Unicode.GetChars(bytes, 0, bytesCount);
                charsCount = chars.Length;
            }
            outCount = charsCount;
            outChars = chars;
        }

        /// <summary>
        /// gbk->unicode->utf8
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="byteIndex"></param>
        /// <param name="length"></param>
        /// <param name="isCache">true返回缓冲</param>
        /// <returns></returns>
        public static string GbkConvertToUtf16_String(byte[] byteArray, int byteIndex, int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }
            // GBK To Unicode
            int bytesCount;
            byte[] bytes;
            GbkToUnicode(out bytes, out bytesCount, byteArray, byteIndex, length);
            return Encoding.Unicode.GetString(bytes, 0, bytesCount);
        }

        /// <summary>
        /// unicode->gbk
        /// </summary>
        /// <param name="charArray"></param>
        /// <param name="charIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] Utf16ConvertToGbk(char[] charArray, int charIndex, int length)
        {
            int bytesCount;
            byte[] bytes;

            // dstEncoding.GetBytes(
            bytesCount = Encoding.Unicode.GetByteCount(charArray, charIndex, length);
            bytes = CacheByte.GetCache(bytesCount);
            Encoding.Unicode.GetBytes(charArray, charIndex, length, bytes, 0);

            byte[] netData = UnicodeToGbk(bytes, 0, bytesCount);
            return netData;
        }

        public static void GbkToUnicode(out byte[] outBuffer, out int outSize, byte[] buffer, int index, int length)
        {
            int unSize = GbkToUnicodeSize(buffer, index, length);
            outBuffer = CacheByte.GetCache(unSize);
            int sizeIndex = 0;
            int i = index;
            length += index;
            while (i < length)
            {
                if (buffer[i] < 128)
                {
                    outBuffer[sizeIndex++] = buffer[i];
                    outBuffer[sizeIndex++] = 0x00;
                    i++;
                }
                else
                {
                    int value = buffer[i];
                    value = ((value << 8) & 0xff00) | (buffer[i + 1] & 0xff);
                    value = DichotomySearch(GBKToUnicodeTable.ucs_MappingTable, 0, (ushort)(GBKToUnicodeTable.ucs_MappingTable.Length / 2), (ushort)value);
                    int temp = (value >> 8) & 0xff;
                    value = value & 0x00ff;
                    outBuffer[sizeIndex++] = (byte)value;
                    outBuffer[sizeIndex++] = (byte)temp;
                    i += 2;
                }
            }
            outSize = sizeIndex;
        }

        public static int GbkToUnicodeSize(byte[] buffer, int index, int length)
        {
            int retSize = 0;
            int i = index;
            length += index;
            while (i < length)
            {
                if (buffer[i] < 128)
                {
                    retSize += 2;
                    i++;
                }
                else
                {
                    retSize += 2;
                    i += 2;
                }
            }
            return retSize;
        }

        private static int UnicodeToGbkSize(byte[] buffer, int index, int length)
        {
            int retSize = 0;
            int i = index;
            length += index;
            while (i < length)
            {
                if (buffer[i] < 128 && buffer[i + 1] == 0)
                {
                    retSize += 1;
                }
                else
                {
                    retSize += 2;
                }
                i += 2;
            }
            return retSize;
        }

        public static int UnicodeToGbkSize(char[] buffer, int index, int length)
        {
            int retSize = 0;
            int i = index;
            length += index;
            while (i < length)
            {
                if (buffer[i] < 128)
                {
                    retSize += 1;
                }
                else
                {
                    retSize += 2;
                }
                ++i;
            }
            return retSize;
        }

        public static byte[] UnicodeToGbk(byte[] buffer, int index, int length)
        {
            byte[] outBuffer = new byte[UnicodeToGbkSize(buffer, index, length)];
            int outSize = 0;
            int i = index;
            length += index;
            while (i < length)
            {
                if (buffer[i] < 128 && buffer[i + 1] == 0)
                {
                    outBuffer[outSize++] = buffer[i];
                }
                else
                {
                    int value = buffer[i] | ((buffer[i + 1] << 8) & 0xff00);
                    value = DichotomySearch(UnicodeToGBKTable.ucs_MappingTable, 0,
                       (ushort)(UnicodeToGBKTable.ucs_MappingTable.Length / 2), (ushort)value);

                    byte value1 = (byte)((0xff00 & value) >> 8);
                    byte value0 = (byte)(0x00ff & value);
                    outBuffer[outSize++] = value1;
                    outBuffer[outSize++] = value0;
                }
                ++i;
                ++i;
            }
            return outBuffer;
        }

        private static ushort DichotomySearch(
            ushort[,] mappingTable,
            ushort borderBegin,
            ushort borderEnd,
            ushort code,
            byte comCol = 0,
            byte returnCol = 1)
        {
            int n = (borderEnd + borderBegin) / 2;

            if (mappingTable[n, comCol] == code)
            {
                return mappingTable[n, returnCol];
            }
            else if (borderEnd - borderBegin > 0x40)
            {
                if (mappingTable[n, comCol] > code)
                {
                    return DichotomySearch(mappingTable, borderBegin, (ushort)n, code, comCol, returnCol);
                }
                else
                {
                    return DichotomySearch(mappingTable, (ushort)n, borderEnd, code, comCol, returnCol);
                }
            }
            else
            {
                int i;
                if (mappingTable[n, comCol] > code)
                {
                    for (i = n; i >= borderBegin; i--)
                    {
                        if (mappingTable[i, comCol] == code)
                        {
                            return mappingTable[i, returnCol];
                        }
                    }
                }
                else
                {
                    try
                    {
                        for (i = n; i <= borderEnd; i++)
                        {
                            if (mappingTable[i, comCol] == code)
                            {
                                return mappingTable[i, returnCol];
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //越界不处理
                    }
                }
                return mappingTable[0, returnCol];/* not found */
            }
        }

        public static byte[] UnToGBK(byte[] buffer, int index, int length)
        {
            List<byte> data = new List<byte>();
            int i = index;
            length += index;
            while (i < length)
            {
                if (buffer[i] < 128 && buffer[i + 1] == 0)
                {
                    data.Add(buffer[i]);
                }
                else
                {
                    int value = buffer[i] | ((buffer[i + 1] << 8) & 0xff00);
                    byte[] bt = System.BitConverter.GetBytes(GBKTools.DichotomySearch(UnicodeToGBKTable.ucs_MappingTable, 0, (ushort)(UnicodeToGBKTable.ucs_MappingTable.Length / 2), (ushort)value));
                    data.Add(bt[1]);
                    data.Add(bt[0]);
                }
                ++i;
                ++i;
            }
            return data.ToArray();
        }

        public static byte[] GBKToUn(byte[] buffer, int index, int length)
        {
            List<byte> data = new List<byte>();
            int i = index;
            length += index;
            while (i < length)
            {
                if (buffer[i] < 128)
                {
                    data.Add(buffer[i]);
                    data.Add(0x00);
                    i++;
                }
                else
                {
                    int value = buffer[i];
                    value = ((value << 8) & 0xff00) | (buffer[i + 1] & 0xff);
                    value = GBKTools.DichotomySearch(GBKToUnicodeTable.ucs_MappingTable, 0, (ushort)(GBKToUnicodeTable.ucs_MappingTable.Length / 2), (ushort)value);
                    int temp = (value >> 8) & 0xff;
                    value = value & 0x00ff;
                    data.Add((byte)value);
                    data.Add((byte)temp);
                    i += 2;
                }
            }
            return data.ToArray();
        }
    }
}
