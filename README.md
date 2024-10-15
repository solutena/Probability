# Probability<T>

확률을 구현하기 위한 클래스입니다.

## Add

```csharp
Probability<string> probability = new Probability<string>();
probability.Add("A", 1);
probability.Add("B", 2);
probability.Add("C", 3);
probability.Add("D", 4);
string random = probability.Get();
```

첫번째 인자에 타겟을,

두번째 인자에 확률을 추가하고

`Get` 혹은 `InverseGet` 함수를 통해 랜덤한 타겟을 가져옵니다.

## Get

`Get()` 함수로 확률에 기반한 랜덤한 타겟을 가져옵니다.

`Get(seed)` 시드값을 넣어 항상 같은 결과를 얻을 수 있습니다.

Get 함수는 `probability`값을 모두 더한 총합에서 `probability`값의 가중치를 가집니다.

`"A"` : 10%

`"B"` : 20%

`"C"` : 30%

`"D"` : 40%
