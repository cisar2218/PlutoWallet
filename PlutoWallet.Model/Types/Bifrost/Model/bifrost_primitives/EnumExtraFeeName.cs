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


namespace Bifrost.NetApi.Generated.Model.bifrost_primitives
{
    
    
    /// <summary>
    /// >> ExtraFeeName
    /// </summary>
    public enum ExtraFeeName
    {
        
        /// <summary>
        /// >> SalpContribute
        /// </summary>
        SalpContribute = 0,
        
        /// <summary>
        /// >> StatemineTransfer
        /// </summary>
        StatemineTransfer = 1,
        
        /// <summary>
        /// >> VoteVtoken
        /// </summary>
        VoteVtoken = 2,
        
        /// <summary>
        /// >> VoteRemoveDelegatorVote
        /// </summary>
        VoteRemoveDelegatorVote = 3,
        
        /// <summary>
        /// >> NoExtraFee
        /// </summary>
        NoExtraFee = 4,
    }
    
    /// <summary>
    /// >> 420 - Variant[bifrost_primitives.ExtraFeeName]
    /// </summary>
    public sealed class EnumExtraFeeName : BaseEnum<ExtraFeeName>
    {
    }
}