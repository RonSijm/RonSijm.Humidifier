namespace Humidifier.CloudHSMV2
{
    using global::System.Collections.Generic;

    public class Backup : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string BackupState =  "BackupState" ;
            public static string NeverExpires =  "NeverExpires" ;
            public static string ClusterId =  "ClusterId" ;
            public static string BackupId =  "BackupId" ;
            public static string Arn =  "Arn" ;
            public static string CreateTimestamp =  "CreateTimestamp" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.CloudHSMV2.Backup; }
    }
}