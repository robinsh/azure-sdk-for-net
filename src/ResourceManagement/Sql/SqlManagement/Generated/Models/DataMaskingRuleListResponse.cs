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
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the response to a List data masking rules request.
    /// </summary>
    public partial class DataMaskingRuleListResponse : AzureOperationResponse, IEnumerable<DataMaskingRule>
    {
        private IList<DataMaskingRule> _dataMaskingRules;
        
        /// <summary>
        /// Optional. Gets or sets the list of Azure Sql Database data masking
        /// rules
        /// </summary>
        public IList<DataMaskingRule> DataMaskingRules
        {
            get { return this._dataMaskingRules; }
            set { this._dataMaskingRules = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataMaskingRuleListResponse class.
        /// </summary>
        public DataMaskingRuleListResponse()
        {
            this.DataMaskingRules = new LazyList<DataMaskingRule>();
        }
        
        /// <summary>
        /// Gets the sequence of DataMaskingRules.
        /// </summary>
        public IEnumerator<DataMaskingRule> GetEnumerator()
        {
            return this.DataMaskingRules.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of DataMaskingRules.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
