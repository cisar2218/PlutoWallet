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
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> create_farming_pool
        /// See [`Pallet::create_farming_pool`].
        /// </summary>
        create_farming_pool = 0,
        
        /// <summary>
        /// >> charge
        /// See [`Pallet::charge`].
        /// </summary>
        charge = 1,
        
        /// <summary>
        /// >> deposit
        /// See [`Pallet::deposit`].
        /// </summary>
        deposit = 2,
        
        /// <summary>
        /// >> withdraw
        /// See [`Pallet::withdraw`].
        /// </summary>
        withdraw = 3,
        
        /// <summary>
        /// >> claim
        /// See [`Pallet::claim`].
        /// </summary>
        claim = 4,
        
        /// <summary>
        /// >> withdraw_claim
        /// See [`Pallet::withdraw_claim`].
        /// </summary>
        withdraw_claim = 5,
        
        /// <summary>
        /// >> force_retire_pool
        /// See [`Pallet::force_retire_pool`].
        /// </summary>
        force_retire_pool = 6,
        
        /// <summary>
        /// >> set_retire_limit
        /// See [`Pallet::set_retire_limit`].
        /// </summary>
        set_retire_limit = 7,
        
        /// <summary>
        /// >> close_pool
        /// See [`Pallet::close_pool`].
        /// </summary>
        close_pool = 8,
        
        /// <summary>
        /// >> reset_pool
        /// See [`Pallet::reset_pool`].
        /// </summary>
        reset_pool = 9,
        
        /// <summary>
        /// >> kill_pool
        /// See [`Pallet::kill_pool`].
        /// </summary>
        kill_pool = 10,
        
        /// <summary>
        /// >> edit_pool
        /// See [`Pallet::edit_pool`].
        /// </summary>
        edit_pool = 11,
        
        /// <summary>
        /// >> gauge_withdraw
        /// See [`Pallet::gauge_withdraw`].
        /// </summary>
        gauge_withdraw = 12,
        
        /// <summary>
        /// >> force_gauge_claim
        /// See [`Pallet::force_gauge_claim`].
        /// </summary>
        force_gauge_claim = 13,
        
        /// <summary>
        /// >> add_boost_pool_whitelist
        /// See [`Pallet::add_boost_pool_whitelist`].
        /// </summary>
        add_boost_pool_whitelist = 14,
        
        /// <summary>
        /// >> set_next_round_whitelist
        /// See [`Pallet::set_next_round_whitelist`].
        /// </summary>
        set_next_round_whitelist = 15,
        
        /// <summary>
        /// >> vote
        /// See [`Pallet::vote`].
        /// </summary>
        vote = 16,
        
        /// <summary>
        /// >> start_boost_round
        /// See [`Pallet::start_boost_round`].
        /// </summary>
        start_boost_round = 17,
        
        /// <summary>
        /// >> end_boost_round
        /// See [`Pallet::end_boost_round`].
        /// </summary>
        end_boost_round = 18,
        
        /// <summary>
        /// >> charge_boost
        /// See [`Pallet::charge_boost`].
        /// </summary>
        charge_boost = 19,
    }
    
    /// <summary>
    /// >> 371 - Variant[bifrost_farming.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill>>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>>>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U8>>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Percent>>, Substrate.NetApi.Model.Types.Primitive.U32, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>
    {
    }
}
