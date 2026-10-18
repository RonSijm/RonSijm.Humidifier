namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using EmailAddressTypes;

    public class EmailAddress : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveInstanceArn, IHaveDisplayName, IHaveEmailAddress_, IHaveListOfConnectEmailAddressTypesAliasConfigurationAliasConfigurations
    {
        public class Attributes
        {
            public static string EmailAddressArn =  "EmailAddressArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.EmailAddress; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-emailaddress.html#cfn-connect-emailaddress-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-emailaddress.html#cfn-connect-emailaddress-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-emailaddress.html#cfn-connect-emailaddress-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// EmailAddress_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-emailaddress.html#cfn-connect-emailaddress-emailaddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EmailAddress_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-emailaddress.html#cfn-connect-emailaddress-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AliasConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-emailaddress.html#cfn-connect-emailaddress-aliasconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AliasConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.EmailAddressTypes.AliasConfiguration>, IReadOnlyList<Union<Humidifier.Connect.EmailAddressTypes.AliasConfiguration, BaseFunction>>, BaseFunction>? AliasConfigurations { get; set; }
    }

    namespace EmailAddressTypes
    {
        public class AliasConfiguration : Humidifier.Base.BaseSubResource, IHaveEmailAddressArn
        {
            /// <summary>
            /// EmailAddressArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-emailaddress-aliasconfiguration.html#cfn-connect-emailaddress-aliasconfiguration-emailaddressarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailAddressArn { get; set; }
        }
    }
}