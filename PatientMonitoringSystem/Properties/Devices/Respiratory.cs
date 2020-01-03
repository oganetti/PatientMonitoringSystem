using System;
namespace PatientMonitoringSystem.Properties
{
    public class Respiratory : Vital
    {



        public Respiratory(string name,int num) : base(name,num)
        {
 
        }
        public override void Measure()
        {
           Console.WriteLine(name +" Respiratory Device is checking... Measurement Result: "+num+"\n");
        }
    }
}
