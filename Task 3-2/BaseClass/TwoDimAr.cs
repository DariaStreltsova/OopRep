using System;
namespace BaseClass{
    sealed class TwoDimensionalArray : BaseClass{
        private int[,] matrix;
        private int Length;
        private int Height;
    
        public TwoDimensionalArray(int len, int heig, bool InputByUser = false){
            matrix = new int[len, heig];
            Length = len;
            Height = heig;
            if(!InputByUser){
                RandomInput();
            }
            else{
                UserInput();
            }
        }
    
        protected override void RandomInput(){
            Random rnd = new Random();
            for(int i = 0; i < Length; i ++){
                for(int j = 0; j < Height; j ++){
                    matrix[i, j] = rnd.Next(0, 1000);
                }
            }
        }
    
        protected override void UserInput(){
            for(int i = 0; i < Length; i ++){
                for(int j = 0; j < Height; j ++){
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    
        public override void average(){
            double sum = 0;
            for(int i =0; i < Length; i ++){
                for(int j = 0; j < Height; j ++){
                    sum = sum + matrix[i, j];
                }
            }
            Console.WriteLine(sum/(Length*Height));
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


        public override void Output(){
            for(int i = 0; i < Length; i ++){
                for(int j = 0; j < Height; j ++){
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}