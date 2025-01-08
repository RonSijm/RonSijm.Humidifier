namespace Humidifier.CleanRooms
{
    using System.Collections.Generic;
    using CollaborationTypes;

    public class Collaboration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveQueryLogStatus
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.Collaboration; }
        /// <summary>
        /// AnalyticsEngine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-analyticsengine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AnalyticsEngine { get; set; }

        /// <summary>
        /// CreatorDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-creatordisplayname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CreatorDisplayName { get; set; }

        /// <summary>
        /// CreatorMemberAbilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-creatormemberabilities
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic CreatorMemberAbilities { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Description { get; set; }

        /// <summary>
        /// QueryLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-querylogstatus
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic QueryLogStatus { get; set; }
        /// <summary>
        /// CreatorPaymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-creatorpaymentconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PaymentConfiguration
        /// </summary>
        public Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration CreatorPaymentConfiguration { get; set; }
        /// <summary>
        /// DataEncryptionMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-dataencryptionmetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataEncryptionMetadata
        /// </summary>
        public Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata DataEncryptionMetadata { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Members
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-members
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MemberSpecification
        /// </summary>
        [Required]
        public List<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> Members { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CollaborationTypes
    {
        public class DataEncryptionMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowCleartext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-allowcleartext
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowCleartext { get; set; }
            /// <summary>
            /// PreserveNulls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-preservenulls
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PreserveNulls { get; set; }
            /// <summary>
            /// AllowJoinsOnColumnsWithDifferentNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-allowjoinsoncolumnswithdifferentnames
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowJoinsOnColumnsWithDifferentNames { get; set; }
            /// <summary>
            /// AllowDuplicates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-allowduplicates
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowDuplicates { get; set; }
        }

        public class MemberSpecification : Humidifier.Base.BaseSubResource, IHaveDisplayName, IHaveAccountId
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-accountid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountId { get; set; }
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-displayname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayName { get; set; }
            /// <summary>
            /// MemberAbilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-memberabilities
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MemberAbilities { get; set; }
            /// <summary>
            /// PaymentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-paymentconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PaymentConfiguration
            /// </summary>
            public Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration PaymentConfiguration { get; set; }
        }

        public class PaymentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-paymentconfiguration.html#cfn-cleanrooms-collaboration-paymentconfiguration-querycompute
            /// Required: True
            /// UpdateType: Immutable
            /// Type: QueryComputePaymentConfig
            /// </summary>
            public Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig QueryCompute { get; set; }
        }

        public class QueryComputePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-querycomputepaymentconfig.html#cfn-cleanrooms-collaboration-querycomputepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsResponsible { get; set; }
        }
    }
}