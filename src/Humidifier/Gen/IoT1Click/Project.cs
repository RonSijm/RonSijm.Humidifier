namespace Humidifier.IoT1Click
{
    using System.Collections.Generic;
    using ProjectTypes;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveProjectName
    {
        public class Attributes
        {
            public static string ProjectName =  "ProjectName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT1Click.Project; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-project.html#cfn-iot1click-project-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// PlacementTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-project.html#cfn-iot1click-project-placementtemplate
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PlacementTemplate
        /// </summary>
        [Required]
        public Humidifier.IoT1Click.ProjectTypes.PlacementTemplate PlacementTemplate { get; set; }
        public dynamic ProjectName { get => GivenName; set => GivenName = value; }
    }

    namespace ProjectTypes
    {
        public class DeviceTemplate : Humidifier.Base.BaseSubResource, IHaveDeviceType
        {
            /// <summary>
            /// DeviceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot1click-project-devicetemplate.html#cfn-iot1click-project-devicetemplate-devicetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceType { get; set; }
            /// <summary>
            /// CallbackOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot1click-project-devicetemplate.html#cfn-iot1click-project-devicetemplate-callbackoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CallbackOverrides { get; set; }
        }

        public class PlacementTemplate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeviceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot1click-project-placementtemplate.html#cfn-iot1click-project-placementtemplate-devicetemplates
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic DeviceTemplates { get; set; }
            /// <summary>
            /// DefaultAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot1click-project-placementtemplate.html#cfn-iot1click-project-placementtemplate-defaultattributes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic DefaultAttributes { get; set; }
        }
    }
}