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


namespace Bifrost.NetApi.Generated.Model.pallet_prices.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_price
        /// Set emergency price
        /// </summary>
        set_price = 0,
        
        /// <summary>
        /// >> reset_price
        /// Reset emergency price
        /// </summary>
        reset_price = 1,
        
        /// <summary>
        /// >> set_foreign_asset
        /// Set foreign vault token mapping
        /// </summary>
        set_foreign_asset = 2,
    }
    
    /// <summary>
    /// >> 443 - Variant[pallet_prices.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>>(Call.set_price);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.reset_price);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>>(Call.set_foreign_asset);
        }
    }
}
