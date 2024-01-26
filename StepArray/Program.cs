using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите количество строк массива");
    int n = int.Parse(Console.ReadLine());
    StepArray el = new StepArray(n);
    Console.WriteLine("Массив:");
    el.Output();
    Console.WriteLine("Среднее значение массива:" + el.average());
    Console.WriteLine("Средние значения внутренних массивов:");
    el.AverageByParts();
    el.Replace();
    Console.WriteLine("Массив с замененными значениями:");
    el.Output();
  }
}

class StepArray{
    private int[][] array;

    public StepArray(int wid, bool InputByUser = false){
        array = new int[wid][];

        if(!InputByUser){
            array = RandomInput();
        }
        else{
            array = UserInput();
        }
    }

    public int[][] RandomInput(){
        Random rnd = new Random();
        for(int i = 0; i < array.Length; i ++){
            int LenEl = rnd.Next(0, 10);
            int[] interAr = new int[LenEl];
            for(int j = 0; j < LenEl; j ++){
                interAr[j] = rnd.Next(0, 1000);
            }
            array[i] = interAr;
        }
        return array;
    }

    public int[][] UserInput(){
        for(int i = 0; i < array.Length; i++){
            Console.WriteLine("Введите количество элементов в строке");
            int LenEl = int.Parse(Console.ReadLine());
            int[] interAr = new int[LenEl];
            for(int j = 0; j < LenEl; j++){
                Console.WriteLine("Введите элемент");
                int el = int.Parse(Console.ReadLine());
                interAr[j] = el;
            }
            array[i] = interAr;
        }
        return array;
    }

    public decimal average(){
        decimal sum = 0;
        int col = 0;
        for(int i = 0; i < array.Length; i ++){
            for(int j = 0; j < array[i].Length; j ++){
                sum = sum + array[i][j];
                col++;
            }
        }
        return sum/col;
    }

    public void AverageByParts(){
        for(int i = 0; i < array.Length; i ++){
            double sum = 0;
            for(int j = 0; j < array[i].Length; j ++){
                sum = sum + array[i][j];
            }
            Console.WriteLine(sum/array[i].Length);
        }
    }

    public int[][] Replace(){
        for(int i = 0; i < array.Length; i ++){
            for(int j = 0; j < array[i].Length; j++){
                if(array[i][j] % 2 == 0){
                    array[i][j] = i * j;
                }
            }
        }
        return array;
    }

    public void Output(){
        for(int i = 0; i < array.Length; i++){
            for(int j = 0; j < array[i].Length; j++){
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}