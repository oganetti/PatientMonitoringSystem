using System;
namespace PatientMonitoringSystem.Properties
{
    public class AlarmOnCommand : ICommand
    {
        Alarm alarm;

        public AlarmOnCommand(Alarm alarm)
        {
            this.alarm = alarm;
        }

        public void execute()
        {
            alarm.On();
        }

        public void undo()
        {
            alarm.Off();
        }

    }
}
