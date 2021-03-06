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
using Microsoft.Azure.Management.DataFactories.Core;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Core
{
    public static partial class ActivityWindowOperationsExtensions
    {
        /// <summary>
        /// Gets the first page of activity window instances for a data factory
        /// with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListByDataFactory(this IActivityWindowOperations operations, ActivityWindowsByDataFactoryListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListByDataFactoryAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the first page of activity window instances for a data factory
        /// with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListByDataFactoryAsync(this IActivityWindowOperations operations, ActivityWindowsByDataFactoryListParameters parameters)
        {
            return operations.ListByDataFactoryAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the first page of activity window instances for a dataset with
        /// the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListByDataset(this IActivityWindowOperations operations, ActivityWindowsByDatasetListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListByDatasetAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the first page of activity window instances for a dataset with
        /// the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListByDatasetAsync(this IActivityWindowOperations operations, ActivityWindowsByDatasetListParameters parameters)
        {
            return operations.ListByDatasetAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the first page of activity window instances for a pipeline
        /// with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListByPipeline(this IActivityWindowOperations operations, ActivityWindowsByPipelineListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListByPipelineAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the first page of activity window instances for a pipeline
        /// with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListByPipelineAsync(this IActivityWindowOperations operations, ActivityWindowsByPipelineListParameters parameters)
        {
            return operations.ListByPipelineAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the first page of activity window instances for a pipeline
        /// activity with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListByPipelineActivity(this IActivityWindowOperations operations, ActivityWindowsByActivityListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListByPipelineActivityAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the first page of activity window instances for a pipeline
        /// activity with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListByPipelineActivityAsync(this IActivityWindowOperations operations, ActivityWindowsByActivityListParameters parameters)
        {
            return operations.ListByPipelineActivityAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListNextByDataFactory(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByDataFactoryListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListNextByDataFactoryAsync(nextLink, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListNextByDataFactoryAsync(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByDataFactoryListParameters parameters)
        {
            return operations.ListNextByDataFactoryAsync(nextLink, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListNextByDataset(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByDatasetListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListNextByDatasetAsync(nextLink, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListNextByDatasetAsync(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByDatasetListParameters parameters)
        {
            return operations.ListNextByDatasetAsync(nextLink, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListNextByPipeline(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByPipelineListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListNextByPipelineAsync(nextLink, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListNextByPipelineAsync(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByPipelineListParameters parameters)
        {
            return operations.ListNextByPipelineAsync(nextLink, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static ActivityWindowListResponse ListNextByPipelineActivity(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByActivityListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IActivityWindowOperations)s).ListNextByPipelineActivityAsync(nextLink, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IActivityWindowOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Required. Filter parameters for activity windows list.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        public static Task<ActivityWindowListResponse> ListNextByPipelineActivityAsync(this IActivityWindowOperations operations, string nextLink, ActivityWindowsByActivityListParameters parameters)
        {
            return operations.ListNextByPipelineActivityAsync(nextLink, parameters, CancellationToken.None);
        }
    }
}
