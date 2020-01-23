﻿using UnityEngine;

namespace AdrianMiasik
{
    public static class MathUtils
    {
        /// <summary>
        /// Returns a 3D position on the provided cubic bezier curve at a specific time (0-1)
        /// </summary>
        /// <param name="_p0">Start Anchor</param>
        /// <param name="_p1">Start Handle (tangent)</param>
        /// <param name="_p2">End Handle (tangent)</param>
        /// <param name="_p3">End Anchor</param>
        /// <param name="_time">A number between 0-1. 0 representing P0 and 1 representing P3</param>
        /// <returns></returns>
        public static Vector3 GetPointOnCubicBezierCurve(Vector3 _p0, Vector3 _p1, Vector3 _p2, Vector3 _p3, float _time)
        {
            float term = 1 - _time;
            
            float termSquared = term * term;
            float timeSquared = _time * _time;
            
            float termCubed = termSquared * term;
            float timeCubed = timeSquared * _time;
            
            // Formula Source: https://en.wikipedia.org/wiki/B%C3%A9zier_curve#Cubic_B%C3%A9zier_curves
            return _p0 * termCubed + 
                   _p1 * (3 * termSquared * _time) +
                   _p2 * (3 * timeSquared * term) +
                   _p3 * timeCubed;
        }
    }
}
