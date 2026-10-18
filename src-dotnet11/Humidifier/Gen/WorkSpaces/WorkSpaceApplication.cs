namespace Humidifier.WorkSpaces
{
    using global::System.Collections.Generic;

    public class WorkSpaceApplication : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Owner =  "Owner" ;
            public static string Description =  "Description" ;
            public static string SupportedComputeTypeNames =  "SupportedComputeTypeNames" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string ApplicationId =  "ApplicationId" ;
            public static string Created =  "Created" ;
            public static string LicenseType =  "LicenseType" ;
            public static string Name =  "Name" ;
            public static string SupportedOperatingSystemNames =  "SupportedOperatingSystemNames" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpaces.WorkSpaceApplication; }
    }
}