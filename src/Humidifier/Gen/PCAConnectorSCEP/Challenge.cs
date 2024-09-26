namespace Humidifier.PCAConnectorSCEP
{
    using System.Collections.Generic;

    public class Challenge : Humidifier.Base.BaseResource, IHaveConnectorArn
    {
        public class Attributes
        {
            public static string ChallengeArn =  "ChallengeArn" ;
        }

        public override string AWSTypeName { get => AWS.PCAConnectorSCEP.Challenge; }

        /// <summary>
        /// ConnectorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorscep-challenge.html#cfn-pcaconnectorscep-challenge-connectorarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectorArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorscep-challenge.html#cfn-pcaconnectorscep-challenge-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }
}