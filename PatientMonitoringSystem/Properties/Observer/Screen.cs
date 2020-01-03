using System;
namespace PatientMonitoringSystem.Properties
{
    public class Screen : IObserver
    {
        public void update(IDeviceObservable device)
        {
            Console.WriteLine("SCREEN: SOMETHINGS GO WRONG!! MEASUREMENT ALERT!!\n");
        }
   
    }
}
