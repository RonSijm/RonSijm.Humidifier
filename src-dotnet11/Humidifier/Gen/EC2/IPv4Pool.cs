namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class IPv4Pool : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string PoolId =  "PoolId" ;
            public static string TotalAddressCount =  "TotalAddressCount" ;
            public static string Arn =  "Arn" ;
            public static string TotalAvailableAddressCount =  "TotalAvailableAddressCount" ;
            public static string NetworkBorderGroup =  "NetworkBorderGroup" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPv4Pool; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipv4pool.html#cfn-ec2-ipv4pool-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}