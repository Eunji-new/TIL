# Intodution to Operating System

User와 API는 하드웨어에 직접 접근하지 못한다.(OS를 통해야만 가능!!)

## Operating System 정의

### Operating System

: API와 컴퓨터 하드웨
어 사이에서 중간 역할을 한다.

: 하드웨어 resource를 관리한다.

: API에게 서비스를 제공한다.

### USER View

: OS는 API를 실행한다.

: OS는 컴퓨터 시스템을 사용하기 편하게 해준다.

### System view

: OS는 자원할당자(resource allocator)다.

	: H/W resources : CPU, memory, and I/O devices.

	: SW resources : files, sockets, semaphores, etc.

: OS는 통제/조절 프로그램(control program)이다.

	: I/O 디바이스의 작동과 API의 실행을 관리(control)한다.



###  OS의 정의
: 애매하다!

: (X)"OS를 주문할때 탑재된 모든 것" ex) microsoft windows, Unix, andrid, ios, etc.

: (O)컴퓨터에서 항상 수행하는 프로그램
	->커널

	->다른 모든 것은 시스템 프로그램 또는 API 프로그램이다.

## Computer System Operation

- computer-system 조직
: 각 I/O 디바이스 컨트롤러는 특정 디바이스 타입에 책임이 있다.
: 각 I/O 디바이스 컨트롤러는 로컬 버퍼를 지니고 있다.

- Disk I/O operation
: 디스크 컨트롤러는 자신의 로컬 버퍼와 디바이스 사이에서 데이터를 전달시켜 준다.(왔다갔다)
: CPU는 디바이스 컨트롤러의 로컬버퍼와 메인 메모리 사이에서 데이터를 전다시켜 준다.(왔다갔다)

: CPU와 I/O디바이스는 자신의 동작을 독립적으로 수행할 수 있다.

->디바이스 컨트롤러는 CPU에게 interrupt에 의해 동작이 끝났다고 전달해준다.

- Interrupt handling
: interrupt가 발생했을때, CPU는 하고 있는 것을 멈추고 interrupt service routine(ISR)을 발생시킨다.

### Storage Structure

- Main memory
: CPU가 직접 접근할 수 있는 저장 매체
: DRAM(Dynamic Random Access Memory) : 휘발성

- Secondary memory
: 비휘발성인 저장 용량이 큰 저장 매체
: HDD, NAND 플래시 메모리, SSD

### Caching
- 프로그램을 실행하기 위해, 데이터 또는 명령은 HDD에서 CPU register로 로드되어야한다.
- 더 빠른 저장 매체 안에 데이터를 저장하는 것. 
	->같은 데이터의 나중..다음..미래..? 요청에 접근속도 향상 위해서!!!
Caching에 대해 더,,,
- Caching은 다양한 환경과 시스템안에서 다양한 단계로 수행되는 것이다.
	-> CPU cache, operating system's buffer cache, disk cache, etc.
	->Web cache, streaming cache, etc.
- Cache는 먼저 요청된 데이터가 있는지 없는지 결정을 체크한다.
	->만약 있다면, 데이터는 직접 cache로부터 사용된다.
	->없다면, 데이터는 cache에 복사되고 그곳에서 사용된다.

- 일반적으로, cache 사이즈는 제한적이다.
	-> replacement policy는 요구된다.
	-> E.g. LRU, LFU, clock, ...

- cache된 데이터는 주의해서 다뤄져야한다.
: 몇몇 자료 안의 카피들은 존재한다. -> 데이터 불안정

- 멀티프로세서 환경에서
: cach 일관성
	-> 모든 CPU들은 그들의 cache에서 가장 최근 값을 가진다. 
- 분산환경상황에서는 더 복잡하다.

### OS 구조

- 멀티프로그래밍

: 몇몇 프로그램은 메인메모리 안에서 동시에 지켜지고, CPU는 그들 사이에서 다중통신된다.

-> CPU 이용 증가

: 싱글 프로그램은 CPU와 I/O 디바이스를 항상 지킬 수 없다.

: 프로그램을 구성하여 CPU가 항상 실행하도록 프로그램을 구성합니다

:한 프로그램은 선택되고 스케줄링을 통해 실행된다.
기다리고 있을때, OS는 다른 프로그램을 스위칭한다.

- Timesharing

: Timesharing은 멀티프로그래밍에서 논리적인 확장이다.

: UNIX는 좋은 예다.

: 사용자는 명령을 키보드나 마우스를 사용하는 프로그램에 준다, 그리고 즉각 결과를 기다린다.

-> 응답 시간으 짧다.(전형적으로 1초 미만)

: CPU가 프로그램을 꽤 빈번하게 바꿔서 사용자는 각각 프로그램과 상호작용한다.

-> 응답시간 최소화

OS Operations

-OS는 event driven이다.

	: 프로그램이 없으면 I/O요청도 없고 사용자도 없다.
	: OS는 어떤 이벤트가 일어날때까지 가만히 기다릴것이다.


- Events

