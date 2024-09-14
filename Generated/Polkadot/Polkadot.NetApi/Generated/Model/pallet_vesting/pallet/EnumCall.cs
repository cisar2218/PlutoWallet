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


namespace Polkadot.NetApi.Generated.Model.pallet_vesting.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> vest
        /// See [`Pallet::vest`].
        /// </summary>
        vest = 0,
        
        /// <summary>
        /// >> vest_other
        /// See [`Pallet::vest_other`].
        /// </summary>
        vest_other = 1,
        
        /// <summary>
        /// >> vested_transfer
        /// See [`Pallet::vested_transfer`].
        /// </summary>
        vested_transfer = 2,
        
        /// <summary>
        /// >> force_vested_transfer
        /// See [`Pallet::force_vested_transfer`].
        /// </summary>
        force_vested_transfer = 3,
        
        /// <summary>
        /// >> merge_schedules
        /// See [`Pallet::merge_schedules`].
        /// </summary>
        merge_schedules = 4,
        
        /// <summary>
        /// >> force_remove_vesting_schedule
        /// See [`Pallet::force_remove_vesting_schedule`].
        /// </summary>
        force_remove_vesting_schedule = 5,
    }
    
    /// <summary>
    /// >> 188 - Variant[pallet_vesting.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseVoid>(Call.vest);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.vest_other);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Polkadot.NetApi.Generated.Model.pallet_vesting.vesting_info.VestingInfo>>(Call.vested_transfer);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Polkadot.NetApi.Generated.Model.pallet_vesting.vesting_info.VestingInfo>>(Call.force_vested_transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.merge_schedules);
				AddTypeDecoder<BaseTuple<Polkadot.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.force_remove_vesting_schedule);
        }
    }
}
