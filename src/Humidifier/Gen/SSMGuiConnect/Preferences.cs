namespace Humidifier.SSMGuiConnect
{
    using global::System.Collections.Generic;
    using PreferencesTypes;

    public class Preferences : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.SSMGuiConnect.Preferences; }
        /// <summary>
        /// ConnectionRecordingPreferences
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmguiconnect-preferences.html#cfn-ssmguiconnect-preferences-connectionrecordingpreferences
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectionRecordingPreferences
        /// </summary>
        public Humidifier.SSMGuiConnect.PreferencesTypes.ConnectionRecordingPreferences ConnectionRecordingPreferences { get; set; }
    }

    namespace PreferencesTypes
    {
        public class ConnectionRecordingPreferences : Humidifier.Base.BaseSubResource, IHaveKMSKeyArn
        {
            /// <summary>
            /// KMSKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmguiconnect-preferences-connectionrecordingpreferences.html#cfn-ssmguiconnect-preferences-connectionrecordingpreferences-kmskeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KMSKeyArn { get; set; }
            /// <summary>
            /// RecordingDestinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmguiconnect-preferences-connectionrecordingpreferences.html#cfn-ssmguiconnect-preferences-connectionrecordingpreferences-recordingdestinations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecordingDestinations
            /// </summary>
            public Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations RecordingDestinations { get; set; }
        }

        public class RecordingDestinations : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Buckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmguiconnect-preferences-recordingdestinations.html#cfn-ssmguiconnect-preferences-recordingdestinations-s3buckets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: S3Bucket
            /// </summary>
            public List<Humidifier.SSMGuiConnect.PreferencesTypes.S3Bucket> S3Buckets { get; set; }
        }

        public class S3Bucket : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketOwner
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmguiconnect-preferences-s3bucket.html#cfn-ssmguiconnect-preferences-s3bucket-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmguiconnect-preferences-s3bucket.html#cfn-ssmguiconnect-preferences-s3bucket-bucketowner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwner { get; set; }
        }
    }
}