: 하드웨어 interrupts
-> 디스크 인터럽트 , 키보, 마우스 인터럽트 등등

: 소프트웨어 트랩(exceptions)
-> 0으로 나뉨, 불확실한 메모리 접근, 시스템 콜 등

: 다른 에러
-> 무한 루프


- Dual mode

: 유저모드, 커널모드

: 권한 명령은 커널모드에서 수행된다.

:Mode bit는 하드웨어에의해 제공된다.(program status word, PSW)

-> 유저모드(1), 커널모드(0)

: E.g. 시스템 콜은 커널에서 모드를 전환하고 리턴할때 사용자에게 다시 설정한다.


### Process Management
- 프로세스는 실행중인 프로그램이다.
: 프로그램은 소극적, 프로세스는 적극적 독립체이다.
:시스템 안에서 일하는 단위이다.

- 프로세스는 그 일을 성취하기 위해 resource가 필요하다.
: CPU, memory, I/O devices, files ,...

- 프로세스 관리 활동
: CPU에서 스케쥴링 프로세스
: 프로세스 생성, 삭제
: 프로세스 동기화 메커니즘
: 상호 프로세스 소통 메커니즘
: 데드락 처리

### Memory 관리
- 메모리 관리 활동
: 누가 현재 메모리의 어느 부분을 사용하고 있는지 추적
: 어떤 프로세스와 데이터가 메모리로 들어오고 나가는 지 결정하기
: 필요한만큼 메모리 공간을 할당하고 할당 해제하기

- 가상 메모리 시스템
: 다양한 형태의 데이터 저장 장치 (DRAM 및 디스크)를 가상화하여 
마치 한 종류의 메모리, "가상"메모리 만있는 것처럼 프로그램을 설계 할 수 있습니다.

### Storage Management
- OS는 정보 저장의 규격적이고 논리적 뷰를 제공한다.

	: File
	- 논리적 저장 단위.
	- 파일은 보통 디렉토리안에서 조직된다.

	: File system
	- 데이터를 저장, 되찾기, 업데이트하고 디바이스 내 이용가능한 공간을 관리한다.

- File system 활동

: 파일과 디렉토리 생성, 삭제

: 파일과 디렉토리를 조작하기위한 기본 요소를 지원

: secondary storage에 파일 매핑. 


- Mass-storage management

: 보통 디스크는 데이터를 저장하는데 사용된다.

: 컴퓨터 operation의 전체 속도는 디스크 하위시스템과 알고리즘에 따라 달라진다.

- Disk storage 활동

: 빈 공간 관리

: 저장 할당

: 디스크 스케쥴링

### I/O Subsystem
- OS의 하나의 목적은 사용자로부터 하드웨어 디바이스의 특성을 숨기는 것이다.

- I/O 하위시스템은 구성한다.

: 일반 device-driver 인터페이스

: 특정 하드웨어 디바이스 드라이버

: I/O 메모리 관리(including 버퍼링, 캐싱, 스풀링)

### Special purpose system
- real time system

: E.g. 미사일 제어 시스템, 의료 장비 시스템

: 까다로운 응답시간 요구 -> Deadline


: real-time 시스템은 하드나 소프트일것이다.
 : missile control vs mp3 player

- Multimedia systems

: E.g. mp3, DVD player

: soft real-time 요청

- Mobile systems
: E.g. Cellular phones
: 낮은 H/W 능력 
-> 느린 프로세서, 제한적 메모리, 작은 스크린, 제한된 파워

### Virtual Machine
- Virtual Machines

: 몇몇 다른 수행상황에서 추상적인 컴퓨터하나

: 분산수행상황이 자신의 컴퓨터를 사용하는 허상(lillusion)을 생성한다

:  하드웨어와 커널을 그것들 모두 하드웨어 인 것 처럼 속인다

- virtual machine 특성

: 시스템 resource의 완전한 보호를 제공한다.

: 자원의 직접 공유가 없다.

: OS를 개발하는데 편리하다.

: 다른 OS에서 API를 테스트하기에 편리하다.

-> 만약 API가 LInux, FreeBSD, Windows XP에서 테스트되어야 한다면?

## 요약
- 운영 체제는 응용 프로그램과 컴퓨터 하드웨어 사이의 중개자 역할을하며 컴퓨터 하드웨어 자원을 관리하고 응용 프로그램에 대한 일부 서비스를 제공합니다.
- 인터럽트가 발생하면 CPU는 현재 수행중인 작업을 중단하고 인터럽트 서비스 루틴 (ISR)을 호출합니다.
- 캐싱은 향후 동일한 데이터 요청에 대한 액세스 속도를 향상시키기 위해 더 빠른 저장 미디어에 데이터를 저장합니다.
- 시분할 시스템에서 CPU는 프로그램을 너무 자주 전환하여 사용자가 각 프로그램과 상호 작용할 수 있도록합니다.
- 운영 체제는 프로세스 관리, 메모리 관리, 파일 시스템, I / O 하위 시스템 등으로 구성됩니다.




