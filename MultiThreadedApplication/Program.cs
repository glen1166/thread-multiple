using System;

namespace MultiThreadedApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaClass AreaObject = new AreaClass();  

            System.Threading.Thread Thread =  
                new System.Threading.Thread(AreaObject.CalcArea);  
            AreaObject.Base = 30;  
            AreaObject.Height = 40;  
            Thread.Start(); 
        }
    }
}  
