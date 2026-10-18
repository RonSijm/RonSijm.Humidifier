namespace Humidifier.IoT
{
    using global::System.Collections.Generic;

    public class ThingPrincipalAttachment : Humidifier.Base.BaseResource, IHaveThingPrincipalType, IHaveThingName, IHavePrincipal
    {
        public override string AWSTypeName { get => AWS.IoT.ThingPrincipalAttachment; }
        /// <summary>
        /// ThingPrincipalType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-thingprincipaltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ThingPrincipalType { get; set; }

        /// <summary>
        /// ThingName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-thingname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ThingName { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Principal { get; set; }
    }
}