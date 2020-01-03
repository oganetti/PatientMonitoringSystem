using System;
namespace PatientMonitoringSystem.Properties
{
    public interface IObserver
    {
         void update(IDeviceObservable device);
    }
}
