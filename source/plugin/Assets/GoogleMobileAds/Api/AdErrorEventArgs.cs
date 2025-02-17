// Copyright (C) 2018 Google, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace GoogleMobileAds.Api
{
    // Event arguments that return when an ad operation fails.

    /// @deprecated Use @ref AdError directly.
    public class AdErrorEventArgs : EventArgs
    {
        // AdError Object that returns when an ad operation fails.
        public AdError AdError { get; set; }

        /// @deprecated Use @ref AdError.GetMessage() instead.
        [Obsolete ("use AdError.GetMessage() instead.")]
        public string Message { get; set; }
    }
}
