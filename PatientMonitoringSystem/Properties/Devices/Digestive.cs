using System;
namespace PatientMonitoringSystem.Properties
{
    public class Digestive: ParentDevice, IDevice
    {
        Observable observable;
   

        public Digestive(string name,int num):base(name,num)
        {
            this.observable = new Observable(this);
            this.name = name;
        }

        public virtual void Measure()
        {
            Console.WriteLine(name+ " Digestive Device is checking... Measurement Result: " + num);
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
