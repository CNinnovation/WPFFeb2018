using System.Windows.Media.Animation;

namespace AnimationWPF
{
    public class EasingFunctionModel
    {
        public EasingFunctionModel(EasingFunctionBase easingFunction) =>
            EasingFunction = easingFunction;

        public EasingFunctionBase EasingFunction { get; }

        public override string ToString() => EasingFunction.GetType().Name;
    }
}
