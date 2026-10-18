namespace Humidifier.DataPipeline
{
    using global::System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfDataPipelinePipelineTypesPipelineTagPipelineTags, IHaveListOfDataPipelinePipelineTypesParameterObjectParameterObjects, IHaveDescription, IHaveActivate_Boolean, IHaveListOfDataPipelinePipelineTypesPipelineObjectPipelineObjects, IHaveListOfDataPipelinePipelineTypesParameterValueParameterValues, IHaveName
    {
        public class Attributes
        {
            public static string PipelineId =  "PipelineId" ;
        }

        public override string AWSTypeName { get => AWS.DataPipeline.Pipeline; }
        /// <summary>
        /// PipelineTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datapipeline-pipeline.html#cfn-datapipeline-pipeline-pipelinetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PipelineTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataPipeline.PipelineTypes.PipelineTag>, IReadOnlyList<Union<Humidifier.DataPipeline.PipelineTypes.PipelineTag, BaseFunction>>, BaseFunction>? PipelineTags { get; set; }
        /// <summary>
        /// ParameterObjects
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datapipeline-pipeline.html#cfn-datapipeline-pipeline-parameterobjects
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ParameterObject
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataPipeline.PipelineTypes.ParameterObject>, IReadOnlyList<Union<Humidifier.DataPipeline.PipelineTypes.ParameterObject, BaseFunction>>, BaseFunction>? ParameterObjects { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datapipeline-pipeline.html#cfn-datapipeline-pipeline-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Activate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datapipeline-pipeline.html#cfn-datapipeline-pipeline-activate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Activate { get; set; }
        /// <summary>
        /// PipelineObjects
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datapipeline-pipeline.html#cfn-datapipeline-pipeline-pipelineobjects
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PipelineObject
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataPipeline.PipelineTypes.PipelineObject>, IReadOnlyList<Union<Humidifier.DataPipeline.PipelineTypes.PipelineObject, BaseFunction>>, BaseFunction>? PipelineObjects { get; set; }
        /// <summary>
        /// ParameterValues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datapipeline-pipeline.html#cfn-datapipeline-pipeline-parametervalues
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ParameterValue
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataPipeline.PipelineTypes.ParameterValue>, IReadOnlyList<Union<Humidifier.DataPipeline.PipelineTypes.ParameterValue, BaseFunction>>, BaseFunction>? ParameterValues { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PipelineTypes
    {
        public class Field : Humidifier.Base.BaseSubResource, IHaveRefValue, IHaveStringValue, IHaveKey
        {
            /// <summary>
            /// RefValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-field.html#cfn-datapipeline-pipeline-field-refvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-field.html#cfn-datapipeline-pipeline-field-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-field.html#cfn-datapipeline-pipeline-field-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ParameterAttribute : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveKey
        {
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parameterattribute.html#cfn-datapipeline-pipeline-parameterattribute-stringvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parameterattribute.html#cfn-datapipeline-pipeline-parameterattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ParameterObject : Humidifier.Base.BaseSubResource, IHaveListOfDataPipelinePipelineTypesParameterAttributeAttributes_, IHaveId
        {
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parameterobject.html#cfn-datapipeline-pipeline-parameterobject-attributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ParameterAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataPipeline.PipelineTypes.ParameterAttribute>, IReadOnlyList<Union<Humidifier.DataPipeline.PipelineTypes.ParameterAttribute, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parameterobject.html#cfn-datapipeline-pipeline-parameterobject-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class ParameterValue : Humidifier.Base.BaseSubResource, IHaveId, IHaveStringValue
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parametervalue.html#cfn-datapipeline-pipeline-parametervalue-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-parametervalue.html#cfn-datapipeline-pipeline-parametervalue-stringvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class PipelineObject : Humidifier.Base.BaseSubResource, IHaveListOfDataPipelinePipelineTypesFieldFields, IHaveId, IHaveName
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelineobject.html#cfn-datapipeline-pipeline-pipelineobject-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Field
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataPipeline.PipelineTypes.Field>, IReadOnlyList<Union<Humidifier.DataPipeline.PipelineTypes.Field, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelineobject.html#cfn-datapipeline-pipeline-pipelineobject-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelineobject.html#cfn-datapipeline-pipeline-pipelineobject-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PipelineTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelinetag.html#cfn-datapipeline-pipeline-pipelinetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datapipeline-pipeline-pipelinetag.html#cfn-datapipeline-pipeline-pipelinetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}