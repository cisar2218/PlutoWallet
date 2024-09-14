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


namespace Bifrost.NetApi.Generated.Model.pallet_ranked_collective.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Account is already a member.
        /// </summary>
        AlreadyMember = 0,
        
        /// <summary>
        /// >> NotMember
        /// Account is not a member.
        /// </summary>
        NotMember = 1,
        
        /// <summary>
        /// >> NotPolling
        /// The given poll index is unknown or has closed.
        /// </summary>
        NotPolling = 2,
        
        /// <summary>
        /// >> Ongoing
        /// The given poll is still ongoing.
        /// </summary>
        Ongoing = 3,
        
        /// <summary>
        /// >> NoneRemaining
        /// There are no further records to be removed.
        /// </summary>
        NoneRemaining = 4,
        
        /// <summary>
        /// >> Corruption
        /// Unexpected error in state.
        /// </summary>
        Corruption = 5,
        
        /// <summary>
        /// >> RankTooLow
        /// The member's rank is too low to vote.
        /// </summary>
        RankTooLow = 6,
        
        /// <summary>
        /// >> InvalidWitness
        /// The information provided is incorrect.
        /// </summary>
        InvalidWitness = 7,
        
        /// <summary>
        /// >> NoPermission
        /// The origin is not sufficiently privileged to do the operation.
        /// </summary>
        NoPermission = 8,
        
        /// <summary>
        /// >> SameMember
        /// The new member to exchange is the same as the old member
        /// </summary>
        SameMember = 9,
    }
    
    /// <summary>
    /// >> 906 - Variant[pallet_ranked_collective.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
