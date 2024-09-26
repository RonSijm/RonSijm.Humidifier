namespace Humidifier.Rekognition
{
    using System.Collections.Generic;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveProjectName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Rekognition.Project; }
        public dynamic ProjectName { get => GivenName; set => GivenName = value; }
    }
}