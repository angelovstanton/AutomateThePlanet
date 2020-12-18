﻿// <copyright file="BingMainPageElementMap.cs" company="Automate The Planet Ltd.">
// Copyright 2017 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://automatetheplanet.com/</site>

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HuddlePageObjectsPartialClassesFluentApi.Pages
{
    public partial class BingMainPageElements
    {
        private readonly IWebDriver _driver;

        public BingMainPageElements(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement GetSearchBox()
        {
            return _driver.FindElement(By.Id("sb_form_q"));
        }

        public IWebElement GetGoButton()
        {
            return _driver.FindElement(By.Id("sb_form_go"));
        }

        public IWebElement GetResultsCountDiv()
        {
            return _driver.FindElement(By.Id("b_tween"));
        }

        public IWebElement GetImagesLink()
        {
            return _driver.FindElement(By.LinkText("Images"));
        }

        public SelectElement GetSizesSelect()
        {
            return new SelectElement(_driver.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Size']")));
        }

        public SelectElement GetColorSelect()
        {
            return new SelectElement(_driver.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Color']")));
        }

        public SelectElement GetTypeSelect()
        {
            return new SelectElement(_driver.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Type']")));
        }

        public SelectElement GetLayoutSelect()
        {
            return new SelectElement(_driver.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Layout']")));
        }

        public SelectElement GetPeopleSelect()
        {
            return new SelectElement(_driver.FindElement(By.XPath("//div/ul/li/span/span[text() = 'People']")));
        }

        public SelectElement GetDateSelect()
        {
            return new SelectElement(_driver.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Date']")));
        }

        public SelectElement GetLicenseSelect()
        {
            return new SelectElement(_driver.FindElement(By.XPath("//div/ul/li/span/span[text() = 'License']")));
        }
    }
}