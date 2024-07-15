//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_omnipool.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> TokenAdded
        /// An asset was added to Omnipool
        /// </summary>
        TokenAdded = 0,
        
        /// <summary>
        /// >> TokenRemoved
        /// An asset was removed from Omnipool
        /// </summary>
        TokenRemoved = 1,
        
        /// <summary>
        /// >> LiquidityAdded
        /// Liquidity of an asset was added to Omnipool.
        /// </summary>
        LiquidityAdded = 2,
        
        /// <summary>
        /// >> LiquidityRemoved
        /// Liquidity of an asset was removed from Omnipool.
        /// </summary>
        LiquidityRemoved = 3,
        
        /// <summary>
        /// >> ProtocolLiquidityRemoved
        /// PRotocol Liquidity was removed from Omnipool.
        /// </summary>
        ProtocolLiquidityRemoved = 4,
        
        /// <summary>
        /// >> SellExecuted
        /// Sell trade executed.
        /// </summary>
        SellExecuted = 5,
        
        /// <summary>
        /// >> BuyExecuted
        /// Buy trade executed.
        /// </summary>
        BuyExecuted = 6,
        
        /// <summary>
        /// >> PositionCreated
        /// LP Position was created and NFT instance minted.
        /// </summary>
        PositionCreated = 7,
        
        /// <summary>
        /// >> PositionDestroyed
        /// LP Position was destroyed and NFT instance burned.
        /// </summary>
        PositionDestroyed = 8,
        
        /// <summary>
        /// >> PositionUpdated
        /// LP Position was updated.
        /// </summary>
        PositionUpdated = 9,
        
        /// <summary>
        /// >> TradableStateUpdated
        /// Asset's tradable state has been updated.
        /// </summary>
        TradableStateUpdated = 10,
        
        /// <summary>
        /// >> AssetRefunded
        /// Amount has been refunded for asset which has not been accepted to add to omnipool.
        /// </summary>
        AssetRefunded = 11,
        
        /// <summary>
        /// >> AssetWeightCapUpdated
        /// Asset's weight cap has been updated.
        /// </summary>
        AssetWeightCapUpdated = 12,
    }
    
    /// <summary>
    /// >> 82 - Variant[pallet_omnipool.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.pallet_omnipool.types.Tradability>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>>
    {
    }
}