namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ProjectTypes;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProjectName, IHaveListOfSageMakerProjectTypesTemplateProviderDetailTemplateProviderDetails, IHaveSageMakerProjectTypesServiceCatalogProvisionedProductDetailsServiceCatalogProvisionedProductDetails, IHaveSageMakerProjectTypesServiceCatalogProvisioningDetailsServiceCatalogProvisioningDetails, IHaveProjectDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string ProjectArn =  "ProjectArn" ;
            public static string ProjectStatus =  "ProjectStatus" ;
            public static string ProjectId =  "ProjectId" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Project; }
        public Union<string, BaseFunction>? ProjectName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TemplateProviderDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-templateproviderdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TemplateProviderDetail
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail>, IReadOnlyList<Union<Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail, BaseFunction>>, BaseFunction>? TemplateProviderDetails { get; set; }
        /// <summary>
        /// ServiceCatalogProvisionedProductDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-servicecatalogprovisionedproductdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceCatalogProvisionedProductDetails
        /// </summary>
        public Union<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails, BaseFunction>? ServiceCatalogProvisionedProductDetails { get; set; }
        /// <summary>
        /// ServiceCatalogProvisioningDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-servicecatalogprovisioningdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServiceCatalogProvisioningDetails
        /// </summary>
        public Union<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails, BaseFunction>? ServiceCatalogProvisioningDetails { get; set; }
        /// <summary>
        /// ProjectDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-projectdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ProjectDescription; set => ProjectDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ProjectTypes
    {
        public class CfnStackParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfnstackparameter.html#cfn-sagemaker-project-cfnstackparameter-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfnstackparameter.html#cfn-sagemaker-project-cfnstackparameter-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class CfnTemplateProviderDetail : Humidifier.Base.BaseSubResource, IHaveTemplateURL, IHaveListOfSageMakerProjectTypesCfnStackParameterParameters, IHaveTemplateName, IHaveRoleARN
        {
            /// <summary>
            /// TemplateURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-templateurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateURL { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CfnStackParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ProjectTypes.CfnStackParameter>, IReadOnlyList<Union<Humidifier.SageMaker.ProjectTypes.CfnStackParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-templatename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateName { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-rolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleARN { get; set; }
        }

        public class ProvisioningParameter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-provisioningparameter.html#cfn-sagemaker-project-provisioningparameter-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-provisioningparameter.html#cfn-sagemaker-project-provisioningparameter-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ServiceCatalogProvisionedProductDetails : Humidifier.Base.BaseSubResource, IHaveProvisionedProductStatusMessage, IHaveProvisionedProductId
        {
            /// <summary>
            /// ProvisionedProductStatusMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisionedproductdetails.html#cfn-sagemaker-project-servicecatalogprovisionedproductdetails-provisionedproductstatusmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProvisionedProductStatusMessage { get; set; }
            /// <summary>
            /// ProvisionedProductId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisionedproductdetails.html#cfn-sagemaker-project-servicecatalogprovisionedproductdetails-provisionedproductid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProvisionedProductId { get; set; }
        }

        public class ServiceCatalogProvisioningDetails : Humidifier.Base.BaseSubResource, IHavePathId, IHaveListOfSageMakerProjectTypesProvisioningParameterProvisioningParameters, IHaveProductId, IHaveProvisioningArtifactId
        {
            /// <summary>
            /// PathId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-pathid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PathId { get; set; }
            /// <summary>
            /// ProvisioningParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-provisioningparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ProvisioningParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ProjectTypes.ProvisioningParameter>, IReadOnlyList<Union<Humidifier.SageMaker.ProjectTypes.ProvisioningParameter, BaseFunction>>, BaseFunction>? ProvisioningParameters { get; set; }
            /// <summary>
            /// ProductId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-productid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductId { get; set; }
            /// <summary>
            /// ProvisioningArtifactId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-provisioningartifactid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProvisioningArtifactId { get; set; }
        }

        public class TemplateProviderDetail : Humidifier.Base.BaseSubResource, IHaveSageMakerProjectTypesCfnTemplateProviderDetailCfnTemplateProviderDetail
        {
            /// <summary>
            /// CfnTemplateProviderDetail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-templateproviderdetail.html#cfn-sagemaker-project-templateproviderdetail-cfntemplateproviderdetail
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CfnTemplateProviderDetail
            /// </summary>
            public Union<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail, BaseFunction>? CfnTemplateProviderDetail { get; set; }
        }
    }
}