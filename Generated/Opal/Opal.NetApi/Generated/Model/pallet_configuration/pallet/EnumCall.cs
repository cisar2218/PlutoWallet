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


namespace Opal.NetApi.Generated.Model.pallet_configuration.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_weight_to_fee_coefficient_override
        /// See [`Pallet::set_weight_to_fee_coefficient_override`].
        /// </summary>
        set_weight_to_fee_coefficient_override = 0,
        
        /// <summary>
        /// >> set_min_gas_price_override
        /// See [`Pallet::set_min_gas_price_override`].
        /// </summary>
        set_min_gas_price_override = 1,
        
        /// <summary>
        /// >> set_app_promotion_configuration_override
        /// See [`Pallet::set_app_promotion_configuration_override`].
        /// </summary>
        set_app_promotion_configuration_override = 3,
        
        /// <summary>
        /// >> set_collator_selection_desired_collators
        /// See [`Pallet::set_collator_selection_desired_collators`].
        /// </summary>
        set_collator_selection_desired_collators = 4,
        
        /// <summary>
        /// >> set_collator_selection_license_bond
        /// See [`Pallet::set_collator_selection_license_bond`].
        /// </summary>
        set_collator_selection_license_bond = 5,
        
        /// <summary>
        /// >> set_collator_selection_kick_threshold
        /// See [`Pallet::set_collator_selection_kick_threshold`].
        /// </summary>
        set_collator_selection_kick_threshold = 6,
    }
    
    /// <summary>
    /// >> 320 - Variant[pallet_configuration.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>>(Call.set_weight_to_fee_coefficient_override);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>>(Call.set_min_gas_price_override);
				AddTypeDecoder<Opal.NetApi.Generated.Model.pallet_configuration.AppPromotionConfiguration>(Call.set_app_promotion_configuration_override);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.set_collator_selection_desired_collators);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>(Call.set_collator_selection_license_bond);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.set_collator_selection_kick_threshold);
        }
    }
}
