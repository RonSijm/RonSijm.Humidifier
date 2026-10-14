namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using DomainVerificationTypes;

    public class DomainVerification : Humidifier.Base.BaseResource, IHaveTags, IHaveDomainName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TxtMethodConfig =  "TxtMethodConfig" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.DomainVerification; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-domainverification.html#cfn-vpclattice-domainverification-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-domainverification.html#cfn-vpclattice-domainverification-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DomainVerificationTypes
    {
        public class TxtMethodConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-domainverification-txtmethodconfig.html#cfn-vpclattice-domainverification-txtmethodconfig-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic name { get; set; }
            /// <summary>
            /// value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-domainverification-txtmethodconfig.html#cfn-vpclattice-domainverification-txtmethodconfig-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic value { get; set; }
        }
    }
}