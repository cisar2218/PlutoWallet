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


namespace Opal.NetApi.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 608 - Composite[up_data_structs.RpcCollectionFlags]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RpcCollectionFlags : BaseType
    {
        
        /// <summary>
        /// >> foreign
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool Foreign { get; set; }
        /// <summary>
        /// >> erc721metadata
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool Erc721metadata { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "RpcCollectionFlags";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Foreign.Encode());
            result.AddRange(Erc721metadata.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Foreign = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Foreign.Decode(byteArray, ref p);
            Erc721metadata = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Erc721metadata.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
