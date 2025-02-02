﻿import BaseTileLayer from "@arcgis/core/layers/BaseTileLayer";
import {buildDotNetEffect} from "./dotNetBuilder";
import {buildJsEffect} from "./jsBuilder";

export default class BaseTileLayerWrapper {
    public layer: BaseTileLayer;

    constructor(btLayer: BaseTileLayer) {
        this.layer = btLayer;
    }
    
    getTileBounds(level: number, row: number, col: number): any {
        return this.layer.getTileBounds(level, row, col);
    }
    
    setEffect(effect: any) {
        this.layer.effect = buildJsEffect(effect);
    }
}