# Yggdrasil Education: Roll-A-Ball

**Yggdrasil** 게임 개발 동아리 교육용 프로젝트입니다. 유니티의 기초적인 물리 기반 이동과 트리거(Trigger)를 활용한 아이템 수집 및 UI 시스템 구현을 학습합니다.

## 🛠 소스코드 분석 (Source Code Analysis)

### 1. Player Movement (`PlayerMovement.cs`)
* **물리 이동**: `Input.GetAxisRaw`를 사용하여 수평(Horizontal) 및 수직(Vertical) 입력값을 가져옵니다.
* **힘의 적용**: `Update` 함수 내에서 `Rigidbody.AddForce`를 호출하여 플레이어 오브젝트에 물리적인 힘을 가해 이동시킵니다.
* **컴포넌트 참조**: `Start` 시점에 `GetComponent<Rigidbody>()`를 통해 해당 오브젝트의 리지드바디 컴포넌트를 캐싱하여 사용합니다.

### 2. Scoring System (`Score.cs`)
* **충돌 판정**: `OnTriggerEnter`를 통해 플레이어와의 충돌을 감지합니다. 
* **태그 검사**: 충돌한 오브젝트의 태그가 `"Player"`인 경우에만 점수 가산 로직이 실행됩니다.
* **상호작용**: 플레이어의 `PlayerScore` 컴포넌트를 찾아 `SetScore(1)` 메서드를 호출하여 점수를 1점 올린 후, 아이템 자신은 `Destroy(gameObject)`를 통해 씬에서 제거됩니다.
* **디버깅**: `OnTriggerEnter`, `Stay`, `Exit` 시점에 콘솔 로그를 남겨 트리거 상태를 확인할 수 있습니다.

### 3. Player Score & UI (`PlayerScore.cs`)
* **데이터 관리**: 플레이어의 점수를 정수형 변수 `_score`로 관리합니다.
* **UI 연동**: `UnityEngine.UI.Text` 라이브러리를 사용하여 현재 점수를 화면에 실시간으로 표시합니다.
* **업데이트 로직**: `SetScore` 메서드가 호출될 때마다 점수를 누적하고, `_scoreText.text`를 갱신하여 "Player Score : [점수]" 형태로 UI에 출력합니다.

## 📂 프로젝트 구조
- `PlayerMovement.cs`: 플레이어 조작 및 물리 로직.
- `Score.cs`: 수집 아이템(점수 오브젝트)의 트리거 로직.
- `PlayerScore.cs`: 점수 데이터 및 UI 텍스트 관리.

## 🚀 실행 가이드
1. 플레이어 오브젝트에 `Rigidbody`, `PlayerMovement`, `PlayerScore` 컴포넌트를 부착합니다.
2. 점수 아이템 오브젝트에는 `SphereCollider` (Is Trigger 체크됨)와 `Score` 컴포넌트를 부착합니다.
3. `PlayerScore` 컴포넌트의 `Score Text` 필드에 UI Text 오브젝트를 할당합니다.
4. 게임을 실행하고 방향키나 WASD로 움직여 아이템을 획득하세요.

---
**Developer**: [BaeJiwoo](https://github.com/BaeJiwoo)  
**Affiliation**: Daegu Catholic University, Game Engineering
