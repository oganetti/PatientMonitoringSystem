using System;
namespace PatientMonitoringSystem.Properties
{
    public abstract class AbstractDeviceFactory
    {
        public abstract IDevice createDevice(Information i,RemoteControl rm);


    }
}
