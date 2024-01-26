using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите количество элементов в массиве");
    int n = int.Parse(Console.ReadLine());
    OneDimensionalArray el = new OneDimensionalArray(n, true);
    Console.WriteLine("Массив:");
    el.Output();
    Console.WriteLine();
    Console.WriteLine("Среднее значение в массиве: " + el.average());
    Console.WriteLine("Массив без повторов:");
    el.WithoutRepeats();
    el.Output();
    Console.WriteLine();
    Console.WriteLine("Массив с элементами в диапозоне от -100 до 100: ");
    el.mod();
    el.Output();
  }
}
class OneDimensionalArray
{
    private int[] array;
    public OneDimensionalArray(int n, bool InputByUser = false)
    {
        array = new int[n];
        if(!InputByUser)
        {
            array = RandomInput(n);
        }
        else
        {
            array = UserInput(n);
        }
    }
   
    public int[] RandomInput(int len){
        int[] Array = new int[len];
        Random el = new Random();
        for(int i = 0; i < len; i ++){
            Array[i] = el.Next(0, 1000);
        }
        return Array;
    }
   
    public int[] UserInput(int len){
        int[] Array = new int[len];
        for(int i = 0; i < len; i ++){
            Console.WriteLine("Введите элемент");
            int el = int.Parse(Console.ReadLine());
            Array[i] = el;
        }
        return Array;
    }
   
    public double average(){
        double sum = 0;
        for(int i = 0; i < array.Length; i ++){
            sum = sum + array[i];
        }
        return sum/array.Length;
    }
   
    public void mod(){
        int len2 = 0;
        int[] num2 = new int[array.Length];
        for(int i = 0; i < array.Length; i ++){
            if((array[i] <= 100) && (array[i] >= -100)){
                len2 ++;
            }
            num2[i] = array[i];
        }


        array = new int[len2];
        int j = 0;
        for(int i = 0; i < num2.Length; i ++){
           
            if((num2[i] <= 100) && (num2[i] >= -100)){
                array[j] = num2[i];
                j ++;
            }
        }
    }
    public void WithoutRepeats(){
        int n;
        int[] array2 = new int[array.Length];
        int len2 = 0;
        for(int i = 0; i < array.Length; i++)
        {
            n = 1;
            for(int j = 0; j < i; j++)
            {  
                if(array[j] == array[i])
                {
                    n = 0;
                }
            }
            if(n == 1)
            {
                array2[len2] = array[i];
                len2++;
            }
        }
        array = new int [len2];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = array2[i];
        }
    }


    public void Output(){
        for(int i = 0; i < array.Length; i ++){
            Console.Write(array[i] + " ");
        }
    }
}