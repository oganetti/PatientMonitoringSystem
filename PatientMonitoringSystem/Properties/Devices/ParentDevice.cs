using System;
namespace PatientMonitoringSystem.Properties
{
    public class ParentDevice
    {
        protected string name;
        protected int num;

        public ParentDevice(string name,int num)
        {
            this.name = name;
            this.num = num;
        }
    }
}
