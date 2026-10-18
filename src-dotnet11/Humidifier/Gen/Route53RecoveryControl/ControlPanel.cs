namespace Humidifier.Route53RecoveryControl
{
    using global::System.Collections.Generic;

    public class ControlPanel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveClusterArn, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ControlPanelArn =  "ControlPanelArn" ;
            public static string DefaultControlPanel =  "DefaultControlPanel" ;
            public static string RoutingControlCount =  "RoutingControlCount" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryControl.ControlPanel; }
        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-controlpanel.html#cfn-route53recoverycontrol-controlpanel-clusterarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-controlpanel.html#cfn-route53recoverycontrol-controlpanel-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}