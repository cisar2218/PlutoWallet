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


namespace Bifrost.NetApi.Generated.Model.bifrost_primitives.currency
{
    
    
    /// <summary>
    /// >> AssetIds
    /// </summary>
    public enum AssetIds
    {
        
        /// <summary>
        /// >> ForeignAssetId
        /// </summary>
        ForeignAssetId = 0,
        
        /// <summary>
        /// >> NativeAssetId
        /// </summary>
        NativeAssetId = 1,
    }
    
    /// <summary>
    /// >> 498 - Variant[bifrost_primitives.currency.AssetIds]
    /// </summary>
    public sealed class EnumAssetIds : BaseEnumRust<AssetIds>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumAssetIds()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(AssetIds.ForeignAssetId);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(AssetIds.NativeAssetId);
        }
    }
}
