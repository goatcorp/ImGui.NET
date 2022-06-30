using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontKerningPair
    {
        public ushort Left;
        public ushort Right;
        public float AdvanceXAdjustment;
    }
    public unsafe partial struct ImFontKerningPairPtr
    {
        public ImFontKerningPair* NativePtr { get; }
        public ImFontKerningPairPtr(ImFontKerningPair* nativePtr) => NativePtr = nativePtr;
        public ImFontKerningPairPtr(IntPtr nativePtr) => NativePtr = (ImFontKerningPair*)nativePtr;
        public static implicit operator ImFontKerningPairPtr(ImFontKerningPair* nativePtr) => new ImFontKerningPairPtr(nativePtr);
        public static implicit operator ImFontKerningPair* (ImFontKerningPairPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontKerningPairPtr(IntPtr nativePtr) => new ImFontKerningPairPtr(nativePtr);
        public ref ushort Left => ref Unsafe.AsRef<ushort>(&NativePtr->Left);
        public ref ushort Right => ref Unsafe.AsRef<ushort>(&NativePtr->Right);
        public ref float AdvanceXAdjustment => ref Unsafe.AsRef<float>(&NativePtr->AdvanceXAdjustment);
    }
}
