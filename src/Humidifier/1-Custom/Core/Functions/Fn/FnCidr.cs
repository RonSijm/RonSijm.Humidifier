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
public class FnCidr
{
    public dynamic IpBlock { get; set; }
    public dynamic Count { get; set; }
    public dynamic SizeMask { get; set; }

    public FnCidr(dynamic ipBlock, dynamic count, dynamic sizeMask)
    {
        IpBlock = ipBlock;
        Count = count;
        SizeMask = sizeMask;
    }
}