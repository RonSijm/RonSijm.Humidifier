namespace Humidifier.MedicalImaging
{
    using global::System.Collections.Generic;

    public class ImageSet : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string ImageSetId =  "ImageSetId" ;
            public static string ImageSetWorkflowStatus =  "ImageSetWorkflowStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string IsPrimary =  "IsPrimary" ;
            public static string StorageTier =  "StorageTier" ;
            public static string ImageSetArn =  "ImageSetArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Tags =  "Tags" ;
            public static string ImageSetState =  "ImageSetState" ;
            public static string LastAccessedAt =  "LastAccessedAt" ;
        }

        public override string AWSTypeName { get => AWS.MedicalImaging.ImageSet; }
        /// <summary>
        /// DatastoreId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medicalimaging-imageset.html#cfn-medicalimaging-imageset-datastoreid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatastoreId { get; set; }
    }
}