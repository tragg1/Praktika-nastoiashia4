//Задание 1
class A
{
    public char Symbol;

    public A(char symbol)
    {
        Symbol = symbol;
    }

    public A(A other)
    {
        Symbol = other.Symbol;
    }
}

class B : A
{
    public string Text;

    public B(char symbol, string text) : base(symbol)
    {
        Text = text;
    }

    public B(B other) : base(other)
    {
        Text = other.Text;
    }
}

class C : B
{
    public int Number;

    public C(char symbol, string text, int number) : base(symbol, text)
    {
        Number = number;
    }

    public C(C other) : base(other)
    {
        Number = other.Number;
    }
}

class Program
{
    static void Main()
    {
        C obj1 = new C('X', "Привет", 42);
        C obj2 = new C(obj1);

        Console.WriteLine($"{obj2.Symbol} {obj2.Text} {obj2.Number}");
    }
}


//Задание 2
//class Base
//{
//    public int Number;

//    public Base(int number)
//    {
//        Number = number;
//    }

//    public virtual int this[int index]
//    {
//        get
//        {
//            string s = Math.Abs(Number).ToString();
//            if (index < 0 || index >= s.Length) return 0;
//            return s[s.Length - 1 - index] - '0';
//        }
//    }
//}

//class Derived : Base
//{
//    public int Extra;

//    public Derived(int number, int extra) : base(number)
//    {
//        Extra = extra;
//    }

//    public int this[int field, int index]
//    {
//        get
//        {
//            int value = (field == 0) ? Number : Extra;
//            string s = Math.Abs(value).ToString();
//            if (index < 0 || index >= s.Length) return 0;
//            return s[s.Length - 1 - index] - '0';
//        }
//    }

//   public override int this[int index]
//    {
//        get
//        {
//            string s = Math.Abs(Number + Extra).ToString();
//            if (index < 0 || index >= s.Length) return 0;
//            return s[s.Length - 1 - index] - '0';
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Derived obj = new Derived(123, 45);

//        Console.WriteLine("Цифра суммы (разряд 0): " + obj[0]);   
//        Console.WriteLine("Цифра Number (разряд 0): " + obj[0, 0]);
//        Console.WriteLine("Цифра Extra (разряд 0): " + obj[1, 0]);     }
//}




////Задание 3
//using System;

//class Base
//{
//    protected int[] Numbers;

//    public Base(int size)
//    {
//        Numbers = new int[size];
//    }

//    public int this[int index]
//    {
//        get { return Numbers[index]; }
//        set { Numbers[index] = value; }
//    }

//    public virtual int[] Size
//    {
//        get { return new int[] { Numbers.Length }; }
//    }
//}

//class Derived : Base
//{
//    protected char[] Chars;

//    public Derived(int intSize, int charSize) : base(intSize)
//    {
//        Chars = new char[charSize];
//    }

//    public char this[char index]
//    {
//        get { return Chars[index]; }
//        set { Chars[index] = value; }
//    }

//    public override int[] Size
//    {
//        get { return new int[] { Numbers.Length, Chars.Length }; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Derived obj = new Derived(3, 5);

//        obj[0] = 10;
//        obj[1] = 20;
//        obj[2] = 30;

//        obj['a'] = 'X';
//        obj['b'] = 'Y';

//        Console.WriteLine("Числа: " + obj[0] + ", " + obj[1] + ", " + obj[2]);
//        Console.WriteLine("Символы: " + obj['a'] + ", " + obj['b']);

//        int[] sizes = obj.Size;
//        Console.WriteLine($"Размер int-массива: {sizes[0]}, размер char-массива: {sizes[1]}");
//    }
//}