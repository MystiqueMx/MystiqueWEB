﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MystiqueNative.iOS
{
    [Register ("HistorialCell")]
    partial class NotificacionCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelSucursal { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelSucursal != null) {
                labelSucursal.Dispose ();
                labelSucursal = null;
            }
        }
    }
}