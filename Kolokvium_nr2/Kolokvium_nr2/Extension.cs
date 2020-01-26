
using System;
public static class Extension
{
    public static string Extension_method(this DateTime x)
    {
        DateTime data = DateTime.Today;
        int tmp ;
        int tmp2;        
        tmp = (data - x).Hours;
        tmp2 = (data - x).Days;
        
        if(tmp<1)
        {
            Console.WriteLine("Przed chvila..");
        }
        if(tmp2<1)
        {
            Console.WriteLine("yesterday"+data.Date);

        }
        return data.Date.Kind.ToString();

    }

}
