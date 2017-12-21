using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages_CS
{
    public static class Lang_Utils
    {
        public static ILanguage GetGUI_Lang(int languagecode)
        {

            switch (languagecode)
            {
                case 0:
                    return new GUI_ENG();
                default:
	                return new GUI_ENG();
                    // Case 1
                    //  Return New GUI_SPAN
            }
        }
    }
}
