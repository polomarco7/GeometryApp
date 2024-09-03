
using GeometryLibrary;

namespace GeometryApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Rect rext = new Rect(2, 2);
        Console.WriteLine(rext.GetArea());
    }
}
