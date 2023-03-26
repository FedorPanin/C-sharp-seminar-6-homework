int InputNumber()
{
    while (true)
    {
        try
        {
            System.Console.Write("Введите номер числа фибоначчи: ");
            int number = int.Parse(Console.ReadLine()!);
            if (number < 1)
            {
                throw new Exception();
            }

            return number;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Допустимое значение: любое число от 1 до ∞");
            throw;
        }
    }
}

int Fib(int index)
{
    if (index == 0 || index == 1)
        return index;
    return Fib(index - 1) + Fib(index - 2);
}

void PrintNegafib(int k)
{
    int fibNumber;
    List<int> fibList = new List<int>();
    fibList.Add(0);
    for (int i = 1; i < k; i++)
    {
        fibNumber = Fib(i);
        fibList.Add(fibNumber);
        fibList.Insert(0, fibNumber * (i % 2 == 0 ? -1 : 1));
    }
    Console.WriteLine($"k = {k} -> [{string.Join(", ", fibList)}]");
}

int k = InputNumber();
PrintNegafib(k);