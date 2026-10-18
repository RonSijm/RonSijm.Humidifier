namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;
    using AgreementTypes;

    public class Agreement : Humidifier.Base.BaseResource, IHaveTags, IHaveStatus, IHaveDescription, IHaveBaseDirectory, IHaveServerId, IHaveTransferAgreementTypesCustomDirectoriesCustomDirectories, IHaveAccessRole, IHavePartnerProfileId, IHaveLocalProfileId, IHaveEnforceMessageSigning, IHavePreserveFilename
    {
        public class Attributes
        {
            public static string AgreementId =  "AgreementId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.Agreement; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// BaseDirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-basedirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BaseDirectory { get; set; }

        /// <summary>
        /// ServerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-serverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServerId { get; set; }
        /// <summary>
        /// CustomDirectories
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-customdirectories
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomDirectories
        /// </summary>
        public Union<Humidifier.Transfer.AgreementTypes.CustomDirectories, BaseFunction>? CustomDirectories { get; set; }

        /// <summary>
        /// AccessRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-accessrole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessRole { get; set; }

        /// <summary>
        /// PartnerProfileId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-partnerprofileid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PartnerProfileId { get; set; }

        /// <summary>
        /// LocalProfileId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-localprofileid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LocalProfileId { get; set; }
        /// <summary>
        /// EnforceMessageSigning
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-enforcemessagesigning
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnforceMessageSigning { get; set; }
        /// <summary>
        /// PreserveFilename
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-preservefilename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreserveFilename { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-agreement.html#cfn-transfer-agreement-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AgreementTypes
    {
        public class CustomDirectories : Humidifier.Base.BaseSubResource, IHaveFailedFilesDirectory, IHaveTemporaryFilesDirectory, IHaveMdnFilesDirectory, IHavePayloadFilesDirectory, IHaveStatusFilesDirectory
        {
            /// <summary>
            /// FailedFilesDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-agreement-customdirectories.html#cfn-transfer-agreement-customdirectories-failedfilesdirectory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailedFilesDirectory { get; set; }
            /// <summary>
            /// TemporaryFilesDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-agreement-customdirectories.html#cfn-transfer-agreement-customdirectories-temporaryfilesdirectory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemporaryFilesDirectory { get; set; }
            /// <summary>
            /// MdnFilesDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-agreement-customdirectories.html#cfn-transfer-agreement-customdirectories-mdnfilesdirectory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MdnFilesDirectory { get; set; }
            /// <summary>
            /// PayloadFilesDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-agreement-customdirectories.html#cfn-transfer-agreement-customdirectories-payloadfilesdirectory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadFilesDirectory { get; set; }
            /// <summary>
            /// StatusFilesDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-agreement-customdirectories.html#cfn-transfer-agreement-customdirectories-statusfilesdirectory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusFilesDirectory { get; set; }
        }
    }
}