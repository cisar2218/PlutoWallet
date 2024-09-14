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


namespace Bifrost.NetApi.Generated.Model.bifrost_vstoken_conversion.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> VsbondConvertToVsksm
        /// </summary>
        VsbondConvertToVsksm = 0,
        
        /// <summary>
        /// >> VsksmConvertToVsbond
        /// </summary>
        VsksmConvertToVsbond = 1,
        
        /// <summary>
        /// >> VsbondConvertToVsdot
        /// </summary>
        VsbondConvertToVsdot = 2,
        
        /// <summary>
        /// >> VsdotConvertToVsbond
        /// </summary>
        VsdotConvertToVsbond = 3,
        
        /// <summary>
        /// >> VsbondConvertToVstoken
        /// </summary>
        VsbondConvertToVstoken = 4,
        
        /// <summary>
        /// >> VstokenConvertToVsbond
        /// </summary>
        VstokenConvertToVsbond = 5,
        
        /// <summary>
        /// >> ExchangeFeeSet
        /// </summary>
        ExchangeFeeSet = 6,
        
        /// <summary>
        /// >> ExchangeRateSet
        /// </summary>
        ExchangeRateSet = 7,
        
        /// <summary>
        /// >> RelaychainLeaseSet
        /// </summary>
        RelaychainLeaseSet = 8,
    }
    
    /// <summary>
    /// >> 512 - Variant[bifrost_vstoken_conversion.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.VsbondConvertToVsksm);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.VsksmConvertToVsbond);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.VsbondConvertToVsdot);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.VsdotConvertToVsbond);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.VsbondConvertToVstoken);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.VstokenConvertToVsbond);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_vstoken_conversion.primitives.VstokenConversionExchangeFee>(Event.ExchangeFeeSet);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.I32, Bifrost.NetApi.Generated.Model.bifrost_vstoken_conversion.primitives.VstokenConversionExchangeRate>>(Event.ExchangeRateSet);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.RelaychainLeaseSet);
        }
    }
}
