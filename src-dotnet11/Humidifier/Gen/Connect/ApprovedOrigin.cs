namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class ApprovedOrigin : Humidifier.Base.BaseResource, IHaveOrigin, IHaveInstanceId
    {
        public override string AWSTypeName { get => AWS.Connect.ApprovedOrigin; }

        /// <summary>
        /// Origin
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-approvedorigin.html#cfn-connect-approvedorigin-origin
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Origin { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-approvedorigin.html#cfn-connect-approvedorigin-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceId { get; set; }
    }
}