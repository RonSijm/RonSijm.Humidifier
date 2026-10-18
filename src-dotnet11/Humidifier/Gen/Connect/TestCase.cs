namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using TestCaseTypes;

    public class TestCase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveDescription, IHaveContent, IHaveInstanceArn, IHaveConnectTestCaseTypesEntryPointEntryPoint, IHaveInitializationData, IHaveName
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
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-content
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Content { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// EntryPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-entrypoint
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EntryPoint
        /// </summary>
        public Union<Humidifier.Connect.TestCaseTypes.EntryPoint, BaseFunction>? EntryPoint { get; set; }
        /// <summary>
        /// InitializationData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-initializationdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InitializationData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-testcase.html#cfn-connect-testcase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TestCaseTypes
    {
        public class ChatEntryPointParameters : Humidifier.Base.BaseSubResource, IHaveFlowId
        {
            /// <summary>
            /// FlowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-chatentrypointparameters.html#cfn-connect-testcase-chatentrypointparameters-flowid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowId { get; set; }
        }

        public class EntryPoint : Humidifier.Base.BaseSubResource, IHaveType, IHaveConnectTestCaseTypesChatEntryPointParametersChatEntryPointParameters, IHaveConnectTestCaseTypesVoiceCallEntryPointParametersVoiceCallEntryPointParameters
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-entrypoint.html#cfn-connect-testcase-entrypoint-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ChatEntryPointParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-entrypoint.html#cfn-connect-testcase-entrypoint-chatentrypointparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChatEntryPointParameters
            /// </summary>
            public Union<Humidifier.Connect.TestCaseTypes.ChatEntryPointParameters, BaseFunction>? ChatEntryPointParameters { get; set; }
            /// <summary>
            /// VoiceCallEntryPointParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-entrypoint.html#cfn-connect-testcase-entrypoint-voicecallentrypointparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VoiceCallEntryPointParameters
            /// </summary>
            public Union<Humidifier.Connect.TestCaseTypes.VoiceCallEntryPointParameters, BaseFunction>? VoiceCallEntryPointParameters { get; set; }
        }

        public class VoiceCallEntryPointParameters : Humidifier.Base.BaseSubResource, IHaveFlowId, IHaveSourcePhoneNumber, IHaveDestinationPhoneNumber
        {
            /// <summary>
            /// FlowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-voicecallentrypointparameters.html#cfn-connect-testcase-voicecallentrypointparameters-flowid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowId { get; set; }
            /// <summary>
            /// SourcePhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-voicecallentrypointparameters.html#cfn-connect-testcase-voicecallentrypointparameters-sourcephonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePhoneNumber { get; set; }
            /// <summary>
            /// DestinationPhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-testcase-voicecallentrypointparameters.html#cfn-connect-testcase-voicecallentrypointparameters-destinationphonenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPhoneNumber { get; set; }
        }
    }
}