namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using FrameworkTypes;

    public class Framework : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfBackupFrameworkTypesFrameworkControlFrameworkControls, IHaveFrameworkName, IHaveTagListOfFrameworkTags, IHaveFrameworkDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string FrameworkStatus =  "FrameworkStatus" ;
            public static string DeploymentStatus =  "DeploymentStatus" ;
            public static string FrameworkArn =  "FrameworkArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.Framework; }

        /// <summary>
        /// FrameworkControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-framework.html#cfn-backup-framework-frameworkcontrols
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FrameworkControl
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Backup.FrameworkTypes.FrameworkControl>, IReadOnlyList<Union<Humidifier.Backup.FrameworkTypes.FrameworkControl, BaseFunction>>, BaseFunction>? FrameworkControls { get; set; }
        public Union<string, BaseFunction>? FrameworkName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FrameworkTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-framework.html#cfn-backup-framework-frameworktags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? FrameworkTags { get; set; }
        /// <summary>
        /// FrameworkDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-framework.html#cfn-backup-framework-frameworkdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FrameworkDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => FrameworkDescription; set => FrameworkDescription = value; }
    }

    namespace FrameworkTypes
    {
        public class ControlInputParameter : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlinputparameter.html#cfn-backup-framework-controlinputparameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlinputparameter.html#cfn-backup-framework-controlinputparameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }

        public class ControlScope : Humidifier.Base.BaseSubResource, IHaveTags, IHaveStringListOfComplianceResourceTypes, IHaveStringListOfComplianceResourceIds
        {
            /// <summary>
            /// ComplianceResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlscope.html#cfn-backup-framework-controlscope-complianceresourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ComplianceResourceTypes { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlscope.html#cfn-backup-framework-controlscope-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// ComplianceResourceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlscope.html#cfn-backup-framework-controlscope-complianceresourceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ComplianceResourceIds { get; set; }
        }

        public class FrameworkControl : Humidifier.Base.BaseSubResource, IHaveControlName, IHaveListOfBackupFrameworkTypesControlInputParameterControlInputParameters, IHaveBackupFrameworkTypesControlScopeControlScope
        {
            /// <summary>
            /// ControlName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-frameworkcontrol.html#cfn-backup-framework-frameworkcontrol-controlname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ControlName { get; set; }
            /// <summary>
            /// ControlInputParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-frameworkcontrol.html#cfn-backup-framework-frameworkcontrol-controlinputparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlInputParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.FrameworkTypes.ControlInputParameter>, IReadOnlyList<Union<Humidifier.Backup.FrameworkTypes.ControlInputParameter, BaseFunction>>, BaseFunction>? ControlInputParameters { get; set; }
            /// <summary>
            /// ControlScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-frameworkcontrol.html#cfn-backup-framework-frameworkcontrol-controlscope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ControlScope
            /// </summary>
            public Union<Humidifier.Backup.FrameworkTypes.ControlScope, BaseFunction>? ControlScope { get; set; }
        }
    }
}