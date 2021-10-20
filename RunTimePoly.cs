using System;
class RunTimePoly: Displays
{
    public override void forRunTimeDemoShow()
    {
        Console.WriteLine("This is run time demo in in Derived Class");
        base.forRunTimeDemoShow();      //to access the overridden method
    }
}