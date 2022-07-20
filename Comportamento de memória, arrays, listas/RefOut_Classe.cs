
namespace RefOut
{
    internal class Calculadora
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triples(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
