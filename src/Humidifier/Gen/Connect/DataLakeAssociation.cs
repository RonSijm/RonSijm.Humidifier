namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class DataLakeAssociation : Humidifier.Base.BaseResource, IHaveInstanceId, IHaveDataSetId
    {
        public class Attributes
        {
            public static string ResourceShareId =  "ResourceShareId" ;
            public static string ResourceShareArn =  "ResourceShareArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.DataLakeAssociation; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datalakeassociation.html#cfn-connect-datalakeassociation-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }

        /// <summary>
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datalakeassociation.html#cfn-connect-datalakeassociation-datasetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataSetId { get; set; }
        /// <summary>
        /// TargetAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datalakeassociation.html#cfn-connect-datalakeassociation-targetaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetAccountId { get; set; }
    }
}