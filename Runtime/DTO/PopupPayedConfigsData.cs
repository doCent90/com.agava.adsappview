﻿using System;
using UnityEngine.Scripting;

namespace AdsAppView.DTO
{
    [Preserve, Serializable]
    public class PopupPayedConfigsData
    {
        public string app_id { get; set; }
        public string store_id { get; set; }
        public string platform { get; set; }
        public string ads_app_id { get; set; }
        public int first_timer { get; set; }
        public int regular_timer { get; set; }
        public bool carousel { get; set; }
        public int carousel_count { get; set; }
    }
}
