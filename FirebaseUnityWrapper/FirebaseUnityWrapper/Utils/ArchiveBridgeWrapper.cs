﻿using UnityEngine;
using System;
using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.Utils
{
    internal static class ArchiveBridgeWrapper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.game.ArchiveBridge");

        public static void CallArchiveBridge(this JavaObjectWrapper javaObjectWrapper, Action onSuccess, Action<AndroidException> onFailure)
        {
            String methodName = "getShowArchiveListIntent";
            javaObjectWrapper.CallAsWrapper<TaskAndroidJavaObject>(methodName)
                .AddOnSuccessListener((intent) =>
                {
                    var callback = new GenericBridgeCallbackWrapper()
                   .AddOnFailureListener(onFailure)
                   .AddOnSuccessListener((nothing) =>
                   {
                       onSuccess.Invoke();
                   });
                    sJavaClass.CallStatic("receiveShow", intent, callback);

                }).AddOnFailureListener((exception) => onFailure.Invoke(exception));
        }
    }
}