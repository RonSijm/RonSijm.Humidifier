namespace Humidifier.SavingsPlans
{
    using global::System.Collections.Generic;

    public class SavingsPlan : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ProductTypes =  "ProductTypes" ;
            public static string Description =  "Description" ;
            public static string SavingsPlanType =  "SavingsPlanType" ;
            public static string Start =  "Start" ;
            public static string RecurringPaymentAmount =  "RecurringPaymentAmount" ;
            public static string SavingsPlanOfferingId =  "SavingsPlanOfferingId" ;
            public static string UpfrontPaymentAmount =  "UpfrontPaymentAmount" ;
            public static string State =  "State" ;
            public static string Currency =  "Currency" ;
            public static string TermDurationInSeconds =  "TermDurationInSeconds" ;
            public static string SavingsPlanArn =  "SavingsPlanArn" ;
            public static string SavingsPlanId =  "SavingsPlanId" ;
            public static string PaymentOption =  "PaymentOption" ;
            public static string End =  "End" ;
            public static string Commitment =  "Commitment" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.SavingsPlans.SavingsPlan; }
    }
}