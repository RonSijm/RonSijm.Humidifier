namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;
    using DataProtectionSettingsTypes;

    public class DataProtectionSettings : Humidifier.Base.BaseResource, IHaveTags, IHaveWorkSpacesWebDataProtectionSettingsTypesInlineRedactionConfigurationInlineRedactionConfiguration, IHaveDescription, IHaveCustomerManagedKey, IHaveStringDictionaryOfAdditionalEncryptionContext, IHaveDisplayName
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
        public Union<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration, BaseFunction>? InlineRedactionConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// CustomerManagedKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-customermanagedkey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerManagedKey { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-dataprotectionsettings.html#cfn-workspacesweb-dataprotectionsettings-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataProtectionSettingsTypes
    {
        public class CustomPattern : Humidifier.Base.BaseSubResource, IHaveKeywordRegex, IHavePatternDescription, IHavePatternName, IHavePatternRegex
        {
            /// <summary>
            /// KeywordRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-keywordregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeywordRegex { get; set; }
            /// <summary>
            /// PatternDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-patterndescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternDescription { get; set; }
            /// <summary>
            /// PatternName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-patternname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternName { get; set; }
            /// <summary>
            /// PatternRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-custompattern.html#cfn-workspacesweb-dataprotectionsettings-custompattern-patternregex
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PatternRegex { get; set; }
        }

        public class InlineRedactionConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfWorkSpacesWebDataProtectionSettingsTypesInlineRedactionPatternInlineRedactionPatterns, IHaveGlobalConfidenceLevel_Double, IHaveStringListOfGlobalExemptUrls, IHaveStringListOfGlobalEnforcedUrls
        {
            /// <summary>
            /// InlineRedactionPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-inlineredactionpatterns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InlineRedactionPattern
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionPattern>, IReadOnlyList<Union<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionPattern, BaseFunction>>, BaseFunction>? InlineRedactionPatterns { get; set; }
            /// <summary>
            /// GlobalConfidenceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-globalconfidencelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? GlobalConfidenceLevel { get; set; }
            /// <summary>
            /// GlobalExemptUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-globalexempturls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GlobalExemptUrls { get; set; }
            /// <summary>
            /// GlobalEnforcedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionconfiguration.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionconfiguration-globalenforcedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GlobalEnforcedUrls { get; set; }
        }

        public class InlineRedactionPattern : Humidifier.Base.BaseSubResource, IHaveStringListOfEnforcedUrls, IHaveConfidenceLevel_Double, IHaveWorkSpacesWebDataProtectionSettingsTypesCustomPatternCustomPattern, IHaveStringListOfExemptUrls, IHaveBuiltInPatternId, IHaveWorkSpacesWebDataProtectionSettingsTypesRedactionPlaceHolderRedactionPlaceHolder
        {
            /// <summary>
            /// EnforcedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-enforcedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnforcedUrls { get; set; }
            /// <summary>
            /// ConfidenceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-confidencelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ConfidenceLevel { get; set; }
            /// <summary>
            /// CustomPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-custompattern
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPattern
            /// </summary>
            public Union<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.CustomPattern, BaseFunction>? CustomPattern { get; set; }
            /// <summary>
            /// ExemptUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-exempturls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExemptUrls { get; set; }
            /// <summary>
            /// BuiltInPatternId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-builtinpatternid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuiltInPatternId { get; set; }
            /// <summary>
            /// RedactionPlaceHolder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-inlineredactionpattern.html#cfn-workspacesweb-dataprotectionsettings-inlineredactionpattern-redactionplaceholder
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedactionPlaceHolder
            /// </summary>
            public Union<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.RedactionPlaceHolder, BaseFunction>? RedactionPlaceHolder { get; set; }
        }

        public class RedactionPlaceHolder : Humidifier.Base.BaseSubResource, IHaveRedactionPlaceHolderType, IHaveRedactionPlaceHolderText
        {
            /// <summary>
            /// RedactionPlaceHolderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-redactionplaceholder.html#cfn-workspacesweb-dataprotectionsettings-redactionplaceholder-redactionplaceholdertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedactionPlaceHolderType { get; set; }
            /// <summary>
            /// RedactionPlaceHolderText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-dataprotectionsettings-redactionplaceholder.html#cfn-workspacesweb-dataprotectionsettings-redactionplaceholder-redactionplaceholdertext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedactionPlaceHolderText { get; set; }
        }
    }
}