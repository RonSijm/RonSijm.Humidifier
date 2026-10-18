namespace Humidifier.CodeConnections
{
    using global::System.Collections.Generic;

    public class Connection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveConnectionName, IHaveHostArn, IHaveProviderType
    {
        public class Attributes
        {
            public static string ConnectionArn =  "ConnectionArn" ;
            public static string ConnectionStatus =  "ConnectionStatus" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
        }

        public override string AWSTypeName { get => AWS.CodeConnections.Connection; }
        public Union<string, BaseFunction>? ConnectionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// HostArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-connection.html#cfn-codeconnections-connection-hostarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostArn { get; set; }
        /// <summary>
        /// ProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-connection.html#cfn-codeconnections-connection-providertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProviderType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codeconnections-connection.html#cfn-codeconnections-connection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}