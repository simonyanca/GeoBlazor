﻿namespace dymaptic.GeoBlazor.Core;

/// <summary>
///     Configuration Settings Object, can be populated from JSON (e.g., appsettings.json) or environment variables.
/// </summary>
public class GeoBlazorSettings
{
    /// <summary>
    ///     The GeoBlazor Core Registration Key, generated on the licensing server.
    /// </summary>
    public string? RegistrationKey { get; set; }
    
    /// <summary>
    ///     The GeoBlazor Pro License Key, generated on the licensing server.
    /// </summary>
    public string? LicenseKey { get; set; }
    
    /// <summary>
    ///     The Application Name for a MAUI application. Not required for Blazor Server or Blazor WebAssembly.
    /// </summary>
    public string? MauiAppName { get; set; }
    
    /// <summary>
    ///     Optional setting to define where on your Blazor Server application the license validation file will be stored.
    ///     If not set, the default is `Path.GetTempPath()`.
    /// </summary>
    public string? ValidationServerStoragePath { get; set; }
}