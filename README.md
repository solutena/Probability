# Probability<T>

확률을 구현하기 위한 클래스이다

## 사용방법

### Add

```
Probability<string> probability = new Probability<string>();
probability.Add("A", 1);
probability.Add("B", 2);
probability.Add("C", 3);
probability.Add("D", 4);
string random = probability.Get();
```

첫번째 인자에 타겟을,

두번째 인자에 확률을 추가하고

`Get` 혹은 `InverseGet` 함수를 통해 랜덤한 타겟을 가져온다.

### Get

`Get()` 함수로 확률에 기반한 랜덤한 타겟을 가져온다.

`Get(seed)` 시드값을 넣어 항상 같은 결과를 얻을 수 있다.

Get 함수는 `probability`값을 모두 더한 총합에서 `probability`값의 가중치를 가진다.

`"A"` : 10%

`"B"` : 20%

`"C"` : 30%

`"D"` : 40%

### InverseGet
`InverseGet()` 함수로 가중치가 높을수록 확률이 낮은 랜덤한 타겟을 가져올 수 있다.

`InverseGet(seed)` 시드값을 넣어 항상 같은 결과를 얻을 수 있다.

InverseGet 함수는 `1/probability`값을 모두 더한 총합에서 `1/probability`값의 가중치를 가진다.

`"A"` : 48%

`"B"` : 24%

`"C"` : 16%

`"D"` : 12%
