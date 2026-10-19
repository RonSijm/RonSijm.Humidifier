namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using IntegrationTypes;

    public class Integration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveCloudWatchIntegrationTypesIntegrationCredentialCredential, IHaveStringDictionaryOfIntegrationAttributes, IHaveIntegrationType, IHaveRoleArn, IHaveListOfCloudWatchIntegrationTypesTagsItemsTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IntegrationArn =  "IntegrationArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string IntegrationId =  "IntegrationId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.Integration; }
        /// <summary>
        /// Credential
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-integration.html#cfn-cloudwatch-integration-credential
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IntegrationCredential
        /// </summary>
        public Union<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential, BaseFunction>? Credential { get; set; }
        /// <summary>
        /// IntegrationAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-integration.html#cfn-cloudwatch-integration-integrationattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? IntegrationAttributes { get; set; }

        /// <summary>
        /// IntegrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-integration.html#cfn-cloudwatch-integration-integrationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IntegrationType { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-integration.html#cfn-cloudwatch-integration-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-integration.html#cfn-cloudwatch-integration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.IntegrationTypes.TagsItems>, IReadOnlyList<Union<Humidifier.CloudWatch.IntegrationTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace IntegrationTypes
    {
        public class ApiKeyCredential : Humidifier.Base.BaseSubResource, IHaveApiKeyValue
        {
            /// <summary>
            /// ApiKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-integration-apikeycredential.html#cfn-cloudwatch-integration-apikeycredential-apikeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyValue { get; set; }
        }

        public class IntegrationCredential : Humidifier.Base.BaseSubResource, IHaveCloudWatchIntegrationTypesApiKeyCredentialApiKeyCredential
        {
            /// <summary>
            /// ApiKeyCredential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-integration-integrationcredential.html#cfn-cloudwatch-integration-integrationcredential-apikeycredential
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ApiKeyCredential
            /// </summary>
            public Union<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential, BaseFunction>? ApiKeyCredential { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-integration-tagsitems.html#cfn-cloudwatch-integration-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-integration-tagsitems.html#cfn-cloudwatch-integration-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}