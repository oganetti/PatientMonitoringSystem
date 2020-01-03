using System;
namespace PatientMonitoringSystem.Properties
{
    public class Nervous: ParentDevice, IDevice
    {
        Observable observable;
  
        public Nervous(string name,int num) : base(name, num)
        {
            this.observable = new Observable(this);
    
        }

        public virtual void Measure()
        {
            Console.WriteLine(name+ " Nervous Device is checking... Measurement Result: " + num+"\n");
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
