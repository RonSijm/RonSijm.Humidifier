namespace Humidifier.Artifact
{
    using global::System.Collections.Generic;

    public class Report : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AcceptanceType =  "AcceptanceType" ;
            public static string Description =  "Description" ;
            public static string Category =  "Category" ;
            public static string ProductName =  "ProductName" ;
            public static string PeriodStart =  "PeriodStart" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ReportId =  "ReportId" ;
            public static string TermArn =  "TermArn" ;
            public static string PeriodEnd =  "PeriodEnd" ;
            public static string Name =  "Name" ;
            public static string Series =  "Series" ;
            public static string CompanyName =  "CompanyName" ;
            public static string Version =  "Version" ;
            public static string State =  "State" ;
            public static string SequenceNumber =  "SequenceNumber" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Artifact.Report; }
    }
}