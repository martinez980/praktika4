﻿using System.Collections;
using System;
class Program
{
  static void Main(string[] args)
  {
    ArrayList myList = new ArrayList(); 
    myList.Add("D");
    myList.Add("Q");
    myList.Add("W");
    myList.Add("A");
    foreach (string item in myList)
    {
      Console.WriteLine("Unsorted: {0}", item);
    }
    // Сортировка при помощи стандартного объекта сравнения 
    myList.Sort();
    foreach (string item in myList)
    {
      Console.WriteLine("   Sorted: {0}", item);
    }
  }
}
