using UnityEngine;

public static class EasingFunc
{
    /// <summary>
    /// all easing functions
    /// </summary>
    /// <param name="x">time</param>
    /// <param name="type">easing function name as enum</param>
    /// <returns>return easing with specify type</returns>
    public static float Easing(float x,EasingType type)
    {
        switch (type) 
        {
            case EasingType.EaseInSine:
                return EaseInSine(x);

            case EasingType.EaseOutSine:
                return EaseOutSine(x);

            case EasingType.EaseInOutSine:
                return EaseInOutSine(x);

            case EasingType.EaseInQuad:
                return EaseInQuad(x);

            case EasingType.EaseOutQuad:
                return EaseOutQuad(x);

            case EasingType.EaseInOutQuad:
                return EaseInOutQuad(x);

            default:
                return 0.0f;
        }


            

    }
    /// <summary>
    /// example: https://easings.net/#easeInSine
    /// </summary>
    /// <param name="x">time</param>
    /// <returns></returns>
    public static float EaseInSine(float x)
    {
        return 1 - Mathf.Cos((x * Mathf.PI) / 2);
    }

    /// <summary>
    /// example: https://easings.net/#easeOutSine
    /// </summary>
    /// <param name="x">time</param>
    /// <returns></returns>
    public static float EaseOutSine(float x)
    {
        return 1 - Mathf.Sin((x * Mathf.PI) / 2);
    }

    /// <summary>
    /// example: https://easings.net/#easeInOutSine
    /// </summary>
    /// <param name="x">time</param>
    /// <returns></returns>
    public static float EaseInOutSine(float x)
    {
        return -(Mathf.Cos(Mathf.PI * x) - 1) / 2;
    }

    /// <summary>
    /// example: https://easings.net/#easeInQuad
    /// </summary>
    /// <param name="x">time</param>
    /// <returns></returns>
    public static float EaseInQuad(float x)
    {
        return x * x;
    }

    /// <summary>
    /// example: https://easings.net/#easeOutQuad
    /// </summary>
    /// <param name="x">time</param>
    /// <returns></returns>
    public static float EaseOutQuad(float x)
    {
        return 1 - (1 - x) * (1 - x);
    }

    /// <summary>
    /// example: https://easings.net/#easeInOutQuad
    /// </summary>
    /// <param name="x">time</param>
    /// <returns></returns>
    public static float EaseInOutQuad(float x)
    {
        return x < 0.5 ? 2 * x * x : 1 - Mathf.Pow(-2 * x + 2, 2) / 2;
    }
}


public enum EasingType
{
    EaseInSine,
    EaseOutSine,
    EaseInOutSine,
    EaseInQuad,
    EaseOutQuad,
    EaseInOutQuad
}
