using System;
using System.Collections;
using System.Collections.Generic;

namespace PatientMonitoringSystem.Properties
{
    public class DeviceList:IDevice
    {
        List<IDevice> devices = new List<IDevice>();
        Observable device;

        public DeviceList()
        {
            device = new Observable(this);
        }
       

        public void add(IDevice device)
        {
            devices.Add(device);


        }

       public void Measure()
        {
            IEnumerator<IDevice> enumerator = devices.GetEnumerator();
            IDevice item;

            
            while (enumerator.MoveNext())
            {
                item = enumerator.Current;
                item.Measure();
            }
        }

        public void registerObserver(IObserver observer)
        {
            IEnumerator<IDevice> enumerator = devices.GetEnumerator();
            IDevice item;


            while (enumerator.MoveNext())
            {
                item = enumerator.Current;
                item.registerObserver(observer);
            }
        }

        public void notifyObservers()
        {
            device.notifyObservers();
        }


    }
}
