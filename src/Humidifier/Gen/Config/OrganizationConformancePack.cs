namespace Humidifier.Config
{
    using System.Collections.Generic;
    using OrganizationConformancePackTypes;

    public class OrganizationConformancePack : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTemplateBody, IHaveDeliveryS3Bucket, IHaveDeliveryS3KeyPrefix, IHaveTemplateS3Uri, IHaveExcludedAccounts
    {
        public override string AWSTypeName { get => AWS.Config.OrganizationConformancePack; }
        /// <summary>
        /// ConformancePackInputParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-conformancepackinputparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConformancePackInputParameter
        /// </summary>
        public List<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> ConformancePackInputParameters { get; set; }
        /// <summary>
        /// DeliveryS3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-deliverys3bucket
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeliveryS3Bucket { get; set; }
        /// <summary>
        /// ExcludedAccounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-excludedaccounts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ExcludedAccounts { get; set; }
        /// <summary>
        /// DeliveryS3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-deliverys3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeliveryS3KeyPrefix { get; set; }
        /// <summary>
        /// TemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-templatebody
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TemplateBody { get; set; }
        public dynamic OrganizationConformancePackName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TemplateS3Uri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-templates3uri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TemplateS3Uri { get; set; }
    }

    namespace OrganizationConformancePackTypes
    {
        public class ConformancePackInputParameter : Humidifier.Base.BaseSubResource, IHaveParameterName, IHaveParameterValue
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconformancepack-conformancepackinputparameter.html#cfn-config-organizationconformancepack-conformancepackinputparameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconformancepack-conformancepackinputparameter.html#cfn-config-organizationconformancepack-conformancepackinputparameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
        }
    }
}