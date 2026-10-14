namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;

    public class AudienceModel : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Description =  "Description" ;
            public static string KmsKeyArn =  "KmsKeyArn" ;
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string TrainingDataEndTime =  "TrainingDataEndTime" ;
            public static string TrainingDatasetArn =  "TrainingDatasetArn" ;
            public static string TrainingDataStartTime =  "TrainingDataStartTime" ;
            public static string Tags =  "Tags" ;
            public static string AudienceModelArn =  "AudienceModelArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.AudienceModel; }
    }
}