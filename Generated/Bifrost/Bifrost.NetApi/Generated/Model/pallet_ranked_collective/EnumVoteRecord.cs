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


namespace Bifrost.NetApi.Generated.Model.pallet_ranked_collective
{
    
    
    /// <summary>
    /// >> VoteRecord
    /// </summary>
    public enum VoteRecord
    {
        
        /// <summary>
        /// >> Aye
        /// </summary>
        Aye = 0,
        
        /// <summary>
        /// >> Nay
        /// </summary>
        Nay = 1,
    }
    
    /// <summary>
    /// >> 528 - Variant[pallet_ranked_collective.VoteRecord]
    /// </summary>
    public sealed class EnumVoteRecord : BaseEnumRust<VoteRecord>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumVoteRecord()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(VoteRecord.Aye);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(VoteRecord.Nay);
        }
    }
}
