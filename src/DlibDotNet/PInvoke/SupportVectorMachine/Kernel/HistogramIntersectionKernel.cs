﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace
namespace DlibDotNet
{

    internal sealed partial class NativeMethods
    {

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern ErrorType histogram_intersection_kernel_new(MatrixElementType matrixElementType, 
                                                                         int templateRow, 
                                                                         int templateColumn,
                                                                         out IntPtr ret);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void histogram_intersection_kernel_delete(MatrixElementType matrixElementType,
                                                                       IntPtr linerKernel, 
                                                                       int templateRow,
                                                                       int templateColumn);

    }

}