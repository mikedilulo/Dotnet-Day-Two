using System;
using classes.Models;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");


      Cat snibbley = new Cat("Mr.", "Snibbley", 7);
      //NOTE not allowed to set this name because it is set to private as snibbley.Name = "snibbley"
      //NOTE can SCW because it is a simple getter, its just saying go get the information
      System.Console.WriteLine(snibbley.FirstName);
      System.Console.WriteLine((snibbley.Pet()));
    }
  }
}
