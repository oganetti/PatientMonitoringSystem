using System;
namespace PatientMonitoringSystem.Properties
{
    public class GeneralElectricFactory:AbstractDeviceFactory
    {
        public override IDevice createDevice(Information i,RemoteControl rm)
        {
            IDevice device = null;
            string name = "GeneralElectric";

            if (i.Type.Equals("immune")){
                if(i.Number<200 && i.Number > 100)
                    device = new ImmuneAdapter(name,i.Number,new Immune());
                else
                    device = new AlertMeasurement(new ImmuneAdapter (name,i.Number,new Immune()),rm);
                    
            }

            else if (i.Type.Equals("nervous"))
            {
                if (i.Number < 20 && i.Number > 10)
                    device = new Nervous(name,i.Number);
                else
                    device = new AlertMeasurement(new Nervous(name,i.Number),rm);

            }

            else if (i.Type.Equals("respiratory"))
            {
                if (i.Number < 20 && i.Number > 10)
                    device = new Respiratory(name,i.Number);
                else
                    device = new AlertMeasurement(new Respiratory(name,i.Number),rm);

            }

            else if (i.Type.Equals("cordiovascular"))
            {
                if (i.Number < 20 && i.Number > 10)
                    device = new Cordiovascular(name,i.Number);
                else
                    device = new AlertMeasurement(new Cordiovascular(name,i.Number),rm);

            }

            else if (i.Type.Equals("digestive"))
            {
                if (i.Number < 20 && i.Number > 10)
                    device = new Digestive(name,i.Number);
                else

                    device = new AlertMeasurement(new Digestive(name,i.Number),rm);
            }

          return device;

        }
    }
}

