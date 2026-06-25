using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Enumerated type of the plugin device archetypes. Each type supports a set of required and/or optional features.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DeviceType
{
    /// <summary>
    /// Type for batteries.
    /// </summary>
    BATTERY,

    /// <summary>
    /// Type for sensors measuring or detecting parameters of the environment, like the current temperature or whether it rains or not.
    /// </summary>
    CLIMATE_SENSOR,

    /// <summary>
    /// Type for contact sensors detecting, for example, if a window is opened or closed.
    /// </summary>
    CONTACT_SENSOR,

    /// <summary>
    /// Type for devices monitoring the energy input and output of other devices.
    /// </summary>
    ENERGY_METER,

    /// <summary>
    /// Type for electric vehicle chargers.
    /// </summary>
    EV_CHARGER,

    /// <summary>
    /// Type for grid connection points, i.e. the device that connects your home to the electrical grid.
    /// </summary>
    GRID_CONNECTION_POINT,

    /// <summary>
    /// Type for heat pumps.
    /// </summary>
    HEAT_PUMP,

    /// <summary>
    /// Type for air conditioning devices.
    /// </summary>
    HVAC,

    /// <summary>
    /// Type for inverters like solar power inverters.
    /// </summary>
    INVERTER,

    /// <summary>
    /// Type for lighting devices like light bulbs or light strips.
    /// </summary>
    LIGHT,

    /// <summary>
    /// Type for devices like motion sensors that can detect presence in a room or area.
    /// </summary>
    OCCUPANCY_SENSOR,

    /// <summary>
    /// Type for sensors that measure particulate matter in the environment.
    /// </summary>
    PARTICULATE_MATTER_SENSOR,

    /// <summary>
    /// Type for smoke detecting devices.
    /// </summary>
    SMOKE_ALARM,

    /// <summary>
    /// Type for device that can be switched on or off.
    /// </summary>
    SWITCH,

    /// <summary>
    /// Type for devices that can be triggered to send out single switch signals to the system, like buttons.
    /// </summary>
    SWITCH_INPUT,

    /// <summary>
    /// Type for thermostats, i.e. devices that can heat or cool to a setpoint temperature.
    /// </summary>
    THERMOSTAT,

    /// <summary>
    /// Type for electric vehicles.
    /// </summary>
    VEHICLE,

    /// <summary>
    /// Type for water sensors.
    /// </summary>
    WATER_SENSOR,

    /// <summary>
    /// Type for window covering devices like electric window shutters.
    /// </summary>
    WINDOW_COVERING,
}
