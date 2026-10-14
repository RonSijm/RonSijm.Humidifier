namespace Humidifier.CognitoSync
{
    using global::System.Collections.Generic;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDatasetName, IHaveIdentityPoolId
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string LastModifiedDate =  "LastModifiedDate" ;
            public static string LastModifiedBy =  "LastModifiedBy" ;
            public static string DataStorage =  "DataStorage" ;
            public static string NumRecords =  "NumRecords" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CognitoSync.Dataset; }
        public dynamic DatasetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IdentityId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognitosync-dataset.html#cfn-cognitosync-dataset-identityid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityId { get; set; }
        /// <summary>
        /// IdentityPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognitosync-dataset.html#cfn-cognitosync-dataset-identitypoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityPoolId { get; set; }
    }
}