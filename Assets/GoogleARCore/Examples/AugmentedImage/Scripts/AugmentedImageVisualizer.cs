//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google">
//
// Copyright 2018 Google LLC. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;

    /// <summary>
    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    /// </summary>
    public class AugmentedImageVisualizer : MonoBehaviour
    {
        /// <summary>
        /// The AugmentedImage to visualize.
        /// </summary>
        public AugmentedImage Image;

        /// <summary>
        /// 黒板.
        /// </summary>
        public GameObject BlackBoard;

        /// <summary>
        /// チョーク(文字).
        /// </summary>
        public GameObject Chalk;

        public Vector3 vW = new Vector3(-0.24f, 0.0f, 0.0f);
        public Vector3 vH = new Vector3(0.0f, 0.0f, 0.515f);

        /// <summary>
        /// The Unity Update method.
        /// </summary>
        public void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                BlackBoard.SetActive(false);
                Chalk.SetActive(false);
                return;
            }

            float halfWidth = Image.ExtentX / 2;
            float halfHeight = Image.ExtentZ / 2;
            BlackBoard.transform.localPosition =
                (halfWidth * Vector3.zero) + (halfHeight * Vector3.zero);
            Chalk.transform.localPosition =
                (halfWidth * vW) + (halfHeight * vH);

            BlackBoard.SetActive(true);
            Chalk.SetActive(true);
        }
    }
}
