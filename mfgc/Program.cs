// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
int []arr={1,2,3,4,5};
foreach(var c in arr){
Console.WriteLine(c);
}


Dictionary<int,string> months=new Dictionary<int, string>();
months.Add(1,"January");
months.Add(2,"February");
months[3]="March";
months.Add(4,"hvashvgjh");
// months.Add(4,"hvash");
months[4]="April";
foreach(var month in months){
    // System.Console.WriteLine($"key : {month.key},value : {month.value}");
    System.Console.WriteLine(month);
   System.Console.WriteLine(month.Key);
    System.Console.WriteLine(month.Value);

}