//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.RestService.Generated.Storage;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ConfigurationController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ConfigurationController : ControllerBase
    {
        
        private IConfigurationStorage _configurationStorage;
        
        /// <summary>
        /// ConfigurationController constructor.
        /// </summary>
        public ConfigurationController(IConfigurationStorage configurationStorage)
        {
            _configurationStorage = configurationStorage;
        }
        
        /// <summary>
        /// >> WeightToFeeCoefficientOverride
        /// </summary>
        [HttpGet("WeightToFeeCoefficientOverride")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.ConfigurationStorage), "WeightToFeeCoefficientOverrideParams")]
        public IActionResult GetWeightToFeeCoefficientOverride()
        {
            return this.Ok(_configurationStorage.GetWeightToFeeCoefficientOverride());
        }
        
        /// <summary>
        /// >> MinGasPriceOverride
        /// </summary>
        [HttpGet("MinGasPriceOverride")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.ConfigurationStorage), "MinGasPriceOverrideParams")]
        public IActionResult GetMinGasPriceOverride()
        {
            return this.Ok(_configurationStorage.GetMinGasPriceOverride());
        }
        
        /// <summary>
        /// >> AppPromomotionConfigurationOverride
        /// </summary>
        [HttpGet("AppPromomotionConfigurationOverride")]
        [ProducesResponseType(typeof(Opal.NetApi.Generated.Model.pallet_configuration.AppPromotionConfiguration), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.ConfigurationStorage), "AppPromomotionConfigurationOverrideParams")]
        public IActionResult GetAppPromomotionConfigurationOverride()
        {
            return this.Ok(_configurationStorage.GetAppPromomotionConfigurationOverride());
        }
        
        /// <summary>
        /// >> CollatorSelectionDesiredCollatorsOverride
        /// </summary>
        [HttpGet("CollatorSelectionDesiredCollatorsOverride")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.ConfigurationStorage), "CollatorSelectionDesiredCollatorsOverrideParams")]
        public IActionResult GetCollatorSelectionDesiredCollatorsOverride()
        {
            return this.Ok(_configurationStorage.GetCollatorSelectionDesiredCollatorsOverride());
        }
        
        /// <summary>
        /// >> CollatorSelectionLicenseBondOverride
        /// </summary>
        [HttpGet("CollatorSelectionLicenseBondOverride")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.ConfigurationStorage), "CollatorSelectionLicenseBondOverrideParams")]
        public IActionResult GetCollatorSelectionLicenseBondOverride()
        {
            return this.Ok(_configurationStorage.GetCollatorSelectionLicenseBondOverride());
        }
        
        /// <summary>
        /// >> CollatorSelectionKickThresholdOverride
        /// </summary>
        [HttpGet("CollatorSelectionKickThresholdOverride")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApi.Generated.Storage.ConfigurationStorage), "CollatorSelectionKickThresholdOverrideParams")]
        public IActionResult GetCollatorSelectionKickThresholdOverride()
        {
            return this.Ok(_configurationStorage.GetCollatorSelectionKickThresholdOverride());
        }
    }
}