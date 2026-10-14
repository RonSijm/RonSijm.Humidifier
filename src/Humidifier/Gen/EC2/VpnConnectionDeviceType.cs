namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VpnConnectionDeviceType : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string VpnConnectionDeviceTypeId =  "VpnConnectionDeviceTypeId" ;
            public static string Platform =  "Platform" ;
            public static string Software =  "Software" ;
            public static string Vendor =  "Vendor" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VpnConnectionDeviceType; }
    }
}