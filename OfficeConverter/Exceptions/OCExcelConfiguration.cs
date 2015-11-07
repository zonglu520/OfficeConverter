﻿using System;
// ReSharper disable InconsistentNaming

/*
Copyright 2014-2015 Kees van Spelde

Licensed under The Code Project Open License (CPOL) 1.02;
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

 http://www.codeproject.com/info/cpol10.aspx

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

namespace OfficeConverter.Exceptions
{
    /// <summary>
    ///     Raised when there is an Excel configuration problem
    /// </summary>
    public class OCExcelConfiguration : Exception
    {
        internal OCExcelConfiguration() { }

        internal OCExcelConfiguration(string message) : base(message) { }

        internal OCExcelConfiguration(string message, Exception inner) : base(message, inner) { }
    }
}