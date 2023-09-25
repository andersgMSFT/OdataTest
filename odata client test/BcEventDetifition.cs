// -----------------------------------------------------------------------
// <copyright file="Subscription.cs" company="MicrosoftCorporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace odata_client_test 
{ 
    using Microsoft.OData.Client;
    using System;

    [Key("appId")]
    [OriginalName("externalbusinesseventdefinition")]
    public class BcBusinessEventDefinition
    {
        [OriginalName("appId")]
        public Guid AppId { get; set; }

        [OriginalName("name")]
        public string Name { get; set; }

        [OriginalName("payload")]
        public string Payload { get; set; }

        [OriginalName("displayName")]
        public string DisplayName { get; set; }

        [OriginalName("description")]
        public string Description { get; set; }

        [OriginalName("category")]
        public string Category { get; set; }

        [OriginalName("appName")]
        public string AppName { get; set; }

        [OriginalName("appPublisher")]
        public string AppPublisher { get; set; }

        [OriginalName("appVersion")]
        public string AppVersion { get; set; }

        [OriginalName("eventVersion")]
        public string EventVersion { get; set; }
    }
}
