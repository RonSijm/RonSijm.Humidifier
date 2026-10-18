namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using SourceServerTypes;

    public class SourceServer : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string LifeCycle =  "LifeCycle" ;
            public static string FqdnForActionFramework =  "FqdnForActionFramework" ;
            public static string ApplicationID =  "ApplicationID" ;
            public static string Tags =  "Tags" ;
            public static string LaunchedInstance =  "LaunchedInstance" ;
            public static string Arn =  "Arn" ;
            public static string ReplicationType =  "ReplicationType" ;
            public static string SourceServerID =  "SourceServerID" ;
            public static string ConnectorAction =  "ConnectorAction" ;
            public static string VcenterClientID =  "VcenterClientID" ;
            public static string IsArchived =  "IsArchived" ;
            public static string UserProvidedID =  "UserProvidedID" ;
            public static string DataReplicationInfo =  "DataReplicationInfo" ;
            public static string SourceProperties =  "SourceProperties" ;
        }

        public override string AWSTypeName { get => AWS.MGN.SourceServer; }
    }

    namespace SourceServerTypes
    {
        public class CPU : Humidifier.Base.BaseSubResource, IHaveCores_Double, IHaveModelName
        {
            /// <summary>
            /// Cores
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-cpu.html#cfn-mgn-sourceserver-cpu-cores
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Cores { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-cpu.html#cfn-mgn-sourceserver-cpu-modelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelName { get; set; }
        }

        public class DataReplicationInfo : Humidifier.Base.BaseSubResource, IHaveDataReplicationState, IHaveLastSnapshotDateTime, IHaveLagDuration, IHaveListOfMGNSourceServerTypesDataReplicationInfoReplicatedDiskReplicatedDisks, IHaveMGNSourceServerTypesDataReplicationInitiationDataReplicationInitiation
        {
            /// <summary>
            /// DataReplicationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-datareplicationstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataReplicationState { get; set; }
            /// <summary>
            /// LastSnapshotDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-lastsnapshotdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastSnapshotDateTime { get; set; }
            /// <summary>
            /// LagDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-lagduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LagDuration { get; set; }
            /// <summary>
            /// ReplicatedDisks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-replicateddisks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataReplicationInfoReplicatedDisk
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MGN.SourceServerTypes.DataReplicationInfoReplicatedDisk>, IReadOnlyList<Union<Humidifier.MGN.SourceServerTypes.DataReplicationInfoReplicatedDisk, BaseFunction>>, BaseFunction>? ReplicatedDisks { get; set; }
            /// <summary>
            /// DataReplicationInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-datareplicationinitiation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataReplicationInitiation
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.DataReplicationInitiation, BaseFunction>? DataReplicationInitiation { get; set; }
        }

        public class DataReplicationInfoReplicatedDisk : Humidifier.Base.BaseSubResource, IHaveBackloggedStorageBytes_Double, IHaveReplicatedStorageBytes_Double, IHaveRescannedStorageBytes_Double, IHaveDeviceName, IHaveTotalStorageBytes_Double
        {
            /// <summary>
            /// BackloggedStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-backloggedstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BackloggedStorageBytes { get; set; }
            /// <summary>
            /// ReplicatedStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-replicatedstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ReplicatedStorageBytes { get; set; }
            /// <summary>
            /// RescannedStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-rescannedstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RescannedStorageBytes { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
            /// <summary>
            /// TotalStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-totalstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TotalStorageBytes { get; set; }
        }

        public class DataReplicationInitiation : Humidifier.Base.BaseSubResource, IHaveListOfMGNSourceServerTypesDataReplicationInitiationStepSteps, IHaveStartDateTime
        {
            /// <summary>
            /// Steps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiation.html#cfn-mgn-sourceserver-datareplicationinitiation-steps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataReplicationInitiationStep
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MGN.SourceServerTypes.DataReplicationInitiationStep>, IReadOnlyList<Union<Humidifier.MGN.SourceServerTypes.DataReplicationInitiationStep, BaseFunction>>, BaseFunction>? Steps { get; set; }
            /// <summary>
            /// StartDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiation.html#cfn-mgn-sourceserver-datareplicationinitiation-startdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartDateTime { get; set; }
        }

        public class DataReplicationInitiationStep : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiationstep.html#cfn-mgn-sourceserver-datareplicationinitiationstep-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiationstep.html#cfn-mgn-sourceserver-datareplicationinitiationstep-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Disk : Humidifier.Base.BaseSubResource, IHaveBytes_Double, IHaveDeviceName
        {
            /// <summary>
            /// Bytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-disk.html#cfn-mgn-sourceserver-disk-bytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Bytes { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-disk.html#cfn-mgn-sourceserver-disk-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class IdentificationHints : Humidifier.Base.BaseSubResource, IHaveFqdn, IHaveAwsInstanceID, IHaveHostname, IHaveVmPath, IHaveVmWareUuid
        {
            /// <summary>
            /// Fqdn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-fqdn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Fqdn { get; set; }
            /// <summary>
            /// AwsInstanceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-awsinstanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsInstanceID { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Hostname { get; set; }
            /// <summary>
            /// VmPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-vmpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VmPath { get; set; }
            /// <summary>
            /// VmWareUuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-vmwareuuid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VmWareUuid { get; set; }
        }

        public class LaunchedInstance : Humidifier.Base.BaseSubResource, IHaveEc2InstanceID, IHaveFirstBoot, IHaveJobID
        {
            /// <summary>
            /// Ec2InstanceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-launchedinstance.html#cfn-mgn-sourceserver-launchedinstance-ec2instanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ec2InstanceID { get; set; }
            /// <summary>
            /// FirstBoot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-launchedinstance.html#cfn-mgn-sourceserver-launchedinstance-firstboot
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirstBoot { get; set; }
            /// <summary>
            /// JobID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-launchedinstance.html#cfn-mgn-sourceserver-launchedinstance-jobid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobID { get; set; }
        }

        public class LifeCycle : Humidifier.Base.BaseSubResource, IHaveAddedToServiceDateTime, IHaveLastSeenByServiceDateTime, IHaveElapsedReplicationDuration, IHaveMGNSourceServerTypesLifeCycleLastTestLastTest, IHaveState, IHaveFirstByteDateTime, IHaveMGNSourceServerTypesLifeCycleLastCutoverLastCutover
        {
            /// <summary>
            /// AddedToServiceDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-addedtoservicedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddedToServiceDateTime { get; set; }
            /// <summary>
            /// LastSeenByServiceDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-lastseenbyservicedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastSeenByServiceDateTime { get; set; }
            /// <summary>
            /// ElapsedReplicationDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-elapsedreplicationduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ElapsedReplicationDuration { get; set; }
            /// <summary>
            /// LastTest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-lasttest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleLastTest
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleLastTest, BaseFunction>? LastTest { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// FirstByteDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-firstbytedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirstByteDateTime { get; set; }
            /// <summary>
            /// LastCutover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-lastcutover
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleLastCutover
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleLastCutover, BaseFunction>? LastCutover { get; set; }
        }

        public class LifeCycleEvent : Humidifier.Base.BaseSubResource, IHaveApiCallDateTime, IHaveJobID
        {
            /// <summary>
            /// ApiCallDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycleevent.html#cfn-mgn-sourceserver-lifecycleevent-apicalldatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiCallDateTime { get; set; }
            /// <summary>
            /// JobID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycleevent.html#cfn-mgn-sourceserver-lifecycleevent-jobid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobID { get; set; }
        }

        public class LifeCycleEventNoJob : Humidifier.Base.BaseSubResource, IHaveApiCallDateTime
        {
            /// <summary>
            /// ApiCallDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycleeventnojob.html#cfn-mgn-sourceserver-lifecycleeventnojob-apicalldatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiCallDateTime { get; set; }
        }

        public class LifeCycleLastCutover : Humidifier.Base.BaseSubResource, IHaveMGNSourceServerTypesLifeCycleEventInitiated, IHaveMGNSourceServerTypesLifeCycleEventNoJobReverted, IHaveMGNSourceServerTypesLifeCycleEventNoJobFinalized
        {
            /// <summary>
            /// Initiated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelastcutover.html#cfn-mgn-sourceserver-lifecyclelastcutover-initiated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEvent
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleEvent, BaseFunction>? Initiated { get; set; }
            /// <summary>
            /// Reverted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelastcutover.html#cfn-mgn-sourceserver-lifecyclelastcutover-reverted
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob, BaseFunction>? Reverted { get; set; }
            /// <summary>
            /// Finalized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelastcutover.html#cfn-mgn-sourceserver-lifecyclelastcutover-finalized
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob, BaseFunction>? Finalized { get; set; }
        }

        public class LifeCycleLastTest : Humidifier.Base.BaseSubResource, IHaveMGNSourceServerTypesLifeCycleEventInitiated, IHaveMGNSourceServerTypesLifeCycleEventNoJobReverted, IHaveMGNSourceServerTypesLifeCycleEventNoJobFinalized
        {
            /// <summary>
            /// Initiated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelasttest.html#cfn-mgn-sourceserver-lifecyclelasttest-initiated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEvent
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleEvent, BaseFunction>? Initiated { get; set; }
            /// <summary>
            /// Reverted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelasttest.html#cfn-mgn-sourceserver-lifecyclelasttest-reverted
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob, BaseFunction>? Reverted { get; set; }
            /// <summary>
            /// Finalized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelasttest.html#cfn-mgn-sourceserver-lifecyclelasttest-finalized
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob, BaseFunction>? Finalized { get; set; }
        }

        public class NetworkInterface : Humidifier.Base.BaseSubResource, IHaveIsPrimary_Boolean, IHaveMacAddress, IHaveStringListOfIps
        {
            /// <summary>
            /// IsPrimary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-networkinterface.html#cfn-mgn-sourceserver-networkinterface-isprimary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsPrimary { get; set; }
            /// <summary>
            /// MacAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-networkinterface.html#cfn-mgn-sourceserver-networkinterface-macaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MacAddress { get; set; }
            /// <summary>
            /// Ips
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-networkinterface.html#cfn-mgn-sourceserver-networkinterface-ips
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-os.html#cfn-mgn-sourceserver-os-fullstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FullString { get; set; }
        }

        public class SourceProperties : Humidifier.Base.BaseSubResource, IHaveRecommendedInstanceType, IHaveMGNSourceServerTypesIdentificationHintsIdentificationHints, IHaveMGNSourceServerTypesOSOs, IHaveListOfMGNSourceServerTypesNetworkInterfaceNetworkInterfaces, IHaveListOfMGNSourceServerTypesDiskDisks, IHaveRamBytes_Double, IHaveListOfMGNSourceServerTypesCPUCpus, IHaveLastUpdatedDateTime
        {
            /// <summary>
            /// RecommendedInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-recommendedinstancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecommendedInstanceType { get; set; }
            /// <summary>
            /// IdentificationHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-identificationhints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentificationHints
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.IdentificationHints, BaseFunction>? IdentificationHints { get; set; }
            /// <summary>
            /// Os
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-os
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OS
            /// </summary>
            public Union<Humidifier.MGN.SourceServerTypes.OS, BaseFunction>? Os { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-networkinterfaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkInterface
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MGN.SourceServerTypes.NetworkInterface>, IReadOnlyList<Union<Humidifier.MGN.SourceServerTypes.NetworkInterface, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// Disks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-disks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Disk
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MGN.SourceServerTypes.Disk>, IReadOnlyList<Union<Humidifier.MGN.SourceServerTypes.Disk, BaseFunction>>, BaseFunction>? Disks { get; set; }
            /// <summary>
            /// RamBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-rambytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RamBytes { get; set; }
            /// <summary>
            /// Cpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-cpus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CPU
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MGN.SourceServerTypes.CPU>, IReadOnlyList<Union<Humidifier.MGN.SourceServerTypes.CPU, BaseFunction>>, BaseFunction>? Cpus { get; set; }
            /// <summary>
            /// LastUpdatedDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-lastupdateddatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastUpdatedDateTime { get; set; }
        }

        public class SourceServerConnectorAction : Humidifier.Base.BaseSubResource, IHaveConnectorArn, IHaveCredentialsSecretArn
        {
            /// <summary>
            /// ConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceserverconnectoraction.html#cfn-mgn-sourceserver-sourceserverconnectoraction-connectorarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorArn { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceserverconnectoraction.html#cfn-mgn-sourceserver-sourceserverconnectoraction-credentialssecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsSecretArn { get; set; }
        }
    }
}