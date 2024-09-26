namespace Humidifier.Logs
{
    using System.Collections.Generic;

    public class LogStream : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveLogGroupName, IHaveLogStreamName
    {
        public override string AWSTypeName { get => AWS.Logs.LogStream; }
        public dynamic LogStreamName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-logstream.html#cfn-logs-logstream-loggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LogGroupName { get; set; }
    }
}