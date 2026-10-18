namespace Humidifier.SSM
{
    using global::System.Collections.Generic;
    using DocumentTypes;

    public class Document : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDocumentFormat, IHaveListOfSSMDocumentTypesDocumentRequiresRequires, IHaveContent_Json, IHaveTargetType, IHaveDocumentType, IHaveVersionName, IHaveUpdateMethod, IHaveListOfSSMDocumentTypesAttachmentsSourceAttachments, IHaveName
    {
        public override string AWSTypeName { get => AWS.SSM.Document; }
        /// <summary>
        /// DocumentFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-documentformat
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DocumentFormat { get; set; }
        /// <summary>
        /// Requires
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-requires
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: DocumentRequires
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSM.DocumentTypes.DocumentRequires>, IReadOnlyList<Union<Humidifier.SSM.DocumentTypes.DocumentRequires, BaseFunction>>, BaseFunction>? Requires { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-content
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Content { get; set; }
        /// <summary>
        /// TargetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-targettype
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetType { get; set; }
        /// <summary>
        /// DocumentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-documenttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DocumentType { get; set; }
        /// <summary>
        /// VersionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-versionname
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionName { get; set; }
        /// <summary>
        /// UpdateMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-updatemethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UpdateMethod { get; set; }
        /// <summary>
        /// Attachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-attachments
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: AttachmentsSource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSM.DocumentTypes.AttachmentsSource>, IReadOnlyList<Union<Humidifier.SSM.DocumentTypes.AttachmentsSource, BaseFunction>>, BaseFunction>? Attachments { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-document.html#cfn-ssm-document-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DocumentTypes
    {
        public class AttachmentsSource : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-document-attachmentssource.html#cfn-ssm-document-attachmentssource-values
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-document-attachmentssource.html#cfn-ssm-document-attachmentssource-key
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-document-attachmentssource.html#cfn-ssm-document-attachmentssource-name
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DocumentRequires : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-document-documentrequires.html#cfn-ssm-document-documentrequires-version
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-document-documentrequires.html#cfn-ssm-document-documentrequires-name
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}