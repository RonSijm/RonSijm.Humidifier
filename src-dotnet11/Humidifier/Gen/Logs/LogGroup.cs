namespace Humidifier.Logs
{
    using global::System.Collections.Generic;

    public class LogGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveJsonListOfFieldIndexPolicies, IHaveRetentionInDays_Integer, IHaveKmsKeyId, IHaveBearerTokenAuthenticationEnabled_Boolean, IHaveLogGroupClass, IHaveResourcePolicyDocument_Json, IHaveLogGroupName, IHaveDeletionProtectionEnabled_Boolean, IHaveDataProtectionPolicy_Json
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Logs.LogGroup; }
        /// <summary>
        /// FieldIndexPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-fieldindexpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: Json
        /// </summary>
        public Union<IReadOnlyList<object>, IReadOnlyList<Union<object, BaseFunction>>, BaseFunction>? FieldIndexPolicies { get; set; }
        /// <summary>
        /// RetentionInDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-retentionindays
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetentionInDays { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// BearerTokenAuthenticationEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-bearertokenauthenticationenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? BearerTokenAuthenticationEnabled { get; set; }
        /// <summary>
        /// LogGroupClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-loggroupclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogGroupClass { get; set; }
        /// <summary>
        /// ResourcePolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-resourcepolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ResourcePolicyDocument { get; set; }
        public Union<string, BaseFunction>? LogGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// DataProtectionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-logs-loggroup-dataprotectionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? DataProtectionPolicy { get; set; }
    }
}