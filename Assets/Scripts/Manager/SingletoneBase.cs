using UnityEngine;

public class SingletoneBase<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            // 싱글톤 만들기
            // 1. instance - null 체크
            if (instance == null)
            {
                // 없다면 새로운 싱글톤 만들기
                // 2. 예외처리 - 혹시 씬에 싱글톤이 있는지
                instance = (T)FindObjectOfType(typeof(T));

                if (instance == null)
                {
                    // 3. 새로운 오브젝트를 만들기
                    string tName = typeof(T).ToString();
                    var singletoneObj = new GameObject(tName);
                    // 4. 컴포넌트를 추가 <- T  추가
                    // 5. instance 할당
                    instance = singletoneObj.AddComponent<T>();
                    
                    DontDestroyOnLoad(instance);
                }
            }

            // 있다면 instance 리턴
            return instance;
        }
    }

    public void Init()
    {
    }
    
    public void Release()
    {
        
    }
}