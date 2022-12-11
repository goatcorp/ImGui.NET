namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiHoveredFlags
    {
        None = 0,
        ChildWindows = 1,
        RootWindow = 2,
        AnyWindow = 4,
        AllowWhenBlockedByPopup = 8,
        AllowWhenBlockedByActiveItem = 32,
        AllowWhenOverlapped = 64,
        AllowWhenDisabled = 128,
        NoNavOverride = 256,
        RectOnly = 104,
        RootAndChildWindows = 3,
        NoPopupHierarchy = 512,
        DockHierarchy = 1024,
    }
}
