using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите количество строк массива");
    int len = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int heig = int.Parse(Console.ReadLine());
    TwoDimensionalArray el = new TwoDimensionalArray(len, heig);
    Console.WriteLine("Массив:");
    el.Output();
    Console.WriteLine("Срелнее значение в массиве: " + el.average());
    Console.WriteLine("Массив с замененным порядком элементов:");
    el.OutputSnake();
  }
}
class TwoDimensionalArray{
    private int[,] matrix;
    private int Length;
    private int Height;
    
    public TwoDimensionalArray(int len, int heig, bool InputByUser = false){
        matrix = new int[len, heig];
        Length = len;
        Height = heig;
        if(!InputByUser){
            matrix = RandomInput();
        }
        else{
            matrix = UserInput();
        }
    }
    
    public int[,] RandomInput(){
        Random rnd = new Random();
        for(int i = 0; i < Length; i ++){
            for(int j = 0; j < Height; j ++){
                matrix[i, j] = rnd.Next(0, 1000);
            }
        }
        return matrix;
    }
    
    public int[,] UserInput(){
        for(int i = 0; i < Length; i ++){
            for(int j = 0; j < Height; j ++){
                int el = int.Parse(Console.ReadLine());
                matrix[i, j] = el;
            }
        }
        return matrix;
    }
    
    public double average(){
        double sum = 0;
        for(int i =0; i < Length; i ++){
            for(int j = 0; j < Height; j ++){
                sum = sum + matrix[i, j];
            }
        }
        double mul = Height * Length;
        return sum/mul;
    }
    
    public void OutputSnake(){
        for(int i = 0; i < Length; i ++){
            for(int j = 0; j < Height; j ++){
                if(i % 2 == 0){
                    Console.Write(matrix[i, Height - j - 1] + " ");
                }
                else{
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    public void Output(){
        for(int i = 0; i < Length; i ++){
            for(int j = 0; j < Height; j ++){
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
