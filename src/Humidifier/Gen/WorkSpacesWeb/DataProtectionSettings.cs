namespace Humidifier.WorkSpacesWeb
{
    using System.Collections.Generic;
    using DataProtectionSettingsTypes;

    public class DataProtectionSettings : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDisplayName, IHaveCustomerManagedKey
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string AssociatedPortalArns =  "AssociatedPortalArns" ;
            public static string DataProtectionSettingsArn =  "DataProtectionSettingsArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.DataProtectionSettings; }
        /// <summary>
        /// InlineRedactionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InlineRedactionConfiguration
        /// </summary>
        public Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration InlineRedactionConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// CustomerManagedKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-customermanagedkey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerManagedKey { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DataProtectionSettingsTypes
    {
        public class CustomPattern : Humidifier.Base.BaseSubResource, IHavePatternName
        {
            /// <summary>
            /// KeywordRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-keywordregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeywordRegex { get; set; }
            /// <summary>
            /// PatternDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-patterndescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatternDescription { get; set; }
            /// <summary>
            /// PatternName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-patternname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatternName { get; set; }
            /// <summary>
            /// PatternRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-patternregex
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatternRegex { get; set; }
        }

        public class InlineRedactionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InlineRedactionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-inlineredactionpatterns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InlineRedactionPattern
            /// </summary>
            public List<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionPattern> InlineRedactionPatterns { get; set; }
            /// <summary>
            /// GlobalConfidenceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-globalconfidencelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic GlobalConfidenceLevel { get; set; }
            /// <summary>
            /// GlobalExemptUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-globalexempturls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GlobalExemptUrls { get; set; }
            /// <summary>
            /// GlobalEnforcedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-globalenforcedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GlobalEnforcedUrls { get; set; }
        }

        public class InlineRedactionPattern : Humidifier.Base.BaseSubResource, IHaveConfidenceLevel
        {
            /// <summary>
            /// EnforcedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-enforcedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EnforcedUrls { get; set; }
            /// <summary>
            /// ConfidenceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-confidencelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ConfidenceLevel { get; set; }
            /// <summary>
            /// CustomPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-custompattern
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPattern
            /// </summary>
            public Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.CustomPattern CustomPattern { get; set; }
            /// <summary>
            /// ExemptUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-exempturls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExemptUrls { get; set; }
            /// <summary>
            /// BuiltInPatternId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-builtinpatternid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BuiltInPatternId { get; set; }
            /// <summary>
            /// RedactionPlaceHolder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-redactionplaceholder
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedactionPlaceHolder
            /// </summary>
            public Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.RedactionPlaceHolder RedactionPlaceHolder { get; set; }
        }

        public class RedactionPlaceHolder : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RedactionPlaceHolderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-redactionplaceholder.html#cfn-workspacesweb-dataprotectionsettings-redactionplaceholder-redactionplaceholdertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedactionPlaceHolderType { get; set; }
            /// <summary>
            /// RedactionPlaceHolderText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-redactionplaceholder.html#cfn-workspacesweb-dataprotectionsettings-redactionplaceholder-redactionplaceholdertext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedactionPlaceHolderText { get; set; }
        }
    }
}