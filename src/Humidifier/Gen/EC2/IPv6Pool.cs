namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using IPv6PoolTypes;

    public class IPv6Pool : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string PoolId =  "PoolId" ;
            public static string PoolCidrBlocks =  "PoolCidrBlocks" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPv6Pool; }
    }

    namespace IPv6PoolTypes
    {
        public class PoolCidrBlock : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipv6pool-poolcidrblock.html#cfn-ec2-ipv6pool-poolcidrblock-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
        }
    }
}