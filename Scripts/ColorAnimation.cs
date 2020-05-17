using UnityEngine;
using System;

namespace DUCK.Tween
{
    public class ColorAnimation : AbstractColorFadeAnimation
    {
        private readonly Action<Color> action;

		public ColorAnimation(UnityEngine.Object target, Action<Color> action, Color from, Color to, float duration = 1f, Func<float, float> easingFunction = null)
			: base(target, from, to, duration, easingFunction)
		{
            this.action = action;
		}

        protected override void SetColor(Color color)
        {
            action(color);
        }
    }
}
