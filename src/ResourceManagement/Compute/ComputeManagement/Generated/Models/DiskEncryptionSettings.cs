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
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Describes a Encryption Settings for a Disk
    /// </summary>
    public partial class DiskEncryptionSettings
    {
        private KeyVaultSecretReference _diskEncryptionKey;
        
        /// <summary>
        /// Required. Gets or sets the disk encryption key which is a KeyVault
        /// Secret.
        /// </summary>
        public KeyVaultSecretReference DiskEncryptionKey
        {
            get { return this._diskEncryptionKey; }
            set { this._diskEncryptionKey = value; }
        }
        
        private KeyVaultKeyReference _keyEncryptionKey;
        
        /// <summary>
        /// Optional. Gets or sets the key encryption key which is KeyVault Key.
        /// </summary>
        public KeyVaultKeyReference KeyEncryptionKey
        {
            get { return this._keyEncryptionKey; }
            set { this._keyEncryptionKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSettings class.
        /// </summary>
        public DiskEncryptionSettings()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSettings class with
        /// required arguments.
        /// </summary>
        public DiskEncryptionSettings(KeyVaultSecretReference diskEncryptionKey)
            : this()
        {
            if (diskEncryptionKey == null)
            {
                throw new ArgumentNullException("diskEncryptionKey");
            }
            this.DiskEncryptionKey = diskEncryptionKey;
        }
    }
}
