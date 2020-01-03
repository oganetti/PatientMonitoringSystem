using System;
namespace PatientMonitoringSystem.Properties
{
    public class AlarmOffCommand: ICommand
    {

        Alarm alarm;

        public AlarmOffCommand(Alarm alarm)
        {
            this.alarm = alarm;
        }

        public void execute()
        {
            alarm.Off();
        }

        public void undo()
        {
            alarm.On();
        }
    }
}
