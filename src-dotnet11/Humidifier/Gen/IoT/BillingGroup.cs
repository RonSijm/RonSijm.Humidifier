namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using BillingGroupTypes;

    public class BillingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveBillingGroupName, IHaveIoTBillingGroupTypesBillingGroupPropertiesBillingGroupProperties
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.BillingGroup; }
        public Union<string, BaseFunction>? BillingGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BillingGroupProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-billinggroup.html#cfn-iot-billinggroup-billinggroupproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BillingGroupProperties
        /// </summary>
        public Union<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties, BaseFunction>? BillingGroupProperties { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-billinggroup.html#cfn-iot-billinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BillingGroupTypes
    {
        public class BillingGroupProperties : Humidifier.Base.BaseSubResource, IHaveBillingGroupDescription
        {
            /// <summary>
            /// BillingGroupDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-billinggroup-billinggroupproperties.html#cfn-iot-billinggroup-billinggroupproperties-billinggroupdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingGroupDescription { get; set; }
        }
    }
}