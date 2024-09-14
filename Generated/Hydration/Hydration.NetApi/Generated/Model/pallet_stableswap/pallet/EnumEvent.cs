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


namespace Hydration.NetApi.Generated.Model.pallet_stableswap.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> PoolCreated
        /// A pool was created.
        /// </summary>
        PoolCreated = 0,
        
        /// <summary>
        /// >> FeeUpdated
        /// Pool fee has been updated.
        /// </summary>
        FeeUpdated = 1,
        
        /// <summary>
        /// >> LiquidityAdded
        /// Liquidity of an asset was added to a pool.
        /// </summary>
        LiquidityAdded = 2,
        
        /// <summary>
        /// >> LiquidityRemoved
        /// Liquidity removed.
        /// </summary>
        LiquidityRemoved = 3,
        
        /// <summary>
        /// >> SellExecuted
        /// Sell trade executed. Trade fee paid in asset leaving the pool (already subtracted from amount_out).
        /// </summary>
        SellExecuted = 4,
        
        /// <summary>
        /// >> BuyExecuted
        /// Buy trade executed. Trade fee paid in asset entering the pool (already included in amount_in).
        /// </summary>
        BuyExecuted = 5,
        
        /// <summary>
        /// >> TradableStateUpdated
        /// Asset's tradable state has been updated.
        /// </summary>
        TradableStateUpdated = 6,
        
        /// <summary>
        /// >> AmplificationChanging
        /// AAmplification of a pool has been scheduled to change.
        /// </summary>
        AmplificationChanging = 7,
    }
    
    /// <summary>
    /// >> 106 - Variant[pallet_stableswap.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>, Hydration.NetApi.Generated.Types.Base.NonZeroU16, Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>>(Event.PoolCreated);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>>(Event.FeeUpdated);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Hydration.NetApi.Generated.Model.pallet_stableswap.types.AssetAmount>>>(Event.LiquidityAdded);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Hydration.NetApi.Generated.Model.pallet_stableswap.types.AssetAmount>, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.LiquidityRemoved);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.SellExecuted);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.BuyExecuted);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.pallet_stableswap.types.Tradability>>(Event.TradableStateUpdated);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Types.Base.NonZeroU16, Hydration.NetApi.Generated.Types.Base.NonZeroU16, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.AmplificationChanging);
        }
    }
}
