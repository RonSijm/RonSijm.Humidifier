namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;

    public class Hub : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string SubscribedAt =  "SubscribedAt" ;
            public static string ARN =  "ARN" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.Hub; }
        /// <summary>
        /// ControlFindingGenerator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html#cfn-securityhub-hub-controlfindinggenerator
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ControlFindingGenerator { get; set; }
        /// <summary>
        /// EnableDefaultStandards
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html#cfn-securityhub-hub-enabledefaultstandards
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDefaultStandards { get; set; }
        /// <summary>
        /// AutoEnableControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html#cfn-securityhub-hub-autoenablecontrols
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoEnableControls { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html#cfn-securityhub-hub-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }
}