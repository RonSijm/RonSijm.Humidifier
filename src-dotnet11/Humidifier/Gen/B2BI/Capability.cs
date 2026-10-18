namespace Humidifier.B2BI
{
    using global::System.Collections.Generic;
    using CapabilityTypes;

    public class Capability : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveB2BICapabilityTypesCapabilityConfigurationConfiguration, IHaveListOfB2BICapabilityTypesS3LocationInstructionsDocuments, IHaveName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string CapabilityId =  "CapabilityId" ;
            public static string CapabilityArn =  "CapabilityArn" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.B2BI.Capability; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-capability.html#cfn-b2bi-capability-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-capability.html#cfn-b2bi-capability-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CapabilityConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// InstructionsDocuments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-capability.html#cfn-b2bi-capability-instructionsdocuments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: S3Location
        /// </summary>
        public Union<IReadOnlyList<Humidifier.B2BI.CapabilityTypes.S3Location>, IReadOnlyList<Union<Humidifier.B2BI.CapabilityTypes.S3Location, BaseFunction>>, BaseFunction>? InstructionsDocuments { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-b2bi-capability.html#cfn-b2bi-capability-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CapabilityTypes
    {
        public class CapabilityConfiguration : Humidifier.Base.BaseSubResource, IHaveB2BICapabilityTypesEdiConfigurationEdi
        {
            /// <summary>
            /// Edi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-capabilityconfiguration.html#cfn-b2bi-capability-capabilityconfiguration-edi
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EdiConfiguration
            /// </summary>
            public Union<Humidifier.B2BI.CapabilityTypes.EdiConfiguration, BaseFunction>? Edi { get; set; }
        }

        public class EdiConfiguration : Humidifier.Base.BaseSubResource, IHaveB2BICapabilityTypesEdiTypeType, IHaveB2BICapabilityTypesS3LocationInputLocation, IHaveTransformerId, IHaveB2BICapabilityTypesS3LocationOutputLocation, IHaveCapabilityDirection
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-ediconfiguration.html#cfn-b2bi-capability-ediconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EdiType
            /// </summary>
            public Union<Humidifier.B2BI.CapabilityTypes.EdiType, BaseFunction>? Type { get; set; }
            /// <summary>
            /// InputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-ediconfiguration.html#cfn-b2bi-capability-ediconfiguration-inputlocation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.B2BI.CapabilityTypes.S3Location, BaseFunction>? InputLocation { get; set; }
            /// <summary>
            /// TransformerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-ediconfiguration.html#cfn-b2bi-capability-ediconfiguration-transformerid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransformerId { get; set; }
            /// <summary>
            /// OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-ediconfiguration.html#cfn-b2bi-capability-ediconfiguration-outputlocation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.B2BI.CapabilityTypes.S3Location, BaseFunction>? OutputLocation { get; set; }
            /// <summary>
            /// CapabilityDirection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-ediconfiguration.html#cfn-b2bi-capability-ediconfiguration-capabilitydirection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapabilityDirection { get; set; }
        }

        public class EdiType : Humidifier.Base.BaseSubResource, IHaveB2BICapabilityTypesX12DetailsX12Details
        {
            /// <summary>
            /// X12Details
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-editype.html#cfn-b2bi-capability-editype-x12details
            /// Required: True
            /// UpdateType: Mutable
            /// Type: X12Details
            /// </summary>
            public Union<Humidifier.B2BI.CapabilityTypes.X12Details, BaseFunction>? X12Details { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveKey, IHaveBucketName
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-s3location.html#cfn-b2bi-capability-s3location-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-s3location.html#cfn-b2bi-capability-s3location-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }

        public class X12Details : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveTransactionSet
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-x12details.html#cfn-b2bi-capability-x12details-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// TransactionSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-b2bi-capability-x12details.html#cfn-b2bi-capability-x12details-transactionset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransactionSet { get; set; }
        }
    }
}