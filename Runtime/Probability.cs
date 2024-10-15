using System;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

public class Probability<T>
{
	class ProbabilityElement
	{
		public T Target { get; }
		public float Probability { get; }

		public ProbabilityElement(T target, float probability)
		{
			Target = target;
			Probability = probability;
		}
	}

	List<ProbabilityElement> ProbabilityList { get; } = new List<ProbabilityElement>();
	
	public bool IsEmpty => ProbabilityList.Count <= 0;

	public void Add(T target, float probability)
	{
		if (probability <= 0)
			return;
		ProbabilityList.Add(new ProbabilityElement(target, probability));
	}

	public T Get()
	{
		float cumulativeProbability = 0;
		float randomValue = Random.Range(0f, ProbabilityList.Sum(x => x.Probability));
		foreach (var element in ProbabilityList)
		{
			cumulativeProbability += element.Probability;
			if (randomValue <= cumulativeProbability)
				return element.Target;
		}
		return default;
	}

	public T Get(int seed)
	{
		Random.InitState(seed);
		return Get();
	}
}