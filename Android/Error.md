# 안드로이드 에러 및 해결

### 1. your project path has non-ASC|| ,,
경로를 모두 영어로 바꿔준다(한글X)

### 2. Error:java.util.concurrent.ExecutionException: com.android.tools.aapt2.Aapt2Exception: AAPT2 error: check logs for details

gradle Scripts의 gradle.properties에 다음 코드를 추가해준다
- android.enableAapt2=false

### 3. Error:Execution failed for task ':app:mergeDebugResources'.
> Error: java.util.concurrent.ExecutionException: com.android.tools.aapt2.Aapt2Exception: AAPT2 error: check logs for details

build.gradle의 
 >  androidTestImplementation 'com.android.support.test:runner:1.0.2'
    androidTestImplementation 'com.android.support.test.espresso:espresso-core:3.0.2'

    의 1.0.2를 1.0.1로
3.0.2를 3.0.1로 바꿔준다.