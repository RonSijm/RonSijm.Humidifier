namespace Humidifier.B2BI
{
    using System.Collections.Generic;
    using TransformerTypes;

    public class Transformer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveStatus
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string TransformerId =  "TransformerId" ;
            public static string TransformerArn =  "TransformerArn" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.B2BI.Transformer; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Status { get; set; }
        /// <summary>
        /// Mapping
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-mapping
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Mapping
        /// </summary>
        public Humidifier.B2BI.TransformerTypes.Mapping Mapping { get; set; }
        /// <summary>
        /// InputConversion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-inputconversion
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InputConversion
        /// </summary>
        public Humidifier.B2BI.TransformerTypes.InputConversion InputConversion { get; set; }
        /// <summary>
        /// SampleDocuments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-sampledocuments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SampleDocuments
        /// </summary>
        public Humidifier.B2BI.TransformerTypes.SampleDocuments SampleDocuments { get; set; }
        /// <summary>
        /// OutputConversion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-outputconversion
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputConversion
        /// </summary>
        public Humidifier.B2BI.TransformerTypes.OutputConversion OutputConversion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-transformer.html#cfn-b2bi-transformer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TransformerTypes
    {
        public class FormatOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// X12
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-formatoptions.html#cfn-b2bi-transformer-formatoptions-x12
            /// Required: True
            /// UpdateType: Mutable
            /// Type: X12Details
            /// </summary>
            public Humidifier.B2BI.TransformerTypes.X12Details X12 { get; set; }
        }

        public class InputConversion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-inputconversion.html#cfn-b2bi-transformer-inputconversion-formatoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatOptions
            /// </summary>
            public Humidifier.B2BI.TransformerTypes.FormatOptions FormatOptions { get; set; }
            /// <summary>
            /// FromFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-inputconversion.html#cfn-b2bi-transformer-inputconversion-fromformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FromFormat { get; set; }
        }

        public class Mapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TemplateLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-mapping.html#cfn-b2bi-transformer-mapping-templatelanguage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateLanguage { get; set; }
            /// <summary>
            /// Template
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-mapping.html#cfn-b2bi-transformer-mapping-template
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Template { get; set; }
        }

        public class OutputConversion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ToFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-outputconversion.html#cfn-b2bi-transformer-outputconversion-toformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ToFormat { get; set; }
            /// <summary>
            /// FormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-outputconversion.html#cfn-b2bi-transformer-outputconversion-formatoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FormatOptions
            /// </summary>
            public Humidifier.B2BI.TransformerTypes.FormatOptions FormatOptions { get; set; }
        }

        public class SampleDocumentKeys : Humidifier.Base.BaseSubResource, IHaveInput
        {
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocumentkeys.html#cfn-b2bi-transformer-sampledocumentkeys-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Input { get; set; }
            /// <summary>
            /// Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocumentkeys.html#cfn-b2bi-transformer-sampledocumentkeys-output
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Output { get; set; }
        }

        public class SampleDocuments : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocuments.html#cfn-b2bi-transformer-sampledocuments-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// Keys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-sampledocuments.html#cfn-b2bi-transformer-sampledocuments-keys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleDocumentKeys
            /// </summary>
            public List<Humidifier.B2BI.TransformerTypes.SampleDocumentKeys> Keys { get; set; }
        }

        public class X12Details : Humidifier.Base.BaseSubResource, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12details.html#cfn-b2bi-transformer-x12details-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// TransactionSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-transformer-x12details.html#cfn-b2bi-transformer-x12details-transactionset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransactionSet { get; set; }
        }
    }
}