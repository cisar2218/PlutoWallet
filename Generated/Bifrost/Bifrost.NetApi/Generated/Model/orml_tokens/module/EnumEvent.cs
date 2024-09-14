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


namespace Bifrost.NetApi.Generated.Model.orml_tokens.module
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Endowed
        /// An account was created with some free balance.
        /// </summary>
        Endowed = 0,
        
        /// <summary>
        /// >> DustLost
        /// An account was removed whose balance was non-zero but below
        /// ExistentialDeposit, resulting in an outright loss.
        /// </summary>
        DustLost = 1,
        
        /// <summary>
        /// >> Transfer
        /// Transfer succeeded.
        /// </summary>
        Transfer = 2,
        
        /// <summary>
        /// >> Reserved
        /// Some balance was reserved (moved from free to reserved).
        /// </summary>
        Reserved = 3,
        
        /// <summary>
        /// >> Unreserved
        /// Some balance was unreserved (moved from reserved to free).
        /// </summary>
        Unreserved = 4,
        
        /// <summary>
        /// >> ReserveRepatriated
        /// Some reserved balance was repatriated (moved from reserved to
        /// another account).
        /// </summary>
        ReserveRepatriated = 5,
        
        /// <summary>
        /// >> BalanceSet
        /// A balance was set by root.
        /// </summary>
        BalanceSet = 6,
        
        /// <summary>
        /// >> TotalIssuanceSet
        /// The total issuance of an currency has been set
        /// </summary>
        TotalIssuanceSet = 7,
        
        /// <summary>
        /// >> Withdrawn
        /// Some balances were withdrawn (e.g. pay for transaction fee)
        /// </summary>
        Withdrawn = 8,
        
        /// <summary>
        /// >> Slashed
        /// Some balances were slashed (e.g. due to mis-behavior)
        /// </summary>
        Slashed = 9,
        
        /// <summary>
        /// >> Deposited
        /// Deposited some balance into an account
        /// </summary>
        Deposited = 10,
        
        /// <summary>
        /// >> LockSet
        /// Some funds are locked
        /// </summary>
        LockSet = 11,
        
        /// <summary>
        /// >> LockRemoved
        /// Some locked funds were unlocked
        /// </summary>
        LockRemoved = 12,
        
        /// <summary>
        /// >> Locked
        /// Some free balance was locked.
        /// </summary>
        Locked = 13,
        
        /// <summary>
        /// >> Unlocked
        /// Some locked balance was freed.
        /// </summary>
        Unlocked = 14,
        
        /// <summary>
        /// >> Issued
        /// </summary>
        Issued = 15,
        
        /// <summary>
        /// >> Rescinded
        /// </summary>
        Rescinded = 16,
    }
    
    /// <summary>
    /// >> 488 - Variant[orml_tokens.module.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Endowed);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.DustLost);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Transfer);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Reserved);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Unreserved);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.frame_support.traits.tokens.misc.EnumBalanceStatus>>(Event.ReserveRepatriated);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.BalanceSet);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.TotalIssuanceSet);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Withdrawn);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Slashed);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Deposited);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Types.Base.Arr8U8, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.LockSet);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Types.Base.Arr8U8, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.LockRemoved);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Locked);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Unlocked);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Issued);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Rescinded);
        }
    }
}
