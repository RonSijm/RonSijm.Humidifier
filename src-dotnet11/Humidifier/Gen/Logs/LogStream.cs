namespace Humidifier.Logs
{
    using global::System.Collections.Generic;

    public class LogStream : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveLogStreamName, IHaveLogGroupName
    {
        public override string AWSTypeName { get => AWS.Logs.LogStream; }
        public Union<string, BaseFunction>? LogStreamName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-logstream.html#cfn-logs-logstream-loggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LogGroupName { get; set; }
    }
}