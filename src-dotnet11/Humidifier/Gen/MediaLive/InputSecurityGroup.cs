namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using InputSecurityGroupTypes;

    public class InputSecurityGroup : Humidifier.Base.BaseResource, IHaveListOfMediaLiveInputSecurityGroupTypesInputWhitelistRuleWhitelistRules, IHaveStringDictionaryOfTags
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
        public Union<IReadOnlyList<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule>, IReadOnlyList<Union<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRule, BaseFunction>>, BaseFunction>? WhitelistRules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-inputsecuritygroup.html#cfn-medialive-inputsecuritygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
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
            public Union<string, BaseFunction>? Cidr { get; set; }
        }
    }
}