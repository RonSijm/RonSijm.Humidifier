namespace Humidifier.KafkaConnect
{
    using global::System.Collections.Generic;
    using ConnectorOperationTypes;

    public class ConnectorOperation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string EndTime =  "EndTime" ;
            public static string TargetWorkerSetting =  "TargetWorkerSetting" ;
            public static string ConnectorOperationArn =  "ConnectorOperationArn" ;
            public static string ConnectorOperationState =  "ConnectorOperationState" ;
            public static string OriginWorkerSetting =  "OriginWorkerSetting" ;
            public static string ConnectorArn =  "ConnectorArn" ;
            public static string OperationSteps =  "OperationSteps" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ConnectorOperationType =  "ConnectorOperationType" ;
        }

        public override string AWSTypeName { get => AWS.KafkaConnect.ConnectorOperation; }
    }

    namespace ConnectorOperationTypes
    {
        public class CapacityDescription : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorOperationTypesProvisionedCapacityDescriptionProvisionedCapacity
        {
            /// <summary>
            /// ProvisionedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connectoroperation-capacitydescription.html#cfn-kafkaconnect-connectoroperation-capacitydescription-provisionedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProvisionedCapacityDescription
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorOperationTypes.ProvisionedCapacityDescription, BaseFunction>? ProvisionedCapacity { get; set; }
        }

        public class ConnectorOperationStep : Humidifier.Base.BaseSubResource, IHaveStepState, IHaveStepType
        {
            /// <summary>
            /// StepState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connectoroperation-connectoroperationstep.html#cfn-kafkaconnect-connectoroperation-connectoroperationstep-stepstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StepState { get; set; }
            /// <summary>
            /// StepType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connectoroperation-connectoroperationstep.html#cfn-kafkaconnect-connectoroperation-connectoroperationstep-steptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StepType { get; set; }
        }

        public class ProvisionedCapacityDescription : Humidifier.Base.BaseSubResource, IHaveWorkerCount_Integer, IHaveMcuCount_Integer
        {
            /// <summary>
            /// WorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connectoroperation-provisionedcapacitydescription.html#cfn-kafkaconnect-connectoroperation-provisionedcapacitydescription-workercount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WorkerCount { get; set; }
            /// <summary>
            /// McuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connectoroperation-provisionedcapacitydescription.html#cfn-kafkaconnect-connectoroperation-provisionedcapacitydescription-mcucount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? McuCount { get; set; }
        }

        public class WorkerSetting : Humidifier.Base.BaseSubResource, IHaveKafkaConnectConnectorOperationTypesCapacityDescriptionCapacity
        {
            /// <summary>
            /// Capacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kafkaconnect-connectoroperation-workersetting.html#cfn-kafkaconnect-connectoroperation-workersetting-capacity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityDescription
            /// </summary>
            public Union<Humidifier.KafkaConnect.ConnectorOperationTypes.CapacityDescription, BaseFunction>? Capacity { get; set; }
        }
    }
}