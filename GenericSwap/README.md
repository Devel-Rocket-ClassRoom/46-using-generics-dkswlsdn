# 제네릭 유틸리티 메서드

**제네릭 유틸리티 메서드**들을 구현하세요.

배열과 변수를 다루는 다양한 제네릭 메서드들을 구현합니다.

**구현 요구사항**

`Utils` 클래스에 다음 정적 메서드들을 구현:

1. `Swap<T>(ref T a, ref T b)`: 두 변수의 값을 교환
2. `SwapInArray<T>(T[] array, int index1, int index2)`: 배열에서 두 요소의 위치를 교환
3. `FindMin<T>(T[] array)`: 배열에서 최솟값 반환 (IComparable\<T\> 제약조건 필요)
4. `FindMax<T>(T[] array)`: 배열에서 최댓값 반환 (IComparable\<T\> 제약조건 필요)
5. `Reverse<T>(T[] array)`: 배열을 뒤집음 (원본 배열 수정)

**테스트 코드**

```csharp
// Swap 테스트
int x = 10, y = 20;
Console.WriteLine($"교환 전: x={x}, y={y}");
Utils.Swap(ref x, ref y);
Console.WriteLine($"교환 후: x={x}, y={y}");

string a = "Hello", b = "World";
Console.WriteLine($"\n교환 전: a={a}, b={b}");
Utils.Swap(ref a, ref b);
Console.WriteLine($"교환 후: a={a}, b={b}");

// SwapInArray 테스트
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine($"\n배열 교환 전: [{string.Join(", ", numbers)}]");
Utils.SwapInArray(numbers, 0, 4);
Console.WriteLine($"배열 교환 후: [{string.Join(", ", numbers)}]");

// FindMin, FindMax 테스트
int[] scores = { 85, 92, 78, 95, 88 };
Console.WriteLine($"\n점수: [{string.Join(", ", scores)}]");
Console.WriteLine($"최소값: {Utils.FindMin(scores)}");
Console.WriteLine($"최대값: {Utils.FindMax(scores)}");

string[] words = { "banana", "apple", "cherry" };
Console.WriteLine($"\n단어: [{string.Join(", ", words)}]");
Console.WriteLine($"사전순 첫 단어: {Utils.FindMin(words)}");
Console.WriteLine($"사전순 끝 단어: {Utils.FindMax(words)}");

// Reverse 테스트
int[] data = { 1, 2, 3, 4, 5 };
Console.WriteLine($"\n뒤집기 전: [{string.Join(", ", data)}]");
Utils.Reverse(data);
Console.WriteLine($"뒤집기 후: [{string.Join(", ", data)}]");
```

## 예상 실행 결과

```
교환 전: x=10, y=20
교환 후: x=20, y=10

교환 전: a=Hello, b=World
교환 후: a=World, b=Hello

배열 교환 전: [1, 2, 3, 4, 5]
배열 교환 후: [5, 2, 3, 4, 1]

점수: [85, 92, 78, 95, 88]
최소값: 78
최대값: 95

단어: [banana, apple, cherry]
사전순 첫 단어: apple
사전순 끝 단어: cherry

뒤집기 전: [1, 2, 3, 4, 5]
뒤집기 후: [5, 4, 3, 2, 1]
```
