namespace Humidifier.AccountAccess
{
    using global::System.Collections.Generic;
    using EntitlementTypes;

    public class Entitlement : Humidifier.Base.BaseResource, IHaveApplicationArn
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string EntitlementId =  "EntitlementId" ;
        }

        public override string AWSTypeName { get => AWS.AccountAccess.Entitlement; }

        /// <summary>
        /// ApplicationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accountaccess-entitlement.html#cfn-accountaccess-entitlement-applicationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationArn { get; set; }

        /// <summary>
        /// Entitlement_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accountaccess-entitlement.html#cfn-accountaccess-entitlement-entitlement
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Entitlement
        /// </summary>
        [Required]
        public Humidifier.AccountAccess.EntitlementTypes.Entitlement Entitlement_ { get; set; }
    }

    namespace EntitlementTypes
    {
        public class Entitlement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrincipalRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-entitlement.html#cfn-accountaccess-entitlement-entitlement-principalrole
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PrincipalRoleEntitlement
            /// </summary>
            public Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement PrincipalRole { get; set; }
        }

        public class IdentityCenterPrincipal : Humidifier.Base.BaseSubResource, IHaveGroupId, IHaveUserId
        {
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-identitycenterprincipal.html#cfn-accountaccess-entitlement-identitycenterprincipal-userid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserId { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-identitycenterprincipal.html#cfn-accountaccess-entitlement-identitycenterprincipal-groupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupId { get; set; }
        }

        public class Principal : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principal.html#cfn-accountaccess-entitlement-principal-identitycenter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IdentityCenterPrincipal
            /// </summary>
            public Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal IdentityCenter { get; set; }
        }

        public class PrincipalRoleEntitlement : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveAccount
        {
            /// <summary>
            /// Account
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principalroleentitlement.html#cfn-accountaccess-entitlement-principalroleentitlement-account
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Account { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principalroleentitlement.html#cfn-accountaccess-entitlement-principalroleentitlement-principal
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Principal
            /// </summary>
            public Humidifier.AccountAccess.EntitlementTypes.Principal Principal { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-entitlement-principalroleentitlement.html#cfn-accountaccess-entitlement-principalroleentitlement-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}