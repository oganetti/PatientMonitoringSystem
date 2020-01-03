using System;

namespace PatientMonitoringSystem.Properties
{
    public interface ICommand
    {
        void execute();
        void undo();

    }
}
