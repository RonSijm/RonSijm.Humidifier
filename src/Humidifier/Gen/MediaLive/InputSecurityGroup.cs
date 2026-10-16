namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using InputSecurityGroupTypes;

    public class InputSecurityGroup : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Inputs =  "Inputs" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.InputSecurityGroup; }
        /// <summary>
        /// WhitelistRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-inputsecuritygroup.html#cfn-medialive-inputsecuritygroup-whitelistrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputWhitelistRule
        /// </summary>
        public List<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule> WhitelistRules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-inputsecuritygroup.html#cfn-medialive-inputsecuritygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace InputSecurityGroupTypes
    {
        public class InputWhitelistRule : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputsecuritygroup-inputwhitelistrule.html#cfn-medialive-inputsecuritygroup-inputwhitelistrule-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
        }
    }
}