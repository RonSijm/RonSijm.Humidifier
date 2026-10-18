namespace Humidifier.CognitoSync
{
    using global::System.Collections.Generic;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDatasetName, IHaveIdentityId, IHaveIdentityPoolId
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
        public Union<string, BaseFunction>? DatasetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IdentityId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognitosync-dataset.html#cfn-cognitosync-dataset-identityid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityId { get; set; }
        /// <summary>
        /// IdentityPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognitosync-dataset.html#cfn-cognitosync-dataset-identitypoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityPoolId { get; set; }
    }
}