namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;

    public class MeteredProduct : Humidifier.Base.BaseResource, IHaveLicenseEndpointId, IHaveProductId
    {
        public class Attributes
        {
            public static string Port =  "Port" ;
            public static string Family =  "Family" ;
            public static string Vendor =  "Vendor" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.MeteredProduct; }
        /// <summary>
        /// LicenseEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-meteredproduct.html#cfn-deadline-meteredproduct-licenseendpointid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LicenseEndpointId { get; set; }
        /// <summary>
        /// ProductId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-meteredproduct.html#cfn-deadline-meteredproduct-productid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProductId { get; set; }
    }
}