namespace Humidifier.Glue
{
    using global::System.Collections.Generic;

    public class IdentityCenterConfiguration : Humidifier.Base.BaseResource, IHaveUserBackgroundSessionsEnabled_Boolean, IHaveStringListOfScopes, IHaveInstanceArn
    {
        public class Attributes
        {
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.Glue.IdentityCenterConfiguration; }
        /// <summary>
        /// UserBackgroundSessionsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-identitycenterconfiguration.html#cfn-glue-identitycenterconfiguration-userbackgroundsessionsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UserBackgroundSessionsEnabled { get; set; }
        /// <summary>
        /// Scopes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-identitycenterconfiguration.html#cfn-glue-identitycenterconfiguration-scopes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-identitycenterconfiguration.html#cfn-glue-identitycenterconfiguration-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
    }
}