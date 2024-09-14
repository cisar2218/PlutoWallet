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


namespace Bifrost.NetApi.Generated.Model.lend_market.rate_model
{
    
    
    /// <summary>
    /// >> 440 - Composite[lend_market.rate_model.CurveModel]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CurveModel : BaseType
    {
        
        /// <summary>
        /// >> base_rate
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 BaseRate { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CurveModel";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BaseRate.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BaseRate = new Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            BaseRate.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
