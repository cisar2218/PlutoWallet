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


namespace Bifrost.NetApi.Generated.Model.bifrost_clouds_convert.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> clouds_to_vebnc
        /// </summary>
        clouds_to_vebnc = 0,
        
        /// <summary>
        /// >> charge_vbnc
        /// </summary>
        charge_vbnc = 1,
    }
    
    /// <summary>
    /// >> 451 - Variant[bifrost_clouds_convert.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.clouds_to_vebnc);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.charge_vbnc);
        }
    }
}
