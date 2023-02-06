<<<<<<< HEAD
﻿String fullName = "Sudip Maji";
// String phoneNumber = "123-456-7890";


//fullName = fullName.ToUpper();
//fullName = fullName.ToLower();
//Console.WriteLine(fullName);

//phoneNumber = phoneNumber.Replace("-","");
//Console.WriteLine(phoneNumber);

// String userName = fullName.Insert(0,"Mr.");
// Console.WriteLine(userName);

//Console.WriteLine(fullName.Length);

// String firstName = fullName.Substring(0, 6);
//             String lastName = fullName.Substring(6);

//             Console.WriteLine(firstName);
//             Console.WriteLine(lastName);


string m="1,2,3,4,5,6";
foreach(var c in m.Split(",")){
    System.Console.WriteLine(c);
}

string g="1";
int s =Convert.ToInt32(g);
System.Console.WriteLine(s);
=======
<<<<<<< HEAD
﻿int [] arr={2,5,1,7,3,9,67,10};
// Array.Sort(arr);
// foreach (int item in arr){
//     System.Console.WriteLine(item);
// }
// time complexity=nlogn




// Selection sorting 
//best and worst==n**n
//  using System;
//  int []arr = {64,25,12,22,11};
//  int n=arr.Length;
//  for (int i = 0; i < n; i++)
//         {
//             // Find the minimum element in unsorted array
//             int min_idx = i;
//             for (int j = i + 1; j < n; j++)
//                 if (arr[j] < arr[min_idx])
//                     min_idx = j;
 
//             int temp = arr[min_idx];
//             arr[min_idx] = arr[i];
//             arr[i] = temp;
//         }
        // for (int i=0;i<arr.Length;i++){
        //     System.Console.WriteLine(arr[i]);
        // }



//  time complexity=n, n*n
//  insertion sort
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
        for (int i=0;i<arr.Length;i++){
            System.Console.WriteLine(arr[i]);
        }
=======
﻿// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

byte number =2;
Console.WriteLine(number);

List<string> cars=new List<string>();
cars.Add("Maruti");
cars.Add("Suzuki");
cars.Add("BMW");
//  for (int i=0;i<cars.Count;i++){
//     System.Console.WriteLine(cars[i]);
//  }
foreach(string car in cars){
    System.Console.WriteLine(car);
}

string[] fruits={"apple","watermelon","grapes","peach","banana"};
foreach(string a in fruits){
    System.Console.WriteLine(a);
}

int[] num={1,2,3,4,5,6,7,8,9};
foreach(int n in num){
    System.Console.WriteLine(n);
}

>>>>>>> d6ddb3805dad68ea8a88e56db32cc6dcffc0d2b3
>>>>>>> a127730f1c4fd04de8e703b8a059c2848abf6b97
