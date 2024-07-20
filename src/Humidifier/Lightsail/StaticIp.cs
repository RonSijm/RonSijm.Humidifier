namespace Humidifier.Lightsail
{
    using System.Collections.Generic;

    public class StaticIp : Humidifier.Resource
    {
        public class Attributes
        {
            public static string StaticIpArn =  "StaticIpArn" ;
            public static string IsAttached =  "IsAttached" ;
            public static string IpAddress =  "IpAddress" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lightsail::StaticIp";
            }
        }

        /// <summary>
        /// StaticIpName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-staticip.html#cfn-lightsail-staticip-staticipname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StaticIpName { get; set; }
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