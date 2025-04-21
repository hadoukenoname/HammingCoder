using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовая
{
    public static class HammingCoder
    {
        //Atributes
        private static int[,] _G = new int[4, 7]
        {
            { 1, 0, 0, 0, 1, 1, 1 },
            { 0, 1, 0, 0, 1, 1, 0 },
            { 0, 0, 1, 0, 1, 0, 1 },
            { 0, 0, 0, 1, 0, 1, 1 }
        };

        private static int[,] _H = new int[3, 7]
        {
            { 1, 1, 1, 0, 1, 0, 0 },
            { 1, 1, 0, 1, 0, 1, 0 },
            { 1, 0, 1, 1, 0, 0, 1 }
        };

        private static int[,] _G1 = new int[11, 15]
        {
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0 },
            { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1 },
            { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1 }
        };

        private static int[,] _H1 = new int[4, 15]
        {
            { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
            { 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 0 },
            { 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 0 },
            { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1 }
        };


        //Methods

        public enum HammingCodeType
        {
            Code7_4,
            Code15_11
        }

        private static void PrintMatr(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintG(int index)
        {
            PrintMatr(index == 0 ? _G : _G1);
        }

        public static void PrintH(int index)
        {
            PrintMatr(index == 0 ? _H : _H1);
        }

        private static void Error()
        {
            Console.WriteLine("Error");
        }

        public static int[] Encode(int[] message)
        {
            int[,] G;
            if (message.Length == _G.GetLength(0))
                G = _G;
            else if (message.Length == _G1.GetLength(0))
                G = _G1;
            else
            {
                Error();
                return new int[0];
            }

            int[] encoded = new int[G.GetLength(1)];
            for (int j = 0; j < G.GetLength(1); j++)
            {
                int sum = 0;
                for (int i = 0; i < G.GetLength(0); i++)
                {
                    sum += message[i] * G[i, j];
                }
                encoded[j] = sum % 2;
            }
            return encoded;
        }

        public static int[] CorrectErrors(int[] received)
        {
            int[,] H;
            if (received.Length == _H.GetLength(1))
                H = _H;
            else if (received.Length == _H1.GetLength(1))
                H = _H1;
            else
            {
                Error();
                return new int[0];
            }

            int[] corrected = (int[])received.Clone();
            int[] syndrome = new int[H.GetLength(0)];

            for (int i = 0; i < H.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < H.GetLength(1); j++)
                {
                    sum += H[i, j] * corrected[j];
                }
                syndrome[i] = sum % 2;
            }

            if (syndrome.All(s => s == 0))
                return corrected;

            int errorPosition = -1;
            for (int j = 0; j < H.GetLength(1); j++)
            {
                bool match = true;
                for (int i = 0; i < H.GetLength(0); i++)
                {
                    if (H[i, j] != syndrome[i])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    errorPosition = j;
                    break;
                }
            }

            if (errorPosition != -1)
                corrected[errorPosition] ^= 1;

            return corrected;
        }


        public static int[] Decode(int[] received)
        {
            int[] corrected = CorrectErrors(received);
            if (corrected.Length == 0)
            {
                Error();
                return corrected;
            }

            int messageLength = corrected.Length == _G.GetLength(1) ? 4 : 11;
            return corrected.Take(messageLength).ToArray();
        }

        public static int[] ConvertToArray(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '0' && input[i] != '1')
                {
                    Error();
                    return new int[0];
                }
            }

            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = input[i] - 48;
            }

            return result;
        }

        public static int[] MakeErros(int probability, int[] encoded)
        {
            Random rnd = new Random();
            for (int i = 0; i < encoded.Length; i++)
            {
                if (probability > rnd.Next(0, 101))
                    encoded[i] = 1 - encoded[i];
            }
            return encoded;
        }

        public static int[,] MakeErrors(int probability, int[,] encodedMatrix)
        {
            Random rnd = new Random();

            for (int i = 0; i < encodedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < encodedMatrix.GetLength(1); j++)
                {
                    if (probability > rnd.Next(0, 101))
                        encodedMatrix[i, j] = 1 - encodedMatrix[i, j];
                }
            }
            return encodedMatrix;
        }

        public static List<int> Missmatch(int[] received, int[] encoded)
        {
            List<int> result = new List<int>();

            if (received.Length != encoded.Length)
                return result;

            else
            {
                for (int i = 0; i < received.Length; i++)
                {
                    if (received[i] != encoded[i])
                        result.Add(i);
                }
            }
            return result;
        }

        public static int[,] GetG(int index)
        {
            return index == 0 ? _G : _G1;
        }
        public static int[,] GetH(int index)
        {
            return index == 0 ? _H : _H1;
        }

        public static int[] ConvertTextToBinaryArray(string text)
        {           
                        
            List<int> binaryList = new List<int>();
            foreach (char c in text)
            {                
                int charCode = c;                
                for (int i = 7; i >= 0; i--) 
                {
                    int bit = (charCode >> i) & 1; 
                    binaryList.Add(bit); 
                }
            }            
            return binaryList.ToArray();
        }

        public static string ConvertBinaryArrayToText(int[] binaryData)
        {
            if (binaryData.Length % 8 != 0)
                throw new ArgumentException("Длина массива должна быть кратна 8.");

            System.Text.StringBuilder text = new System.Text.StringBuilder();

            for (int i = 0; i < binaryData.Length; i += 8)
            {
                
                int byteValue = 0;
                for (int j = 0; j < 8; j++)
                {
                    byteValue = (byteValue << 1) | binaryData[i + j];
                }

                
                char c = (char)byteValue;
                text.Append(c);
            }

            return text.ToString();
        }

        private static int[,] ParseBinary(int[] binaryData, HammingCodeType codetype)
        {
            int blockLength = codetype == HammingCodeType.Code7_4 ? 4 : 11;

            if (binaryData.Length % blockLength != 0)
                throw new ArgumentException("Длина массива должна быть кратна длине блока.");
            
            int numPackets = binaryData.Length / blockLength;

            int[,] result = new int[numPackets, blockLength];

            for (int i = 0; i < numPackets; i++)
            {
                for (int j = 0; j < blockLength; j++)
                {
                    result[i, j] = binaryData[i * blockLength + j];
                }
            }
            return result;
        }

        private static int[,] EncodeParsed(int[,] parsedBinaryData, HammingCodeType codeType)
        {
            
            int inputBlockSize = codeType == HammingCodeType.Code7_4 ? 4 : 11;
            int outputBlockSize = codeType == HammingCodeType.Code7_4 ? 7 : 15;

            
            int numBlocks = parsedBinaryData.GetLength(0);
            int blockSize = parsedBinaryData.GetLength(1);

            if (blockSize != inputBlockSize)
                throw new ArgumentException($"Размер блока должен быть равен {inputBlockSize} для выбранного кода.");

            
            int[,] result = new int[numBlocks, outputBlockSize];

            
            for (int i = 0; i < numBlocks; i++)
            {
                
                int[] block = new int[inputBlockSize];
                for (int j = 0; j < inputBlockSize; j++)
                {
                    block[j] = parsedBinaryData[i, j];
                }

                int[] encodedBlock = Encode(block);                    

                
                for (int j = 0; j < outputBlockSize; j++)
                {
                    result[i, j] = encodedBlock[j];
                }
            }

            return result;
        }

        public static int[,] DecodeParsed(int[,] encodedBlocks, HammingCodeType codeType)
        {
            
            int inputBlockSize = codeType == HammingCodeType.Code7_4 ? 7 : 15;
            int outputBlockSize = codeType == HammingCodeType.Code7_4 ? 4 : 11;

            
            int numBlocks = encodedBlocks.GetLength(0);
            int blockSize = encodedBlocks.GetLength(1);

            if (blockSize != inputBlockSize)
                throw new ArgumentException($"Размер блока должен быть равен {inputBlockSize} для выбранного кода.");

            
            int[,] result = new int[numBlocks, outputBlockSize];

          
            for (int i = 0; i < numBlocks; i++)
            {
                
                int[] block = new int[inputBlockSize];
                for (int j = 0; j < inputBlockSize; j++)
                {
                    block[j] = encodedBlocks[i, j];
                }
                
                int[] decodedBlock = Decode(block);                   

               
                for (int j = 0; j < outputBlockSize; j++)
                {
                    result[i, j] = decodedBlock[j];
                }
            }

            return result;
        }

        public static int[] MatrixToBinary(int[,] matrix)
        {
            List<int> binary = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    binary.Add(matrix[i, j]);
                }
            }

            return binary.ToArray();
        }

        public static int[] PadBinaryArray(int[] binaryArray, HammingCodeType codetype)
        {
            int blockSize = codetype == HammingCodeType.Code7_4 ? 4 : 11;

            int paddingLength = (blockSize - binaryArray.Length % blockSize) % blockSize;
            
            int[] paddedArray = new int[binaryArray.Length + paddingLength];
            Array.Copy(binaryArray, paddedArray, binaryArray.Length);

            return paddedArray;
        }
        public static int[] RemovePadding(int[] paddedArray, int originalLength)
        {
            
            int[] originalArray = new int[originalLength];            
            Array.Copy(paddedArray, originalArray, originalLength);

            return originalArray;
        }

        public static int[,] EncodeText(string text, HammingCodeType codetype)
        {
            int[] binary = ConvertTextToBinaryArray(text); 

            int[] padded = PadBinaryArray(binary, codetype);
            int[,] parsed = ParseBinary(padded, codetype);
            int[,] encoded = EncodeParsed(parsed, codetype);

            return encoded;
        }

        public static int[,] ConvertTextToMatrix(string text)
        {
            // Разделяем текст на строки (блоки) по символу табуляции
            string[] lines = text.Split('\t');

            // Определяем количество строк (количество блоков)
            int rows = lines.Length - 1; // Последний элемент может быть пустым

            // Проверяем, что все блоки имеют одинаковую длину
            if (rows == 0 || lines[0].Length == 0)
            {
                throw new ArgumentException("Текст не содержит данных для восстановления матрицы.");
            }

            // Определяем количество столбцов (длина одного блока)
            int cols = lines[0].Length;

            // Создаем двумерный массив заданного размера
            int[,] matrix = new int[rows, cols];

            // Проходим по каждой строке и заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                string line = lines[i];

                // Проверяем, что длина строки соответствует количеству столбцов
                if (line.Length != cols)
                {
                    throw new ArgumentException($"Длина строки {i + 1} не соответствует ожидаемой длине.");
                }

                for (int j = 0; j < cols; j++)
                {
                    // Преобразуем каждый символ строки в целое число
                    matrix[i, j] = int.Parse(line[j].ToString());
                }
            }

            return matrix;
        }
    }
}
