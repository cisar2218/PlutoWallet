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


namespace Bifrost.NetApi.Generated.Model.bifrost_slp.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> DelegatorInitialized
        /// </summary>
        DelegatorInitialized = 0,
        
        /// <summary>
        /// >> DelegatorBonded
        /// </summary>
        DelegatorBonded = 1,
        
        /// <summary>
        /// >> DelegatorBondExtra
        /// </summary>
        DelegatorBondExtra = 2,
        
        /// <summary>
        /// >> DelegatorUnbond
        /// </summary>
        DelegatorUnbond = 3,
        
        /// <summary>
        /// >> DelegatorUnbondAll
        /// </summary>
        DelegatorUnbondAll = 4,
        
        /// <summary>
        /// >> DelegatorRebond
        /// </summary>
        DelegatorRebond = 5,
        
        /// <summary>
        /// >> Delegated
        /// </summary>
        Delegated = 6,
        
        /// <summary>
        /// >> Undelegated
        /// </summary>
        Undelegated = 7,
        
        /// <summary>
        /// >> Payout
        /// </summary>
        Payout = 8,
        
        /// <summary>
        /// >> Liquidize
        /// </summary>
        Liquidize = 9,
        
        /// <summary>
        /// >> Chill
        /// </summary>
        Chill = 10,
        
        /// <summary>
        /// >> TransferBack
        /// </summary>
        TransferBack = 11,
        
        /// <summary>
        /// >> TransferTo
        /// </summary>
        TransferTo = 12,
        
        /// <summary>
        /// >> ConvertAsset
        /// </summary>
        ConvertAsset = 13,
        
        /// <summary>
        /// >> DelegatorAdded
        /// </summary>
        DelegatorAdded = 14,
        
        /// <summary>
        /// >> DelegatorRemoved
        /// </summary>
        DelegatorRemoved = 15,
        
        /// <summary>
        /// >> ValidatorsAdded
        /// </summary>
        ValidatorsAdded = 16,
        
        /// <summary>
        /// >> ValidatorsRemoved
        /// </summary>
        ValidatorsRemoved = 17,
        
        /// <summary>
        /// >> Refund
        /// </summary>
        Refund = 18,
        
        /// <summary>
        /// >> FundMoveFromExitToEntrance
        /// </summary>
        FundMoveFromExitToEntrance = 19,
        
        /// <summary>
        /// >> TimeUnitUpdated
        /// </summary>
        TimeUnitUpdated = 20,
        
        /// <summary>
        /// >> PoolTokenIncreased
        /// </summary>
        PoolTokenIncreased = 21,
        
        /// <summary>
        /// >> HostingFeeCharged
        /// </summary>
        HostingFeeCharged = 22,
        
        /// <summary>
        /// >> PoolTokenDecreased
        /// </summary>
        PoolTokenDecreased = 23,
        
        /// <summary>
        /// >> FeeSupplemented
        /// </summary>
        FeeSupplemented = 24,
        
        /// <summary>
        /// >> ValidatorsByDelegatorSet
        /// </summary>
        ValidatorsByDelegatorSet = 25,
        
        /// <summary>
        /// >> OperateOriginSet
        /// </summary>
        OperateOriginSet = 26,
        
        /// <summary>
        /// >> FeeSourceSet
        /// </summary>
        FeeSourceSet = 27,
        
        /// <summary>
        /// >> DelegatorLedgerSet
        /// </summary>
        DelegatorLedgerSet = 28,
        
        /// <summary>
        /// >> DelegatorLedgerQueryResponseConfirmed
        /// </summary>
        DelegatorLedgerQueryResponseConfirmed = 29,
        
        /// <summary>
        /// >> DelegatorLedgerQueryResponseFailed
        /// </summary>
        DelegatorLedgerQueryResponseFailed = 30,
        
        /// <summary>
        /// >> ValidatorsByDelegatorQueryResponseConfirmed
        /// </summary>
        ValidatorsByDelegatorQueryResponseConfirmed = 31,
        
        /// <summary>
        /// >> ValidatorsByDelegatorQueryResponseFailed
        /// </summary>
        ValidatorsByDelegatorQueryResponseFailed = 32,
        
        /// <summary>
        /// >> MinimumsMaximumsSet
        /// </summary>
        MinimumsMaximumsSet = 33,
        
        /// <summary>
        /// >> CurrencyDelaysSet
        /// </summary>
        CurrencyDelaysSet = 34,
        
        /// <summary>
        /// >> HostingFeesSet
        /// </summary>
        HostingFeesSet = 35,
        
        /// <summary>
        /// >> CurrencyTuneExchangeRateLimitSet
        /// </summary>
        CurrencyTuneExchangeRateLimitSet = 36,
        
        /// <summary>
        /// >> OngoingTimeUnitUpdateIntervalSet
        /// </summary>
        OngoingTimeUnitUpdateIntervalSet = 37,
        
        /// <summary>
        /// >> SupplementFeeAccountWhitelistAdded
        /// </summary>
        SupplementFeeAccountWhitelistAdded = 38,
        
        /// <summary>
        /// >> SupplementFeeAccountWhitelistRemoved
        /// </summary>
        SupplementFeeAccountWhitelistRemoved = 39,
        
        /// <summary>
        /// >> ValidatorsReset
        /// </summary>
        ValidatorsReset = 40,
        
        /// <summary>
        /// >> ValidatorBoostListSet
        /// </summary>
        ValidatorBoostListSet = 41,
        
        /// <summary>
        /// >> ValidatorBoostListAdded
        /// </summary>
        ValidatorBoostListAdded = 42,
        
        /// <summary>
        /// >> RemovedFromBoostList
        /// </summary>
        RemovedFromBoostList = 43,
        
        /// <summary>
        /// >> OutdatedValidatorBoostListCleaned
        /// </summary>
        OutdatedValidatorBoostListCleaned = 44,
        
        /// <summary>
        /// >> BurnFeeFailed
        /// </summary>
        BurnFeeFailed = 45,
    }
    
    /// <summary>
    /// >> 468 - Variant[bifrost_slp.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U16>, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit>, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumTimeUnit>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U128>>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.EnumLedger>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.EnumLedgerUpdateEntry>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.EnumValidatorsByDelegatorUpdateEntry>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.MinimumsMaximums>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.Delays>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U32>>>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
