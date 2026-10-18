namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VerifiedAccessGroupTypes;

    public class VerifiedAccessGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHavePolicyDocument, IHaveEC2VerifiedAccessGroupTypesSseSpecificationSseSpecification, IHaveVerifiedAccessInstanceId, IHavePolicyEnabled_Boolean
    {
        public class Attributes
        {
            public static string Owner =  "Owner" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string VerifiedAccessGroupId =  "VerifiedAccessGroupId" ;
            public static string VerifiedAccessGroupArn =  "VerifiedAccessGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VerifiedAccessGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessgroup.html#cfn-ec2-verifiedaccessgroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessgroup.html#cfn-ec2-verifiedaccessgroup-policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyDocument { get; set; }
        /// <summary>
        /// SseSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessgroup.html#cfn-ec2-verifiedaccessgroup-ssespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SseSpecification
        /// </summary>
        public Union<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification, BaseFunction>? SseSpecification { get; set; }

        /// <summary>
        /// VerifiedAccessInstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessgroup.html#cfn-ec2-verifiedaccessgroup-verifiedaccessinstanceid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VerifiedAccessInstanceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessgroup.html#cfn-ec2-verifiedaccessgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// PolicyEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessgroup.html#cfn-ec2-verifiedaccessgroup-policyenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PolicyEnabled { get; set; }
    }

    namespace VerifiedAccessGroupTypes
    {
        public class SseSpecification : Humidifier.Base.BaseSubResource, IHaveCustomerManagedKeyEnabled_Boolean, IHaveKmsKeyArn
        {
            /// <summary>
            /// CustomerManagedKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessgroup-ssespecification.html#cfn-ec2-verifiedaccessgroup-ssespecification-customermanagedkeyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CustomerManagedKeyEnabled { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessgroup-ssespecification.html#cfn-ec2-verifiedaccessgroup-ssespecification-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }
    }
}