namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using BillingGroupTypes;

    public class BillingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.BillingGroup; }
        public dynamic BillingGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BillingGroupProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-billinggroup.html#cfn-iot-billinggroup-billinggroupproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BillingGroupProperties
        /// </summary>
        public Humidifier.IoT.BillingGroupTypes.BillingGroupProperties BillingGroupProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-billinggroup.html#cfn-iot-billinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace BillingGroupTypes
    {
        public class BillingGroupProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BillingGroupDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-billinggroup-billinggroupproperties.html#cfn-iot-billinggroup-billinggroupproperties-billinggroupdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingGroupDescription { get; set; }
        }
    }
}