namespace Humidifier.PCAConnectorSCEP
{
    using global::System.Collections.Generic;

    public class Challenge : Humidifier.Base.BaseResource, IHaveConnectorArn, IHaveStringDictionaryOfTags
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
        public Union<string, BaseFunction>? ConnectorArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorscep-challenge.html#cfn-pcaconnectorscep-challenge-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}