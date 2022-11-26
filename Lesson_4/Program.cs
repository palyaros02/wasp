// namespace Lesson_4;
//
// internal static class Program
// {
//     static void Main(string[] args)
//     {
//         Triangle triangle1 = new Triangle(3, 4, 5);
//         triangle1.Print();
//         IsoscelesTriangle triangle2 = new IsoscelesTriangle(3, 4, 5);
//         triangle2.Print();
//             
//         Shape shape1 = triangle1;
//         shape1.Print();
//         Shape shape2 = triangle2;
//         shape2.Print();
//
//         List<Shape> shapes = new List<Shape>()
//         {
//             new Square(4),
//             new Triangle(3, 4, 5)
//         };
//         shapes.Add(new Circle(5));
//         shapes.Add(new IsoscelesTriangle(3, 4, 5));
//         foreach (var shape in shapes)
//         {
//             shape.Print();
//         }
//     }
// }
//
// // виртуальные методы
// public abstract class Shape // абстрактный класс
// {
//     // private int _p;
//     // public int P { get => _p; set => _p = value; } //свойство
//     // public int S { get; set; } //авто-свойство
//     public abstract string Name { get; } // абстрактное авто свойство
//     public abstract int P { get; set; } // абстрактное методы
//     public abstract int S { get; set; } // абстрактное методы
//     public abstract void Print(); // абстрактное методы
//     // public Shape()
//     // {
//     //     P = 0;
//     //     S = 0;
//     // }
// }
//
// public class Triangle : Shape
// {
//     public int A { get; set; }
//     public int B { get; set; }
//     public int C { get; set; }
//
//     /* //обязательно new для переписывания унаследованного метода
//     public new int P 
//     {
//         get => _a + _b + _c; 
//     }
//     */
//     public override string Name => "Triangle";
//
//     public override int P
//     {
//         get => A + B + C; // переписывание унаследованного виртуального метода
//         set => throw new NotImplementedException();
//     }
//
//     public override int S
//     {
//         get
//         {
//             int p = (A + B + C) / 2;
//             return (int) Math.Sqrt(p * (p - A) * (p - B) * (p - C));
//         }
//         set => throw new NotImplementedException();
//     }
//
//     public /*sealed*/ override void Print() // sealed запрещает переопределение метода в дочерних классах, "запечатанный" метод
//         // override не дает вызвать метод базового класса при апкастинге. Без него неявно используется new
//     {
//         Console.WriteLine("Triangle called");
//     }
//
//     public Triangle(int a, int b, int c)
//     {
//         A = a;
//         B = b;
//         C = c;
//     }
// }
// // равнобедренный треугольник
// class IsoscelesTriangle : Triangle
// {
//     public override int S
//     {
//         get
//         {
//             int p = (A + B + B) / 2;
//             return (int) Math.Sqrt(p * (p - A) * (p - B) * (p - B));
//         }
//     }
//
//     public override void Print() // override не дает вызвать метод базового класса при апкастинге. Без него неявно используется new
//     {
//         Console.WriteLine("IsoscelesTriangle called");
//     }
//
//     public IsoscelesTriangle(int a, int b, int c) : base(a, b, c)
//     {
//     }
// }
//    
// public class Circle : Shape
// {
//     public Circle(int r)
//     {
//         R = r;
//     }
//
//     public int R { get; }
//
//     public override string Name => "Circle";
//
//     public override int P
//     {
//         get => (int)(2 * Math.PI * R);
//         set => throw new NotImplementedException();
//     }
//
//     public override int S
//     {
//         get => (int)(Math.PI * Math.Pow(R, 2));
//         set => throw new NotImplementedException();
//     }
//
//     public override void Print()
//     { 
//         Console.WriteLine("Circle called");
//     }
// }
//
// public class Square : Shape
// {
//     public Square(int a)
//     {
//         A = a;
//     }
//
//     public int A { get; set; }
//
//     public override string Name => "Square";
//
//     public override int P
//     {
//         get => 4 * A;
//         set => throw new NotImplementedException();
//     }
//
//     public override int S
//     {
//         get => A * A;
//         set => throw new NotImplementedException();
//     }
//
//     public override void Print()
//     {
//         Console.WriteLine("Square called");
//     }
// }
