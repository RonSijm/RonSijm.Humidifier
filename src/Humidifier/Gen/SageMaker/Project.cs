namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ProjectTypes;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProjectName, IHaveProjectDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string ProjectArn =  "ProjectArn" ;
            public static string ProjectStatus =  "ProjectStatus" ;
            public static string ProjectId =  "ProjectId" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Project; }
        public dynamic ProjectName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TemplateProviderDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-templateproviderdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TemplateProviderDetail
        /// </summary>
        public List<Humidifier.SageMaker.ProjectTypes.TemplateProviderDetail> TemplateProviderDetails { get; set; }
        /// <summary>
        /// ServiceCatalogProvisionedProductDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-servicecatalogprovisionedproductdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceCatalogProvisionedProductDetails
        /// </summary>
        public Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails ServiceCatalogProvisionedProductDetails { get; set; }
        /// <summary>
        /// ServiceCatalogProvisioningDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-servicecatalogprovisioningdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServiceCatalogProvisioningDetails
        /// </summary>
        public Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails ServiceCatalogProvisioningDetails { get; set; }
        /// <summary>
        /// ProjectDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-projectdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ProjectDescription; set => ProjectDescription = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfnstackparameter.html#cfn-sagemaker-project-cfnstackparameter-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class CfnTemplateProviderDetail : Humidifier.Base.BaseSubResource, IHaveRoleARN, IHaveTemplateName, IHaveTemplateURL
        {
            /// <summary>
            /// TemplateURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-templateurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateURL { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CfnStackParameter
            /// </summary>
            public List<Humidifier.SageMaker.ProjectTypes.CfnStackParameter> Parameters { get; set; }
            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-templatename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateName { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-cfntemplateproviderdetail.html#cfn-sagemaker-project-cfntemplateproviderdetail-rolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-provisioningparameter.html#cfn-sagemaker-project-provisioningparameter-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ServiceCatalogProvisionedProductDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProvisionedProductStatusMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisionedproductdetails.html#cfn-sagemaker-project-servicecatalogprovisionedproductdetails-provisionedproductstatusmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProvisionedProductStatusMessage { get; set; }
            /// <summary>
            /// ProvisionedProductId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisionedproductdetails.html#cfn-sagemaker-project-servicecatalogprovisionedproductdetails-provisionedproductid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProvisionedProductId { get; set; }
        }

        public class ServiceCatalogProvisioningDetails : Humidifier.Base.BaseSubResource, IHaveProductId, IHaveProvisioningArtifactId, IHavePathId
        {
            /// <summary>
            /// PathId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-pathid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PathId { get; set; }
            /// <summary>
            /// ProvisioningParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-provisioningparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ProvisioningParameter
            /// </summary>
            public List<Humidifier.SageMaker.ProjectTypes.ProvisioningParameter> ProvisioningParameters { get; set; }
            /// <summary>
            /// ProductId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-productid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProductId { get; set; }
            /// <summary>
            /// ProvisioningArtifactId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-servicecatalogprovisioningdetails.html#cfn-sagemaker-project-servicecatalogprovisioningdetails-provisioningartifactid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProvisioningArtifactId { get; set; }
        }

        public class TemplateProviderDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CfnTemplateProviderDetail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-project-templateproviderdetail.html#cfn-sagemaker-project-templateproviderdetail-cfntemplateproviderdetail
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CfnTemplateProviderDetail
            /// </summary>
            public Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail CfnTemplateProviderDetail { get; set; }
        }
    }
}