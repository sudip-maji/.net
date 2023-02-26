using System;
using System.Collections.Generic;
public class ReverseWords
{
    public static void Main()
    {
    //     try{
    //     Console.WriteLine("Please insert the string ");
    //     string input=Console.ReadLine();
    //     string[] s =input.Split(' ');
    //     string ans = "";
    //     for (int i = s.Length - 1;i >= 0; i--)
    //     {
    //         ans += s[i] + " ";
    //     }
    //     Console.WriteLine("Reversed String is : "+ans);
    
    // }
    // catch(Exception e){
    //     Console.WriteLine(e.Message);
    // }
    // finally{
    //     Console.WriteLine("Thank you for testing ");
    // }

    // insertion sort
    Console.WriteLine("Enter the number of numbers");
    int num=int.Parse(Console.ReadLine());
    int []arr=new int[num];
    Console.WriteLine("Insert the numbers for array");
    for(int i=0;i<num;i++){
        int data=int.Parse(Console.ReadLine());
        arr[i]=data;
    }
    //  1 2 4 12 
      int n = arr.Length;
        for (int i = 1; i < n; i++) {
            int current = arr[i];
            int j = i - 1;
 
            while (j >= 0 && arr[j] > current) {
                arr[j + 1] = arr[j];
                j --;
            }
            arr[j + 1] = current;
        }
        // Console.WriteLine("The final sorted Array is : "+ arr );
        Console.WriteLine("Array : ");
        Console.WriteLine("[{0}]", string.Join(", ", arr));
        // for (int i=0;i<arr.Length;i++){
        //     System.Console.WriteLine(arr[i] +" ");
        //     // ans.add(arr[i]);
    }
    }

    
