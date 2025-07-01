#include <string>
#include <vector>
#include <bits/stdc++.h>

using namespace std;

int solution(int l, int w, vector<int> t) {
    int count = 0;  // 테스팅용(몇 번 반복?)
    
    int answer = 0;
    int totalW = 0;

    int curPos = 0; // 다리에 올라간 트럭의 앞 대가리 - 다리 통과와 함께 증가
    int endPos = -1; // 다리에 올라간 트럭 줄의 뒷 놈 - 트럭 추가와 함께 증가
    int tSz = t.size();
    
    deque<int> dq;  // 각 트럭별 이동 진행도 (시작값 : length - 1)
    int delta = 0;  // dq(다리에) 존재하는 트럭들 몇 칸 전진하는지
    
    ios::sync_with_stdio(false);
    cin.tie(0);
    
    while(curPos < tSz){
        if(dq.empty()){
            dq.push_back(l);
            
            totalW += t[++endPos];
            curPos = endPos;
            answer++;
        }
        else{
            // Step 01. dq에 추가 가능성 판단
            if(totalW + t[endPos + 1] <= w){
                // 01-00 .추가 가능 => 다리 위에서 한칸 씩만 전진
                delta = 1;
                for(int i = 0; i < dq.size(); i++){
                    dq[i] -= delta;
                }
                
                // 01-01. 한칸 전진 후 트럭 추가
                dq.push_back(l);
                totalW += t[++endPos];
                answer += delta;
                
                // 01-02. dq에서(다리) 진행도가 0인(다리를 다 건너간) 요소가 존재하는지(dq.front() == 0인지) 체크 후 제거
                // curPos 조정
                if(dq[0] == 0){
                    totalW -= t[curPos];
                    dq.pop_front();
                    curPos++;
                }
            }
            else{
                // 다른 트럭 추가 불가능 => dq.front()만큼 전진 -> 대가리 제거 -> 트럭 추가
                delta = dq[0];
                
                for(int i = 0; i < dq.size(); i++){
                    dq[i] -= delta;
                }
                
                answer += delta;

                if(dq[0] == 0){
                    totalW -= t[curPos];
                    dq.pop_front();
                    curPos++;
                }
                
                if(totalW + t[endPos + 1] <= w){
                    dq.push_back(l);
                    totalW += t[++endPos];
                }
            }
        }
        
        
        
        // 테스팅
        count++;
        cout << endl << endl;
        cout << count << "번 째 반복" << " (answer : " << answer << ")" << endl;
        cout << "curPos = " << curPos << ", endPos = " << endPos << endl;
        cout << "## dq 현 상황 ##" << endl;
        for (int i = 0; i < dq.size(); i++) {
            cout << "dq[" << i << "] = " << dq[i] << endl;
        }
    }
    
    return answer;
    
}