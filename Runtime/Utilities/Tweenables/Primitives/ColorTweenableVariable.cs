using System;
using Unity.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives
{
    /// <summary>
    /// Bindable variable that can tween over time towards a target color value.
    /// Uses an async implementation to tween using the job system.
    /// </summary>
    
    public class ColorTweenableVariable : TweenableVariableAsyncBase<Color>
    {
        /// <inheritdoc />
        protected override JobHandle ScheduleTweenJob(ref TweenJobData<Color> jobData)
        {
            var job = new ColorTweenJob
            {
                jobData = jobData,
                colorBlendAmount = 1f,
                colorBlendMode = (byte)ColorBlendMode.Solid,
            };
            return job.Schedule();
        }
    }
}
