namespace Humidifier.Wickr
{
    using global::System.Collections.Generic;

    public class Network : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveNetworkName, IHaveAccessLevel
    {
        public class Attributes
        {
            public static string MigrationState =  "MigrationState" ;
            public static string AwsAccountId =  "AwsAccountId" ;
            public static string Standing =  "Standing" ;
            public static string NetworkId =  "NetworkId" ;
            public static string NetworkArn =  "NetworkArn" ;
        }

        public override string AWSTypeName { get => AWS.Wickr.Network; }
        public Union<string, BaseFunction>? NetworkName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// AccessLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wickr-network.html#cfn-wickr-network-accesslevel
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessLevel { get; set; }
    }
}