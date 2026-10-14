namespace Humidifier.SCN
{
    using global::System.Collections.Generic;

    public class Instance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string InstanceId =  "InstanceId" ;
            public static string State =  "State" ;
            public static string AwsAccountId =  "AwsAccountId" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
            public static string VersionNumber =  "VersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.SCN.Instance; }
        public dynamic InstanceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// WebAppDnsDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-instance.html#cfn-scn-instance-webappdnsdomain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WebAppDnsDomain { get; set; }
        /// <summary>
        /// InstanceDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-instance.html#cfn-scn-instance-instancedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceDescription { get; set; }

        [Ignore]
        public dynamic Description { get => InstanceDescription; set => InstanceDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-instance.html#cfn-scn-instance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}