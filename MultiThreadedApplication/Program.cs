using System;
using System.ComponentModel;

namespace MultiThreadedApplication
{
    class Program
    {
            private static System.ComponentModel.BackgroundWorker BackgroundWorker1  
    = new System.ComponentModel.BackgroundWorker();  

        static void Main(string[] args)
        {
            InitializeBackgroundWorker();  

            AreaClass AreaObject = new AreaClass();  
            AreaObject.Base = 30;  
            AreaObject.Height = 40;  

            // Start the asynchronous operation.  
            BackgroundWorker1.RunWorkerAsync(AreaObject); 

        }

        private static void InitializeBackgroundWorker()  
        {  
            // Attach event handlers to the BackgroundWorker object.  
            BackgroundWorker1.DoWork +=  
                new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);  
            BackgroundWorker1.RunWorkerCompleted +=  
                new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);  
        }  

        private static void BackgroundWorker1_DoWork(  
            object sender,  
            System.ComponentModel.DoWorkEventArgs e)  
        {  
            AreaClass AreaObject2 = (AreaClass)e.Argument;  
            // Return the value through the Result property.  
            e.Result = AreaObject2.CalcArea();  
        }  

        private static void BackgroundWorker1_RunWorkerCompleted(  
            object sender,  
            System.ComponentModel.RunWorkerCompletedEventArgs e)  
        {  
            // Access the result through the Result property.  
            double Area = (double)e.Result;  
            Console.WriteLine("The area is: " + Area.ToString());  
        }  
    }
}
