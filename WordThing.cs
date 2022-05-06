using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Please Input The First Word");
    string WOne = Console.ReadLine();
    Console.WriteLine("Please Input The Second Word");
    string WTwo = Console.ReadLine();
    
    Char[] One = new Char[WOne.Length];
    Char[] Two = new Char[WTwo.Length];
    int O = 0;
    int T = 0;
    
    while (O != WOne.Length)
    {
      One[O] = WOne[O];
      O++;
    }
    while (T != WTwo.Length)
    {
      Two[T] = WTwo[T];
      T++;
    }

    T = 0;
    O = 0;
    bool Found = false;
    while (!Found)
    {
      while(One[O] != Two[T])
      {
        if(T == WTwo.Length - 1)
        {
          break;
        }
        else
        {
           T++;
        }
      }
      
      if(O == WOne.Length - 1)
      {
        Found = true;
      }
      else if (One[O] == Two[T])
      {
        
        Two[T] = 'f';
        T = 0;
        O++;
      }
      if (T == WTwo.Length && O == WOne.Length)
      {
        break;
      }
      if(T == WTwo.Length - 1)
      {
        break;
      }
    }
    if (Found)
    {
      Console.WriteLine("Can be made");
    }
    else
    {
      Console.WriteLine("Can't be made");
      Found = true;
    }
  }
}
