using Stratis.SmartContracts;

public class AuctionManager : SmartContract
{
    public AuctionManager(ISmartContractState smartContractState)
        : base(smartContractState)
    {
    }

    public Address CreateNewAuction(ulong durationBlocks)
    {
        var createResult = this.Create<Auction>(new object[] { durationBlocks });

        return createResult.NewContractAddress;
    }
}