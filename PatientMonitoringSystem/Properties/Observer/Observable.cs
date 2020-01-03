using System;
using System.Collections.Generic;

namespace PatientMonitoringSystem.Properties
{
    public class Observable:IDeviceObservable
    {
        List<IObserver> observers = new List<IObserver>();
        IDeviceObservable device;

        public Observable(IDeviceObservable device)
        {
            this.device = device;
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers()
        {
            IEnumerator<IObserver> enumerator = observers.GetEnumerator();
            IObserver item;


            while (enumerator.MoveNext())
            {
                item = enumerator.Current;
                item.update(device);
            }
        }
    }
}
