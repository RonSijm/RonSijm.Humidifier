namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class HostReservation : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfHostIdSet, IHaveOfferingId
    {
        public class Attributes
        {
            public static string InstanceFamily =  "InstanceFamily" ;
            public static string Start =  "Start" ;
            public static string State =  "State" ;
            public static string HostReservationId =  "HostReservationId" ;
            public static string HourlyPrice =  "HourlyPrice" ;
            public static string PaymentOption =  "PaymentOption" ;
            public static string Duration =  "Duration" ;
            public static string End =  "End" ;
            public static string Count =  "Count" ;
            public static string Arn =  "Arn" ;
            public static string UpfrontPrice =  "UpfrontPrice" ;
        }

        public override string AWSTypeName { get => AWS.EC2.HostReservation; }
        /// <summary>
        /// HostIdSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-hostreservation.html#cfn-ec2-hostreservation-hostidset
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HostIdSet { get; set; }
        /// <summary>
        /// OfferingId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-hostreservation.html#cfn-ec2-hostreservation-offeringid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OfferingId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-hostreservation.html#cfn-ec2-hostreservation-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}