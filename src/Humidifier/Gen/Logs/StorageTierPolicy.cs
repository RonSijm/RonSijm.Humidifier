namespace Humidifier.Logs
{
    using global::System.Collections.Generic;

    public class StorageTierPolicy : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.Logs.StorageTierPolicy; }

        /// <summary>
        /// StorageTier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-storagetierpolicy.html#cfn-logs-storagetierpolicy-storagetier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StorageTier { get; set; }
    }
}