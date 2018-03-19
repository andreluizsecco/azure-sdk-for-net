// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response containing the status of operations for all documents in the
    /// indexing request.
    /// </summary>
    public partial class DocumentIndexResult
    {
        /// <summary>
        /// Initializes a new instance of the DocumentIndexResult class.
        /// </summary>
        public DocumentIndexResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DocumentIndexResult class.
        /// </summary>
        /// <param name="results">The list of status information for each
        /// document in the indexing request.</param>
        public DocumentIndexResult(IList<IndexingResult> results = default(IList<IndexingResult>))
        {
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of status information for each document in the
        /// indexing request.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<IndexingResult> Results { get; private set; }

    }
}