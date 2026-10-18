namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;
    using DataShareTypes;

    public class DataShare : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ProducerArn =  "ProducerArn" ;
            public static string AllowPubliclyAccessibleConsumers =  "AllowPubliclyAccessibleConsumers" ;
            public static string DataShareArn =  "DataShareArn" ;
            public static string DataShareAssociations =  "DataShareAssociations" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.DataShare; }
    }

    namespace DataShareTypes
    {
        public class DataShareAssociation : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStatusChangeDate, IHaveCreatedDate, IHaveConsumerIdentifier
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-datashare-datashareassociation.html#cfn-redshift-datashare-datashareassociation-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StatusChangeDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-datashare-datashareassociation.html#cfn-redshift-datashare-datashareassociation-statuschangedate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusChangeDate { get; set; }
            /// <summary>
            /// CreatedDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-datashare-datashareassociation.html#cfn-redshift-datashare-datashareassociation-createddate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedDate { get; set; }
            /// <summary>
            /// ConsumerIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-datashare-datashareassociation.html#cfn-redshift-datashare-datashareassociation-consumeridentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConsumerIdentifier { get; set; }
        }
    }
}