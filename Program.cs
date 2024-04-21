using System;

class Program
{
    static void Main(string[] args) {
        int startNumber = 5;
        int stopNumber = 96;
        int increment = 7;
        int actualValue;

        for (actualValue = startNumber; actualValue <= stopNumber; actualValue += increment)
        {
            Console.WriteLine(actualValue);
        }

        //т.к. мы знаем точные параметры нашего цикла, а именно - начальное значение, 
        // конечное значение и инкремент, то исходя из этого выбран цикл for, 
        // хотя можно использовать и цикл while
    }
}