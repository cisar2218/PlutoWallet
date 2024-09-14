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


namespace Opal.NetApi.Generated.Model.pallet_referenda.types
{
    
    
    /// <summary>
    /// >> Curve
    /// </summary>
    public enum Curve
    {
        
        /// <summary>
        /// >> LinearDecreasing
        /// </summary>
        LinearDecreasing = 0,
        
        /// <summary>
        /// >> SteppedDecreasing
        /// </summary>
        SteppedDecreasing = 1,
        
        /// <summary>
        /// >> Reciprocal
        /// </summary>
        Reciprocal = 2,
    }
    
    /// <summary>
    /// >> 532 - Variant[pallet_referenda.types.Curve]
    /// </summary>
    public sealed class EnumCurve : BaseEnumRust<Curve>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCurve()
        {
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill, Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill, Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill>>(Curve.LinearDecreasing);
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill, Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill, Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill, Opal.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill>>(Curve.SteppedDecreasing);
				AddTypeDecoder<BaseTuple<Opal.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedI64, Opal.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedI64, Opal.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedI64>>(Curve.Reciprocal);
        }
    }
}
