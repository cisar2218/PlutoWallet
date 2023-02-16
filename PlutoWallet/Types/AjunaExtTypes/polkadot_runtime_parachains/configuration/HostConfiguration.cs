//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration
{
    
    
    /// <summary>
    /// >> 638 - Composite[polkadot_runtime_parachains.configuration.HostConfiguration]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class HostConfiguration : BaseType
    {
        
        /// <summary>
        /// >> max_code_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxCodeSize;
        
        /// <summary>
        /// >> max_head_data_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxHeadDataSize;
        
        /// <summary>
        /// >> max_upward_queue_count
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxUpwardQueueCount;
        
        /// <summary>
        /// >> max_upward_queue_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxUpwardQueueSize;
        
        /// <summary>
        /// >> max_upward_message_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxUpwardMessageSize;
        
        /// <summary>
        /// >> max_upward_message_num_per_candidate
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxUpwardMessageNumPerCandidate;
        
        /// <summary>
        /// >> hrmp_max_message_num_per_candidate
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpMaxMessageNumPerCandidate;
        
        /// <summary>
        /// >> validation_upgrade_cooldown
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _validationUpgradeCooldown;
        
        /// <summary>
        /// >> validation_upgrade_delay
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _validationUpgradeDelay;
        
        /// <summary>
        /// >> max_pov_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxPovSize;
        
        /// <summary>
        /// >> max_downward_message_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _maxDownwardMessageSize;
        
        /// <summary>
        /// >> ump_service_total_weight
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _umpServiceTotalWeight;
        
        /// <summary>
        /// >> hrmp_max_parachain_outbound_channels
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpMaxParachainOutboundChannels;
        
        /// <summary>
        /// >> hrmp_max_parathread_outbound_channels
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpMaxParathreadOutboundChannels;
        
        /// <summary>
        /// >> hrmp_sender_deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _hrmpSenderDeposit;
        
        /// <summary>
        /// >> hrmp_recipient_deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _hrmpRecipientDeposit;
        
        /// <summary>
        /// >> hrmp_channel_max_capacity
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpChannelMaxCapacity;
        
        /// <summary>
        /// >> hrmp_channel_max_total_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpChannelMaxTotalSize;
        
        /// <summary>
        /// >> hrmp_max_parachain_inbound_channels
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpMaxParachainInboundChannels;
        
        /// <summary>
        /// >> hrmp_max_parathread_inbound_channels
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpMaxParathreadInboundChannels;
        
        /// <summary>
        /// >> hrmp_channel_max_message_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpChannelMaxMessageSize;
        
        /// <summary>
        /// >> code_retention_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _codeRetentionPeriod;
        
        /// <summary>
        /// >> parathread_cores
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _parathreadCores;
        
        /// <summary>
        /// >> parathread_retries
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _parathreadRetries;
        
        /// <summary>
        /// >> group_rotation_frequency
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _groupRotationFrequency;
        
        /// <summary>
        /// >> chain_availability_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _chainAvailabilityPeriod;
        
        /// <summary>
        /// >> thread_availability_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _threadAvailabilityPeriod;
        
        /// <summary>
        /// >> scheduling_lookahead
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _schedulingLookahead;
        
        /// <summary>
        /// >> max_validators_per_core
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> _maxValidatorsPerCore;
        
        /// <summary>
        /// >> max_validators
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> _maxValidators;
        
        /// <summary>
        /// >> dispute_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _disputePeriod;
        
        /// <summary>
        /// >> dispute_post_conclusion_acceptance_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _disputePostConclusionAcceptancePeriod;
        
        /// <summary>
        /// >> dispute_max_spam_slots
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _disputeMaxSpamSlots;
        
        /// <summary>
        /// >> dispute_conclusion_by_time_out_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _disputeConclusionByTimeOutPeriod;
        
        /// <summary>
        /// >> no_show_slots
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _noShowSlots;
        
        /// <summary>
        /// >> n_delay_tranches
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _nDelayTranches;
        
        /// <summary>
        /// >> zeroth_delay_tranche_width
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _zerothDelayTrancheWidth;
        
        /// <summary>
        /// >> needed_approvals
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _neededApprovals;
        
        /// <summary>
        /// >> relay_vrf_modulo_samples
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _relayVrfModuloSamples;
        
        /// <summary>
        /// >> ump_max_individual_weight
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight _umpMaxIndividualWeight;
        
        /// <summary>
        /// >> pvf_checking_enabled
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _pvfCheckingEnabled;
        
        /// <summary>
        /// >> pvf_voting_ttl
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _pvfVotingTtl;
        
        /// <summary>
        /// >> minimum_validation_upgrade_delay
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _minimumValidationUpgradeDelay;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxCodeSize
        {
            get
            {
                return this._maxCodeSize;
            }
            set
            {
                this._maxCodeSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxHeadDataSize
        {
            get
            {
                return this._maxHeadDataSize;
            }
            set
            {
                this._maxHeadDataSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueCount
        {
            get
            {
                return this._maxUpwardQueueCount;
            }
            set
            {
                this._maxUpwardQueueCount = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueSize
        {
            get
            {
                return this._maxUpwardQueueSize;
            }
            set
            {
                this._maxUpwardQueueSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageSize
        {
            get
            {
                return this._maxUpwardMessageSize;
            }
            set
            {
                this._maxUpwardMessageSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageNumPerCandidate
        {
            get
            {
                return this._maxUpwardMessageNumPerCandidate;
            }
            set
            {
                this._maxUpwardMessageNumPerCandidate = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpMaxMessageNumPerCandidate
        {
            get
            {
                return this._hrmpMaxMessageNumPerCandidate;
            }
            set
            {
                this._hrmpMaxMessageNumPerCandidate = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ValidationUpgradeCooldown
        {
            get
            {
                return this._validationUpgradeCooldown;
            }
            set
            {
                this._validationUpgradeCooldown = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ValidationUpgradeDelay
        {
            get
            {
                return this._validationUpgradeDelay;
            }
            set
            {
                this._validationUpgradeDelay = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxPovSize
        {
            get
            {
                return this._maxPovSize;
            }
            set
            {
                this._maxPovSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MaxDownwardMessageSize
        {
            get
            {
                return this._maxDownwardMessageSize;
            }
            set
            {
                this._maxDownwardMessageSize = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight UmpServiceTotalWeight
        {
            get
            {
                return this._umpServiceTotalWeight;
            }
            set
            {
                this._umpServiceTotalWeight = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpMaxParachainOutboundChannels
        {
            get
            {
                return this._hrmpMaxParachainOutboundChannels;
            }
            set
            {
                this._hrmpMaxParachainOutboundChannels = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpMaxParathreadOutboundChannels
        {
            get
            {
                return this._hrmpMaxParathreadOutboundChannels;
            }
            set
            {
                this._hrmpMaxParathreadOutboundChannels = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 HrmpSenderDeposit
        {
            get
            {
                return this._hrmpSenderDeposit;
            }
            set
            {
                this._hrmpSenderDeposit = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 HrmpRecipientDeposit
        {
            get
            {
                return this._hrmpRecipientDeposit;
            }
            set
            {
                this._hrmpRecipientDeposit = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpChannelMaxCapacity
        {
            get
            {
                return this._hrmpChannelMaxCapacity;
            }
            set
            {
                this._hrmpChannelMaxCapacity = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpChannelMaxTotalSize
        {
            get
            {
                return this._hrmpChannelMaxTotalSize;
            }
            set
            {
                this._hrmpChannelMaxTotalSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpMaxParachainInboundChannels
        {
            get
            {
                return this._hrmpMaxParachainInboundChannels;
            }
            set
            {
                this._hrmpMaxParachainInboundChannels = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpMaxParathreadInboundChannels
        {
            get
            {
                return this._hrmpMaxParathreadInboundChannels;
            }
            set
            {
                this._hrmpMaxParathreadInboundChannels = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpChannelMaxMessageSize
        {
            get
            {
                return this._hrmpChannelMaxMessageSize;
            }
            set
            {
                this._hrmpChannelMaxMessageSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 CodeRetentionPeriod
        {
            get
            {
                return this._codeRetentionPeriod;
            }
            set
            {
                this._codeRetentionPeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ParathreadCores
        {
            get
            {
                return this._parathreadCores;
            }
            set
            {
                this._parathreadCores = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ParathreadRetries
        {
            get
            {
                return this._parathreadRetries;
            }
            set
            {
                this._parathreadRetries = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 GroupRotationFrequency
        {
            get
            {
                return this._groupRotationFrequency;
            }
            set
            {
                this._groupRotationFrequency = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ChainAvailabilityPeriod
        {
            get
            {
                return this._chainAvailabilityPeriod;
            }
            set
            {
                this._chainAvailabilityPeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ThreadAvailabilityPeriod
        {
            get
            {
                return this._threadAvailabilityPeriod;
            }
            set
            {
                this._threadAvailabilityPeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 SchedulingLookahead
        {
            get
            {
                return this._schedulingLookahead;
            }
            set
            {
                this._schedulingLookahead = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> MaxValidatorsPerCore
        {
            get
            {
                return this._maxValidatorsPerCore;
            }
            set
            {
                this._maxValidatorsPerCore = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> MaxValidators
        {
            get
            {
                return this._maxValidators;
            }
            set
            {
                this._maxValidators = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 DisputePeriod
        {
            get
            {
                return this._disputePeriod;
            }
            set
            {
                this._disputePeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 DisputePostConclusionAcceptancePeriod
        {
            get
            {
                return this._disputePostConclusionAcceptancePeriod;
            }
            set
            {
                this._disputePostConclusionAcceptancePeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 DisputeMaxSpamSlots
        {
            get
            {
                return this._disputeMaxSpamSlots;
            }
            set
            {
                this._disputeMaxSpamSlots = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 DisputeConclusionByTimeOutPeriod
        {
            get
            {
                return this._disputeConclusionByTimeOutPeriod;
            }
            set
            {
                this._disputeConclusionByTimeOutPeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 NoShowSlots
        {
            get
            {
                return this._noShowSlots;
            }
            set
            {
                this._noShowSlots = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 NDelayTranches
        {
            get
            {
                return this._nDelayTranches;
            }
            set
            {
                this._nDelayTranches = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ZerothDelayTrancheWidth
        {
            get
            {
                return this._zerothDelayTrancheWidth;
            }
            set
            {
                this._zerothDelayTrancheWidth = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 NeededApprovals
        {
            get
            {
                return this._neededApprovals;
            }
            set
            {
                this._neededApprovals = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 RelayVrfModuloSamples
        {
            get
            {
                return this._relayVrfModuloSamples;
            }
            set
            {
                this._relayVrfModuloSamples = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight UmpMaxIndividualWeight
        {
            get
            {
                return this._umpMaxIndividualWeight;
            }
            set
            {
                this._umpMaxIndividualWeight = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool PvfCheckingEnabled
        {
            get
            {
                return this._pvfCheckingEnabled;
            }
            set
            {
                this._pvfCheckingEnabled = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 PvfVotingTtl
        {
            get
            {
                return this._pvfVotingTtl;
            }
            set
            {
                this._pvfVotingTtl = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MinimumValidationUpgradeDelay
        {
            get
            {
                return this._minimumValidationUpgradeDelay;
            }
            set
            {
                this._minimumValidationUpgradeDelay = value;
            }
        }
        
        public override string TypeName()
        {
            return "HostConfiguration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxCodeSize.Encode());
            result.AddRange(MaxHeadDataSize.Encode());
            result.AddRange(MaxUpwardQueueCount.Encode());
            result.AddRange(MaxUpwardQueueSize.Encode());
            result.AddRange(MaxUpwardMessageSize.Encode());
            result.AddRange(MaxUpwardMessageNumPerCandidate.Encode());
            result.AddRange(HrmpMaxMessageNumPerCandidate.Encode());
            result.AddRange(ValidationUpgradeCooldown.Encode());
            result.AddRange(ValidationUpgradeDelay.Encode());
            result.AddRange(MaxPovSize.Encode());
            result.AddRange(MaxDownwardMessageSize.Encode());
            result.AddRange(UmpServiceTotalWeight.Encode());
            result.AddRange(HrmpMaxParachainOutboundChannels.Encode());
            result.AddRange(HrmpMaxParathreadOutboundChannels.Encode());
            result.AddRange(HrmpSenderDeposit.Encode());
            result.AddRange(HrmpRecipientDeposit.Encode());
            result.AddRange(HrmpChannelMaxCapacity.Encode());
            result.AddRange(HrmpChannelMaxTotalSize.Encode());
            result.AddRange(HrmpMaxParachainInboundChannels.Encode());
            result.AddRange(HrmpMaxParathreadInboundChannels.Encode());
            result.AddRange(HrmpChannelMaxMessageSize.Encode());
            result.AddRange(CodeRetentionPeriod.Encode());
            result.AddRange(ParathreadCores.Encode());
            result.AddRange(ParathreadRetries.Encode());
            result.AddRange(GroupRotationFrequency.Encode());
            result.AddRange(ChainAvailabilityPeriod.Encode());
            result.AddRange(ThreadAvailabilityPeriod.Encode());
            result.AddRange(SchedulingLookahead.Encode());
            result.AddRange(MaxValidatorsPerCore.Encode());
            result.AddRange(MaxValidators.Encode());
            result.AddRange(DisputePeriod.Encode());
            result.AddRange(DisputePostConclusionAcceptancePeriod.Encode());
            result.AddRange(DisputeMaxSpamSlots.Encode());
            result.AddRange(DisputeConclusionByTimeOutPeriod.Encode());
            result.AddRange(NoShowSlots.Encode());
            result.AddRange(NDelayTranches.Encode());
            result.AddRange(ZerothDelayTrancheWidth.Encode());
            result.AddRange(NeededApprovals.Encode());
            result.AddRange(RelayVrfModuloSamples.Encode());
            result.AddRange(UmpMaxIndividualWeight.Encode());
            result.AddRange(PvfCheckingEnabled.Encode());
            result.AddRange(PvfVotingTtl.Encode());
            result.AddRange(MinimumValidationUpgradeDelay.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxCodeSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxCodeSize.Decode(byteArray, ref p);
            MaxHeadDataSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxHeadDataSize.Decode(byteArray, ref p);
            MaxUpwardQueueCount = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueCount.Decode(byteArray, ref p);
            MaxUpwardQueueSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueSize.Decode(byteArray, ref p);
            MaxUpwardMessageSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageSize.Decode(byteArray, ref p);
            MaxUpwardMessageNumPerCandidate = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageNumPerCandidate.Decode(byteArray, ref p);
            HrmpMaxMessageNumPerCandidate = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpMaxMessageNumPerCandidate.Decode(byteArray, ref p);
            ValidationUpgradeCooldown = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeCooldown.Decode(byteArray, ref p);
            ValidationUpgradeDelay = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeDelay.Decode(byteArray, ref p);
            MaxPovSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxPovSize.Decode(byteArray, ref p);
            MaxDownwardMessageSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MaxDownwardMessageSize.Decode(byteArray, ref p);
            UmpServiceTotalWeight = new PlutoWallet.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            UmpServiceTotalWeight.Decode(byteArray, ref p);
            HrmpMaxParachainOutboundChannels = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpMaxParachainOutboundChannels.Decode(byteArray, ref p);
            HrmpMaxParathreadOutboundChannels = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpMaxParathreadOutboundChannels.Decode(byteArray, ref p);
            HrmpSenderDeposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            HrmpSenderDeposit.Decode(byteArray, ref p);
            HrmpRecipientDeposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            HrmpRecipientDeposit.Decode(byteArray, ref p);
            HrmpChannelMaxCapacity = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpChannelMaxCapacity.Decode(byteArray, ref p);
            HrmpChannelMaxTotalSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpChannelMaxTotalSize.Decode(byteArray, ref p);
            HrmpMaxParachainInboundChannels = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpMaxParachainInboundChannels.Decode(byteArray, ref p);
            HrmpMaxParathreadInboundChannels = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpMaxParathreadInboundChannels.Decode(byteArray, ref p);
            HrmpChannelMaxMessageSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpChannelMaxMessageSize.Decode(byteArray, ref p);
            CodeRetentionPeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            CodeRetentionPeriod.Decode(byteArray, ref p);
            ParathreadCores = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ParathreadCores.Decode(byteArray, ref p);
            ParathreadRetries = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ParathreadRetries.Decode(byteArray, ref p);
            GroupRotationFrequency = new Ajuna.NetApi.Model.Types.Primitive.U32();
            GroupRotationFrequency.Decode(byteArray, ref p);
            ChainAvailabilityPeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ChainAvailabilityPeriod.Decode(byteArray, ref p);
            ThreadAvailabilityPeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ThreadAvailabilityPeriod.Decode(byteArray, ref p);
            SchedulingLookahead = new Ajuna.NetApi.Model.Types.Primitive.U32();
            SchedulingLookahead.Decode(byteArray, ref p);
            MaxValidatorsPerCore = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
            MaxValidatorsPerCore.Decode(byteArray, ref p);
            MaxValidators = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
            MaxValidators.Decode(byteArray, ref p);
            DisputePeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            DisputePeriod.Decode(byteArray, ref p);
            DisputePostConclusionAcceptancePeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            DisputePostConclusionAcceptancePeriod.Decode(byteArray, ref p);
            DisputeMaxSpamSlots = new Ajuna.NetApi.Model.Types.Primitive.U32();
            DisputeMaxSpamSlots.Decode(byteArray, ref p);
            DisputeConclusionByTimeOutPeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            DisputeConclusionByTimeOutPeriod.Decode(byteArray, ref p);
            NoShowSlots = new Ajuna.NetApi.Model.Types.Primitive.U32();
            NoShowSlots.Decode(byteArray, ref p);
            NDelayTranches = new Ajuna.NetApi.Model.Types.Primitive.U32();
            NDelayTranches.Decode(byteArray, ref p);
            ZerothDelayTrancheWidth = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ZerothDelayTrancheWidth.Decode(byteArray, ref p);
            NeededApprovals = new Ajuna.NetApi.Model.Types.Primitive.U32();
            NeededApprovals.Decode(byteArray, ref p);
            RelayVrfModuloSamples = new Ajuna.NetApi.Model.Types.Primitive.U32();
            RelayVrfModuloSamples.Decode(byteArray, ref p);
            UmpMaxIndividualWeight = new PlutoWallet.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            UmpMaxIndividualWeight.Decode(byteArray, ref p);
            PvfCheckingEnabled = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            PvfCheckingEnabled.Decode(byteArray, ref p);
            PvfVotingTtl = new Ajuna.NetApi.Model.Types.Primitive.U32();
            PvfVotingTtl.Decode(byteArray, ref p);
            MinimumValidationUpgradeDelay = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MinimumValidationUpgradeDelay.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
