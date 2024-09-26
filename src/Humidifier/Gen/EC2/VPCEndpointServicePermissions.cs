namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class VPCEndpointServicePermissions : Humidifier.Base.BaseResource, IHaveServiceId
    {
        public override string AWSTypeName { get => AWS.EC2.VPCEndpointServicePermissions; }
        /// <summary>
        /// AllowedPrincipals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservicepermissions.html#cfn-ec2-vpcendpointservicepermissions-allowedprincipals
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AllowedPrincipals { get; set; }

        /// <summary>
        /// ServiceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservicepermissions.html#cfn-ec2-vpcendpointservicepermissions-serviceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceId { get; set; }
    }
}