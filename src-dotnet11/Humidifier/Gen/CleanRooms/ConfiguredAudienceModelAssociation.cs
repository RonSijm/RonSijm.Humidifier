namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;

    public class ConfiguredAudienceModelAssociation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string Description =  "Description" ;
            public static string MembershipArn =  "MembershipArn" ;
            public static string CreateTime =  "CreateTime" ;
            public static string CollaborationArn =  "CollaborationArn" ;
            public static string Name =  "Name" ;
            public static string MembershipIdentifier =  "MembershipIdentifier" ;
            public static string ConfiguredAudienceModelAssociationIdentifier =  "ConfiguredAudienceModelAssociationIdentifier" ;
            public static string ManageResourcePolicies =  "ManageResourcePolicies" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string Arn =  "Arn" ;
            public static string ConfiguredAudienceModelArn =  "ConfiguredAudienceModelArn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.ConfiguredAudienceModelAssociation; }
    }
}