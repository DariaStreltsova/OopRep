using System;


namespace BaseClass
{
    sealed class OneDimensionalArray : BaseClass
    {
        private int[] array;
        public OneDimensionalArray(int n, bool InputByUser = false)
        {
            array = new int[n];
            if(!InputByUser)
            {
                RandomInput();
            }
            else
            {
                UserInput();
            }
        }
    
        protected override void RandomInput(){
            Random el = new Random();
            for(int i = 0; i < array.Length; i ++){
                array[i] = el.Next(0, 1000);
            }
        }
    
        protected override void UserInput(){
            for(int i = 0; i < array.Length; i ++){
                Console.WriteLine("Введите элемент");
                int el = int.Parse(Console.ReadLine());
                array[i] = el;
            }
        }
    
        public override void average(){
            double sum = 0;
            for(int i = 0; i < array.Length; i ++){
                sum = sum + array[i];
            }
            Console.WriteLine(sum/array.Length);
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




        public override void Output(){
            for(int i = 0; i < array.Length; i ++){
                Console.Write(array[i] + " ");
            }
        }
    }
}
