using System;
using System.Collections;
using System.Collections.Generic;


{
    Console.WriteLine("\n===========================");

    Stack stack = new Stack();

    stack.Push(100);
    stack.Push(200);

    Console.WriteLine($"값1: {(int)stack.Pop()}, 값2: {(int)stack.Pop()}");
}

{
    Console.WriteLine("\n===========================");

    Stack<int> stack = new Stack<int>();

    stack.Push(100);
    stack.Push(200);

    Console.WriteLine($"값1: {stack.Pop()}, 값2: {stack.Pop()}");
}

{
    Console.WriteLine("\n===========================");

    Cup<string> cup1 = new Cup<string>("커피");
    Cup<int> cup2 = new Cup<int>(500);

    Console.WriteLine($"음료: {cup2.value}");
    Console.WriteLine($"용량: {cup2.value}ml");
}

{
    Console.WriteLine("\n===========================");

    var pair1 = new Pair<string, int>("용사", 100);
    var pair2 = new Pair<int, double>(1, 95.5);

    Console.WriteLine($"이름: {pair1.First}, HP: {pair1.Second}");
    Console.WriteLine($"순위: {pair2.First}등, 점수: {pair2.Second}점");
}

{
    Console.WriteLine("\n===========================");

    int x = 10, y = 20;

    Console.WriteLine($"교환 전: x={x}, y={y}");

    Swap<int>(ref x, ref y);

    Console.WriteLine($"교환 후: x={x}, y={y}");


    string first = "사과", second = "바나나";

    Console.WriteLine($"교환 전: x={first}, y={second}");

    Swap(ref first, ref second);

    Console.WriteLine($"교환 전: first={first}, second={second}");


    void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

{
    Console.WriteLine("\n===========================");

    var value1 = new NumberContainer<int>(100);
    var value2 = new NumberContainer<double>(3.14);

    Console.WriteLine($"정수값: {value1.Value}");
    Console.WriteLine($"실수값: {value2.Value}");
}

{
    Console.WriteLine("\n===========================");

    var slime = CreateInstance<Monster>();
    slime.Name = "슬라임";
    slime.Health = 50;

    Console.WriteLine($"생성된 몬스터: {slime.Name}, HP: {slime.Health}");


    T CreateInstance<T>() where T : new()
    {
        return new T(); 
    } 
}

{
    Console.WriteLine("\n===========================");

    int a = 10, b = 25;

    Console.WriteLine($"더 큰 정수: {GetMax(a, b)}");

    string apple = "사과", banana = "바나나";

    Console.WriteLine($"사전순 뒤: {GetMax(apple, banana)}");


    T GetMax<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}

{
    Console.WriteLine("\n===========================");

    Console.WriteLine($"int 기본값: {GetDefaultValue<int>()}");
    Console.WriteLine($"bool 기본값: {GetDefaultValue<bool>()}");
    Console.WriteLine($"string 기본값: {GetDefaultValue<string>()}");


    T GetDefaultValue<T>()
    {
        return default(T); 
    }
}

{
    Console.WriteLine("\n===========================");

    List<string> names = new List<string>();

    names.Add("철수");
    names.Add("영희");
    names.Add("민수");

    Console.WriteLine("이름 목록:");

    foreach (string name in names)
        Console.WriteLine($"  - {name}");

    Dictionary<string, int> students = new Dictionary<string, int>();

    students["철수"] = 95;
    students["영희"] = 88;
    students["민수"] = 92;

    Console.WriteLine("점수:");

    foreach (var pair in students)
    {
        Console.WriteLine($"  {pair.Key}: {pair.Value}점");
    }
}

{
    Console.WriteLine("\n===========================");

    SpecialConainer<string> specialConainer = new SpecialConainer<string>();
    specialConainer.Value = "특별한 아이템";
    specialConainer.Discription = "레어 등급";

    IntContainer intContainer = new IntContainer();
    intContainer.Value = 50;

    Console.WriteLine($"{specialConainer.Value} ({specialConainer.Discription})");
    Console.WriteLine($"값: {intContainer.Value}, 두 배: {intContainer.Double()}");
}

{
    Console.WriteLine("\n===========================");

    Counter<int>.Count++;
    Counter<int>.Count++;
    Counter<string>.Count++;

    Console.WriteLine($"Counter<int>.Count: {Counter<int>.Count}");
    Console.WriteLine($"Counter<string>.Count: {Counter<string>.Count}");
}