using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorningRecap
{
    public class Credentials
    {

           
            static string _globaluser;
            static string _globalpass;

            public static string GlobalUser
            {
                get
                {
                    return _globaluser;
                }
                set
                {
                    _globaluser = value;
                }
            }


            public static string GlobalPass
            {
                get
                {
                    return _globalpass;
                }
                set
                {
                    _globalpass = value;
                }
            }
    }

}
