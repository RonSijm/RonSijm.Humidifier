namespace Humidifier.HealthAgent
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfHealthAgentDomainTypesTagsItemsTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DomainId =  "DomainId" ;
            public static string EncryptionContext =  "EncryptionContext" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.HealthAgent.Domain; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthagent-domain.html#cfn-healthagent-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.HealthAgent.DomainTypes.TagsItems>, IReadOnlyList<Union<Humidifier.HealthAgent.DomainTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DomainTypes
    {
        public class EncryptionContext : Humidifier.Base.BaseSubResource, IHaveEncryptionType
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthagent-domain-encryptioncontext.html#cfn-healthagent-domain-encryptioncontext-encryptiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthagent-domain-tagsitems.html#cfn-healthagent-domain-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthagent-domain-tagsitems.html#cfn-healthagent-domain-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}