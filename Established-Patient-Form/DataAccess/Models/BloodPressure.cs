using System;

namespace DataAccess.Models
{
    public class BloodPressure
    {
        public double systolic { get; set; } // 
        public double diastolic { get; set; }
        public override string ToString()
        {
            return $"{systolic}/{diastolic}";
        }

        public BloodPressure()
        {
        }

        public BloodPressure(string data)
        {
            if(!string.IsNullOrEmpty(data))
            {
                double temp = 0;              
                if(data.Contains("/"))
                {
                    double.TryParse(data.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0], out temp);
                    systolic = temp;
                    temp = 0;
                    double.TryParse(data.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1], out temp);
                    diastolic = temp;
                }
            }
        }
    }
}
