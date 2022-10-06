using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToJSONAdaptee JSONAdaptee = new ConvertToJSONAdaptee();
            ConvertToXMLAdaptee XMLAdaptee = new ConvertToXMLAdaptee();
            //ITarget target = new ToJSONAdapter(ConvertToJSONAdaptee);
            ITarget target = new ToXMLAdapter(XMLAdaptee);
            Console.WriteLine(target.Convert());
        }
        //Target will Communicate with Adapter.
        //Adapter will call to Adaptee and excute specified function.
    }
}