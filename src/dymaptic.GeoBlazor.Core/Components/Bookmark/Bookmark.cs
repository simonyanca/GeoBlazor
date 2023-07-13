using dymaptic.GeoBlazor.Core.Components.Views;
using dymaptic.GeoBlazor.Core.Objects;
using dymaptic.GeoBlazor.Core.Components.View;
using dymaptic.GeoBlazor.Core.Components.WebMap;
using Microsoft.AspNetCore.Components;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;

namespace dymaptic.GeoBlazor.Core.Components.Bookmark;

/// <summary>
///     A bookmark is a saved map extent that allows end users to quickly navigate to a particular area of interest using
///     the Bookmarks widget. They are usually defined part of the WebMap.
///     <a target="_blank" href="https://developers.arcgis.com/javascript/latest/api-reference/esri-webmap-Bookmark.html">
///         ArcGIS
///         JS API
///     </a>
/// </summary>

public class Bookmark : WebMap
{
    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Name { get; set; }

    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Thumbnail { get; set; }

    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapView MapView { get; set; }

    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Bookmark[]? Bookmarks { get; set; }

    [Parameter]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VisibleElements? VisibleElements { get; set; }

    public Task FromJson ()
    {
        return Task.CompletedTask;
    }

    public Task ToJson ()
    {
        return Task.CompletedTask;
    }
}