﻿using RocketSilo.Api.Ships;

namespace RocketSilo.Api.Structures;

[RequestUrl("/my/structures/:structureId/transfer", RequestMethod.POST)]
public class TransferGoodsFromYourStructureToAShipRequest : IRequest<TransferGoodsFromYourStructureToAShipResponse>
{
    public string StructureId { get; }
    public string ShipId { get; }
    public string Good { get; }
    public int Quantity { get; }

    public TransferGoodsFromYourStructureToAShipRequest(string structureId, string shipId, string good, int quantity)
    {
        StructureId = structureId;
        ShipId = shipId;
        Good = good;
        Quantity = quantity;
    }
}

public class TransferGoodsFromYourStructureToAShipResponse : IResponse
{
    public StructureInventory Transfer { get; set; }
    public Structure Structure { get; set; }
    public Ship Ship { get; set; }
}