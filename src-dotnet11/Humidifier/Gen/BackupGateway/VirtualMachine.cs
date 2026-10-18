namespace Humidifier.BackupGateway
{
    using global::System.Collections.Generic;
    using VirtualMachineTypes;

    public class VirtualMachine : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Path =  "Path" ;
            public static string ResourceArn =  "ResourceArn" ;
            public static string HypervisorId =  "HypervisorId" ;
            public static string VmwareTags =  "VmwareTags" ;
            public static string HostName =  "HostName" ;
            public static string Tags =  "Tags" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.BackupGateway.VirtualMachine; }
    }

    namespace VirtualMachineTypes
    {
        public class VmwareTag : Humidifier.Base.BaseSubResource, IHaveVmwareTagDescription, IHaveVmwareCategory, IHaveVmwareTagName
        {
            /// <summary>
            /// VmwareTagDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-virtualmachine-vmwaretag.html#cfn-backupgateway-virtualmachine-vmwaretag-vmwaretagdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VmwareTagDescription { get; set; }
            /// <summary>
            /// VmwareCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-virtualmachine-vmwaretag.html#cfn-backupgateway-virtualmachine-vmwaretag-vmwarecategory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VmwareCategory { get; set; }
            /// <summary>
            /// VmwareTagName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backupgateway-virtualmachine-vmwaretag.html#cfn-backupgateway-virtualmachine-vmwaretag-vmwaretagname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VmwareTagName { get; set; }
        }
    }
}