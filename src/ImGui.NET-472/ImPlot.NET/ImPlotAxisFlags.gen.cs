namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotAxisFlags
    {
        None = 0,
        NoLabel = 1,
        NoGridLines = 2,
        NoTickMarks = 4,
        NoTickLabels = 8,
        NoInitialFit = 16,
        NoMenus = 32,
        Opposite = 64,
        Foreground = 128,
        Invert = 256,
        AutoFit = 512,
        RangeFit = 1024,
        PanStretch = 2048,
        LockMin = 4096,
        LockMax = 8192,
        Lock = 12288,
        NoDecorations = 15,
        AuxDefault = 66,
    }
}
