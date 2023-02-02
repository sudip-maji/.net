int [] arr={2,5,1,7,3,9,67,10};
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
