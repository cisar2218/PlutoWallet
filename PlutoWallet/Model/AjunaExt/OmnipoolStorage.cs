//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace PlutoWallet.Model.AjunaExt
{
    public sealed class OmnipoolStorage
    {
        
        // Substrate client for the storage calls.
        private AjunaClientExt _client;
        
        public OmnipoolStorage(AjunaClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Omnipool", "Assets"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.NetApi.Generated.Model.pallet_omnipool.types.AssetState)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Omnipool", "HubAssetImbalance"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Generated.Model.pallet_omnipool.types.SimpleImbalance)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Omnipool", "HubAssetTradability"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Generated.Model.pallet_omnipool.types.Tradability)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Omnipool", "Positions"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U128), typeof(Substrate.NetApi.Generated.Model.pallet_omnipool.types.Position)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Omnipool", "NextPositionId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Omnipool", "TvlCap"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
        }
        
        /// <summary>
        /// >> AssetsParams
        ///  State of an asset in the omnipool
        /// </summary>
        public static string AssetsParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Omnipool", "Assets", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AssetsDefault
        /// Default value as hex string
        /// </summary>
        public static string AssetsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Assets
        ///  State of an asset in the omnipool
        /// </summary>
        public async Task<Substrate.NetApi.Generated.Model.pallet_omnipool.types.AssetState> Assets(Substrate.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = OmnipoolStorage.AssetsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Generated.Model.pallet_omnipool.types.AssetState>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> HubAssetImbalanceParams
        ///  Imbalance of hub asset
        /// </summary>
        public static string HubAssetImbalanceParams()
        {
            return RequestGenerator.GetStorage("Omnipool", "HubAssetImbalance", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> HubAssetImbalanceDefault
        /// Default value as hex string
        /// </summary>
        public static string HubAssetImbalanceDefault()
        {
            return "0x0000000000000000000000000000000001";
        }
        
        /// <summary>
        /// >> HubAssetImbalance
        ///  Imbalance of hub asset
        /// </summary>
        public async Task<Substrate.NetApi.Generated.Model.pallet_omnipool.types.SimpleImbalance> HubAssetImbalance(CancellationToken token)
        {
            string parameters = OmnipoolStorage.HubAssetImbalanceParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Generated.Model.pallet_omnipool.types.SimpleImbalance>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> HubAssetTradabilityParams
        ///  Tradable state of hub asset.
        /// </summary>
        public static string HubAssetTradabilityParams()
        {
            return RequestGenerator.GetStorage("Omnipool", "HubAssetTradability", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> HubAssetTradabilityDefault
        /// Default value as hex string
        /// </summary>
        public static string HubAssetTradabilityDefault()
        {
            return "0x0F";
        }
        
        /// <summary>
        /// >> HubAssetTradability
        ///  Tradable state of hub asset.
        /// </summary>
        public async Task<Substrate.NetApi.Generated.Model.pallet_omnipool.types.Tradability> HubAssetTradability(CancellationToken token)
        {
            string parameters = OmnipoolStorage.HubAssetTradabilityParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Generated.Model.pallet_omnipool.types.Tradability>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> PositionsParams
        ///  LP positions. Maps NFT instance id to corresponding position
        /// </summary>
        public static string PositionsParams(Substrate.NetApi.Model.Types.Primitive.U128 key)
        {
            return RequestGenerator.GetStorage("Omnipool", "Positions", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PositionsDefault
        /// Default value as hex string
        /// </summary>
        public static string PositionsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Positions
        ///  LP positions. Maps NFT instance id to corresponding position
        /// </summary>
        public async Task<Substrate.NetApi.Generated.Model.pallet_omnipool.types.Position> Positions(Substrate.NetApi.Model.Types.Primitive.U128 key, CancellationToken token)
        {
            string parameters = OmnipoolStorage.PositionsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Generated.Model.pallet_omnipool.types.Position>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> NextPositionIdParams
        ///  Position ids sequencer
        /// </summary>
        public static string NextPositionIdParams()
        {
            return RequestGenerator.GetStorage("Omnipool", "NextPositionId", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NextPositionIdDefault
        /// Default value as hex string
        /// </summary>
        public static string NextPositionIdDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> NextPositionId
        ///  Position ids sequencer
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> NextPositionId(CancellationToken token)
        {
            string parameters = OmnipoolStorage.NextPositionIdParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> TvlCapParams
        ///  TVL cap
        /// </summary>
        public static string TvlCapParams()
        {
            return RequestGenerator.GetStorage("Omnipool", "TvlCap", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> TvlCapDefault
        /// Default value as hex string
        /// </summary>
        public static string TvlCapDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> TvlCap
        ///  TVL cap
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> TvlCap(CancellationToken token)
        {
            string parameters = OmnipoolStorage.TvlCapParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, token);
            return result;
        }
    }
    
    public sealed class OmnipoolCalls
    {
        
        /// <summary>
        /// >> initialize_pool
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InitializePool(NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 stable_asset_price, NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 native_asset_price, NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill stable_weight_cap, NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill native_weight_cap)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(stable_asset_price.Encode());
            byteArray.AddRange(native_asset_price.Encode());
            byteArray.AddRange(stable_weight_cap.Encode());
            byteArray.AddRange(native_weight_cap.Encode());
            return new Method(59, "Omnipool", 0, "initialize_pool", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> add_token
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddToken(Substrate.NetApi.Model.Types.Primitive.U32 asset, NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128 initial_price, NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill weight_cap, NetApiExt.Generated.Model.sp_core.crypto.AccountId32 position_owner)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset.Encode());
            byteArray.AddRange(initial_price.Encode());
            byteArray.AddRange(weight_cap.Encode());
            byteArray.AddRange(position_owner.Encode());
            return new Method(59, "Omnipool", 1, "add_token", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> add_liquidity
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddLiquidity(Substrate.NetApi.Model.Types.Primitive.U32 asset, Substrate.NetApi.Model.Types.Primitive.U128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(59, "Omnipool", 2, "add_liquidity", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_liquidity
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveLiquidity(Substrate.NetApi.Model.Types.Primitive.U128 position_id, Substrate.NetApi.Model.Types.Primitive.U128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(position_id.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(59, "Omnipool", 3, "remove_liquidity", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sacrifice_position
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SacrificePosition(Substrate.NetApi.Model.Types.Primitive.U128 position_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(position_id.Encode());
            return new Method(59, "Omnipool", 4, "sacrifice_position", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sell
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Sell(Substrate.NetApi.Model.Types.Primitive.U32 asset_in, Substrate.NetApi.Model.Types.Primitive.U32 asset_out, Substrate.NetApi.Model.Types.Primitive.U128 amount, Substrate.NetApi.Model.Types.Primitive.U128 min_buy_amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_in.Encode());
            byteArray.AddRange(asset_out.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(min_buy_amount.Encode());
            return new Method(59, "Omnipool", 5, "sell", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> buy
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Buy(Substrate.NetApi.Model.Types.Primitive.U32 asset_out, Substrate.NetApi.Model.Types.Primitive.U32 asset_in, Substrate.NetApi.Model.Types.Primitive.U128 amount, Substrate.NetApi.Model.Types.Primitive.U128 max_sell_amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_out.Encode());
            byteArray.AddRange(asset_in.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(max_sell_amount.Encode());
            return new Method(59, "Omnipool", 6, "buy", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_asset_tradable_state
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetAssetTradableState(Substrate.NetApi.Model.Types.Primitive.U32 asset_id, Substrate.NetApi.Generated.Model.pallet_omnipool.types.Tradability state)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(state.Encode());
            return new Method(59, "Omnipool", 7, "set_asset_tradable_state", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> refund_refused_asset
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RefundRefusedAsset(Substrate.NetApi.Model.Types.Primitive.U32 asset_id, Substrate.NetApi.Model.Types.Primitive.U128 amount, NetApiExt.Generated.Model.sp_core.crypto.AccountId32 recipient)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(recipient.Encode());
            return new Method(59, "Omnipool", 8, "refund_refused_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_asset_weight_cap
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetAssetWeightCap(Substrate.NetApi.Model.Types.Primitive.U32 asset_id, NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill cap)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(cap.Encode());
            return new Method(59, "Omnipool", 9, "set_asset_weight_cap", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_tvl_cap
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetTvlCap(Substrate.NetApi.Model.Types.Primitive.U128 cap)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(cap.Encode());
            return new Method(59, "Omnipool", 10, "set_tvl_cap", byteArray.ToArray());
        }
    }
    
    public sealed class OmnipoolConstants
    {
        
        /// <summary>
        /// >> HdxAssetId
        ///  Native Asset ID
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 HdxAssetId()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00000000");
            return result;
        }
        
        /// <summary>
        /// >> HubAssetId
        ///  Hub Asset ID
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 HubAssetId()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x01000000");
            return result;
        }
        
        /// <summary>
        /// >> StableCoinAssetId
        ///  Preferred stable Asset ID
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 StableCoinAssetId()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x02000000");
            return result;
        }
        
        /// <summary>
        /// >> MinWithdrawalFee
        ///  Minimum withdrawal fee
        /// </summary>
        public NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill MinWithdrawalFee()
        {
            var result = new NetApiExt.Generated.Model.sp_arithmetic.per_things.Permill();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MinimumTradingLimit
        ///  Minimum trading limit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinimumTradingLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0xE8030000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MinimumPoolLiquidity
        ///  Minimum pool liquidity which can be added
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinimumPoolLiquidity()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x40420F00000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxInRatio
        ///  Max fraction of asset reserve to sell in single transaction
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MaxInRatio()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x03000000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxOutRatio
        ///  Max fraction of asset reserve to buy in single transaction
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MaxOutRatio()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x03000000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> NFTCollectionId
        ///  Non fungible class id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 NFTCollectionId()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x39050000000000000000000000000000");
            return result;
        }
    }
    
    public enum OmnipoolErrors
    {
        
        /// <summary>
        /// >> InsufficientBalance
        /// Balance too low
        /// </summary>
        InsufficientBalance,
        
        /// <summary>
        /// >> AssetAlreadyAdded
        /// Asset is already in omnipool
        /// </summary>
        AssetAlreadyAdded,
        
        /// <summary>
        /// >> AssetNotFound
        /// Asset is not in omnipool
        /// </summary>
        AssetNotFound,
        
        /// <summary>
        /// >> NoStableAssetInPool
        /// No stable asset in the pool
        /// </summary>
        NoStableAssetInPool,
        
        /// <summary>
        /// >> NoNativeAssetInPool
        /// No native asset in the pool yet.
        /// </summary>
        NoNativeAssetInPool,
        
        /// <summary>
        /// >> MissingBalance
        /// Adding token as protocol ( root ), token balance has not been updated prior to add token.
        /// </summary>
        MissingBalance,
        
        /// <summary>
        /// >> InvalidInitialAssetPrice
        /// Invalid initial asset price. Price must be non-zero.
        /// </summary>
        InvalidInitialAssetPrice,
        
        /// <summary>
        /// >> BuyLimitNotReached
        /// Minimum limit has not been reached during trade.
        /// </summary>
        BuyLimitNotReached,
        
        /// <summary>
        /// >> SellLimitExceeded
        /// Maximum limit has been exceeded during trade.
        /// </summary>
        SellLimitExceeded,
        
        /// <summary>
        /// >> PositionNotFound
        /// Position has not been found.
        /// </summary>
        PositionNotFound,
        
        /// <summary>
        /// >> InsufficientShares
        /// Insufficient shares in position
        /// </summary>
        InsufficientShares,
        
        /// <summary>
        /// >> NotAllowed
        /// Asset is not allowed to be bought or sold
        /// </summary>
        NotAllowed,
        
        /// <summary>
        /// >> Forbidden
        /// Signed account is not owner of position instance.
        /// </summary>
        Forbidden,
        
        /// <summary>
        /// >> AssetWeightCapExceeded
        /// Asset weight cap has been exceeded.
        /// </summary>
        AssetWeightCapExceeded,
        
        /// <summary>
        /// >> TVLCapExceeded
        /// TVL cap has been exceeded
        /// </summary>
        TVLCapExceeded,
        
        /// <summary>
        /// >> AssetNotRegistered
        /// Asset is not registered in asset registry
        /// </summary>
        AssetNotRegistered,
        
        /// <summary>
        /// >> InsufficientLiquidity
        /// Provided liquidity is below minimum allowed limit
        /// </summary>
        InsufficientLiquidity,
        
        /// <summary>
        /// >> InsufficientTradingAmount
        /// Traded amount is below minimum allowed limit
        /// </summary>
        InsufficientTradingAmount,
        
        /// <summary>
        /// >> SameAssetTradeNotAllowed
        /// Sell or buy with same asset ids is not allowed.
        /// </summary>
        SameAssetTradeNotAllowed,
        
        /// <summary>
        /// >> HubAssetUpdateError
        /// LRNA update after trade results in positive value.
        /// </summary>
        HubAssetUpdateError,
        
        /// <summary>
        /// >> PositiveImbalance
        /// Imbalance results in positive value.
        /// </summary>
        PositiveImbalance,
        
        /// <summary>
        /// >> InvalidSharesAmount
        /// Amount of shares provided cannot be 0.
        /// </summary>
        InvalidSharesAmount,
        
        /// <summary>
        /// >> InvalidHubAssetTradableState
        /// HJb Asset's trabable is only allowed to be SELL or BUY.
        /// </summary>
        InvalidHubAssetTradableState,
        
        /// <summary>
        /// >> AssetRefundNotAllowed
        /// Asset is not allowed to be refunded.
        /// </summary>
        AssetRefundNotAllowed,
        
        /// <summary>
        /// >> MaxOutRatioExceeded
        /// Max fraction of asset reserve to buy has been exceeded.
        /// </summary>
        MaxOutRatioExceeded,
        
        /// <summary>
        /// >> MaxInRatioExceeded
        /// Max fraction of asset reserve to sell has been exceeded.
        /// </summary>
        MaxInRatioExceeded,
        
        /// <summary>
        /// >> PriceDifferenceTooHigh
        /// Max allowed price difference has been exceeded.
        /// </summary>
        PriceDifferenceTooHigh,
        
        /// <summary>
        /// >> InvalidOraclePrice
        /// Invalid oracle price - division by zero.
        /// </summary>
        InvalidOraclePrice,
        
        /// <summary>
        /// >> InvalidWithdrawalFee
        /// Failed to calculate withdrawal fee.
        /// </summary>
        InvalidWithdrawalFee,
        
        /// <summary>
        /// >> FeeOverdraft
        /// More than allowed amount of fee has been transferred.
        /// </summary>
        FeeOverdraft,
    }
}
