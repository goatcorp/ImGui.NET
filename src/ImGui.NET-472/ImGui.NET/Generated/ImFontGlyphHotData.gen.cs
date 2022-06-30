using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontGlyphHotData
    {
        public float AdvanceX;
        public float OccupiedWidth;
        public uint KerningPairUseBisect;
        public uint KerningPairOffset;
        public uint KerningPairCount;
    }
    public unsafe partial struct ImFontGlyphHotDataPtr
    {
        public ImFontGlyphHotData* NativePtr { get; }
        public ImFontGlyphHotDataPtr(ImFontGlyphHotData* nativePtr) => NativePtr = nativePtr;
        public ImFontGlyphHotDataPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyphHotData*)nativePtr;
        public static implicit operator ImFontGlyphHotDataPtr(ImFontGlyphHotData* nativePtr) => new ImFontGlyphHotDataPtr(nativePtr);
        public static implicit operator ImFontGlyphHotData* (ImFontGlyphHotDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontGlyphHotDataPtr(IntPtr nativePtr) => new ImFontGlyphHotDataPtr(nativePtr);
        public ref float AdvanceX => ref Unsafe.AsRef<float>(&NativePtr->AdvanceX);
        public ref float OccupiedWidth => ref Unsafe.AsRef<float>(&NativePtr->OccupiedWidth);
        public ref uint KerningPairUseBisect => ref Unsafe.AsRef<uint>(&NativePtr->KerningPairUseBisect);
        public ref uint KerningPairOffset => ref Unsafe.AsRef<uint>(&NativePtr->KerningPairOffset);
        public ref uint KerningPairCount => ref Unsafe.AsRef<uint>(&NativePtr->KerningPairCount);
    }
}
