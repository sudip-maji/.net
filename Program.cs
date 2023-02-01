// See https://aka.ms/new-console-template for more information
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

