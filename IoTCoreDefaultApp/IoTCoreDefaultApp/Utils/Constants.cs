﻿namespace IoTCoreDefaultApp
{
    public static class Constants
    {
        public static string HasDoneOOBEKey = "DefaultAppHasDoneOOBE";
        public static string HasDoneOOBEValue = "YES";
        public static string GUID_DEVINTERFACE_USB_DEVICE = "A5DCBF10-6530-11D2-901F-00C04FB951ED";
        public static string[] TutorialDocNames = {
            "GetStarted",
#if RPI
            "HelloBlinky",
#endif
            "GetConnected",
            "GetCoding"
        };
    }
}