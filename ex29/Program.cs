using System;
using System.Runtime.CompilerServices;

namespace Ex29_18_Yamamasita
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("直方体の表面積");
            Console.WriteLine("表面積" + Box.GetSurface(InputFloat(" 幅"), InputFloat(" 高さ"), InputFloat(" 奥行")));
            Console.WriteLine("直方体体積");
            Console.WriteLine("体積" + Box.GetVolume(InputFloat(" 幅"), InputFloat(" 高さ"), InputFloat(" 奥行")));

            Console.WriteLine("\n円柱の表面積");
            Console.WriteLine("表面積" + Cylinder.GetSurface(InputFloat(" 底面の半径"), InputFloat(" 高さ")));
            Console.WriteLine("円柱の体積");
            Console.WriteLine("体積" + Cylinder.GetVolume(InputFloat(" 底面の半径"), InputFloat(" 高さ")));

            Console.WriteLine("\n球の表面積");
            Console.WriteLine("表面積" + Sphere.GetSurface(InputFloat(" 半径")));
            Console.WriteLine("球の体積");
            Console.WriteLine("体積" + Sphere.GetVolume(InputFloat("半径")));

            Console.WriteLine("\n三角柱の表面積");
            Console.WriteLine("体積" + TraiangularPrism.GetSurface(InputFloat(" 底面の辺"), InputFloat(" 底面の高さ"), InputFloat("高さ")));
            Console.WriteLine("三角柱の体積");
            Console.WriteLine("体積" + TraiangularPrism.GetVolume(InputFloat(" 底面の辺"), InputFloat(" 底面の高さ"), InputFloat(" 高さ")));
        }

        static float InputFloat(string outputstring)
        {
            float input;
            while (true)
            {
                Console.WriteLine(outputstring);
                if(float.TryParse(Console.ReadLine(), out input) )
                {
                    return input;
                }
            }
        }
    }

    static class Box
    {
        public static float GetSurface(float width, float height, float depth)
        {
            return (width * height + depth * height + width * depth) * 2;
        }
        public static float GetVolume(float width, float height, float depth)
        {
            return width * height * depth;
        }
    }

    static class Cylinder
    {
        public static float GetSurface(float bottom, float height)
        {
            return bottom * 2.0f * MathF.PI * height * bottom * MathF.PI * 2.0f;
        }
        public static float GetVolume(float bottom, float height)
        {
            return bottom * bottom * MathF.PI * height;
        }
    }

    static class Sphere
    {
        public static float GetSurface(float radius)
        {
            return 4.0f * MathF.PI * radius * radius;
        }
        public static float GetVolume(float radius)
        {
            return (4.0f / 3.0f) * MathF.PI * radius * radius * radius;
        }
    }

    static class TraiangularPrism
    {
        public static double GetSurface(float bottom, float bottomheight, float height)
        {
            return bottom * bottomheight + (bottomheight + bottom + MathF.Sqrt(bottom * bottom + bottomheight * bottomheight)) * height;
        }
        public static float GetVolume(float bottom, float bottomheight, float height)
        {
            return bottom * bottomheight / 2.0f * height;
        }
    }
}