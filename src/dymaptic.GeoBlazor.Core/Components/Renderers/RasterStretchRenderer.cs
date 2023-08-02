﻿using dymaptic.GeoBlazor.Core.Components.Layers;
using dymaptic.GeoBlazor.Core.Components.Renderers.ColorRamps;
using dymaptic.GeoBlazor.Core.Extensions;
using dymaptic.GeoBlazor.Core.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dymaptic.GeoBlazor.Core.Components.Renderers;

/// <summary>
///     RasterStretchRenderer defines the symbology with a gradual ramp of colors for each pixel in a ImageryLayer, ImageryTileLayer, and WCSLayer based on the pixel value. The RasterStretchRenderer works well when you have a large range of values to display, such as in imagery, aerial photographs, or elevation models.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-renderers-RasterStretchRenderer.html">
///         ArcGIS
///         JS API
///     </a>
/// </summary>
/// 
public class RasterStretchRenderer : LayerObject
{
    public RasterStretchRenderer() { }

    /// <inheritdoc />
    [JsonPropertyName("type")]
    public static string Type => "raster-stretch";

    //public override RendererType RendererType => RendererType.RasterStretch;

    public MultipartColorRamp? ColorRamp { get; set; }

    /// <summary>
    ///     The computeGamma automatically calculates best gamma value to render exported image based on empirical model. This is applicable to any stretch type when useGamma is true.
    /// </summary>
    public bool ComputeGamma { get; set; }

    /// <summary>
    ///    When Dynamic Range Adjustment is true, the statistics based on the current display extent are calculated as you zoom and pan around the image. This property only applies to images in 2D MapView.
    /// </summary>
    public bool DynamicRangeAdjustment { get; set; } = false;

    /// <summary>
    ///     The gamma values to be used if useGamma is set to true. Gamma refers to the degree of contrast between the mid-level gray values of a raster dataset. Gamma does not affect the black or white values in a raster dataset, only the middle values. By applying a gamma correction, you can control the overall brightness of a layer. Gamma stretching is only valid with the none, standard-deviation, and min-max stretch
    /// </summary>
    public List<int>? Gamma { get; set; }

    /// <summary>
    ///     The outputMax denotes the output maximum, which is the highest pixel value. The outputMin and outputMax will set the range of values that will then be linearly contrast stretched. The outputMax value ranges from 0-255.
    /// </summary>
    public int? OutputMax { get; set; }

    /// <summary>
    ///     The outputMin denotes the output minimum, which is the lowest pixel value. The outputMin and outputMax will set the range of values that will then be linearly contrast stretched. The outputMin value ranges from 0-255.
    /// </summary>
    public int? OutputMin { get; set; }

    /// <summary>
    ///     The stretch type defines a histogram stretch that will be applied to the rasters to enhance their appearance. Stretching improves the appearance of the data by spreading the pixel values along a histogram from the minimum and maximum values defined by their bit depth.
    /// </summary>
    public StretchType StretchType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public List<List<int>>? Statistics { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public bool? UseGamma { get; set; }
    
    public int? NumberOfStandardDeviations { get; set; }

    //public override async Task RegisterChildComponent(MapComponent child)
    //{
    //    switch (child)
    //    {
    //        case ColorRamp colorRamp:
    //            if (!colorRamp.Equals(ColorRamp))
    //            {
    //                ColorRamp = colorRamp;
    //                LayerChanged = true;
    //            }
    //            break;
    //        default:
    //            await base.RegisterChildComponent(child);

    //            break;
    //    }
    //}
    ///// <inheritdoc />
    //public override async Task UnregisterChildComponent(MapComponent child)
    //{
    //    switch (child)
    //    {
    //        case ColorRamp _:
    //            ColorRamp = null;
    //            LayerChanged = true;
    //            break;
    //        default:
    //            await base.UnregisterChildComponent(child);

    //            break;
    //    }
    //}
    ///// <inheritdoc />
    //internal override void ValidateRequiredChildren()
    //{
    //    ColorRamp?.ValidateRequiredChildren();
    //    base.ValidateRequiredChildren();
    //}


}

[JsonConverter(typeof(EnumToKebabCaseStringConverter<StretchType>))]
public enum StretchType
{
    None,
    StandardDeviation,
    HistogramEqualization,
    MinMax,
    PercentClip,
    Sigmoid
}

//internal class StretchTypeConverter : JsonConverter<StretchType>
//{
//    public override StretchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
//    {
//        throw new NotImplementedException();
//    }

//    public override void Write(Utf8JsonWriter writer, StretchType value, JsonSerializerOptions options)
//    {
//        string? stringVal = Enum.GetName(typeof(StretchType), value);
//        string resultString = stringVal!.ToKebabCase();
//        writer.WriteRawValue($"\"{resultString}\"");
//    }
//}
