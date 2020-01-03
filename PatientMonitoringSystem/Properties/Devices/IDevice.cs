using System;
namespace PatientMonitoringSystem.Properties
{
   public interface IDevice : IDeviceObservable
    {
       
        void Measure();
             
    }
}
