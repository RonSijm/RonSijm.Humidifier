namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using RetrieverTypes;

    public class Retriever : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveQBusinessRetrieverTypesRetrieverConfigurationConfiguration, IHaveDisplayName, IHaveApplicationId, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string RetrieverArn =  "RetrieverArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string RetrieverId =  "RetrieverId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.Retriever; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RetrieverConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RetrieverTypes
    {
        public class KendraIndexConfiguration : Humidifier.Base.BaseSubResource, IHaveIndexId
        {
            /// <summary>
            /// IndexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-kendraindexconfiguration.html#cfn-qbusiness-retriever-kendraindexconfiguration-indexid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexId { get; set; }
        }

        public class NativeIndexConfiguration : Humidifier.Base.BaseSubResource, IHaveIndexId
        {
            /// <summary>
            /// IndexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-nativeindexconfiguration.html#cfn-qbusiness-retriever-nativeindexconfiguration-indexid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexId { get; set; }
        }

        public class RetrieverConfiguration : Humidifier.Base.BaseSubResource, IHaveQBusinessRetrieverTypesKendraIndexConfigurationKendraIndexConfiguration, IHaveQBusinessRetrieverTypesNativeIndexConfigurationNativeIndexConfiguration
        {
            /// <summary>
            /// KendraIndexConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-retrieverconfiguration.html#cfn-qbusiness-retriever-retrieverconfiguration-kendraindexconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KendraIndexConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.RetrieverTypes.KendraIndexConfiguration, BaseFunction>? KendraIndexConfiguration { get; set; }
            /// <summary>
            /// NativeIndexConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-retrieverconfiguration.html#cfn-qbusiness-retriever-retrieverconfiguration-nativeindexconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NativeIndexConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.RetrieverTypes.NativeIndexConfiguration, BaseFunction>? NativeIndexConfiguration { get; set; }
        }
    }
}