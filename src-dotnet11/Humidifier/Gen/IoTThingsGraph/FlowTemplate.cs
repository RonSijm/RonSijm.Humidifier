namespace Humidifier.IoTThingsGraph
{
    using global::System.Collections.Generic;
    using FlowTemplateTypes;

    public class FlowTemplate : Humidifier.Base.BaseResource, IHaveCompatibleNamespaceVersion_Double, IHaveIoTThingsGraphFlowTemplateTypesDefinitionDocumentDefinition
    {
        public override string AWSTypeName { get => AWS.IoTThingsGraph.FlowTemplate; }
        /// <summary>
        /// CompatibleNamespaceVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotthingsgraph-flowtemplate.html#cfn-iotthingsgraph-flowtemplate-compatiblenamespaceversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? CompatibleNamespaceVersion { get; set; }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotthingsgraph-flowtemplate.html#cfn-iotthingsgraph-flowtemplate-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DefinitionDocument
        /// </summary>
        [Required]
        public Union<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument, BaseFunction>? Definition { get; set; }
    }

    namespace FlowTemplateTypes
    {
        public class DefinitionDocument : Humidifier.Base.BaseSubResource, IHaveLanguage, IHaveText
        {
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotthingsgraph-flowtemplate-definitiondocument.html#cfn-iotthingsgraph-flowtemplate-definitiondocument-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotthingsgraph-flowtemplate-definitiondocument.html#cfn-iotthingsgraph-flowtemplate-definitiondocument-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }
    }
}