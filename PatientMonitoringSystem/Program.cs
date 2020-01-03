using System;
using System.Collections.Generic;
using PatientMonitoringSystem.Properties;

namespace PatientMonitoringSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var instance = new MainClass();

            List<Information> arrayInfo = new List<Information>();
            arrayInfo.Add(new Information(15, "nervous"));
            arrayInfo.Add(new Information(20, "digestive"));
            arrayInfo.Add(new Information(110, "immune"));
            arrayInfo.Add(new Information(25, "cordiovascular"));
            arrayInfo.Add(new Information(15, "respiratory"));

            AbstractDeviceFactory factoryGeneral = new GeneralElectricFactory();
            AbstractDeviceFactory factoryPhilips = new PhilipsFactory();

            instance.Simulate(factoryGeneral,factoryPhilips,arrayInfo);

        }

        public void Simulate(AbstractDeviceFactory factoryGeneral,AbstractDeviceFactory factoryPhilips, List<Information> arrayInfo)
        {

            Console.WriteLine("-------------Patient Monitoring System-------------\n");

            DeviceList list = new DeviceList();

            //  Command Pattern 
            Alarm alarm = new Alarm();
            RemoteControl rm = new RemoteControl();
            AlarmOnCommand alarmOn = new AlarmOnCommand(alarm);
            AlarmOffCommand alarmOff = new AlarmOffCommand(alarm);

            rm.setCommand(alarmOn, alarmOff);

            foreach (Information i in arrayInfo)         
                list.add(factoryGeneral.createDevice(i,rm));
            

            foreach (Information i in arrayInfo)
                list.add(factoryPhilips.createDevice(i,rm));

            //  Observer Pattern
            Screen observerScreen = new Screen();
            list.registerObserver(observerScreen);


            Call(list);

            Console.WriteLine("\nTHE ALERT COUNT: " + AlertMeasurement.getCountOfAlert()+"\n");

            rm.OffButtonWasPushed();

        }

        void Call(IDevice m)
        {
            m.Measure();
        }


    }

}
