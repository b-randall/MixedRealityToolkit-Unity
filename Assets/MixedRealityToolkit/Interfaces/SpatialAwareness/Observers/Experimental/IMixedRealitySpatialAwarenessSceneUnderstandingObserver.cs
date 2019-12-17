﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Experimental.SpatialAwareness;
using System.Collections.Generic;

namespace Microsoft.MixedReality.Toolkit.SpatialAwareness
{
    /// <summary>
    /// The interface for defining an <see cref="IMixedRealitySpatialAwarenessObserver"/> which provides scene data.
    /// </summary>
    public interface IMixedRealitySpatialAwarenessSceneUnderstandingObserver : IMixedRealitySpatialAwarenessObserver
    {
        /// <summary>
        /// Load a previously serialized scene file from the device
        /// </summary>
        void LoadScene(string filename);

        /// <summary>
        /// Save a scene file to the device
        /// </summary>
        void SaveScene(string filename);

        /// <summary>
        /// The set of <see cref="SpatialAwarenessSceneObject"/>s being managed by the observer, keyed by a unique id.
        /// </summary>
        IReadOnlyDictionary<System.Guid, SpatialAwarenessSceneObject> SceneObjects { get; }

        SpatialAwarenessSurfaceTypes SurfaceTypes { get; set; }

        int PhysicsLayer { get; set; }

        /// <summary>
        /// Number of meshes to generate per frame. Throttled to keep framerate under control.
        /// </summary>
        int InstantiationBatchRate { get; set; }

        /// <summary>
        /// When enabled, renders observed and inferred regions for scene objects.
        /// When disabled, renders only the observed regions for scene objects.
        /// </summary>
        bool RenderInferredRegions { get; set; }

        /// <summary>
        /// When enabled, the service will provide a boundless, static water-tight mesh of the observed environment.
        /// </summary>
        bool GenerateEnvironmentMesh { get; set; }

        /// <summary>
        /// When enabled, the service will provide surface meshes.
        /// </summary>
        bool GenerateMeshes { get; set; }

        /// <summary>
        /// When enabled, the service will provide surface planes, represented as a quad.
        /// </summary>
        /// <remarks>
        /// Use <see cref="PlaneValidationMask"/> for the validation mask on the quad.
        /// </remarks>
        bool GeneratePlanes { get; set; }

        /// <summary>
        /// When enabled, the service will preserve previously observed surfaces when updating.
        /// </summary>
        bool UsePersistentObjects { get; set; }

        /// <summary>
        /// The distance infer surface understanding
        /// </summary>
        float QueryRadius { get; set; }
    }
}