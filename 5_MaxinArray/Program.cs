using System;

class Program{
    static int maxele(int[] arr){
        int mx=arr[0];
        for(int i=1;i<5;i++){
           if(arr[i]>mx){
            mx=arr[i];
           }
        }
        return mx;
    }
    static void Main(){
        int[] myNumbers = new int[5];
        for (int i = 0; i < 5; i++) {
            Console.Write("Enter number {i + 1}: ");
            myNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int mx = maxele(myNumbers);
        Console.WriteLine("The maximum no. is: " + mx);
    }
    }
