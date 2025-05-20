using EBARCommon;
using EBARDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace EBAR_BL
{
    public class EBARProcess 
    {

        public bool ValidateEmptyInput(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return true;
            }
            return false;
        }


    }
}
