using UnityEngine;
using System.Collections;
using System;

namespace DUCK.Tween.Extensions
{
    public static partial class CameraAnimationExtensions
    {
        public static DelegateAnimation<ColorAnimation> ColorFadeTo(this Camera camera, Color to, float duration = 1f, Func<float,float> easingFunction = null)
        {
            var animation = new DelegateAnimation<ColorAnimation>(() =>
                new ColorAnimation(
                    camera.gameObject,
                    (c) => camera.backgroundColor = c,
                    camera.backgroundColor,
                    to,
                    duration,
                    easingFunction)); ;
            return animation;
        }
    }
}
