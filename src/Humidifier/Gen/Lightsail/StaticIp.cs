namespace Humidifier.Lightsail
{
    using System.Collections.Generic;

    public class StaticIp : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string StaticIpArn =  "StaticIpArn" ;
            public static string IsAttached =  "IsAttached" ;
            public static string IpAddress =  "IpAddress" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.StaticIp; }
        public dynamic StaticIpName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AttachedTo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-staticip.html#cfn-lightsail-staticip-attachedto
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AttachedTo { get; set; }
    }
}