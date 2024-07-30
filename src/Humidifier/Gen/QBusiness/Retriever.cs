namespace Humidifier.QBusiness
{
    using System.Collections.Generic;
    using RetrieverTypes;

    public class Retriever : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string RetrieverArn =  "RetrieverArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string RetrieverId =  "RetrieverId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::QBusiness::Retriever";
            }
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RetrieverConfiguration
        /// </summary>
        public RetrieverTypes.RetrieverConfiguration Configuration { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-retriever.html#cfn-qbusiness-retriever-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace RetrieverTypes
    {
        public class KendraIndexConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IndexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-kendraindexconfiguration.html#cfn-qbusiness-retriever-kendraindexconfiguration-indexid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexId { get; set; }
        }

        public class NativeIndexConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IndexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-nativeindexconfiguration.html#cfn-qbusiness-retriever-nativeindexconfiguration-indexid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexId { get; set; }
        }

        public class RetrieverConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KendraIndexConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-retrieverconfiguration.html#cfn-qbusiness-retriever-retrieverconfiguration-kendraindexconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KendraIndexConfiguration
            /// </summary>
            public RetrieverTypes.KendraIndexConfiguration KendraIndexConfiguration { get; set; }
            /// <summary>
            /// NativeIndexConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-retriever-retrieverconfiguration.html#cfn-qbusiness-retriever-retrieverconfiguration-nativeindexconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NativeIndexConfiguration
            /// </summary>
            public RetrieverTypes.NativeIndexConfiguration NativeIndexConfiguration { get; set; }
        }
    }
}