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


namespace Bifrost.NetApi.Generated.Model.merkle_distributor.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> add_to_create_whitelist
        /// </summary>
        add_to_create_whitelist = 0,
        
        /// <summary>
        /// >> remove_from_create_whitelist
        /// </summary>
        remove_from_create_whitelist = 1,
        
        /// <summary>
        /// >> create_merkle_distributor
        /// `create_merkle_distributor` will create a merkle distributor,
        ///  which allow specified users claim asset.
        /// 
        /// The dispatch origin for this call must be `Signed` by root.
        /// 
        /// - `merkle_root`: The root of a merkle tree.
        /// - `description`: About the purpose of this distribution.
        /// - `distribute_currency`: The id of currency about this distribution.
        /// - `distribute_amount`: The total currency amount of this distribution.
        /// </summary>
        create_merkle_distributor = 2,
        
        /// <summary>
        /// >> claim
        /// `claim` Claim rewards through user information and merkle proof.
        /// 
        /// - `merkle_distributor_id`: ID of a merkle distributor.
        /// - `index`: The index of the merkle tree leaf.
        /// - `account`: The owner's account of merkle proof.
        /// - `merkle_proof`: The hashes with merkle tree leaf can get merkle tree root.
        /// </summary>
        claim = 3,
        
        /// <summary>
        /// >> charge
        /// Charge currency to the account of merkle distributor
        /// 
        /// `merkle_distributor_id`: ID of a merkle distributor.
        /// </summary>
        charge = 4,
        
        /// <summary>
        /// >> emergency_withdraw
        /// </summary>
        emergency_withdraw = 5,
    }
    
    /// <summary>
    /// >> 330 - Variant[merkle_distributor.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Call.add_to_create_whitelist);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Call.remove_from_create_whitelist);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.create_merkle_distributor);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.primitive_types.H256>>>(Call.claim);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.charge);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.emergency_withdraw);
        }
    }
}
