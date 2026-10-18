namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using PrefixListTypes;

    public class PrefixList : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMaxEntries_Integer, IHavePrefixListName, IHaveListOfEC2PrefixListTypesEntryEntries, IHaveAddressFamily
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string PrefixListId =  "PrefixListId" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.PrefixList; }
        /// <summary>
        /// MaxEntries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-prefixlist.html#cfn-ec2-prefixlist-maxentries
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxEntries { get; set; }
        public Union<string, BaseFunction>? PrefixListName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Entries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-prefixlist.html#cfn-ec2-prefixlist-entries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Entry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.PrefixListTypes.Entry>, IReadOnlyList<Union<Humidifier.EC2.PrefixListTypes.Entry, BaseFunction>>, BaseFunction>? Entries { get; set; }

        /// <summary>
        /// AddressFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-prefixlist.html#cfn-ec2-prefixlist-addressfamily
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AddressFamily { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-prefixlist.html#cfn-ec2-prefixlist-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PrefixListTypes
    {
        public class Entry : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveCidr
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-prefixlist-entry.html#cfn-ec2-prefixlist-entry-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-prefixlist-entry.html#cfn-ec2-prefixlist-entry-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
        }
    }
}