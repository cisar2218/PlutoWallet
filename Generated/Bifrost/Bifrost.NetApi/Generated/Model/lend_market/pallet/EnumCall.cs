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


namespace Bifrost.NetApi.Generated.Model.lend_market.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> add_market
        /// Stores a new market and its related currency. Returns `Err` if a currency
        /// is not attached to an existent market.
        /// 
        /// All provided market states must be `Pending`, otherwise an error will be returned.
        /// 
        /// If a currency is already attached to a market, then the market will be replaced
        /// by the new provided value.
        /// 
        /// The lend token id and asset id are bound, the lend token id of new provided market
        /// cannot be duplicated with the existing one, otherwise it will return
        /// `InvalidLendTokenId`.
        /// 
        /// - `asset_id`: Market related currency
        /// - `market`: The market that is going to be stored
        /// </summary>
        add_market = 0,
        
        /// <summary>
        /// >> activate_market
        /// Activates a market. Returns `Err` if the market currency does not exist.
        /// 
        /// If the market is already activated, does nothing.
        /// 
        /// - `asset_id`: Market related currency
        /// </summary>
        activate_market = 1,
        
        /// <summary>
        /// >> update_rate_model
        /// Updates the rate model of a stored market. Returns `Err` if the market
        /// currency does not exist or the rate model is invalid.
        /// 
        /// - `asset_id`: Market related currency
        /// - `rate_model`: The new rate model to be updated
        /// </summary>
        update_rate_model = 2,
        
        /// <summary>
        /// >> update_market
        /// Updates a stored market. Returns `Err` if the market currency does not exist.
        /// 
        /// - `asset_id`: market related currency
        /// - `collateral_factor`: the collateral utilization ratio
        /// - `reserve_factor`: fraction of interest currently set aside for reserves
        /// - `close_factor`: maximum liquidation ratio at one time
        /// - `liquidate_incentive`: liquidation incentive ratio
        /// - `cap`: market capacity
        /// </summary>
        update_market = 3,
        
        /// <summary>
        /// >> force_update_market
        /// Force updates a stored market. Returns `Err` if the market currency
        /// does not exist.
        /// 
        /// - `asset_id`: market related currency
        /// - `market`: the new market parameters
        /// </summary>
        force_update_market = 4,
        
        /// <summary>
        /// >> add_reward
        /// Add reward for the pallet account.
        /// 
        /// - `amount`: Reward amount added
        /// </summary>
        add_reward = 5,
        
        /// <summary>
        /// >> withdraw_missing_reward
        /// Withdraw reward token from pallet account.
        /// 
        /// The origin must conform to `UpdateOrigin`.
        /// 
        /// - `target_account`: account receive reward token.
        /// - `amount`: Withdraw amount
        /// </summary>
        withdraw_missing_reward = 6,
        
        /// <summary>
        /// >> update_market_reward_speed
        /// Updates reward speed for the specified market
        /// 
        /// The origin must conform to `UpdateOrigin`.
        /// 
        /// - `asset_id`: Market related currency
        /// - `reward_per_block`: reward amount per block.
        /// </summary>
        update_market_reward_speed = 7,
        
        /// <summary>
        /// >> claim_reward
        /// Claim reward from all market.
        /// </summary>
        claim_reward = 8,
        
        /// <summary>
        /// >> claim_reward_for_market
        /// Claim reward from the specified market.
        /// 
        /// - `asset_id`: Market related currency
        /// </summary>
        claim_reward_for_market = 9,
        
        /// <summary>
        /// >> mint
        /// Sender supplies assets into the market and receives internal supplies in exchange.
        /// 
        /// - `asset_id`: the asset to be deposited.
        /// - `mint_amount`: the amount to be deposited.
        /// </summary>
        mint = 10,
        
        /// <summary>
        /// >> redeem
        /// Sender redeems some of internal supplies in exchange for the underlying asset.
        /// 
        /// - `asset_id`: the asset to be redeemed.
        /// - `redeem_amount`: the amount to be redeemed.
        /// </summary>
        redeem = 11,
        
        /// <summary>
        /// >> redeem_all
        /// Sender redeems all of internal supplies in exchange for the underlying asset.
        /// 
        /// - `asset_id`: the asset to be redeemed.
        /// </summary>
        redeem_all = 12,
        
        /// <summary>
        /// >> borrow
        /// Sender borrows assets from the protocol to their own address.
        /// 
        /// - `asset_id`: the asset to be borrowed.
        /// - `borrow_amount`: the amount to be borrowed.
        /// </summary>
        borrow = 13,
        
        /// <summary>
        /// >> repay_borrow
        /// Sender repays some of their debts.
        /// 
        /// - `asset_id`: the asset to be repaid.
        /// - `repay_amount`: the amount to be repaid.
        /// </summary>
        repay_borrow = 14,
        
        /// <summary>
        /// >> repay_borrow_all
        /// Sender repays all of their debts.
        /// 
        /// - `asset_id`: the asset to be repaid.
        /// </summary>
        repay_borrow_all = 15,
        
        /// <summary>
        /// >> collateral_asset
        /// Set the collateral asset.
        /// 
        /// - `asset_id`: the asset to be set.
        /// - `enable`: turn on/off the collateral option.
        /// </summary>
        collateral_asset = 16,
        
        /// <summary>
        /// >> liquidate_borrow
        /// The sender liquidates the borrower's collateral.
        /// 
        /// - `borrower`: the borrower to be liquidated.
        /// - `liquidation_asset_id`: the assert to be liquidated.
        /// - `repay_amount`: the amount to be repaid borrow.
        /// - `collateral_asset_id`: The collateral to seize from the borrower.
        /// </summary>
        liquidate_borrow = 17,
        
        /// <summary>
        /// >> add_reserves
        /// Add reserves by transferring from payer.
        /// 
        /// May only be called from `T::ReserveOrigin`.
        /// 
        /// - `payer`: the payer account.
        /// - `asset_id`: the assets to be added.
        /// - `add_amount`: the amount to be added.
        /// </summary>
        add_reserves = 18,
        
        /// <summary>
        /// >> reduce_reserves
        /// Reduces reserves by transferring to receiver.
        /// 
        /// May only be called from `T::ReserveOrigin`.
        /// 
        /// - `receiver`: the receiver account.
        /// - `asset_id`: the assets to be reduced.
        /// - `reduce_amount`: the amount to be reduced.
        /// </summary>
        reduce_reserves = 19,
        
        /// <summary>
        /// >> reduce_incentive_reserves
        /// Sender redeems some of internal supplies in exchange for the underlying asset.
        /// 
        /// - `asset_id`: the asset to be redeemed.
        /// - `redeem_amount`: the amount to be redeemed.
        /// </summary>
        reduce_incentive_reserves = 20,
        
        /// <summary>
        /// >> update_liquidation_free_collateral
        /// Update liquidation free collateral.
        /// 
        /// The `assets` won't be counted when do general
        /// </summary>
        update_liquidation_free_collateral = 21,
        
        /// <summary>
        /// >> add_market_bond
        /// </summary>
        add_market_bond = 22,
    }
    
    /// <summary>
    /// >> 436 - Variant[lend_market.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.lend_market.types.Market>>(Call.add_market);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.activate_market);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.lend_market.rate_model.EnumInterestRateModel>>(Call.update_rate_model);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.update_market);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.lend_market.types.Market>>(Call.force_update_market);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.add_reward);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.withdraw_missing_reward);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.update_market_reward_speed);
				AddTypeDecoder<BaseVoid>(Call.claim_reward);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.claim_reward_for_market);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.mint);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.redeem);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.redeem_all);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.borrow);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.repay_borrow);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.repay_borrow_all);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.collateral_asset);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>>(Call.liquidate_borrow);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.add_reserves);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.reduce_reserves);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.reduce_incentive_reserves);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>>(Call.update_liquidation_free_collateral);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>>>(Call.add_market_bond);
        }
    }
}
