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
    [Register ("ActualizarPerfilViewController")]
    partial class ActualizarPerfilViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CameraButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield Ciudad { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MBAutoComplete.MBAutoCompleteTextField COLONIA { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield editBirth { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield editName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield editPass { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield editPass2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield editPaterno { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield editPhone { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.UnderlineUITextfield editSex { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GalleryButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GuardarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel namelabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MystiqueNative.iOS.ToCircleImage ProfilePictureDetalle { get; set; }

        [Action ("CameraButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CameraButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("GalleryButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GalleryButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("GuardarButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GuardarButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CameraButton != null) {
                CameraButton.Dispose ();
                CameraButton = null;
            }

            if (Ciudad != null) {
                Ciudad.Dispose ();
                Ciudad = null;
            }

            if (COLONIA != null) {
                COLONIA.Dispose ();
                COLONIA = null;
            }

            if (editBirth != null) {
                editBirth.Dispose ();
                editBirth = null;
            }

            if (editName != null) {
                editName.Dispose ();
                editName = null;
            }

            if (editPass != null) {
                editPass.Dispose ();
                editPass = null;
            }

            if (editPass2 != null) {
                editPass2.Dispose ();
                editPass2 = null;
            }

            if (editPaterno != null) {
                editPaterno.Dispose ();
                editPaterno = null;
            }

            if (editPhone != null) {
                editPhone.Dispose ();
                editPhone = null;
            }

            if (editSex != null) {
                editSex.Dispose ();
                editSex = null;
            }

            if (GalleryButton != null) {
                GalleryButton.Dispose ();
                GalleryButton = null;
            }

            if (GuardarButton != null) {
                GuardarButton.Dispose ();
                GuardarButton = null;
            }

            if (namelabel != null) {
                namelabel.Dispose ();
                namelabel = null;
            }

            if (ProfilePictureDetalle != null) {
                ProfilePictureDetalle.Dispose ();
                ProfilePictureDetalle = null;
            }
        }
    }
}