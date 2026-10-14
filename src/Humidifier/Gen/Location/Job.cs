namespace Humidifier.Location
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveAction, IHaveExecutionRoleArn
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Location.Job; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-job.html#cfn-location-job-executionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRoleArn { get; set; }

        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-job.html#cfn-location-job-action
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Action { get; set; }

        /// <summary>
        /// InputOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-job.html#cfn-location-job-inputoptions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobInputOptions
        /// </summary>
        [Required]
        public Humidifier.Location.JobTypes.JobInputOptions InputOptions { get; set; }
        /// <summary>
        /// ActionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-job.html#cfn-location-job-actionoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobActionOptions
        /// </summary>
        public Humidifier.Location.JobTypes.JobActionOptions ActionOptions { get; set; }

        /// <summary>
        /// OutputOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-job.html#cfn-location-job-outputoptions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobOutputOptions
        /// </summary>
        [Required]
        public Humidifier.Location.JobTypes.JobOutputOptions OutputOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-job.html#cfn-location-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace JobTypes
    {
        public class JobActionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ValidateAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-job-jobactionoptions.html#cfn-location-job-jobactionoptions-validateaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ValidateAddressActionOptions
            /// </summary>
            public Humidifier.Location.JobTypes.ValidateAddressActionOptions ValidateAddress { get; set; }
        }

        public class JobInputOptions : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveLocation
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-job-jobinputoptions.html#cfn-location-job-jobinputoptions-format
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-job-jobinputoptions.html#cfn-location-job-jobinputoptions-location
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Location { get; set; }
        }

        public class JobOutputOptions : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveLocation
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-job-joboutputoptions.html#cfn-location-job-joboutputoptions-format
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-job-joboutputoptions.html#cfn-location-job-joboutputoptions-location
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Location { get; set; }
        }

        public class ValidateAddressActionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdditionalFeatures
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-job-validateaddressactionoptions.html#cfn-location-job-validateaddressactionoptions-additionalfeatures
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdditionalFeatures { get; set; }
        }
    }
}