using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program {

//Google Question
//Input array with int values
//Output the recurrent number
//Given an array = [2,5,1,2,3,5,1,2,4]:
//It should return 2

//Given an array = [2,1,1,2,3,5,1,2,4]:
//It should return 1

//Given an array = [2,3,4,5]:
//It should return undefined

//Bonus... What if we had this:
// [2,5,5,2,3,5,1,2,4]
// return 5 because the pairs are before 2,2

  //With Hashtable
  public static int? getFirstRecurrent(int[] arr){
    if(arr.Length <= 1) return null;
    Hashtable recNumbers = new Hashtable();
    int cont = 0;
    foreach(var item in arr){
      if(recNumbers.ContainsValue(item))
        return item;

      recNumbers.Add(cont,item);
      cont++;
    }
    return null;
  }
  
  //With HashSet
  public static int? getFirstRecurrent2(int[] arr){
    if(arr.Length <= 1) return null;
    HashSet<int> recNumbers = new HashSet<int>();
    foreach(var item in arr){
      if(recNumbers.Contains(item))
        return item;

      recNumbers.Add(item);
    }
    return null;
  }
  
  public static void Main (string[] args) {
    int[] arr1 = {2,1,1,2,3,5,1,2,};
    int[] arr2 = {2,5,1,2,3,5,1,2,4};
    int[] arr3 = {2,3,4,5};
    int[] arr4 = {2,5,5,2,3,5,1,2,4};
    int[] arr5 = {};
    Console.WriteLine ("first recurrent: " + getFirstRecurrent(arr1));
    Console.WriteLine ("first recurrent: " + getFirstRecurrent(arr2));
    Console.WriteLine ("first recurrent: " + getFirstRecurrent(arr3));
    Console.WriteLine ("first recurrent: " + getFirstRecurrent(arr4));
    Console.WriteLine ("first recurrent: " + getFirstRecurrent(arr5));
  }
}