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


namespace Hydration.NetApi.Generated.Model.hydradx_traits.oracle
{
    
    
    /// <summary>
    /// >> 753 - Composite[hydradx_traits.oracle.Liquidity]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Liquidity : BaseType
    {
        
        /// <summary>
        /// >> a
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 A { get; set; }
        /// <summary>
        /// >> b
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 B { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Liquidity";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(A.Encode());
            result.AddRange(B.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            A = new Substrate.NetApi.Model.Types.Primitive.U128();
            A.Decode(byteArray, ref p);
            B = new Substrate.NetApi.Model.Types.Primitive.U128();
            B.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
