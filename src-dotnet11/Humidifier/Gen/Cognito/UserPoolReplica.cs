namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;

    public class UserPoolReplica : Humidifier.Base.BaseResource, IHaveUserPoolId, IHaveRegionName, IHaveStringDictionaryOfUserPoolTagsAtCreate
    {
        public override string AWSTypeName { get => AWS.Cognito.UserPoolReplica; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolreplica.html#cfn-cognito-userpoolreplica-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }

        /// <summary>
        /// RegionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolreplica.html#cfn-cognito-userpoolreplica-regionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RegionName { get; set; }
        /// <summary>
        /// UserPoolTagsAtCreate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolreplica.html#cfn-cognito-userpoolreplica-userpooltagsatcreate
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? UserPoolTagsAtCreate { get; set; }
    }
}