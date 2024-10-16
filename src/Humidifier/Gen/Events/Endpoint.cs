namespace Humidifier.Events
{
    using System.Collections.Generic;
    using EndpointTypes;

    public class Endpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveRoleArn
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string StateReason =  "StateReason" ;
            public static string EndpointId =  "EndpointId" ;
            public static string Arn =  "Arn" ;
            public static string EndpointUrl =  "EndpointUrl" ;
        }

        public override string AWSTypeName { get => AWS.Events.Endpoint; }

        /// <summary>
        /// EventBuses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-endpoint.html#cfn-events-endpoint-eventbuses
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EndpointEventBus
        /// </summary>
        [Required]
        public List<Humidifier.Events.EndpointTypes.EndpointEventBus> EventBuses { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-endpoint.html#cfn-events-endpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ReplicationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-endpoint.html#cfn-events-endpoint-replicationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfig
        /// </summary>
        public Humidifier.Events.EndpointTypes.ReplicationConfig ReplicationConfig { get; set; }

        /// <summary>
        /// RoutingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-endpoint.html#cfn-events-endpoint-routingconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RoutingConfig
        /// </summary>
        [Required]
        public Humidifier.Events.EndpointTypes.RoutingConfig RoutingConfig { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-endpoint.html#cfn-events-endpoint-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace EndpointTypes
    {
        public class EndpointEventBus : Humidifier.Base.BaseSubResource, IHaveEventBusArn
        {
            /// <summary>
            /// EventBusArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-endpoint-endpointeventbus.html#cfn-events-endpoint-endpointeventbus-eventbusarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventBusArn { get; set; }
        }

        public class FailoverConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Secondary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-endpoint-failoverconfig.html#cfn-events-endpoint-failoverconfig-secondary
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Secondary
            /// </summary>
            public Humidifier.Events.EndpointTypes.Secondary Secondary { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-endpoint-failoverconfig.html#cfn-events-endpoint-failoverconfig-primary
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Primary
            /// </summary>
            public Humidifier.Events.EndpointTypes.Primary Primary { get; set; }
        }

        public class Primary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-endpoint-primary.html#cfn-events-endpoint-primary-healthcheck
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HealthCheck { get; set; }
        }

        public class ReplicationConfig : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-endpoint-replicationconfig.html#cfn-events-endpoint-replicationconfig-state
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class RoutingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FailoverConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-endpoint-routingconfig.html#cfn-events-endpoint-routingconfig-failoverconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FailoverConfig
            /// </summary>
            public Humidifier.Events.EndpointTypes.FailoverConfig FailoverConfig { get; set; }
        }

        public class Secondary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Route
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-endpoint-secondary.html#cfn-events-endpoint-secondary-route
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Route { get; set; }
        }
    }
}