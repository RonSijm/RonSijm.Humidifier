namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using FrameworkTypes;

    public class Framework : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string FrameworkStatus =  "FrameworkStatus" ;
            public static string DeploymentStatus =  "DeploymentStatus" ;
            public static string FrameworkArn =  "FrameworkArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Backup::Framework";
            }
        }

        /// <summary>
        /// FrameworkControls
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-framework.html#cfn-backup-framework-frameworkcontrols
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FrameworkControl
        /// </summary>
        public List<FrameworkTypes.FrameworkControl> FrameworkControls { get; set; }
        public dynamic FrameworkName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FrameworkTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-framework.html#cfn-backup-framework-frameworktags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> FrameworkTags { get; set; }
        /// <summary>
        /// FrameworkDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-framework.html#cfn-backup-framework-frameworkdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FrameworkDescription { get; set; }
    }

    namespace FrameworkTypes
    {
        public class ControlInputParameter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlinputparameter.html#cfn-backup-framework-controlinputparameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlinputparameter.html#cfn-backup-framework-controlinputparameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
        }

        public class ControlScope : Humidifier.Base.BaseSubResource, IHaveTags
        {
            /// <summary>
            /// ComplianceResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlscope.html#cfn-backup-framework-controlscope-complianceresourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ComplianceResourceTypes { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlscope.html#cfn-backup-framework-controlscope-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Tags { get; set; }
            /// <summary>
            /// ComplianceResourceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-controlscope.html#cfn-backup-framework-controlscope-complianceresourceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ComplianceResourceIds { get; set; }
        }

        public class FrameworkControl : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ControlName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-frameworkcontrol.html#cfn-backup-framework-frameworkcontrol-controlname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ControlName { get; set; }
            /// <summary>
            /// ControlInputParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-frameworkcontrol.html#cfn-backup-framework-frameworkcontrol-controlinputparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ControlInputParameter
            /// </summary>
            public List<FrameworkTypes.ControlInputParameter> ControlInputParameters { get; set; }
            /// <summary>
            /// ControlScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-framework-frameworkcontrol.html#cfn-backup-framework-frameworkcontrol-controlscope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ControlScope
            /// </summary>
            public FrameworkTypes.ControlScope ControlScope { get; set; }
        }
    }
}