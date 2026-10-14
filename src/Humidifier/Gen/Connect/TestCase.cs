namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using TestCaseTypes;

    public class TestCase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveStatus, IHaveInstanceArn, IHaveContent
    {
        public class Attributes
        {
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string TestCaseArn =  "TestCaseArn" ;
            public static string LastModifiedRegion =  "LastModifiedRegion" ;
        }

        public override string AWSTypeName { get => AWS.Connect.TestCase; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-content
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Content { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// EntryPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-entrypoint
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EntryPoint
        /// </summary>
        public Humidifier.Connect.TestCaseTypes.EntryPoint EntryPoint { get; set; }
        /// <summary>
        /// InitializationData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-initializationdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InitializationData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace TestCaseTypes
    {
        public class ChatEntryPointParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FlowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-chatentrypointparameters.html#cfn-connect-testcase-chatentrypointparameters-flowid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowId { get; set; }
        }

        public class EntryPoint : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-entrypoint.html#cfn-connect-testcase-entrypoint-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// ChatEntryPointParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-entrypoint.html#cfn-connect-testcase-entrypoint-chatentrypointparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChatEntryPointParameters
            /// </summary>
            public Humidifier.Connect.TestCaseTypes.ChatEntryPointParameters ChatEntryPointParameters { get; set; }
            /// <summary>
            /// VoiceCallEntryPointParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-entrypoint.html#cfn-connect-testcase-entrypoint-voicecallentrypointparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VoiceCallEntryPointParameters
            /// </summary>
            public Humidifier.Connect.TestCaseTypes.VoiceCallEntryPointParameters VoiceCallEntryPointParameters { get; set; }
        }

        public class VoiceCallEntryPointParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FlowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-voicecallentrypointparameters.html#cfn-connect-testcase-voicecallentrypointparameters-flowid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowId { get; set; }
            /// <summary>
            /// SourcePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-voicecallentrypointparameters.html#cfn-connect-testcase-voicecallentrypointparameters-sourcephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePhoneNumber { get; set; }
            /// <summary>
            /// DestinationPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-voicecallentrypointparameters.html#cfn-connect-testcase-voicecallentrypointparameters-destinationphonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPhoneNumber { get; set; }
        }
    }
}