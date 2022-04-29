namespace Arcane.Liquidador.Abstractions
{
    public interface IPsrObjectives
    {
        int ClientSaleTarget { get; set; }
        int DefaultSellout { get; set; }
        int DefaultSim { get; set; }
        int ObjectiveSim1 { get; set; }
        int ObjectiveSim2 { get; set; }
        int ObjectiveSim3 { get; set; }
        int ObjectiveSO1 { get; set; }
        int ObjectiveSO2 { get; set; }
        int VolumePayment { get; set; }
        int VolumeTarget { get; set; }
    }
}