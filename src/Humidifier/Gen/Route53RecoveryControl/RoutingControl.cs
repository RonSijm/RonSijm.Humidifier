namespace Humidifier.Route53RecoveryControl
{
    using System.Collections.Generic;

    public class RoutingControl : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveClusterArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string RoutingControlArn =  "RoutingControlArn" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryControl.RoutingControl; }
        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-routingcontrol.html#cfn-route53recoverycontrol-routingcontrol-clusterarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterArn { get; set; }
        /// <summary>
        /// ControlPanelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-routingcontrol.html#cfn-route53recoverycontrol-routingcontrol-controlpanelarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ControlPanelArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}