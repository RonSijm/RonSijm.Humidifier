namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using OrganizationConformancePackTypes;

    public class OrganizationConformancePack : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfConfigOrganizationConformancePackTypesConformancePackInputParameterConformancePackInputParameters, IHaveDeliveryS3Bucket, IHaveStringListOfExcludedAccounts, IHaveDeliveryS3KeyPrefix, IHaveTemplateBody, IHaveOrganizationConformancePackName, IHaveTemplateS3Uri
    {
        public class Attributes
        {
            public static string OrganizationConformancePackArn =  "OrganizationConformancePackArn" ;
        }

        public override string AWSTypeName { get => AWS.Config.OrganizationConformancePack; }
        /// <summary>
        /// ConformancePackInputParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-conformancepackinputparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConformancePackInputParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter>, IReadOnlyList<Union<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter, BaseFunction>>, BaseFunction>? ConformancePackInputParameters { get; set; }
        /// <summary>
        /// DeliveryS3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-deliverys3bucket
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeliveryS3Bucket { get; set; }
        /// <summary>
        /// ExcludedAccounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-excludedaccounts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedAccounts { get; set; }
        /// <summary>
        /// DeliveryS3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-deliverys3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeliveryS3KeyPrefix { get; set; }
        /// <summary>
        /// TemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-templatebody
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateBody { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? OrganizationConformancePackName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TemplateS3Uri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-organizationconformancepack.html#cfn-config-organizationconformancepack-templates3uri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateS3Uri { get; set; }
    }

    namespace OrganizationConformancePackTypes
    {
        public class ConformancePackInputParameter : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconformancepack-conformancepackinputparameter.html#cfn-config-organizationconformancepack-conformancepackinputparameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconformancepack-conformancepackinputparameter.html#cfn-config-organizationconformancepack-conformancepackinputparameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }
    }
}