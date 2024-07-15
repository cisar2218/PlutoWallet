//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAssetRegistryStorage interface definition.
    /// </summary>
    public interface IAssetRegistryStorage : IStorage
    {
        
        /// <summary>
        /// >> AssetIdLocation
        /// </summary>
        Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location GetAssetIdLocation(string key);
        
        /// <summary>
        /// >> AssetLocationId
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetAssetLocationId(string key);
    }
    
    /// <summary>
    /// AssetRegistryStorage class definition.
    /// </summary>
    public sealed class AssetRegistryStorage : IAssetRegistryStorage
    {
        
        /// <summary>
        /// _assetIdLocationTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location> _assetIdLocationTypedStorage;
        
        /// <summary>
        /// _assetLocationIdTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _assetLocationIdTypedStorage;
        
        /// <summary>
        /// AssetRegistryStorage constructor.
        /// </summary>
        public AssetRegistryStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AssetIdLocationTypedStorage = new TypedMapStorage<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>("AssetRegistry.AssetIdLocation", storageDataProvider, storageChangeDelegates);
            this.AssetLocationIdTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("AssetRegistry.AssetLocationId", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _assetIdLocationTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location> AssetIdLocationTypedStorage
        {
            get
            {
                return _assetIdLocationTypedStorage;
            }
            set
            {
                _assetIdLocationTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _assetLocationIdTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> AssetLocationIdTypedStorage
        {
            get
            {
                return _assetLocationIdTypedStorage;
            }
            set
            {
                _assetLocationIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AssetIdLocationTypedStorage.InitializeAsync("AssetRegistry", "AssetIdLocation");
            await AssetLocationIdTypedStorage.InitializeAsync("AssetRegistry", "AssetLocationId");
        }
        
        /// <summary>
        /// Implements any storage change for AssetRegistry.AssetIdLocation
        /// </summary>
        [StorageChange("AssetRegistry", "AssetIdLocation")]
        public void OnUpdateAssetIdLocation(string key, string data)
        {
            AssetIdLocationTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AssetIdLocation
        /// </summary>
        public Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location GetAssetIdLocation(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetIdLocationTypedStorage.Dictionary.TryGetValue(key, out Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for AssetRegistry.AssetLocationId
        /// </summary>
        [StorageChange("AssetRegistry", "AssetLocationId")]
        public void OnUpdateAssetLocationId(string key, string data)
        {
            AssetLocationIdTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AssetLocationId
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetAssetLocationId(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetLocationIdTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}