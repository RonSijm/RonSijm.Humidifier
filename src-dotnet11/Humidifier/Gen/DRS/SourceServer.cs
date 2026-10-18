namespace Humidifier.DRS
{
    using global::System.Collections.Generic;
    using SourceServerTypes;

    public class SourceServer : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AgentVersion =  "AgentVersion" ;
            public static string SourceServerID =  "SourceServerID" ;
            public static string DataReplicationInfo =  "DataReplicationInfo" ;
            public static string ReplicationDirection =  "ReplicationDirection" ;
            public static string Arn =  "Arn" ;
            public static string SourceProperties =  "SourceProperties" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.DRS.SourceServer; }
    }

    namespace SourceServerTypes
    {
        public class CPU : Humidifier.Base.BaseSubResource, IHaveCores_Integer, IHaveModelName
        {
            /// <summary>
            /// Cores
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-cpu.html#cfn-drs-sourceserver-cpu-cores
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Cores { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-cpu.html#cfn-drs-sourceserver-cpu-modelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelName { get; set; }
        }

        public class DataReplicationInfo : Humidifier.Base.BaseSubResource, IHaveDataReplicationState
        {
            /// <summary>
            /// DataReplicationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-datareplicationinfo.html#cfn-drs-sourceserver-datareplicationinfo-datareplicationstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataReplicationState { get; set; }
        }

        public class Disk : Humidifier.Base.BaseSubResource, IHaveBytes_Integer, IHaveDeviceName
        {
            /// <summary>
            /// Bytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-disk.html#cfn-drs-sourceserver-disk-bytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bytes { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-disk.html#cfn-drs-sourceserver-disk-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class IdentificationHints : Humidifier.Base.BaseSubResource, IHaveFqdn, IHaveAwsInstanceID, IHaveHostname, IHaveVmWareUuid
        {
            /// <summary>
            /// Fqdn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-identificationhints.html#cfn-drs-sourceserver-identificationhints-fqdn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Fqdn { get; set; }
            /// <summary>
            /// AwsInstanceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-identificationhints.html#cfn-drs-sourceserver-identificationhints-awsinstanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsInstanceID { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-identificationhints.html#cfn-drs-sourceserver-identificationhints-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Hostname { get; set; }
            /// <summary>
            /// VmWareUuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-identificationhints.html#cfn-drs-sourceserver-identificationhints-vmwareuuid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VmWareUuid { get; set; }
        }

        public class NetworkInterface : Humidifier.Base.BaseSubResource, IHaveIsPrimary_Boolean, IHaveMacAddress, IHaveStringListOfIps
        {
            /// <summary>
            /// IsPrimary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-networkinterface.html#cfn-drs-sourceserver-networkinterface-isprimary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsPrimary { get; set; }
            /// <summary>
            /// MacAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-networkinterface.html#cfn-drs-sourceserver-networkinterface-macaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MacAddress { get; set; }
            /// <summary>
            /// Ips
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-networkinterface.html#cfn-drs-sourceserver-networkinterface-ips
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ips { get; set; }
        }

        public class OS : Humidifier.Base.BaseSubResource, IHaveFullString
        {
            /// <summary>
            /// FullString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-os.html#cfn-drs-sourceserver-os-fullstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FullString { get; set; }
        }

        public class SourceProperties : Humidifier.Base.BaseSubResource, IHaveRecommendedInstanceType, IHaveDRSSourceServerTypesIdentificationHintsIdentificationHints, IHaveDRSSourceServerTypesOSOs, IHaveSupportsNitroInstances_Boolean, IHaveListOfDRSSourceServerTypesNetworkInterfaceNetworkInterfaces, IHaveListOfDRSSourceServerTypesDiskDisks, IHaveRamBytes_Integer, IHaveListOfDRSSourceServerTypesCPUCpus, IHaveLastUpdatedDateTime
        {
            /// <summary>
            /// RecommendedInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-recommendedinstancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecommendedInstanceType { get; set; }
            /// <summary>
            /// IdentificationHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-identificationhints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentificationHints
            /// </summary>
            public Union<Humidifier.DRS.SourceServerTypes.IdentificationHints, BaseFunction>? IdentificationHints { get; set; }
            /// <summary>
            /// Os
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-os
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OS
            /// </summary>
            public Union<Humidifier.DRS.SourceServerTypes.OS, BaseFunction>? Os { get; set; }
            /// <summary>
            /// SupportsNitroInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-supportsnitroinstances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SupportsNitroInstances { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-networkinterfaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkInterface
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DRS.SourceServerTypes.NetworkInterface>, IReadOnlyList<Union<Humidifier.DRS.SourceServerTypes.NetworkInterface, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// Disks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-disks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Disk
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DRS.SourceServerTypes.Disk>, IReadOnlyList<Union<Humidifier.DRS.SourceServerTypes.Disk, BaseFunction>>, BaseFunction>? Disks { get; set; }
            /// <summary>
            /// RamBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-rambytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RamBytes { get; set; }
            /// <summary>
            /// Cpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-cpus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CPU
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DRS.SourceServerTypes.CPU>, IReadOnlyList<Union<Humidifier.DRS.SourceServerTypes.CPU, BaseFunction>>, BaseFunction>? Cpus { get; set; }
            /// <summary>
            /// LastUpdatedDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-sourceserver-sourceproperties.html#cfn-drs-sourceserver-sourceproperties-lastupdateddatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastUpdatedDateTime { get; set; }
        }
    }
}