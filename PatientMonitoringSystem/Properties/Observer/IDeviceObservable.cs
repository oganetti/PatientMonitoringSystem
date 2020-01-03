using System;
namespace PatientMonitoringSystem.Properties
{
    public interface IDeviceObservable
    {
         void registerObserver(IObserver observer);
         void notifyObservers();
    }
}
