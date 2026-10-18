namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;

    public class TimeSeries : Humidifier.Base.BaseResource, IHaveAssetId
    {
        public class Attributes
        {
            public static string Alias =  "Alias" ;
            public static string TimeSeriesLastUpdateDate =  "TimeSeriesLastUpdateDate" ;
            public static string DataType =  "DataType" ;
            public static string TimeSeriesArn =  "TimeSeriesArn" ;
            public static string TimeSeriesId =  "TimeSeriesId" ;
            public static string TimeSeriesCreationDate =  "TimeSeriesCreationDate" ;
            public static string Tags =  "Tags" ;
            public static string PropertyId =  "PropertyId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.TimeSeries; }
        /// <summary>
        /// AssetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-timeseries.html#cfn-iotsitewise-timeseries-assetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssetId { get; set; }
    }
}