namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;

    public class Ingestion : Humidifier.Base.BaseResource, IHaveDataSetId
    {
        public class Attributes
        {
            public static string IngestionSizeInBytes =  "IngestionSizeInBytes" ;
            public static string RowsIngested =  "RowsIngested" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string IngestionStatus =  "IngestionStatus" ;
            public static string RowsDropped =  "RowsDropped" ;
            public static string TotalRowsInDataset =  "TotalRowsInDataset" ;
            public static string RequestSource =  "RequestSource" ;
            public static string Arn =  "Arn" ;
            public static string IngestionTimeInSeconds =  "IngestionTimeInSeconds" ;
            public static string RequestType =  "RequestType" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.Ingestion; }

        /// <summary>
        /// IngestionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-ingestion.html#cfn-quicksight-ingestion-ingestionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IngestionId { get; set; }

        /// <summary>
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-ingestion.html#cfn-quicksight-ingestion-datasetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataSetId { get; set; }
    }
}