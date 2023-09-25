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


namespace PlutoWallet.NetApiExt.Generated.Model.hydradx_runtime.opaque
{
    
    
    /// <summary>
    /// >> 345 - Composite[hydradx_runtime.opaque.SessionKeys]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SessionKeys : BaseType
    {
        
        /// <summary>
        /// >> aura
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public _aura;
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public Aura
        {
            get
            {
                return this._aura;
            }
            set
            {
                this._aura = value;
            }
        }
        
        public override string TypeName()
        {
            return "SessionKeys";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Aura.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Aura = new PlutoWallet.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
            Aura.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
