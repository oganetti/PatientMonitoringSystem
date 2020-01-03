using System;
namespace PatientMonitoringSystem.Properties
{
    public class Information
    {
        public int Number { get; set; }
        public string Type { get; set; }

        public Information(int Number, string Type)
        {
            this.Number = Number;
            this.Type = Type;
        }
    }
}
