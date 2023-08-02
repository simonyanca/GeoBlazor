﻿using dymaptic.GeoBlazor.Core.Serialization;
using Microsoft.AspNetCore.Components;
using System.Text.Json.Serialization;


namespace dymaptic.GeoBlazor.Core.Components.Renderers.ColorRamps;

/// <summary>
///     Creates a color ramp for use in a raster renderer. The algorithmic color ramp is defined by specifying two colors and the
///     algorithm used to traverse the intervening color spaces.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-rest-support-MultipartColorRamp.html">
///         ArcGIS
///         JS API
///     </a>
/// </summary>
public class MultipartColorRamp : ColorRamp
{
    public MultipartColorRamp() { }
    /// <summary>
    ///     A string value representing the color ramp type.
    /// </summary>
    //[JsonPropertyName("type")]
    public override ColorRampType ColorRampType => ColorRampType.Multipart;

    public AlgorithmicColorRamp[]? ColorRamps { get; set; }

    /// <inheritdoc />
    
}
