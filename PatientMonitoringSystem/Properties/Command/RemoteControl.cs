using System;
namespace PatientMonitoringSystem.Properties
{
    public class RemoteControl
    {

        ICommand onCommand;
        ICommand offCommand;

        public RemoteControl()
        {
        }

        public void setCommand(ICommand onCommand,ICommand offCommand)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
        }

        public void onButtonWasPushed()
        {
            onCommand.execute();
        }

        public void OffButtonWasPushed()
        {
            offCommand.execute();
        }
    }
}
