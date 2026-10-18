namespace Humidifier.RoboMaker
{
    using global::System.Collections.Generic;

    public class RobotApplicationVersion : Humidifier.Base.BaseResource, IHaveCurrentRevisionId, IHaveApplication
    {
        public class Attributes
        {
            public static string ApplicationVersion =  "ApplicationVersion" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RoboMaker.RobotApplicationVersion; }
        /// <summary>
        /// CurrentRevisionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplicationversion.html#cfn-robomaker-robotapplicationversion-currentrevisionid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CurrentRevisionId { get; set; }

        /// <summary>
        /// Application
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplicationversion.html#cfn-robomaker-robotapplicationversion-application
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Application { get; set; }
    }
}