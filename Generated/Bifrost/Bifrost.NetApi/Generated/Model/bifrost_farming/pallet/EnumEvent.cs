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


namespace Bifrost.NetApi.Generated.Model.bifrost_farming.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> FarmingPoolCreated
        /// </summary>
        FarmingPoolCreated = 0,
        
        /// <summary>
        /// >> FarmingPoolReset
        /// </summary>
        FarmingPoolReset = 1,
        
        /// <summary>
        /// >> FarmingPoolClosed
        /// </summary>
        FarmingPoolClosed = 2,
        
        /// <summary>
        /// >> FarmingPoolKilled
        /// </summary>
        FarmingPoolKilled = 3,
        
        /// <summary>
        /// >> FarmingPoolEdited
        /// </summary>
        FarmingPoolEdited = 4,
        
        /// <summary>
        /// >> Charged
        /// </summary>
        Charged = 5,
        
        /// <summary>
        /// >> Deposited
        /// </summary>
        Deposited = 6,
        
        /// <summary>
        /// >> Withdrawn
        /// </summary>
        Withdrawn = 7,
        
        /// <summary>
        /// >> Claimed
        /// </summary>
        Claimed = 8,
        
        /// <summary>
        /// >> WithdrawClaimed
        /// </summary>
        WithdrawClaimed = 9,
        
        /// <summary>
        /// >> GaugeWithdrawn
        /// </summary>
        GaugeWithdrawn = 10,
        
        /// <summary>
        /// >> AllForceGaugeClaimed
        /// </summary>
        AllForceGaugeClaimed = 11,
        
        /// <summary>
        /// >> PartiallyForceGaugeClaimed
        /// </summary>
        PartiallyForceGaugeClaimed = 12,
        
        /// <summary>
        /// >> AllRetired
        /// </summary>
        AllRetired = 13,
        
        /// <summary>
        /// >> PartiallyRetired
        /// </summary>
        PartiallyRetired = 14,
        
        /// <summary>
        /// >> RetireLimitSet
        /// </summary>
        RetireLimitSet = 15,
        
        /// <summary>
        /// >> RoundEnd
        /// </summary>
        RoundEnd = 16,
        
        /// <summary>
        /// >> RoundStartError
        /// </summary>
        RoundStartError = 17,
        
        /// <summary>
        /// >> RoundStart
        /// </summary>
        RoundStart = 18,
        
        /// <summary>
        /// >> Voted
        /// </summary>
        Voted = 19,
        
        /// <summary>
        /// >> BoostCharged
        /// </summary>
        BoostCharged = 20,
    }
    
    /// <summary>
    /// >> 513 - Variant[bifrost_farming.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.FarmingPoolCreated);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.FarmingPoolReset);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.FarmingPoolClosed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.FarmingPoolKilled);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.FarmingPoolEdited);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Primitive.Bool>>(Event.Charged);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>>>(Event.Deposited);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>>(Event.Withdrawn);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.Claimed);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.WithdrawClaimed);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.GaugeWithdrawn);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.AllForceGaugeClaimed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.PartiallyForceGaugeClaimed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.AllRetired);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.PartiallyRetired);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.RetireLimitSet);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.RoundEnd);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_runtime.EnumDispatchError>(Event.RoundStartError);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.RoundStart);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Percent>>>>(Event.Voted);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>>(Event.BoostCharged);
        }
    }
}
