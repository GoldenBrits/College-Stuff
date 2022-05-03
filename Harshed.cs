using System;
using System.Threading;
using System.Collection.Generic;

Static void Main(string[] args)
{
  Console.WriteLine("Please Input a Positive Int");
  string Input = Console.ReadLine();
  bool num = int.TryParse(Input, out int Number);
  
  if (num)
  {
  
  }
  else
  {
  Console.WriteLine("Please only input Positive Numbers");
  Thread.Sleep(2000);
  Main();
  }
}
