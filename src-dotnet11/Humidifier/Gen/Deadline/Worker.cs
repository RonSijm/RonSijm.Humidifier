namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;
    using WorkerTypes;

    public class Worker : Humidifier.Base.BaseResource, IHaveDeadlineWorkerTypesHostPropertiesRequestHostProperties, IHaveFleetId, IHaveFarmId, IHaveListOfDeadlineWorkerTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string WorkerId =  "WorkerId" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Worker; }
        /// <summary>
        /// HostProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-worker.html#cfn-deadline-worker-hostproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: HostPropertiesRequest
        /// </summary>
        public Union<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest, BaseFunction>? HostProperties { get; set; }

        /// <summary>
        /// FleetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-worker.html#cfn-deadline-worker-fleetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FleetId { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-worker.html#cfn-deadline-worker-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-worker.html#cfn-deadline-worker-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Deadline.WorkerTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Deadline.WorkerTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WorkerTypes
    {
        public class HostPropertiesRequest : Humidifier.Base.BaseSubResource, IHaveDeadlineWorkerTypesIpAddressesIpAddresses, IHaveHostName
        {
            /// <summary>
            /// IpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-worker-hostpropertiesrequest.html#cfn-deadline-worker-hostpropertiesrequest-ipaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IpAddresses
            /// </summary>
            public Union<Humidifier.Deadline.WorkerTypes.IpAddresses, BaseFunction>? IpAddresses { get; set; }
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-worker-hostpropertiesrequest.html#cfn-deadline-worker-hostpropertiesrequest-hostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostName { get; set; }
        }

        public class IpAddresses : Humidifier.Base.BaseSubResource, IHaveStringListOfIpV6Addresses, IHaveStringListOfIpV4Addresses
        {
            /// <summary>
            /// IpV6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-worker-ipaddresses.html#cfn-deadline-worker-ipaddresses-ipv6addresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IpV6Addresses { get; set; }
            /// <summary>
            /// IpV4Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-worker-ipaddresses.html#cfn-deadline-worker-ipaddresses-ipv4addresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IpV4Addresses { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-worker-tagsitems.html#cfn-deadline-worker-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-worker-tagsitems.html#cfn-deadline-worker-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}