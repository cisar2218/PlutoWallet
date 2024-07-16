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
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Bifrost.NetApi.Generated.Model.bifrost_ve_minting
{
    
    
    /// <summary>
    /// >> 488 - Composite[bifrost_ve_minting.VeConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class VeConfig : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount { get; set; }
        /// <summary>
        /// >> min_mint
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 MinMint { get; set; }
        /// <summary>
        /// >> min_block
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MinBlock { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "VeConfig";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(MinMint.Encode());
            result.AddRange(MinBlock.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            MinMint = new Substrate.NetApi.Model.Types.Primitive.U128();
            MinMint.Decode(byteArray, ref p);
            MinBlock = new Substrate.NetApi.Model.Types.Primitive.U32();
            MinBlock.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
