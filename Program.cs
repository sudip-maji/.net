// List<string> days=new List<string>();
// days.Add("MONDAY");
// days.Add("TUESDAY");
// days.Add("WEDNESDAY");
// days.Add("THURSDAY");
// days.Add("FRIDAY");
// days.Add("SATURDAY");
// days.Add("SUNDAY");

// foreach(string day in days){
//     System.Console.WriteLine(day);
// }

// var mon=days[0];
// System.Console.WriteLine(mon);

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
// var jan=months.TryGetValue(2,out string February);
// System.Console.WriteLine(jan);

if (months.ContainsKey(1)){
months.Remove(1);
}
if (months.ContainsValue("February")){
months.Remove(2);
}

foreach(var month in months){
    // System.Console.WriteLine($"key : {month.key},value : {month.value}");
    System.Console.WriteLine(month);
}


