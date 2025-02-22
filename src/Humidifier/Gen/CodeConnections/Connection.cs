namespace Humidifier.CodeConnections
{
    using System.Collections.Generic;

    public class Connection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveConnectionName, IHaveProviderType, IHaveHostArn
    {
        public class Attributes
        {
            public static string ConnectionArn =  "ConnectionArn" ;
            public static string ConnectionStatus =  "ConnectionStatus" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
        }

        public override string AWSTypeName { get => AWS.CodeConnections.Connection; }
        public dynamic ConnectionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// HostArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-connection.html#cfn-codeconnections-connection-hostarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HostArn { get; set; }
        /// <summary>
        /// ProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-connection.html#cfn-codeconnections-connection-providertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProviderType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-connection.html#cfn-codeconnections-connection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}