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


namespace Opal.NetApi.Generated.Model.frame_support.traits.schedule
{
    
    
    /// <summary>
    /// >> DispatchTime
    /// </summary>
    public enum DispatchTime
    {
        
        /// <summary>
        /// >> At
        /// </summary>
        At = 0,
        
        /// <summary>
        /// >> After
        /// </summary>
        After = 1,
    }
    
    /// <summary>
    /// >> 217 - Variant[frame_support.traits.schedule.DispatchTime]
    /// </summary>
    public sealed class EnumDispatchTime : BaseEnumRust<DispatchTime>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumDispatchTime()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(DispatchTime.At);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(DispatchTime.After);
        }
    }
}
