// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CapacityState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CapacityState
    {
        /// <summary>
        /// Not Supported
        /// </summary>
        [EnumMember(Value = "NotActivated")]
        NotActivated,
        /// <summary>
        /// Capacity ready for use
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,
        /// <summary>
        /// Capacity in activation process
        /// </summary>
        [EnumMember(Value = "Provisioning")]
        Provisioning,
        /// <summary>
        /// Capacity failed to provisioned
        /// </summary>
        [EnumMember(Value = "ProvisionFailed")]
        ProvisionFailed,
        /// <summary>
        /// Capacity suspended for use
        /// </summary>
        [EnumMember(Value = "Suspended")]
        Suspended,
        /// <summary>
        /// Not Supported
        /// </summary>
        [EnumMember(Value = "PreSuspended")]
        PreSuspended,
        /// <summary>
        /// Capacity in process of being deleted
        /// </summary>
        [EnumMember(Value = "Deleting")]
        Deleting,
        /// <summary>
        /// Capacity has been deleted and is not available
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted,
        /// <summary>
        /// Capacity can not be used
        /// </summary>
        [EnumMember(Value = "Invalid")]
        Invalid,
        /// <summary>
        /// Capacity Sku change is in progress
        /// </summary>
        [EnumMember(Value = "UpdatingSku")]
        UpdatingSku
    }
    internal static class CapacityStateEnumExtension
    {
        internal static string ToSerializedValue(this CapacityState? value)
        {
            return value == null ? null : ((CapacityState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CapacityState value)
        {
            switch( value )
            {
                case CapacityState.NotActivated:
                    return "NotActivated";
                case CapacityState.Active:
                    return "Active";
                case CapacityState.Provisioning:
                    return "Provisioning";
                case CapacityState.ProvisionFailed:
                    return "ProvisionFailed";
                case CapacityState.Suspended:
                    return "Suspended";
                case CapacityState.PreSuspended:
                    return "PreSuspended";
                case CapacityState.Deleting:
                    return "Deleting";
                case CapacityState.Deleted:
                    return "Deleted";
                case CapacityState.Invalid:
                    return "Invalid";
                case CapacityState.UpdatingSku:
                    return "UpdatingSku";
            }
            return null;
        }

        internal static CapacityState? ParseCapacityState(this string value)
        {
            switch( value )
            {
                case "NotActivated":
                    return CapacityState.NotActivated;
                case "Active":
                    return CapacityState.Active;
                case "Provisioning":
                    return CapacityState.Provisioning;
                case "ProvisionFailed":
                    return CapacityState.ProvisionFailed;
                case "Suspended":
                    return CapacityState.Suspended;
                case "PreSuspended":
                    return CapacityState.PreSuspended;
                case "Deleting":
                    return CapacityState.Deleting;
                case "Deleted":
                    return CapacityState.Deleted;
                case "Invalid":
                    return CapacityState.Invalid;
                case "UpdatingSku":
                    return CapacityState.UpdatingSku;
            }
            return null;
        }
    }
}