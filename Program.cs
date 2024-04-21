using System;

class Program
{
    static void Main(string[] args) {
        int startNumber = 5;
        int stopNumber = 96;
        int increment = 7;

        for (int i = startNumber; i <= stopNumber; i += increment)
        {
            Console.WriteLine(i);
        }

        //т.к. мы знаем точные параметры нашего цикла, а именно - начальное значение, 
        // конечное значение и инкремент, то исходя из этого выбран цикл for, 
        // хотя можно использовать и цикл while
    }
}