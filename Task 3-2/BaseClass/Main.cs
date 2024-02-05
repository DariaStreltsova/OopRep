using System;


namespace BaseClass
{


    class Program{
        static void Main(){
            OneDimensionalArray el = new OneDimensionalArray(4);
            Console.WriteLine("Одномерный массив:");
            el.Output();
            Console.WriteLine();
            Console.WriteLine("Среднее в массиве:");
            el.average();

            TwoDimensionalArray element = new TwoDimensionalArray(3, 4);
            Console.WriteLine("Двумерный массив:");
            element.Output();
            Console.WriteLine("Среднее в массиве:");
            element.average();

            StepArray elem = new StepArray(4);
            Console.WriteLine("Ступенчатый массив:");
            elem.Output();
            Console.WriteLine("Среднее в массиве:");
            elem.average();
        }
    }
}
