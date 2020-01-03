using System;
namespace PatientMonitoringSystem.Properties
{
    public class ImmuneAdapter : ParentDevice,IDevice
    {
        Observable observable;
        Immune immune;


        public ImmuneAdapter(string name,int num,Immune immune) : base(name,num)
        {
            this.immune = immune;
            this.observable = new Observable(this);

        }

        public virtual void Measure()
        {
            double result = immune.Hertz(num);
            Console.WriteLine(name+ " Immune Device is checking... Measurement Result: " + result+"\n");
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