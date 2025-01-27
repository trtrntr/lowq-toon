using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Toon.Extend;

namespace Toon
{
    public class Manager : MonoBehaviour
    {
        [SerializeField]
        BossCamera bossCam;

        [SerializeField]
        Material skybox;

        [SerializeField]
        Image fadingPanel;

        [SerializeField]
        UnityEvent onClear, onFail;

        [SerializeField]
        [Tooltip("制限時間")]
        float limit = 90;

        [SerializeField]
        [Tooltip("パネルのフェードアウトの速度")]
        float fading = 3;

        [SerializeField]
        HP towerHp;

        float timer;
        float alpha;
        static float finishedRemainingTime = 0;
        /// <summary>クリア時の残り時間</summary>
        public static float FinishedRemainingTime => finishedRemainingTime;
        float remaining;
        public float Remaining => remaining;
        public float RemainRatio => remaining / limit;
        public bool TimerStart { get; set; }
        bool doneTheEnd = false;
        bool notDoneTheEnd = false;
        public bool Controllable { get; set; }

        void Start()
        {
            RenderSettings.skybox = skybox;
            remaining = limit;
            TimerStart = false;
            Physics.gravity = Constant.MainGravity;
            onClear?.AddListener(Fading);
            onFail?.AddListener(Failing);
        }

        void Update()
        {
            LDJudge();
            RemainTime2(TimerStart);
        }

        public void ChangeScene(string name) => Section.Load(name);

        IEnumerator RemainTime(bool timerStart)
        {
            while (timerStart)
            {
                remaining -= 1;
                yield return new WaitForSeconds(1f);
            }
        }

        void RemainTime2(bool timerStart)
        {
            timer += Time.deltaTime;
            while (timerStart && timer >= 1)
            {
                remaining -= 1;
                timer = 0;
            }
        }

        void LDJudge()
        {
            doneTheEnd = towerHp.IsZero() && remaining >= 0;
            notDoneTheEnd = !towerHp.IsZero() && remaining <= 0;

            // 制限時間内に終わらせたらクリア
            if (doneTheEnd)
                onClear.Invoke();
            // 時間内にやれなかったらアウト
            else if (notDoneTheEnd)
                onFail.Invoke();

            // タイマー止めて記録をメモ
            if (doneTheEnd || notDoneTheEnd)
            {
                TimerStart = false;
                finishedRemainingTime = remaining;
            }
        }

        public void Fading() => AddAlpha(Constant.Clear);

        public void Failing() => AddAlpha(Constant.Failure);

        void AddAlpha(string name)
        {
            alpha = Numeric.Clamp(alpha, 0, 1f);
            alpha += Time.deltaTime / fading;
            fadingPanel.color = new(0, 0, 0, alpha);
            if (fadingPanel.color.a >= 1)
                Section.Load(name);
        }
    }
}
