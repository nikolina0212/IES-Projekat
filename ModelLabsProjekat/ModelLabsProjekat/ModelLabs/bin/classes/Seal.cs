//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    
    
    /// Physically controls access to AssetContainers.
    public class Seal : IdentifiedObject {
        
        /// Date and time this seal has been applied.
        private System.DateTime? cim_appliedDateTime;
        
        private const bool isAppliedDateTimeMandatory = false;
        
        private const string _appliedDateTimePrefix = "cim";
        
        /// Asset container to which this seal is applied.
        private AssetContainer cim_AssetContainer;
        
        private const bool isAssetContainerMandatory = false;
        
        private const string _AssetContainerPrefix = "cim";
        
        /// Condition of seal.
        private SealConditionKind? cim_condition;
        
        private const bool isConditionMandatory = false;
        
        private const string _conditionPrefix = "cim";
        
        /// Kind of seal.
        private SealKind? cim_kind;
        
        private const bool isKindMandatory = false;
        
        private const string _kindPrefix = "cim";
        
        /// (reserved word) Seal number.
        private string cim_sealNumber;
        
        private const bool isSealNumberMandatory = false;
        
        private const string _sealNumberPrefix = "cim";
        
        public virtual System.DateTime AppliedDateTime {
            get {
                return this.cim_appliedDateTime.GetValueOrDefault();
            }
            set {
                this.cim_appliedDateTime = value;
            }
        }
        
        public virtual bool AppliedDateTimeHasValue {
            get {
                return this.cim_appliedDateTime != null;
            }
        }
        
        public static bool IsAppliedDateTimeMandatory {
            get {
                return isAppliedDateTimeMandatory;
            }
        }
        
        public static string AppliedDateTimePrefix {
            get {
                return _appliedDateTimePrefix;
            }
        }
        
        public virtual AssetContainer AssetContainer {
            get {
                return this.cim_AssetContainer;
            }
            set {
                this.cim_AssetContainer = value;
            }
        }
        
        public virtual bool AssetContainerHasValue {
            get {
                return this.cim_AssetContainer != null;
            }
        }
        
        public static bool IsAssetContainerMandatory {
            get {
                return isAssetContainerMandatory;
            }
        }
        
        public static string AssetContainerPrefix {
            get {
                return _AssetContainerPrefix;
            }
        }
        
        public virtual SealConditionKind Condition {
            get {
                return this.cim_condition.GetValueOrDefault();
            }
            set {
                this.cim_condition = value;
            }
        }
        
        public virtual bool ConditionHasValue {
            get {
                return this.cim_condition != null;
            }
        }
        
        public static bool IsConditionMandatory {
            get {
                return isConditionMandatory;
            }
        }
        
        public static string ConditionPrefix {
            get {
                return _conditionPrefix;
            }
        }
        
        public virtual SealKind Kind {
            get {
                return this.cim_kind.GetValueOrDefault();
            }
            set {
                this.cim_kind = value;
            }
        }
        
        public virtual bool KindHasValue {
            get {
                return this.cim_kind != null;
            }
        }
        
        public static bool IsKindMandatory {
            get {
                return isKindMandatory;
            }
        }
        
        public static string KindPrefix {
            get {
                return _kindPrefix;
            }
        }
        
        public virtual string SealNumber {
            get {
                return this.cim_sealNumber;
            }
            set {
                this.cim_sealNumber = value;
            }
        }
        
        public virtual bool SealNumberHasValue {
            get {
                return this.cim_sealNumber != null;
            }
        }
        
        public static bool IsSealNumberMandatory {
            get {
                return isSealNumberMandatory;
            }
        }
        
        public static string SealNumberPrefix {
            get {
                return _sealNumberPrefix;
            }
        }
    }
}
