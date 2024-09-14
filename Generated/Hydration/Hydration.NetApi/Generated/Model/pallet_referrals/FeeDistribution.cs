//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_referrals
{
    
    
    /// <summary>
    /// >> 122 - Composite[pallet_referrals.FeeDistribution]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class FeeDistribution : BaseType
    {
        
        /// <summary>
        /// >> referrer
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill Referrer { get; set; }
        /// <summary>
        /// >> trader
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill Trader { get; set; }
        /// <summary>
        /// >> external
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill External { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "FeeDistribution";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Referrer.Encode());
            result.AddRange(Trader.Encode());
            result.AddRange(External.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Referrer = new Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            Referrer.Decode(byteArray, ref p);
            Trader = new Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            Trader.Decode(byteArray, ref p);
            External = new Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            External.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
