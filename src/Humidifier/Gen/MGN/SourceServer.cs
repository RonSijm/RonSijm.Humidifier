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
        public class CPU : Humidifier.Base.BaseSubResource, IHaveModelName
        {
            /// <summary>
            /// Cores
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-cpu.html#cfn-mgn-sourceserver-cpu-cores
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Cores { get; set; }
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-cpu.html#cfn-mgn-sourceserver-cpu-modelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelName { get; set; }
        }

        public class DataReplicationInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataReplicationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-datareplicationstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataReplicationState { get; set; }
            /// <summary>
            /// LastSnapshotDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-lastsnapshotdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastSnapshotDateTime { get; set; }
            /// <summary>
            /// LagDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-lagduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LagDuration { get; set; }
            /// <summary>
            /// ReplicatedDisks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-replicateddisks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataReplicationInfoReplicatedDisk
            /// </summary>
            public List<Humidifier.MGN.SourceServerTypes.DataReplicationInfoReplicatedDisk> ReplicatedDisks { get; set; }
            /// <summary>
            /// DataReplicationInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinfo.html#cfn-mgn-sourceserver-datareplicationinfo-datareplicationinitiation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataReplicationInitiation
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.DataReplicationInitiation DataReplicationInitiation { get; set; }
        }

        public class DataReplicationInfoReplicatedDisk : Humidifier.Base.BaseSubResource, IHaveDeviceName
        {
            /// <summary>
            /// BackloggedStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-backloggedstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BackloggedStorageBytes { get; set; }
            /// <summary>
            /// ReplicatedStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-replicatedstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ReplicatedStorageBytes { get; set; }
            /// <summary>
            /// RescannedStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-rescannedstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RescannedStorageBytes { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceName { get; set; }
            /// <summary>
            /// TotalStorageBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinforeplicateddisk.html#cfn-mgn-sourceserver-datareplicationinforeplicateddisk-totalstoragebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TotalStorageBytes { get; set; }
        }

        public class DataReplicationInitiation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Steps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiation.html#cfn-mgn-sourceserver-datareplicationinitiation-steps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DataReplicationInitiationStep
            /// </summary>
            public List<Humidifier.MGN.SourceServerTypes.DataReplicationInitiationStep> Steps { get; set; }
            /// <summary>
            /// StartDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiation.html#cfn-mgn-sourceserver-datareplicationinitiation-startdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartDateTime { get; set; }
        }

        public class DataReplicationInitiationStep : Humidifier.Base.BaseSubResource, IHaveName, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiationstep.html#cfn-mgn-sourceserver-datareplicationinitiationstep-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-datareplicationinitiationstep.html#cfn-mgn-sourceserver-datareplicationinitiationstep-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Disk : Humidifier.Base.BaseSubResource, IHaveDeviceName
        {
            /// <summary>
            /// Bytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-disk.html#cfn-mgn-sourceserver-disk-bytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Bytes { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-disk.html#cfn-mgn-sourceserver-disk-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceName { get; set; }
        }

        public class IdentificationHints : Humidifier.Base.BaseSubResource, IHaveHostname
        {
            /// <summary>
            /// Fqdn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-fqdn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Fqdn { get; set; }
            /// <summary>
            /// AwsInstanceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-awsinstanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsInstanceID { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Hostname { get; set; }
            /// <summary>
            /// VmPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-vmpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VmPath { get; set; }
            /// <summary>
            /// VmWareUuid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-identificationhints.html#cfn-mgn-sourceserver-identificationhints-vmwareuuid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VmWareUuid { get; set; }
        }

        public class LaunchedInstance : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ec2InstanceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-launchedinstance.html#cfn-mgn-sourceserver-launchedinstance-ec2instanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ec2InstanceID { get; set; }
            /// <summary>
            /// FirstBoot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-launchedinstance.html#cfn-mgn-sourceserver-launchedinstance-firstboot
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstBoot { get; set; }
            /// <summary>
            /// JobID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-launchedinstance.html#cfn-mgn-sourceserver-launchedinstance-jobid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JobID { get; set; }
        }

        public class LifeCycle : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// AddedToServiceDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-addedtoservicedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddedToServiceDateTime { get; set; }
            /// <summary>
            /// LastSeenByServiceDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-lastseenbyservicedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastSeenByServiceDateTime { get; set; }
            /// <summary>
            /// ElapsedReplicationDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-elapsedreplicationduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElapsedReplicationDuration { get; set; }
            /// <summary>
            /// LastTest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-lasttest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleLastTest
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleLastTest LastTest { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// FirstByteDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-firstbytedatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstByteDateTime { get; set; }
            /// <summary>
            /// LastCutover
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycle.html#cfn-mgn-sourceserver-lifecycle-lastcutover
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleLastCutover
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleLastCutover LastCutover { get; set; }
        }

        public class LifeCycleEvent : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiCallDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycleevent.html#cfn-mgn-sourceserver-lifecycleevent-apicalldatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiCallDateTime { get; set; }
            /// <summary>
            /// JobID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycleevent.html#cfn-mgn-sourceserver-lifecycleevent-jobid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JobID { get; set; }
        }

        public class LifeCycleEventNoJob : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiCallDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecycleeventnojob.html#cfn-mgn-sourceserver-lifecycleeventnojob-apicalldatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiCallDateTime { get; set; }
        }

        public class LifeCycleLastCutover : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Initiated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelastcutover.html#cfn-mgn-sourceserver-lifecyclelastcutover-initiated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEvent
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleEvent Initiated { get; set; }
            /// <summary>
            /// Reverted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelastcutover.html#cfn-mgn-sourceserver-lifecyclelastcutover-reverted
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob Reverted { get; set; }
            /// <summary>
            /// Finalized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelastcutover.html#cfn-mgn-sourceserver-lifecyclelastcutover-finalized
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob Finalized { get; set; }
        }

        public class LifeCycleLastTest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Initiated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelasttest.html#cfn-mgn-sourceserver-lifecyclelasttest-initiated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEvent
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleEvent Initiated { get; set; }
            /// <summary>
            /// Reverted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelasttest.html#cfn-mgn-sourceserver-lifecyclelasttest-reverted
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob Reverted { get; set; }
            /// <summary>
            /// Finalized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-lifecyclelasttest.html#cfn-mgn-sourceserver-lifecyclelasttest-finalized
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifeCycleEventNoJob
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.LifeCycleEventNoJob Finalized { get; set; }
        }

        public class NetworkInterface : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IsPrimary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-networkinterface.html#cfn-mgn-sourceserver-networkinterface-isprimary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsPrimary { get; set; }
            /// <summary>
            /// MacAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-networkinterface.html#cfn-mgn-sourceserver-networkinterface-macaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MacAddress { get; set; }
            /// <summary>
            /// Ips
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-networkinterface.html#cfn-mgn-sourceserver-networkinterface-ips
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Ips { get; set; }
        }

        public class OS : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FullString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-os.html#cfn-mgn-sourceserver-os-fullstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FullString { get; set; }
        }

        public class SourceProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RecommendedInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-recommendedinstancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecommendedInstanceType { get; set; }
            /// <summary>
            /// IdentificationHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-identificationhints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentificationHints
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.IdentificationHints IdentificationHints { get; set; }
            /// <summary>
            /// Os
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-os
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OS
            /// </summary>
            public Humidifier.MGN.SourceServerTypes.OS Os { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-networkinterfaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkInterface
            /// </summary>
            public List<Humidifier.MGN.SourceServerTypes.NetworkInterface> NetworkInterfaces { get; set; }
            /// <summary>
            /// Disks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-disks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Disk
            /// </summary>
            public List<Humidifier.MGN.SourceServerTypes.Disk> Disks { get; set; }
            /// <summary>
            /// RamBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-rambytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RamBytes { get; set; }
            /// <summary>
            /// Cpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-cpus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CPU
            /// </summary>
            public List<Humidifier.MGN.SourceServerTypes.CPU> Cpus { get; set; }
            /// <summary>
            /// LastUpdatedDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceproperties.html#cfn-mgn-sourceserver-sourceproperties-lastupdateddatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastUpdatedDateTime { get; set; }
        }

        public class SourceServerConnectorAction : Humidifier.Base.BaseSubResource, IHaveCredentialsSecretArn, IHaveConnectorArn
        {
            /// <summary>
            /// ConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceserverconnectoraction.html#cfn-mgn-sourceserver-sourceserverconnectoraction-connectorarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorArn { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-sourceserver-sourceserverconnectoraction.html#cfn-mgn-sourceserver-sourceserverconnectoraction-credentialssecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsSecretArn { get; set; }
        }
    }
}