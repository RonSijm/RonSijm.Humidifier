namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using ProjectTypes;

    public class Project : Humidifier.Resource
    {
        public class Attributes
        {
            public static string ProjectArn =  "ProjectArn" ;
            public static string ProjectStatus =  "ProjectStatus" ;
            public static string ProjectId =  "ProjectId" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::Project";
            }
        }

        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-projectname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectName { get; set; }
        /// <summary>
        /// ServiceCatalogProvisionedProductDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-servicecatalogprovisionedproductdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceCatalogProvisionedProductDetails
        /// </summary>
        public ServiceCatalogProvisionedProductDetails ServiceCatalogProvisionedProductDetails { get; set; }
        /// <summary>
        /// ServiceCatalogProvisioningDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-servicecatalogprovisioningdetails
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ServiceCatalogProvisioningDetails
        /// </summary>
        public ServiceCatalogProvisioningDetails ServiceCatalogProvisioningDetails { get; set; }
        /// <summary>
        /// ProjectDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-projectdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectDescription { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-project.html#cfn-sagemaker-project-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ProjectTypes
    {
        public class ProvisioningParameter
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

        public class ServiceCatalogProvisionedProductDetails
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

        public class ServiceCatalogProvisioningDetails
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
            public List<ProvisioningParameter> ProvisioningParameters { get; set; }
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
    }
}