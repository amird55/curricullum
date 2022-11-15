using System.Text.Json;

namespace SerializeBasic
{


    public class Program
    {
        public class Test
        {
            public string[][] schedule { get; set; }

            public Test(string[][] arr)
            {
                this.schedule = arr;
            }
        }


        public static string[][] ConvertArr(string[,] arr)
        {
            var A = new string[arr.GetLength(0)][];
            string[] temp = new string[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    temp[j] = arr[i,j];
                    

                }
                
                A[i] = temp;
                temp = new string[arr.GetLength(1)];
            }
            return A;
        }

        public static void Main()
        {
            string[,] B = new string[,] { { "a", "a", "a", "a", "a", "a", "a", "12:30-13:30" }, { "b", "b", "b", "b", "b", "b", "b", "13:30-14:30" }, { "c", "c", "c", "c", "c", "c", "c", "14:30-15:30" } };
            var A = ConvertArr(B);
            var lishay = new Test(A);

            string jsonString = JsonSerializer.Serialize(lishay);
            Console.WriteLine("enter file name: ");
            string fileN = Console.ReadLine();
            string filename = $@"C:\tmp\{fileN}.json"; 
            File.WriteAllText(filename , jsonString); //write to json
            Console.WriteLine(File.ReadAllText(filename)); //read from json
        }
    }
}