namespace Humidifier.GlobalAccelerator
{
    using global::System.Collections.Generic;

    public class Accelerator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpAddressType, IHaveFlowLogsS3Prefix, IHaveStringListOfIpAddresses, IHaveFlowLogsS3Bucket, IHaveEnabled_Boolean, IHaveFlowLogsEnabled_Boolean, IHaveName
    {
        public class Attributes
        {
            public static string Ipv4Addresses =  "Ipv4Addresses" ;
            public static string DnsName =  "DnsName" ;
            public static string DualStackDnsName =  "DualStackDnsName" ;
            public static string AcceleratorArn =  "AcceleratorArn" ;
            public static string Ipv6Addresses =  "Ipv6Addresses" ;
        }

        public override string AWSTypeName { get => AWS.GlobalAccelerator.Accelerator; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html#cfn-globalaccelerator-accelerator-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// FlowLogsS3Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html#cfn-globalaccelerator-accelerator-flowlogss3prefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FlowLogsS3Prefix { get; set; }
        /// <summary>
        /// IpAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html#cfn-globalaccelerator-accelerator-ipaddresses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IpAddresses { get; set; }
        /// <summary>
        /// FlowLogsS3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html#cfn-globalaccelerator-accelerator-flowlogss3bucket
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FlowLogsS3Bucket { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html#cfn-globalaccelerator-accelerator-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// FlowLogsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html#cfn-globalaccelerator-accelerator-flowlogsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? FlowLogsEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-accelerator.html#cfn-globalaccelerator-accelerator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}