namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using InputSecurityGroupTypes;

    public class InputSecurityGroup : Humidifier.Base.BaseResource, IHaveDynamicTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.InputSecurityGroup; }
        /// <summary>
        /// WhitelistRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-inputsecuritygroup.html#cfn-medialive-inputsecuritygroup-whitelistrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputWhitelistRuleCidr
        /// </summary>
        public List<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> WhitelistRules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-inputsecuritygroup.html#cfn-medialive-inputsecuritygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
    }

    namespace InputSecurityGroupTypes
    {
        public class InputWhitelistRuleCidr : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputsecuritygroup-inputwhitelistrulecidr.html#cfn-medialive-inputsecuritygroup-inputwhitelistrulecidr-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
        }
    }
}