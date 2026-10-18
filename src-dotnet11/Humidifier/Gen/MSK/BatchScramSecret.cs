namespace Humidifier.MSK
{
    using global::System.Collections.Generic;

    public class BatchScramSecret : Humidifier.Base.BaseResource, IHaveClusterArn, IHaveStringListOfSecretArnList
    {
        public override string AWSTypeName { get => AWS.MSK.BatchScramSecret; }

        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-batchscramsecret.html#cfn-msk-batchscramsecret-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterArn { get; set; }
        /// <summary>
        /// SecretArnList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-batchscramsecret.html#cfn-msk-batchscramsecret-secretarnlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecretArnList { get; set; }
    }
}