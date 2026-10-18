namespace Humidifier.ServiceCatalog
{
    using global::System.Collections.Generic;
    using CloudFormationProductTypes;

    public class CloudFormationProduct : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOwner, IHaveDescription, IHaveSupportEmail, IHaveProductType, IHaveName, IHaveReplaceProvisioningArtifacts_Boolean, IHaveSupportDescription, IHaveDistributor, IHaveAcceptLanguage, IHaveSupportUrl, IHaveServiceCatalogCloudFormationProductTypesSourceConnectionSourceConnection, IHaveListOfServiceCatalogCloudFormationProductTypesProvisioningArtifactPropertiesProvisioningArtifactParameters
    {
        public class Attributes
        {
            public static string ProductName =  "ProductName" ;
            public static string ProvisioningArtifactIds =  "ProvisioningArtifactIds" ;
            public static string ProvisioningArtifactNames =  "ProvisioningArtifactNames" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.ServiceCatalog.CloudFormationProduct; }

        /// <summary>
        /// Owner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-owner
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Owner { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SupportEmail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-supportemail
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SupportEmail { get; set; }
        /// <summary>
        /// ProductType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-producttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProductType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ReplaceProvisioningArtifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-replaceprovisioningartifacts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ReplaceProvisioningArtifacts { get; set; }
        /// <summary>
        /// SupportDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-supportdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SupportDescription { get; set; }
        /// <summary>
        /// Distributor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-distributor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Distributor { get; set; }
        /// <summary>
        /// AcceptLanguage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-acceptlanguage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AcceptLanguage { get; set; }
        /// <summary>
        /// SupportUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-supporturl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SupportUrl { get; set; }
        /// <summary>
        /// SourceConnection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-sourceconnection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SourceConnection
        /// </summary>
        public Union<Humidifier.ServiceCatalog.CloudFormationProductTypes.SourceConnection, BaseFunction>? SourceConnection { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ProvisioningArtifactParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-cloudformationproduct.html#cfn-servicecatalog-cloudformationproduct-provisioningartifactparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProvisioningArtifactProperties
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties>, IReadOnlyList<Union<Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties, BaseFunction>>, BaseFunction>? ProvisioningArtifactParameters { get; set; }
    }

    namespace CloudFormationProductTypes
    {
        public class CodeStarParameters : Humidifier.Base.BaseSubResource, IHaveArtifactPath, IHaveRepository, IHaveBranch, IHaveConnectionArn
        {
            /// <summary>
            /// ArtifactPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-codestarparameters.html#cfn-servicecatalog-cloudformationproduct-codestarparameters-artifactpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ArtifactPath { get; set; }
            /// <summary>
            /// Repository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-codestarparameters.html#cfn-servicecatalog-cloudformationproduct-codestarparameters-repository
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Repository { get; set; }
            /// <summary>
            /// Branch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-codestarparameters.html#cfn-servicecatalog-cloudformationproduct-codestarparameters-branch
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Branch { get; set; }
            /// <summary>
            /// ConnectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-codestarparameters.html#cfn-servicecatalog-cloudformationproduct-codestarparameters-connectionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionArn { get; set; }
        }

        public class ConnectionParameters : Humidifier.Base.BaseSubResource, IHaveServiceCatalogCloudFormationProductTypesCodeStarParametersCodeStar
        {
            /// <summary>
            /// CodeStar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-connectionparameters.html#cfn-servicecatalog-cloudformationproduct-connectionparameters-codestar
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeStarParameters
            /// </summary>
            public Union<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters, BaseFunction>? CodeStar { get; set; }
        }

        public class Info : Humidifier.Base.BaseSubResource, IHaveLoadTemplateFromURL, IHaveImportFromPhysicalId
        {
            /// <summary>
            /// LoadTemplateFromURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-info.html#cfn-servicecatalog-cloudformationproduct-info-loadtemplatefromurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadTemplateFromURL { get; set; }
            /// <summary>
            /// ImportFromPhysicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-info.html#cfn-servicecatalog-cloudformationproduct-info-importfromphysicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImportFromPhysicalId { get; set; }
        }

        public class ProvisioningArtifactProperties : Humidifier.Base.BaseSubResource, IHaveType, IHaveDescription, IHaveDisableTemplateValidation_Boolean, IHaveServiceCatalogCloudFormationProductTypesInfoInfo, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-provisioningartifactproperties.html#cfn-servicecatalog-cloudformationproduct-provisioningartifactproperties-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-provisioningartifactproperties.html#cfn-servicecatalog-cloudformationproduct-provisioningartifactproperties-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// DisableTemplateValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-provisioningartifactproperties.html#cfn-servicecatalog-cloudformationproduct-provisioningartifactproperties-disabletemplatevalidation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableTemplateValidation { get; set; }
            /// <summary>
            /// Info
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-provisioningartifactproperties.html#cfn-servicecatalog-cloudformationproduct-provisioningartifactproperties-info
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Info
            /// </summary>
            public Union<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info, BaseFunction>? Info { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-provisioningartifactproperties.html#cfn-servicecatalog-cloudformationproduct-provisioningartifactproperties-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SourceConnection : Humidifier.Base.BaseSubResource, IHaveType, IHaveServiceCatalogCloudFormationProductTypesConnectionParametersConnectionParameters
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-sourceconnection.html#cfn-servicecatalog-cloudformationproduct-sourceconnection-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ConnectionParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-sourceconnection.html#cfn-servicecatalog-cloudformationproduct-sourceconnection-connectionparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectionParameters
            /// </summary>
            public Union<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters, BaseFunction>? ConnectionParameters { get; set; }
        }
    }
}