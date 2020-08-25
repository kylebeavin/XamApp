﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamApp.Models
{
    public enum MenuItemType
    {
        Browse,
        Test,
        XamlSamples
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
