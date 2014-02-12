﻿using UnityEngine;
using System.Collections;

public static class MathUtilityHelper
{
	
	public static Vector3 Direction(this Vector3 source, Vector3 target) 
	{
		return (target - source).normalized;
	}
	
	public static float Range(float min, float max, float excludeRangeMin, float excludeRangeMax)
	{
		return Random.Range(0,2) == 0 ? Random.Range(min, excludeRangeMin) : Random.Range(excludeRangeMax, max);
	}
}