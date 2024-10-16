namespace Humidifier.IoT
{
    using System.Collections.Generic;

    public class ThingPrincipalAttachment : Humidifier.Base.BaseResource, IHavePrincipal, IHaveThingName
    {
        public override string AWSTypeName { get => AWS.IoT.ThingPrincipalAttachment; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Principal { get; set; }

        /// <summary>
        /// ThingName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-thingname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ThingName { get; set; }
    }
}