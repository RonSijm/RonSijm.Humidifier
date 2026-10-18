namespace Humidifier.Kendra
{
    using global::System.Collections.Generic;
    using IndexTypes;

    public class Index : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveUserContextPolicy, IHaveKendraIndexTypesCapacityUnitsConfigurationCapacityUnits, IHaveKendraIndexTypesServerSideEncryptionConfigurationServerSideEncryptionConfiguration, IHaveListOfKendraIndexTypesDocumentMetadataConfigurationDocumentMetadataConfigurations, IHaveRoleArn, IHaveEdition, IHaveName, IHaveListOfKendraIndexTypesUserTokenConfigurationUserTokenConfigurations
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Kendra.Index; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// UserContextPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-usercontextpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserContextPolicy { get; set; }
        /// <summary>
        /// CapacityUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-capacityunits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityUnitsConfiguration
        /// </summary>
        public Union<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration, BaseFunction>? CapacityUnits { get; set; }
        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-serversideencryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        public Union<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// DocumentMetadataConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-documentmetadataconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DocumentMetadataConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration>, IReadOnlyList<Union<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration, BaseFunction>>, BaseFunction>? DocumentMetadataConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }

        /// <summary>
        /// Edition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-edition
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Edition { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// UserTokenConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-index.html#cfn-kendra-index-usertokenconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: UserTokenConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Kendra.IndexTypes.UserTokenConfiguration>, IReadOnlyList<Union<Humidifier.Kendra.IndexTypes.UserTokenConfiguration, BaseFunction>>, BaseFunction>? UserTokenConfigurations { get; set; }
    }

    namespace IndexTypes
    {
        public class CapacityUnitsConfiguration : Humidifier.Base.BaseSubResource, IHaveQueryCapacityUnits_Integer, IHaveStorageCapacityUnits_Integer
        {
            /// <summary>
            /// QueryCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-capacityunitsconfiguration.html#cfn-kendra-index-capacityunitsconfiguration-querycapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? QueryCapacityUnits { get; set; }
            /// <summary>
            /// StorageCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-capacityunitsconfiguration.html#cfn-kendra-index-capacityunitsconfiguration-storagecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCapacityUnits { get; set; }
        }

        public class DocumentMetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveKendraIndexTypesRelevanceRelevance, IHaveType, IHaveKendraIndexTypesSearchSearch, IHaveName
        {
            /// <summary>
            /// Relevance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-documentmetadataconfiguration.html#cfn-kendra-index-documentmetadataconfiguration-relevance
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Relevance
            /// </summary>
            public Union<Humidifier.Kendra.IndexTypes.Relevance, BaseFunction>? Relevance { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-documentmetadataconfiguration.html#cfn-kendra-index-documentmetadataconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Search
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-documentmetadataconfiguration.html#cfn-kendra-index-documentmetadataconfiguration-search
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Search
            /// </summary>
            public Union<Humidifier.Kendra.IndexTypes.Search, BaseFunction>? Search { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-documentmetadataconfiguration.html#cfn-kendra-index-documentmetadataconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class JsonTokenTypeConfiguration : Humidifier.Base.BaseSubResource, IHaveGroupAttributeField, IHaveUserNameAttributeField
        {
            /// <summary>
            /// GroupAttributeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jsontokentypeconfiguration.html#cfn-kendra-index-jsontokentypeconfiguration-groupattributefield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupAttributeField { get; set; }
            /// <summary>
            /// UserNameAttributeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jsontokentypeconfiguration.html#cfn-kendra-index-jsontokentypeconfiguration-usernameattributefield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserNameAttributeField { get; set; }
        }

        public class JwtTokenTypeConfiguration : Humidifier.Base.BaseSubResource, IHaveClaimRegex, IHaveIssuer, IHaveKeyLocation, IHaveSecretManagerArn, IHaveGroupAttributeField, IHaveURL, IHaveUserNameAttributeField
        {
            /// <summary>
            /// ClaimRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html#cfn-kendra-index-jwttokentypeconfiguration-claimregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClaimRegex { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html#cfn-kendra-index-jwttokentypeconfiguration-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// KeyLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html#cfn-kendra-index-jwttokentypeconfiguration-keylocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyLocation { get; set; }
            /// <summary>
            /// SecretManagerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html#cfn-kendra-index-jwttokentypeconfiguration-secretmanagerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretManagerArn { get; set; }
            /// <summary>
            /// GroupAttributeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html#cfn-kendra-index-jwttokentypeconfiguration-groupattributefield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupAttributeField { get; set; }
            /// <summary>
            /// URL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html#cfn-kendra-index-jwttokentypeconfiguration-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? URL { get; set; }
            /// <summary>
            /// UserNameAttributeField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html#cfn-kendra-index-jwttokentypeconfiguration-usernameattributefield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserNameAttributeField { get; set; }
        }

        public class Relevance : Humidifier.Base.BaseSubResource, IHaveImportance_Integer, IHaveRankOrder, IHaveListOfKendraIndexTypesValueImportanceItemValueImportanceItems, IHaveFreshness_Boolean, IHaveDuration
        {
            /// <summary>
            /// Importance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-relevance.html#cfn-kendra-index-relevance-importance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Importance { get; set; }
            /// <summary>
            /// RankOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-relevance.html#cfn-kendra-index-relevance-rankorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RankOrder { get; set; }
            /// <summary>
            /// ValueImportanceItems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-relevance.html#cfn-kendra-index-relevance-valueimportanceitems
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ValueImportanceItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Kendra.IndexTypes.ValueImportanceItem>, IReadOnlyList<Union<Humidifier.Kendra.IndexTypes.ValueImportanceItem, BaseFunction>>, BaseFunction>? ValueImportanceItems { get; set; }
            /// <summary>
            /// Freshness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-relevance.html#cfn-kendra-index-relevance-freshness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Freshness { get; set; }
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-relevance.html#cfn-kendra-index-relevance-duration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Duration { get; set; }
        }

        public class Search : Humidifier.Base.BaseSubResource, IHaveDisplayable_Boolean, IHaveSortable_Boolean, IHaveFacetable_Boolean, IHaveSearchable_Boolean
        {
            /// <summary>
            /// Displayable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-search.html#cfn-kendra-index-search-displayable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Displayable { get; set; }
            /// <summary>
            /// Sortable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-search.html#cfn-kendra-index-search-sortable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Sortable { get; set; }
            /// <summary>
            /// Facetable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-search.html#cfn-kendra-index-search-facetable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Facetable { get; set; }
            /// <summary>
            /// Searchable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-search.html#cfn-kendra-index-search-searchable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Searchable { get; set; }
        }

        public class ServerSideEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-serversideencryptionconfiguration.html#cfn-kendra-index-serversideencryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class UserTokenConfiguration : Humidifier.Base.BaseSubResource, IHaveKendraIndexTypesJwtTokenTypeConfigurationJwtTokenTypeConfiguration, IHaveKendraIndexTypesJsonTokenTypeConfigurationJsonTokenTypeConfiguration
        {
            /// <summary>
            /// JwtTokenTypeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-usertokenconfiguration.html#cfn-kendra-index-usertokenconfiguration-jwttokentypeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JwtTokenTypeConfiguration
            /// </summary>
            public Union<Humidifier.Kendra.IndexTypes.JwtTokenTypeConfiguration, BaseFunction>? JwtTokenTypeConfiguration { get; set; }
            /// <summary>
            /// JsonTokenTypeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-usertokenconfiguration.html#cfn-kendra-index-usertokenconfiguration-jsontokentypeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonTokenTypeConfiguration
            /// </summary>
            public Union<Humidifier.Kendra.IndexTypes.JsonTokenTypeConfiguration, BaseFunction>? JsonTokenTypeConfiguration { get; set; }
        }

        public class ValueImportanceItem : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-valueimportanceitem.html#cfn-kendra-index-valueimportanceitem-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-valueimportanceitem.html#cfn-kendra-index-valueimportanceitem-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}