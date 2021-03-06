// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.Models;

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    /// <summary>
    /// Description of an additional ApiService resource location.
    /// </summary>
    public partial class AdditionalRegion
    {
        private string _location;
        
        /// <summary>
        /// Optional. Gets or sets location name.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private SkuType _skuType;
        
        /// <summary>
        /// Optional. Gets or sets sku type of the location.
        /// </summary>
        public SkuType SkuType
        {
            get { return this._skuType; }
            set { this._skuType = value; }
        }
        
        private int? _skuUnitCount;
        
        /// <summary>
        /// Optional. Gets or sets sku Unit count of the location.
        /// </summary>
        public int? SkuUnitCount
        {
            get { return this._skuUnitCount; }
            set { this._skuUnitCount = value; }
        }
        
        private IList<string> _staticIPs;
        
        /// <summary>
        /// Optional. Gets or sets static IP addresses of the location virtual
        /// machines.
        /// </summary>
        public IList<string> StaticIPs
        {
            get { return this._staticIPs; }
            set { this._staticIPs = value; }
        }
        
        private VirtualNetworkConfiguration _virtualNetworkConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets virtual network configuration for the
        /// location.
        /// </summary>
        public VirtualNetworkConfiguration VirtualNetworkConfiguration
        {
            get { return this._virtualNetworkConfiguration; }
            set { this._virtualNetworkConfiguration = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AdditionalRegion class.
        /// </summary>
        public AdditionalRegion()
        {
            this.StaticIPs = new LazyList<string>();
        }
    }
}
