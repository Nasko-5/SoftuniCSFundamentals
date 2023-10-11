using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Intrinsics;

namespace _9.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string v1 = Console.ReadLine();
            string v2 = Console.ReadLine();

            object result = MaxSelector(type, v1, v2);

            Console.WriteLine(result);
        }

        private static object MaxSelector(string type, string v1, string v2)
        {
            switch (type)
            {
                case "int":
                    return GetMax(int.Parse(v1), int.Parse(v2));
                    break;
                case "char":
                    return GetMax(char.Parse(v1), char.Parse(v2));
                    break;
                case "string":
                    return GetMax(v1, v2);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }


        private static int GetMax(int v1, int v2)
        {
            if (v1 > v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        private static char GetMax(char v1, char v2)
        {
            if (v1 > v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        private static string GetMax(string v1, string v2)
        {
            string biggest = "";
            string smallest = "";
            
            if (v1.Length > v2.Length)
            {
                for (int i = 0; i < v2.Length; i++)
                {
                    if (v1[i] > v2[i])
                    {
                        biggest = v1;
                        smallest = v2;
                    }
                    else
                    {
                        biggest = v1;
                        smallest = v2;
                    }
                }
            }
            else 
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    if (v1[i] > v2[i])
                    {
                        biggest = v1;
                        smallest = v2;
                    }
                    else
                    {
                        biggest = v1;
                        smallest = v2;
                    }
                }
            }

            return smallest;
        }
    }
}