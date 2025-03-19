using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (probability >= rnd.Next(0, 101))
                    encoded[i] = 1 - encoded[i];
            }
            return encoded;
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
    }
}
