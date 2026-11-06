namespace Humidifier.OSIS
{
    using global::System.Collections.Generic;
    using PipelineEndpointTypes;

    public class PipelineEndpoint : Humidifier.Base.BaseResource, IHavePipelineArn, IHaveOSISPipelineEndpointTypesVpcOptionsVpcOptions
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IngestEndpointUrl =  "IngestEndpointUrl" ;
            public static string VpcId =  "VpcId" ;
            public static string EndpointId =  "EndpointId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.OSIS.PipelineEndpoint; }

        /// <summary>
        /// PipelineArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipelineendpoint.html#cfn-osis-pipelineendpoint-pipelinearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PipelineArn { get; set; }

        /// <summary>
        /// VpcOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-osis-pipelineendpoint.html#cfn-osis-pipelineendpoint-vpcoptions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: VpcOptions
        /// </summary>
        [Required]
        public Union<Humidifier.OSIS.PipelineEndpointTypes.VpcOptions, BaseFunction>? VpcOptions { get; set; }
    }

    namespace PipelineEndpointTypes
    {
        public class VpcOptions : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipelineendpoint-vpcoptions.html#cfn-osis-pipelineendpoint-vpcoptions-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-osis-pipelineendpoint-vpcoptions.html#cfn-osis-pipelineendpoint-vpcoptions-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}