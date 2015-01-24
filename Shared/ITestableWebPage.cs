﻿using System;

namespace TestAutomation.Shared
{
    public interface ITestableWebPage : ITestableWebElement
    {
        void Open(Uri uri);
        void Open(string url);
        void Close();
        void Maximize();
        string GetCurrentUrl();
    }
}