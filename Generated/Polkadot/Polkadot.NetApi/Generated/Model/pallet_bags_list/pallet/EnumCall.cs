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


namespace Polkadot.NetApi.Generated.Model.pallet_bags_list.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> rebag
        /// See [`Pallet::rebag`].
        /// </summary>
        rebag = 0,
        
        /// <summary>
        /// >> put_in_front_of
        /// See [`Pallet::put_in_front_of`].
        /// </summary>
        put_in_front_of = 1,
        
        /// <summary>
        /// >> put_in_front_of_other
        /// See [`Pallet::put_in_front_of_other`].
        /// </summary>
        put_in_front_of_other = 2,
    }
    
    /// <summary>
    /// >> 305 - Variant[pallet_bags_list.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>
    {
    }
}
