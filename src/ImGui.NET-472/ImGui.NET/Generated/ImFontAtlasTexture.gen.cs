using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontAtlasTexture
    {
        public IntPtr TexID;
        public byte* TexPixelsAlpha8;
        public uint* TexPixelsRGBA32;
    }
    public unsafe partial struct ImFontAtlasTexturePtr
    {
        public ImFontAtlasTexture* NativePtr { get; }
        public ImFontAtlasTexturePtr(ImFontAtlasTexture* nativePtr) => NativePtr = nativePtr;
        public ImFontAtlasTexturePtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasTexture*)nativePtr;
        public static implicit operator ImFontAtlasTexturePtr(ImFontAtlasTexture* nativePtr) => new ImFontAtlasTexturePtr(nativePtr);
        public static implicit operator ImFontAtlasTexture* (ImFontAtlasTexturePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontAtlasTexturePtr(IntPtr nativePtr) => new ImFontAtlasTexturePtr(nativePtr);
        public ref IntPtr TexID => ref Unsafe.AsRef<IntPtr>(&NativePtr->TexID);
        public IntPtr TexPixelsAlpha8 { get => (IntPtr)NativePtr->TexPixelsAlpha8; set => NativePtr->TexPixelsAlpha8 = (byte*)value; }
        public IntPtr TexPixelsRGBA32 { get => (IntPtr)NativePtr->TexPixelsRGBA32; set => NativePtr->TexPixelsRGBA32 = (uint*)value; }
    }
}
