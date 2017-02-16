using System;

// class Program{

//     public static void Main(){
//         Program p = new Program();
//         p.EvenNumbers();
//     }

//     public void EvenNumbers(){
//         int Start = 0;
        
//         while (Start <= 20){
//             Console.WriteLine(Start);
//             Start += 2;
//         }
//     }
// }

class Program{

    public static void Main(){
        // EvenNumbers(30);
        Program p = new Program();
        int added = p.Add(2,3);
        Console.WriteLine(added);
    }

    public int Add(int firstNum, int secondNum){
        return firstNum + secondNum;
    }

    public static void EvenNumbers(int target){
        int start = 0;
        
        while (start <= target){
            Console.WriteLine(start);
            start += 2;
        }
    }
}