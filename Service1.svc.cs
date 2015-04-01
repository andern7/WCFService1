using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetDataUsingMethod(string value)
        {
            return value + "Returning to you by method";
        }

        public string GetDataUsingURI(string value)
        {
            return value + "Returning to you by URI";
        }

        /*To get the value by method name, copy and paste localhost instance plus /GetDataUsingMethod?Hello
        to return "Hello Returning to you by method":
         * http://localhost:51932/Service1.svc/GetDataUsingMethod?hello
         * 
         To get the value by URI, copy and past the localhost instance plus /GetData/hello to return 
         "Hello, returning to you by URI"
         * http://localhost:51932/Service1.svc/GetData/hello
         * 
         */
    }
}
