namespace Humidifier.S3Tables
{
    using System.Collections.Generic;
    using TableBucketTypes;

    public class TableBucket : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string TableBucketARN =  "TableBucketARN" ;
        }

        public override string AWSTypeName { get => AWS.S3Tables.TableBucket; }
        public dynamic TableBucketName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// UnreferencedFileRemoval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucket.html#cfn-s3tables-tablebucket-unreferencedfileremoval
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UnreferencedFileRemoval
        /// </summary>
        public Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval UnreferencedFileRemoval { get; set; }
    }

    namespace TableBucketTypes
    {
        public class UnreferencedFileRemoval : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveNoncurrentDays
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-unreferencedfileremoval.html#cfn-s3tables-tablebucket-unreferencedfileremoval-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// NoncurrentDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-unreferencedfileremoval.html#cfn-s3tables-tablebucket-unreferencedfileremoval-noncurrentdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NoncurrentDays { get; set; }
            /// <summary>
            /// UnreferencedDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-unreferencedfileremoval.html#cfn-s3tables-tablebucket-unreferencedfileremoval-unreferenceddays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UnreferencedDays { get; set; }
        }
    }
}