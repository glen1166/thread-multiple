
using System;

namespace MultiThreadedApplication
{
    public class AreaClass  
    {  
        public double Base;  
        public double Height;  
        public double Area;  
        public void CalcArea()  
        {  
            Area = 0.5 * Base * Height;  
            Console.WriteLine("The area is: " + Area.ToString());  
        }  
    }
}