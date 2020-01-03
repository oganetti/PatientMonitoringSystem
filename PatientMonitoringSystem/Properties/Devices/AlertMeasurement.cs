using System;
namespace PatientMonitoringSystem.Properties
{
    public class AlertMeasurement:IDevice
    {
        IDevice device;
        static int countOfAlert;
        Observable observable;
        RemoteControl rm;

        public AlertMeasurement(IDevice device,RemoteControl rm)
        {
            this.device = device;
            this.rm = rm;
            this.observable = new Observable(this);
            
            
        }

        public void Measure()
        {
            device.Measure();
            countOfAlert++;
            rm.onButtonWasPushed();
            notifyObservers();
        }

        public static int getCountOfAlert()
        {
            return countOfAlert;
        }

        public void registerObserver(IObserver observer)
        {
            observable.registerObserver(observer);
        }

        public void notifyObservers()
        {
            observable.notifyObservers();

        }

    }
}
