using UnityEngine;
using System.Collections;
using DUCK.Tween;
using System;

namespace DUCK.Tween.Extensions
{
    public static class MaterialAnimationExtension
    {
        public static DelegateAnimation<ColorShaderPropertyAnimation> ColorFadeTo(this Material material, string property, Color to, float duration = 1f, Func<float, float> easingFunction = null)
        {
            var animation = new DelegateAnimation<ColorShaderPropertyAnimation>(() =>
                new ColorShaderPropertyAnimation(
                    material, 
                    property,
                    material.GetColor(property),
                    to,
                    duration,
                    easingFunction));
            return animation;
        }
    }
}
