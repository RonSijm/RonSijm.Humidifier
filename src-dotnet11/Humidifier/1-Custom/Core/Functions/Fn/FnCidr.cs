namespace Humidifier;

/// <summary>
/// The intrinsic function Fn::Cidr returns the specified Cidr address block.
/// 
/// Example: 
/// 
/// { "Fn:Cidr": [ipBlock, count, sizeMask] }
/// 
/// ipBlock: The user-specified default Cidr address block.
/// count: The number of subnets' Cidr block wanted. Count can be 1 to 256.
/// sizeMask: Optional. The digit covered in the subnet.
/// 
/// 
/// </summary>
public class FnCidr : BaseFunction
{
    public object IpBlock { get; set; }
    public object Count { get; set; }
    public object SizeMask { get; set; }

    public FnCidr(object ipBlock, object count, object sizeMask)
    {
        IpBlock = ipBlock;
        Count = count;
        SizeMask = sizeMask;
    }
}