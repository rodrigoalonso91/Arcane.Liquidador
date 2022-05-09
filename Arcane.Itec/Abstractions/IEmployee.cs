﻿namespace Arcane.Itec.Abstractions
{
    public interface IEmployee
    {
        string Name { get; set; }
        int PsrAmount { get; set; }
        int SimAmount { get; set; }
        int SimReward { get; set; }
        string SimPercentage { get; set; }
        int SelloutAmount { get; set; }
        int SelloutReward { get; set; }
        string SelloutPercentage { get; set; }
        int VolumeAmount { get; set; }
        int VolumeReward { get; set; }
        int TotalSalary { get; set; }
    }
}