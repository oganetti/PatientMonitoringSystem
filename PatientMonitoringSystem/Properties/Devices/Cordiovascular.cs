using System;
namespace PatientMonitoringSystem.Properties
{
    public class Cordiovascular : Vital
    {


        public Cordiovascular(string name,int num) : base(name,num)
        {
            this.name = name;
        }

        public override void Measure()
        {
            Console.WriteLine(name+ " Cordiovascular Device is checking... Measurement Result: " + num +"\n");
        }
    }
}
