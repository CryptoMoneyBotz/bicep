// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Bicep.Core.RegistryClient.Models
{
    internal static partial class ArtifactManifestOrderByExtensions
    {
        public static string ToSerialString(this ArtifactManifestOrderBy value) => value switch
        {
            ArtifactManifestOrderBy.None => "none",
            ArtifactManifestOrderBy.LastUpdatedOnDescending => "timedesc",
            ArtifactManifestOrderBy.LastUpdatedOnAscending => "timeasc",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArtifactManifestOrderBy value.")
        };

        public static ArtifactManifestOrderBy ToArtifactManifestOrderBy(this string value)
        {
            if (string.Equals(value, "none", StringComparison.InvariantCultureIgnoreCase)) return ArtifactManifestOrderBy.None;
            if (string.Equals(value, "timedesc", StringComparison.InvariantCultureIgnoreCase)) return ArtifactManifestOrderBy.LastUpdatedOnDescending;
            if (string.Equals(value, "timeasc", StringComparison.InvariantCultureIgnoreCase)) return ArtifactManifestOrderBy.LastUpdatedOnAscending;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArtifactManifestOrderBy value.");
        }
    }
}
