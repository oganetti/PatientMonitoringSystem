using System;
namespace PatientMonitoringSystem.Properties
{
    public class Vital : ParentDevice, IDevice
    {
        Observable observable;


        public Vital(string name,int num): base(name,num)
        {
            this.observable = new Observable(this);

        }

        public virtual void Measure()
        {
            Console.WriteLine("Vital device is checking...");
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
