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


namespace Hydration.NetApi.Generated.Model.pallet_elections_phragmen.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> vote
        /// See [`Pallet::vote`].
        /// </summary>
        vote = 0,
        
        /// <summary>
        /// >> remove_voter
        /// See [`Pallet::remove_voter`].
        /// </summary>
        remove_voter = 1,
        
        /// <summary>
        /// >> submit_candidacy
        /// See [`Pallet::submit_candidacy`].
        /// </summary>
        submit_candidacy = 2,
        
        /// <summary>
        /// >> renounce_candidacy
        /// See [`Pallet::renounce_candidacy`].
        /// </summary>
        renounce_candidacy = 3,
        
        /// <summary>
        /// >> remove_member
        /// See [`Pallet::remove_member`].
        /// </summary>
        remove_member = 4,
        
        /// <summary>
        /// >> clean_defunct_voters
        /// See [`Pallet::clean_defunct_voters`].
        /// </summary>
        clean_defunct_voters = 5,
    }
    
    /// <summary>
    /// >> 340 - Variant[pallet_elections_phragmen.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>>(Call.vote);
				AddTypeDecoder<BaseVoid>(Call.remove_voter);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.submit_candidacy);
				AddTypeDecoder<Hydration.NetApi.Generated.Model.pallet_elections_phragmen.EnumRenouncing>(Call.renounce_candidacy);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.remove_member);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.clean_defunct_voters);
        }
    }
}
