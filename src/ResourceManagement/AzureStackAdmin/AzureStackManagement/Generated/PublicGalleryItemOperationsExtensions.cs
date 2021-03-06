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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    public static partial class PublicGalleryItemOperationsExtensions
    {
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IPublicGalleryItemOperations.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static PublicGalleryItemListResult ListAll(this IPublicGalleryItemOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublicGalleryItemOperations)s).ListAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Your documentation here.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IPublicGalleryItemOperations.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public static Task<PublicGalleryItemListResult> ListAllAsync(this IPublicGalleryItemOperations operations)
        {
            return operations.ListAllAsync(CancellationToken.None);
        }
    }
}
