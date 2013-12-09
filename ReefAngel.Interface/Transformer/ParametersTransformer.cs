using System;

namespace ReefAngel.Interface.Transformer
{
    public interface ITransformParameters
    {
        Parameters Transform(RA ra);
    }
    
    public class ParametersTransformer : ITransformParameters
    {
        public Parameters Transform(RA ra)
        {
            var parameters = new Parameters();

            parameters.Id = ra.ID;
            parameters.Temperature1 = Convert.ToDecimal(ra.T1) / 10;
            parameters.Temperature2 = Convert.ToDecimal(ra.T2) / 10;
            parameters.Temperature3 = Convert.ToDecimal(ra.T3) / 10;
            parameters.pH = Convert.ToDecimal(ra.PH) / 100;
            parameters.R = ra.R;
            parameters.ROn = ra.RON;
            parameters.ROff = ra.ROFF;
            parameters.AtoLow = ra.ATOLOW;
            parameters.AtoHigh = ra.ATOHIGH;
            parameters.Em = ra.EM;
            parameters.Rem = ra.REM;
            parameters.Pwma = ra.PWMA;
            parameters.Pwmd = ra.PWMD;

            return parameters;
        }
    }
}
