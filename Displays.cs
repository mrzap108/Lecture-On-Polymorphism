using System;

class Displays
{
    public virtual void forRunTimeDemoShow()
    {
        Console.WriteLine("This is run time demo in in Base Class");
    }
    
    public void print(int number)
    {
        Console.WriteLine("Display here is an integer: {0}", number);
    }

    public void print(double number)
    {
        Console.WriteLine("Display here is a decimal pointing number: {0}", number);
    }

    public void print(string theString)
    {
        Console.WriteLine("Display here is a string: {0}", theString);
    }

}




