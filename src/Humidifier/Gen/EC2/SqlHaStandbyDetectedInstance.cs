namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class SqlHaStandbyDetectedInstance : Humidifier.Base.BaseResource, IHaveInstanceId
    {
        public class Attributes
        {
            public static string SqlServerLicenseUsage =  "SqlServerLicenseUsage" ;
            public static string HaStatus =  "HaStatus" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SqlHaStandbyDetectedInstance; }
        /// <summary>
        /// SqlServerCredentials
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-sqlhastandbydetectedinstance.html#cfn-ec2-sqlhastandbydetectedinstance-sqlservercredentials
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SqlServerCredentials { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-sqlhastandbydetectedinstance.html#cfn-ec2-sqlhastandbydetectedinstance-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }
    }
}