using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1Signed
{
    public class CprDll
    {

        public bool Check(string cprTxt, out CprError error)
        {

            error = CprError.Check11Error;

            error = Check11Test(cprTxt);
            if (error == CprError.Check11Error)
            {
                return false;
            }
            error = CheckFormat(cprTxt);
            if (error == CprError.FormatError)
            {
                return false;
            }
            error = CheckDate(cprTxt);
            if (error == CprError.DateError)
            {
                return false;
            }

            return true;
        }

        private CprError CheckFormat(string cprTxt)
        {
            return cprTxt.Length == 10 ? CprError.NoError : CprError.FormatError;
        }

        private CprError CheckDate(string cprTxt)
        {
            DateTime dateTime;
            try
            {
                var test = cprTxt.Remove(6);
                dateTime = DateTime.ParseExact(test, "ddmmyy", null);
                return CprError.NoError;
            }
            catch (Exception e)
            {
                return CprError.DateError;
            }
        }

        /// <summary>
        /// The CPR check sum algorithm is calculated by mulitiplying each digit with a factor 
        /// and then add all results and divide the sum by 11.
        /// Factors: 4327654321
        /// CPR: 0609240121
        /// Sum: 0 + 18 + 0 + 72 + 12 + 20 + 0 + 1 + 4 + 1 = 121 / 11 = 11.0 -> CPR is OK
        /// </summary>
        ///
        private CprError Check11Test(string cprTxt)
        {
            CprError cprError = CprError.NoError;
            int sum = 0;
            for (int i = 0; i < 3; i++)
                sum += int.Parse(cprTxt.Substring(i, 1)) * (4 - i);
            for (int i = 3; i < 10; i++)
                sum += int.Parse(cprTxt.Substring(i, 1)) * (10 - i);
            if (sum % 11 != 0)
                cprError = CprError.Check11Error;
            return cprError;
        }
    }

    public enum CprError { NoError, FormatError, DateError, Check11Error };
}
