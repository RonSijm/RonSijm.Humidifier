namespace Humidifier.Tests;

public class FunctionsStackGenerationTest : BaseStackBuilderTest
{
    protected override Task<Stack> BuildStack()
    {
        var stack = new Stack
        {
            AWSTemplateFormatVersion = "2010-09-09",
            Description = "Description",
            Transform = "AWS::Serverless-2016-10-31"
        };

        stack.Add("DeploymentBucket", new Output
        {
            Value = Fn.Ref("DeploymentBucket"),
            Export = new { Name = Fn.Sub("${AWS::StackName}-DeploymentBucket") },

            Description = new List<dynamic>()
            {
                Fn.FindInMap("RegionMap", Fn.Ref("AWS::Region"), "64"),
                Fn.GetAtt("MyElb", ElasticLoadBalancing.LoadBalancer.Attributes.DNSName),
                Fn.GetAZs("us-east-2"),
                Fn.ImportValue(Fn.Sub("${NetworkStackNameParameter}-SubnetID")),
                Fn.Join("", "arn:aws:s3:::", Fn.Ref("DeployBucket"), "/*"),
                Fn.Ref("BucketName"),
                Fn.Select("1", new[] { "a", "b", "c" }),
                Fn.Split("|", "a|b|c"),
                Fn.Sub("${AWS::StackName}-${AWS::Region}-bucket"),
                Fn.Select("1", Fn.Split("|", "a|b|c")),

                // CidrBlock: !Select [1, !Cidr [!Ref cidrBlock, !Ref count, !Ref maskSizeForIPv4]]
                Fn.Cidr("a", "b", "c"),

                // Because JSON doesn't allow newlines, there's a known hack where you can join multiple lines together using Fn::Join
                Fn.Base64(Fn.Join("",
                    "#!/bin/bash -e\n",
                    "wget https://opscode-omnibus-packages.s3.amazonaws.com/ubuntu/12.04/x86_64/chef_11.6.2-1.ubuntu.12.04_amd64.deb\n",
                    "dpkg -i chef_11.6.2-1.ubuntu.12.04_amd64.deb\n"
                )),

                // But that's gross and unreadable, we have a better way! Use a multiline C# string, and let the library take care of encoding it for you.
                //  - Whitespace on the start of the line is trimmed, so feel free to indent you code nicely.
                //  - Newlines are encoded as \r\n automatically by NewtonSoft.Json
                Fn.Base64(
                    @"#!/bin/bash -e
                wget https://opscode-omnibus-packages.s3.amazonaws.com/ubuntu/12.04/x86_64/chef_11.6.2-1.ubuntu.12.04_amd64.deb
                dpkg -i chef_11.6.2-1.ubuntu.12.04_amd64.deb"
                ),
            }
        });

        return Task.FromResult(stack);
    }
}