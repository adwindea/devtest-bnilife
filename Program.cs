class Program
    {
        static void Main(string[] args)
        {
            int max = 20;
            string hasil = null;
            for(int i = 1; i <= max; i++){
                convertResult(i,ref hasil);
                Console.WriteLine(hasil);
            }
        }

        static void convertResult(int i, ref string hasil)
        {
            if(i%15 == 0){
                hasil = "FizzBuzz";
            }else if(i%3 == 0){
                hasil = "Fizz";
            }else if(i%5 == 0){
                hasil = "Buzz";
            }else{
                hasil = i.ToString();
            }
        }
    }