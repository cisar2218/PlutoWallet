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


namespace PolkadotAssetHub.NetApi.Generated.Model.frame_system.extensions.check_mortality
{
    
    
    /// <summary>
    /// >> 462 - Composite[frame_system.extensions.check_mortality.CheckMortality]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CheckMortality : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        public PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.generic.era.EnumEra Value { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CheckMortality";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.generic.era.EnumEra();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
