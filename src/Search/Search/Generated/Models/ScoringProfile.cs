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
using Microsoft.Azure.Search.Models;

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Defines parameters for an Azure Search index that influence scoring in
    /// search queries.  (see
    /// https://msdn.microsoft.com/library/azure/dn798928.aspx for more
    /// information)
    /// </summary>
    public partial class ScoringProfile
    {
        private ScoringFunctionAggregation _functionAggregation;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating how the results of
        /// individual scoring functions should be combined. Defaults to
        /// "Sum". Ignored if there are no scoring functions.
        /// </summary>
        public ScoringFunctionAggregation FunctionAggregation
        {
            get { return this._functionAggregation; }
            set { this._functionAggregation = value; }
        }
        
        private IList<ScoringFunction> _functions;
        
        /// <summary>
        /// Optional. Gets the collection of functions that influence the
        /// scoring of documents.
        /// </summary>
        public IList<ScoringFunction> Functions
        {
            get { return this._functions; }
            set { this._functions = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the scoring profile.  (see
        /// https://msdn.microsoft.com/library/azure/dn857353.aspx for more
        /// information)
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private TextWeights _textWeights;
        
        /// <summary>
        /// Optional. Gets or sets parameters that boost scoring based on text
        /// matches in certain index fields.
        /// </summary>
        public TextWeights TextWeights
        {
            get { return this._textWeights; }
            set { this._textWeights = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ScoringProfile class.
        /// </summary>
        public ScoringProfile()
        {
            this.Functions = new LazyList<ScoringFunction>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ScoringProfile class with
        /// required arguments.
        /// </summary>
        public ScoringProfile(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}
