namespace Humidifier.LicenseManager
{
    using System.Collections.Generic;

    public class Grant : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStatus, IHavePrincipals
    {
        public class Attributes
        {
            public static string GrantArn =  "GrantArn" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManager.Grant; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-grant.html#cfn-licensemanager-grant-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }
        /// <summary>
        /// Principals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-grant.html#cfn-licensemanager-grant-principals
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Principals { get; set; }
        /// <summary>
        /// HomeRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-grant.html#cfn-licensemanager-grant-homeregion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HomeRegion { get; set; }
        /// <summary>
        /// AllowedOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-grant.html#cfn-licensemanager-grant-allowedoperations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AllowedOperations { get; set; }
        /// <summary>
        /// LicenseArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanager-grant.html#cfn-licensemanager-grant-licensearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LicenseArn { get; set; }
        public dynamic GrantName { get => GivenName; set => GivenName = value; }
    }
}