namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using ConformancePackTypes;

    public class ConformancePack : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfConfigConformancePackTypesConformancePackInputParameterConformancePackInputParameters, IHaveConfigConformancePackTypesTemplateSSMDocumentDetailsTemplateSSMDocumentDetails, IHaveDeliveryS3Bucket, IHaveConformancePackName, IHaveDeliveryS3KeyPrefix, IHaveTemplateBody, IHaveTemplateS3Uri
    {
        public class Attributes
        {
            public static string ConformancePackArn =  "ConformancePackArn" ;
        }

        public override string AWSTypeName { get => AWS.Config.ConformancePack; }
        /// <summary>
        /// ConformancePackInputParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html#cfn-config-conformancepack-conformancepackinputparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConformancePackInputParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter>, IReadOnlyList<Union<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter, BaseFunction>>, BaseFunction>? ConformancePackInputParameters { get; set; }
        /// <summary>
        /// TemplateSSMDocumentDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html#cfn-config-conformancepack-templatessmdocumentdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TemplateSSMDocumentDetails
        /// </summary>
        public Union<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails, BaseFunction>? TemplateSSMDocumentDetails { get; set; }
        /// <summary>
        /// DeliveryS3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html#cfn-config-conformancepack-deliverys3bucket
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeliveryS3Bucket { get; set; }
        public Union<string, BaseFunction>? ConformancePackName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeliveryS3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html#cfn-config-conformancepack-deliverys3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeliveryS3KeyPrefix { get; set; }
        /// <summary>
        /// TemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html#cfn-config-conformancepack-templatebody
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateBody { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html#cfn-config-conformancepack-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TemplateS3Uri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-conformancepack.html#cfn-config-conformancepack-templates3uri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateS3Uri { get; set; }
    }

    namespace ConformancePackTypes
    {
        public class ConformancePackInputParameter : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-conformancepack-conformancepackinputparameter.html#cfn-config-conformancepack-conformancepackinputparameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-conformancepack-conformancepackinputparameter.html#cfn-config-conformancepack-conformancepackinputparameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }

        public class TemplateSSMDocumentDetails : Humidifier.Base.BaseSubResource, IHaveDocumentVersion, IHaveDocumentName
        {
            /// <summary>
            /// DocumentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-conformancepack-templatessmdocumentdetails.html#cfn-config-conformancepack-templatessmdocumentdetails-documentversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentVersion { get; set; }
            /// <summary>
            /// DocumentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-conformancepack-templatessmdocumentdetails.html#cfn-config-conformancepack-templatessmdocumentdetails-documentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentName { get; set; }
        }
    }
}