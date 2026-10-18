namespace Humidifier.ResilienceHubV2
{
    using global::System.Collections.Generic;
    using PolicyTypes;

    public class Policy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResilienceHubV2PolicyTypesMultiRegionTargetsMultiRegion, IHaveResilienceHubV2PolicyTypesAvailabilitySloAvailabilitySlo, IHaveDescription, IHaveKmsKeyId, IHaveSharingEnabled_Boolean, IHaveResilienceHubV2PolicyTypesDataRecoveryTargetsDataRecovery, IHaveResilienceHubV2PolicyTypesMultiAzTargetsMultiAz, IHaveName
    {
        public class Attributes
        {
            public static string PolicyArn =  "PolicyArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AssociatedServiceCount =  "AssociatedServiceCount" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.ResilienceHubV2.Policy; }
        /// <summary>
        /// MultiRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-multiregion
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiRegionTargets
        /// </summary>
        public Union<Humidifier.ResilienceHubV2.PolicyTypes.MultiRegionTargets, BaseFunction>? MultiRegion { get; set; }
        /// <summary>
        /// AvailabilitySlo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-availabilityslo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AvailabilitySlo
        /// </summary>
        public Union<Humidifier.ResilienceHubV2.PolicyTypes.AvailabilitySlo, BaseFunction>? AvailabilitySlo { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// SharingEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-sharingenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SharingEnabled { get; set; }
        /// <summary>
        /// DataRecovery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-datarecovery
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataRecoveryTargets
        /// </summary>
        public Union<Humidifier.ResilienceHubV2.PolicyTypes.DataRecoveryTargets, BaseFunction>? DataRecovery { get; set; }
        /// <summary>
        /// MultiAz
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-multiaz
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiAzTargets
        /// </summary>
        public Union<Humidifier.ResilienceHubV2.PolicyTypes.MultiAzTargets, BaseFunction>? MultiAz { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehubv2-policy.html#cfn-resiliencehubv2-policy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PolicyTypes
    {
        public class AvailabilitySlo : Humidifier.Base.BaseSubResource, IHaveTarget_Double
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-availabilityslo.html#cfn-resiliencehubv2-policy-availabilityslo-target
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Target { get; set; }
        }

        public class DataRecoveryTargets : Humidifier.Base.BaseSubResource, IHaveTimeBetweenBackupsInMinutes_Integer
        {
            /// <summary>
            /// TimeBetweenBackupsInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-datarecoverytargets.html#cfn-resiliencehubv2-policy-datarecoverytargets-timebetweenbackupsinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeBetweenBackupsInMinutes { get; set; }
        }

        public class MultiAzTargets : Humidifier.Base.BaseSubResource, IHaveDisasterRecoveryApproach, IHaveRpoInMinutes_Integer, IHaveRtoInMinutes_Integer
        {
            /// <summary>
            /// DisasterRecoveryApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-multiaztargets.html#cfn-resiliencehubv2-policy-multiaztargets-disasterrecoveryapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisasterRecoveryApproach { get; set; }
            /// <summary>
            /// RpoInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-multiaztargets.html#cfn-resiliencehubv2-policy-multiaztargets-rpoinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RpoInMinutes { get; set; }
            /// <summary>
            /// RtoInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-multiaztargets.html#cfn-resiliencehubv2-policy-multiaztargets-rtoinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RtoInMinutes { get; set; }
        }

        public class MultiRegionTargets : Humidifier.Base.BaseSubResource, IHaveDisasterRecoveryApproach, IHaveRpoInMinutes_Integer, IHaveRtoInMinutes_Integer
        {
            /// <summary>
            /// DisasterRecoveryApproach
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-multiregiontargets.html#cfn-resiliencehubv2-policy-multiregiontargets-disasterrecoveryapproach
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisasterRecoveryApproach { get; set; }
            /// <summary>
            /// RpoInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-multiregiontargets.html#cfn-resiliencehubv2-policy-multiregiontargets-rpoinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RpoInMinutes { get; set; }
            /// <summary>
            /// RtoInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehubv2-policy-multiregiontargets.html#cfn-resiliencehubv2-policy-multiregiontargets-rtoinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RtoInMinutes { get; set; }
        }
    }
}