using System;
using ReefAngel.Interface.Domain;
using ReefAngel.Interface.Transfer;

namespace ReefAngel.Interface.Transformer
{
    public interface ITransformParameters
    {
        Parameters Transform(RA ra);
    }

    internal class ParametersTransformer : ITransformParameters
    {
        public Parameters Transform(RA ra)
        {
            var parameters = new Parameters();

            parameters.Id = ra.ID;
            parameters.Temperature1 = Convert.ToDecimal(ra.T1) / 10;
            parameters.Temperature2 = Convert.ToDecimal(ra.T2) / 10;
            parameters.Temperature3 = Convert.ToDecimal(ra.T3) / 10;
            parameters.pH = Convert.ToDecimal(ra.PH) / 100;
            parameters.RelayData = ra.R;
            parameters.RelayMaskOn = ra.RON;
            parameters.RelayMaskOff = ra.ROFF;
            parameters.AutoTopOffLow = ra.ATOLOW;
            parameters.AutoTopOffHigh = ra.ATOHIGH;
            parameters.Em = ra.EM;
            parameters.RelayExpansionModules = ra.REM;
            parameters.PwmActinic = ra.PWMA;
            parameters.PwmDaylight = ra.PWMD;

            return parameters;
        }
    }
}
